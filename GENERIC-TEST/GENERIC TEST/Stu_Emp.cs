using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TEST
{

    public class Student
    {
        private string Name;
        private int Stuid;
        private int Age;
        private int Class;
        private string Stream;

        public Student(string name, int stuID, int age, int classNumber, string stream)
        {
            this.Name = name;
            this.Stuid = stuID;
            this.Age = age;
            this.Class = classNumber;
            this.Stream = stream;
        }

        public string GetSTUDENTNAME { get { return this.Name; } }

        public int GetSTUDENTID { get { return this.Stuid; } }

        public int GetAge { get { return this.Age; } }

        public int GetClass { get { return this.Class; } }

        public string GetStream { get { return this.Stream; } }

    }

    public class Employee
    {
        private string Name;
        private int Empid;
        private int Age;
        private string Dept;

        public Employee(string name, int empid, int age, string dept)
        {
            this.Name = name;
            this.Empid = empid;
            this.Age = age;
            this.Dept = dept;

        }

        public string GetEMPLOYEENAME { get { return this.Name; } }

        public int GetEMPLOYEID { get { return this.Empid; } }

        public string GetEMPLOYEAGE { get { return this.Name; } }

        public string GetEMPLOYEDEPT { get { return this.Dept; } }



    }
}
