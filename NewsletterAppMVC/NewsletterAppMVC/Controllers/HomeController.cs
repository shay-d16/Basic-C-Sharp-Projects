using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // The first thing you do with ADO.NET before you can access any information inside of a 
        // database is create a connection string (a string of characters within quotations that contains
        // specific information that allows access to the database like the server name or credential info, etc.)
        // The best way to get a connection string for ADO.NET is to connect to the database inside
        // of Visual Studio.
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;
                                            Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
        // We used the 'readonly' keyword here to protect the connection string from changing anywhere in our code.


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {                                             
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
                // This checks if any of the variables are an empty string or have a 'null' value.
            {
                return View("~/Views/Shared/Error.cshtml"); // '~' indicates the use of a relative path.
                //Here we used a relative path to the file 'Error.cshtml' to redirect to that view which is
                // an error page if any of the above conditions are true.
                // This 'Error.cshtml' file isn't located inside of a folder that matches a controller, it
                // is in the 'Shared' folder
            }
            else
            // This else statement will save the data submitted to our local database using ADO.NET
            {
                
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";
                // Remember, having parameters like this instead of "raw" user input helps prevent SQL Injection.

                using (SqlConnection connection = new SqlConnection(connectionString)) //passing in 'connectionString'
                    // Remember, any time you're opening up an outside connection, i.e. to a db, you always want to wrap
                    // it in a 'using' statement b/c that when you are done with it, it gets cut off or closed. Leaving 
                    // it open can cause memory leaks or slowdowns in your program later.
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    //Now that we've added the parameters, we need to give them values:
                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                } // This whole 'using' statement should 'INSERT' whatever the user puts into the form into the db.

                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            // Here, we'll create logic for pulling the information from the database and display it to the
            // admin, which we will do using ADO.NET
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";

            // Now we'll create a list of our model
            List<NewsletterSignUp> signups = new List<NewsletterSignUp>();
            // This instantiates a new, empty list called 'signups'

            // Next, we'll open a connection and wrap it in a 'using' statement.
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // While this information is being read, it will also be assigned the values
                    // coming fromt the database.

                    // When creating a new object, it is not necessary to explicitly state the data
                    // type if the data type is obvious.
                    var signup = new NewsletterSignUp();

                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    
                    // B/c we don't want to display something like a user's social to the 'View' we need a way to return
                    // these objects without the 'SocialSecurityNumber' object specifically.
                    // This can be done using a View Model, which is a model that is stripped down to ONLY what you need for
                    // the 'View'. View Models live in a separate folder called 'ViewModels' so we'll need to create that. 
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();                                       
                    
                    // We'll add all of this to the list we just created:
                    signups.Add(signup);
                }
            }
            // A common practice on the controller is to map your database object to a view model. So let's create an empty
            //  list with the 'SignupVm' data type: 
            var signupVms = new List<SignupVm>();
            // The data type is obvious here so it's best practice to use the 'var' keyword in this instance.

            // Then we will loop through all the 'signups':
            foreach (var signup in signups)
            {
                // Here, we will map properties between objects
                var signupVm = new SignupVm();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;
                signupVms.Add(signupVm);
            }




            // So we have populated a list of 'NewsletterSignUps' (which is our model or Business object), 
            // and the list is called 'signups'. Now, we will pass this list to the 'View'.
            return View(signupVms);
        }
    }
}