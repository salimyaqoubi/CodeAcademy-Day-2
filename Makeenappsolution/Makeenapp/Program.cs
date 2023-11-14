
using System.Runtime.ExceptionServices;

namespace Makeenapp
{
    class Program
    {
        static void Main()
        {
            #region consolling data

            /*
             
            //infirmation about me

            //string name = "my name is salim \n";
            //Console.WriteLine(name);

            */

            //Decimal
            //double payment = 4.45;
            //float money = 4.55;
            //decimal salary = 3.35;


            //int realpayment = (int)payment;
            //int realmoney = (int)money;
            //int realsalary = (int)salary;
            #endregion

            string Name = "salim juma";
            string Address = "Al Seeb";
            int age;
            age = 22;

            //Declaration of Value Type
            Console.WriteLine("my name is \n" + Name);
            Console.WriteLine("i am from \n" + Address);
            Console.WriteLine("i am " + age + "years old");
            // variable Declaration

            long ssn = 123445677;
            // decimal 
            double payment = 52.67;
            float money = 30.58;
            decimal salary = 4.5;
            Console.WriteLine(money);

            int x = 5;
            int y = x;
            Console.WriteLine(y);
            x = 6;
            Console.WriteLine(y);
            string grrting = "hello world";
            string Cgrating = grrting;
            Console.WriteLine(Cgrating);
            grrting = "salim";
            Console.WriteLine(Cgrating);
            Console.WriteLine("----------------OLD------------");

            Object obj1 = new Object(); // 
            Object obj2 = new Object(); // 
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("-------------old-----------");
            obj2 = obj1;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


        }
    }
}

