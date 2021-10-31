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
        string[] firstNameInputs = { "Shw","shw","Shweta","XYz","Xyz" };
        string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string[] lastNameInputs = { "Mhe","mhe","Mhetre","MhE","Cpm"};
        string lastNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string[] emailInputs = {"abc.xyz@bl.co.in","abc@bl.co.in","abc.x@gm.co.in","abc.xyzbl.co.in","abc,xyz@bl.in","ab.xyz@bl.co.in","abc.nxcst@bl.co.in" };
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
        string[] mobileNoInputs = {"91 8686531051", "01 8686531051", "918686531051", "91 86865310", "91 0123344556", "91 868653105112", "912 8686531051" };
        string mobileNoPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";

        //password validation
        string[] passwordInputs = {"shwetacm","shweta","Shweta","shwetacmpp","mhetresc" };
        string passwordPattern = "^[a-z]{8}$";

        public void Validation()
        {
            Regex regex = new Regex(passwordPattern);
            Console.WriteLine("UC5 password Validation ");
            foreach (string word in passwordInputs)
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
