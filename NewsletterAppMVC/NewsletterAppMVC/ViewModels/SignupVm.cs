using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.ViewModels
{
    // When you create a View Model it's important to signify that it's a view model; best practice is to end the class
    // with 'Vm'.
    public class SignupVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}