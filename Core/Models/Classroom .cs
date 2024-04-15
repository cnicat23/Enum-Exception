using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public int StudentLimit { get; set; }

        private InformationField _classroomType;
        public InformationField ClassroomType
        {
            get { return _classroomType; }
            set
            {
                if (value == InformationField.Backend)
                {
                    _classroomType = value;
                    StudentLimit = 20;
                }
                else if (value == InformationField.Frontend)
                {
                    _classroomType = value;
                    StudentLimit = 15;
                }


            }
        }
        public Classroom(string name, InformationField classType)
        {
            _id++;
            Id = _id;
            Name = name;
            ClassroomType = classType;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Class Type: {ClassroomType}; Limit: {StudentLimit}";
        }

        public Student[] Students = new Student[] { };

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                throw new OutOfLimitException("Limitden kenara cixildi!");
            }
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }

        public Student GetStudentFindId(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }


        public Student[] RemoveStudent(int id)
        {
            Student[] filteredStudents = new Student[] { };
            bool f = false;
            foreach (Student student in Students)
            {
                if (student.Id != id)
                {
                    Array.Resize(ref filteredStudents, filteredStudents.Length + 1);
                    filteredStudents[filteredStudents.Length - 1] = student;
                    f = true;
                }
            }
            if (f == false)
            {
                throw new StudentNotFoundException("Telebe yoxdur!");
            }

            Students = filteredStudents;
            return Students;
        }


    }
}
