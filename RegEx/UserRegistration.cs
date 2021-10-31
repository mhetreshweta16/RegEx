using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExSample
{
    class UserRegistration
    {
        string[] inputs = { "Shw","shw","Shweta","XYz","Xyz" };
        string pattern = "^[A-Z]{1}[a-z]{2}$";

        public void firstNameValidation()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("UC1 First Name Validation ");
            foreach (string word in inputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }
    }
}
