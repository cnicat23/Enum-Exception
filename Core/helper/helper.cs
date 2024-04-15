using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.helper
{
    public class helper
    {
        public static bool CheckName(string name)
        {
            bool check = true;
            bool choice = false;
            if (name.Length >= 3)
            {
                if (name[0].ToString() == name[0].ToString().ToUpper() && name.Length > 3)
                {
                    choice = true;
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        check = false;
                        break;
                    }
                }
            }

            if (check && choice)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckSurname(string surname)
        {
            bool check = true;
            bool choice = false;

            if (surname.Length >= 3)
            {
                if (surname[0].ToString() == surname[0].ToString().ToUpper() && surname.Length > 3)
                {
                    choice = true;
                }
                for (int i = 1; i < surname.Length; i++)
                {
                    if (surname[i] == ' ')
                    {
                        check = false;
                        break;
                    }
                }
            }

            if (check && k)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckClassroom(string classroom)
        {

            bool check = false;
            bool choice = false;

            if (classroom.Length == 5)
            {
                for (int i = 0; i < classroom.Length - 3; i++)
                {
                    if (char.IsUpper(classroom[i]) && char.IsLetter(classroom[i]))
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }

                for (int i = classroom.Length - 3; i < classroom.Length; i++)
                {
                    if (char.IsDigit(classroom[i]))
                    {
                        choice = true;
                    }
                    else
                    {
                        choice = false;
                        break;
                    }
                }

                if (check && choice)
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
    }
}