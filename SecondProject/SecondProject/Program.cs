using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void CalculateTax()
        {
            float amt, tax;
            float total = 0;
            Console.WriteLine("enter amount and tax");
            amt = float.Parse(Console.ReadLine());
            tax = float.Parse(Console.ReadLine());
            total = amt + (amt * tax / 100);
            Console.WriteLine("Total payable is "+total);
        }

        static void EvenNums()
        {
            for(int i=1;i<11;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void EvenNumsUser()
        {// Improve the code for question 4 to print all the even numbers up to a given number
            //(The number to be taken from user)
            int n;
            Console.WriteLine("enter the max range of even numbers");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Func()
        {
            //Write a method that will take username and password frm user and 
            //check if the username is "admin" and password is "1234" then print welcome. 
            //If not then print "invalid username or pas

            string username, password;
            Console.WriteLine("enter username and password");
            username = Console.ReadLine();
            password= Console.ReadLine();
            if(username=="admin" && password=="1234")
            {
                Console.WriteLine("welcome {0} ",username);
            }
            else
            {
                Console.WriteLine("wrong credentials");
            }
        }
        static void Func2()
        {
            int num;
            int avg = 0;
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("enter the number");
                num = int.Parse(Console.ReadLine());
                if (num % 7 == 0)
                {
                    sum = sum + num;
                    count++;

                }
            }
                avg = sum / count;
                Console.WriteLine("avg of the numbers divisible by 7 is "+avg);
            
        }
        static bool CheckPrime(int num)
        {
            bool bResult = true;
            for(int i=2;i<num;i++)
            {
                if (num % i == 0)
                {
                    bResult = false;
                    break;
                }
            }
            return bResult;
        }
        static void PrintPrime()
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            if(CheckPrime(num)==true)
                Console.WriteLine("number is prime");
            else
                Console.WriteLine("num is not prime");
        }
        static void PrintPrimes()
        {
            int min, max;
            Console.WriteLine("enter min and max ");
            min = int.Parse(Console.ReadLine());
            max = int.Parse(Console.ReadLine());
            for(int i=min;i<max;i++)
            {
                if(CheckPrime(i)==true)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Main(string[] args)
        {
            //CalculateTax();
            //EvenNums();
            //EvenNumsUser();
            //Func2();
            PrintPrimes();
            Console.ReadKey();
        }
    }
}
