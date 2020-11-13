using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
       static void Add()
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("sum of the numbers is "+(num1+num2));
            //Console.WriteLine("sum of {0} and {1} is {2}",num1,num2,num1+num2);
         
        }

        static void GreatestNum()
        {
            int num1, num2;
            Console.WriteLine("enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1>num2)
                Console.WriteLine("num1 is greater");
            else if(num1==num2)
                Console.WriteLine("they are equal");
            else
                Console.WriteLine("num2 is greater");
            
        }
        static void Operations()
        {
            int num1,num2;
            string opr;
            Console.WriteLine("enter two numbers");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the opearnd");
            opr = Console.ReadLine(); 

            switch (opr)
            { 
            case "+":
                    Console.WriteLine("sum of the numbers is " + (num1 + num2));
                break;
            case "-":
                    Console.WriteLine("product of the numbers is " + (num1 * num2));
                break;
            case "*":
                    Console.WriteLine("difference of the numbers is " + (num1 - num2));
                break;
            case "/":
                    if(num2!=0)
                        Console.WriteLine("division of the numbers is " + (num1 / num2));
                    else
                        Console.WriteLine("cant divide by zero");
                break;
             default:
                    Console.WriteLine("invalid input");
                    break;

            }
        }

        static void WhileLoop()
        {
            int count = 0;
            while(count<10)
            {
                Console.WriteLine(count);
                count++;
            }
        }
        static void DoWhileLoop()
        {
            int count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 10);
        }

        static void ForLoop()
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        static void UserInputs()
        {
            int sum = 0;
            int num;

            do
            {
                Console.WriteLine("enter the number");

                num = int.Parse(Console.ReadLine());
                if(num>0)
                    sum = sum + num;


            } while (num > 0);

            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
        //Add();
        //GreatestNum();
        //Operations();
            UserInputs();
            Console.ReadKey();
        }
    }
}
