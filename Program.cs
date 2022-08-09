using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC_AND_INSTANCE_Member
{

    class Student {
        public int id;
        public string name;
        public string Email;
        public string Address;

        public static string SchoolName = "ABCD";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Neha = new Student();
            
            Console.WriteLine( Neha.id=1);
            Console.WriteLine( Neha.name = "nehaSingh");
            Console.WriteLine(Neha.Email = "nehg@gmail.com");
            Console.WriteLine(Neha.Address = "Ballia");
            Console.WriteLine(Student.SchoolName);
            Console.WriteLine("----------------------------------------");
            Student nikki = new Student();
            Console.WriteLine(nikki.id = 2);
            Console.WriteLine( nikki.name = "Nikki Singh");
            Console.WriteLine (nikki.Email = "nikki@gmail.com");
            Console.WriteLine(nikki.Address = "Dokati");
            Console.WriteLine(Student.SchoolName);
            Console.ReadLine();
        }
    }
}
