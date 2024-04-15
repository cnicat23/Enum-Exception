using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public InformationField InformationField { get; set; }

        public Student(string name, string surName, InformationField informationField)
        {
            _id++;
            Id = _id;
            Name = name;
            SurName = surName;
            InformationField = informationField;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Surname: {SurName}; Class Type: {InformationField}";
        }
    }
}
