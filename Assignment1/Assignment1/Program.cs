using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, mobile,dob;
            Console.Write ("Enter your name:");
            name= Console.ReadLine();
            Console.Write("Enter your address:");
            address = Console.ReadLine();
            Console.Write("Enter your mobile number:");
            mobile = Console.ReadLine();
            Console.Write("Enter your date of birth:");
            dob = Console.ReadLine();


            Console.WriteLine("\n"+"Your information detais:"+"\n" +"Name:" +name + "\n"+"Address:"+address + 
                "\n"+ "Mobile Number:"+ mobile + "\n"+ "Date of birth:"+dob);
            Console.ReadLine();
            
        }
    }
}
