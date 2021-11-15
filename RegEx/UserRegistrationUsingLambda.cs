using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExSample
{
    public class UserRegistrationUsingLambda
    {
        public string message;
       
        public UserRegistrationUsingLambda(string message)
            {
            this.message = message;

             }

        /// <summary>
        /// Validate User FirstName Using Lambda function
        /// UC 13 
        /// </summary>
        /// <returns></returns>
        public string ValidateFirstNameUsingLambda()
        {
            

            string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
            bool TestFirstName(string firstName) => (Regex.IsMatch(firstName, firstNamePattern));
            bool re = TestFirstName(message);
            if (re)
            {
                return "valid";
            }
            else {
                return "invalid";
            }

        }

        /// <summary>
        /// Validate User LastName using lambda function
        /// </summary>
        /// <returns></returns>
        public string ValidateLastNameUsingLambda()
        {


            string lastNamePattern = "^[A-Z]{1}[a-z]{2}$";
            bool TestLastName(string firstName) => (Regex.IsMatch(firstName, lastNamePattern));
            bool re = TestLastName(message);
            if (re)
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }


        }

        public string ValidateEmailUsingLambda()
        {


            string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            bool TestLastName(string firstName) => (Regex.IsMatch(firstName, emailPattern));
            bool re = TestLastName(message);
            if (re)
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }

        }

        public string ValidateMobileNumberUsingLambda()
        {


            string mobileNoPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
            bool TestLastName(string firstName) => (Regex.IsMatch(firstName, mobileNoPattern));
            bool re = TestLastName(message);
            if (re)
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }


        }

        public string ValidatePasswordUsingLambda()
        {


            string passwordPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";

            bool TestLastName(string firstName) => (Regex.IsMatch(firstName, passwordPattern));
            bool re = TestLastName(message);
            if (re)
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }

        }





    }
}
