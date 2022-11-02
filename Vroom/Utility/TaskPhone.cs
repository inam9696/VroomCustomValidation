using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Vroom.Utility
{
    public class TaskPhone : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                string[] strings = value.ToString().Split();
                //if(strings.Length < 15)
                //{
                //    return false;
                //}
                foreach (string s in strings)
                {
                    for (int a = 0; a < s.Length; a++)
                    {
                        if ((int)s[a] <= 47 && (int)s[a] >= 44 || (int)s[a] <= 42 || (int)s[a] <= 255 && (int)s[a] >= 58)
                        {
                            return false;
                        }
                    }
                }
                string fw = strings[0];
                if (fw[0] == '+' && fw[1] == '9' && fw[2] == '6' && fw[3] == '6')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        //public override bool IsValid(object value)
        //{
        //    string[] strings = value.ToString().Split();

        //    string pm = strings[0];
        //    if (pm[0] == '+' && pm[1] == '9' && pm[2] == '6' && pm[3] == '6')
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //    //return base.IsValid(value);
        //}


        //public class bool IsPhoneValid(object phoneNumber)
        //{
        //    string regex = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";
        //    if (phoneNumber != null)
        //        return Regex.IsMatch(phoneNumber, regex);
        //    else return false;
        //}
    }
  }


