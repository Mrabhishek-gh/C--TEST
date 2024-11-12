using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Abhishek Ghosh", 2001, 21, 1, "ECE");
            Student stu2 = new Student("Raghav Ghosh", 2002, 22, 1, "ECE");
            Student stu3 = new Student("Shreya Ghosh", 2003, 21, 1, "ECE");
            Employee emp1 = new Employee("Aditya Ghosh", 10101, 30, "Electronics");


            Boolean ch = true;
            GenClass<Student> genClass1 = new GenClass<Student>();
            GenClass<Employee> genClass2 = new GenClass<Employee>();
            while (ch == true)
            {
                Console.WriteLine("1. Add Student  2. Add Employee  3. Get Students  4. Get Employees  5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Student Name ->");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter Student ID ->");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Age ->");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Class ->");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Stream ->");
                        string s = Console.ReadLine();
                        Student stu = new Student(n, i, a, c, s);
                        genClass1.add(stu);


                        Console.WriteLine("Student Successfully Added");
                        break;


                    case 2:
                        Console.WriteLine("Enter Employee Name ->");
                        n = Console.ReadLine();
                        Console.WriteLine("Enter Employee ID ->");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Age ->");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Dept ->");
                        string d = Console.ReadLine();


                        Employee emp = new Employee(n, i, a, d);
                        genClass2.add(emp);
                        Console.WriteLine("Employee Successfully Added");
                        break;
                    case 3:
                        foreach (Student student in genClass1.Getobject())
                        {
                            Console.WriteLine($"{student.GetSTUDENTNAME}--                 {student.GetSTUDENTID}--{student.GetStream}--                  {student.GetAge}--{student.GetClass}");
                        }
                        break;
                    case 4:
                        foreach (Employee employee in genClass2.Getobject())
                        {
                            Console.WriteLine($"{employee.GetEMPLOYEENAME}--                {employee.GetEMPLOYEID}--{employee.GetEMPLOYEAGE}--            {employee.GetEMPLOYEDEPT}");
                        }
                        break;
                    case 5:
                        ch = false;
                        break;

                }
            }
        }
    }
}
