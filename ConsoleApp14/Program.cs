using Core.Enums;
using Core.helper;
using Core.Models;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int check;
            string className;
            byte classType;
            string name;
            string surname;
            int id;

            do
            {
                Console.Write("Classroom adini daxil edin: ");
                className = Console.ReadLine();
            }
            while (!helper.CheckClassroom(className));

            do
            {
                Console.WriteLine("1.Backend");
                Console.WriteLine("2.Frontend");
                Console.Write("Class type daxil edin: ");
            }
            while (!byte.TryParse(Console.ReadLine(), out classType));

            Classroom classroom = new Classroom(className, (InformationField)classType);

            do
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.GetAllStudent");
                Console.WriteLine("3.StudentFindid");
                Console.WriteLine("4.StudentRemove");
                Console.WriteLine("0.Exit");

                do
                {
                    Console.Write("Choose one: ");
                }
                while (!int.TryParse(Console.ReadLine(), out check));

                switch (check)
                {
                    case (byte)Menu.AddStudent:
                        do
                        {
                            Console.Write("Telebenin adini daxil edin: ");
                            name = Console.ReadLine();
                        }
                        while (!helper.CheckName(name));

                        do
                        {
                            Console.Write("Telebenin soyadini daxil edin: ");
                            surname = Console.ReadLine();
                        }
                        while (!helper.CheckSurname(surname));

                        Student student = new Student(name, surname, (InformationField)classType);

                        classroom.AddStudent(student);

                        break;
                    case (byte)Menu.GetAllStudent:
                        foreach (Student item in classroom.GetAllStudents())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case (byte)Menu.StudentFindId:
                        do
                        {
                            Console.Write("Axtarmag istediyiniz telebenin id daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out id));
                        if (classroom.GetStudentFindId(id) != null)
                        {
                            Console.WriteLine(classroom.GetStudentFindId(id));
                        }
                        else
                        {
                            Console.WriteLine($"ID'i {id} olan bir telebe yoxdur!");
                        }
                        break;
                    case (byte)Menu.StudentRemove:
                        do
                        {
                            Console.Write("Axtarmag istediyiniz telebenin id daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out id));

                        foreach (Student item in classroom.RemoveStudent(id))
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }

            while (check != 0);
        }
    }
}
