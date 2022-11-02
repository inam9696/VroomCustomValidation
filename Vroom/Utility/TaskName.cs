using System.ComponentModel.DataAnnotations;

namespace Vroom.Utility
{
    public class TaskName : ValidationAttribute
    {

        public override bool IsValid(object? value)
        {
            if (value != null)
            {

                string[] strings = value.ToString().Split("");
                foreach (string s in strings)
                {
                    for (int a = 0; a < s.Length; a++)
                    {
                        if ((int)s[a] <= 64 && (int)s[a] != 32 || (int)s[a] >= 91 && (int)s[a] <= 96 || (int)s[a] <= 255 && (int)s[a] >= 123)
                        {
                            return false;
                        }
                    }
                }

                string fw = strings[0];
                char c = fw[0];
                //Char.IsUpper(Char) Method
                if (c >= 'A' && c <= 'Z')
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

            //return strings[1].ToUpper() == _allowedName.ToUpper();
        }

    }
}
