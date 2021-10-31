using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExSample
{
    class RegexPattern
    {
        // string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "aa1a1" };
        // string pattern = "^[0-9]*[a-zA-Z]{3}[0-9a-zA-Z]*$";
        //string[] inputs = { "413004", "012345", "B12987", "12345", "867432","123 345","1 23567" };
        //string pattern = "^[1-9]{3}[ ]{1}[0-9]{3}$";
        string[] inputs = { "abc@gamil.com","1ab@gmai.com","abc.com","abc@gmailcom","xyz@titto.com","scm@gmail.in"};
        string pattern = "^[a-zA-z]*[@]{1}[a-zA-z]*[.]{1}[com]{3}$";


        public void checkingPattern()
        {
            Regex regex = new Regex(pattern);
            foreach (string word in inputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "--->valid");
                }
                else
                {
                    Console.WriteLine(word + "--->Invalid");
                }
            }
        
        }
    }
}
