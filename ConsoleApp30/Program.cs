using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int vowel = 0;
            //int constant = 0;
            ////Print total number of vowels and Constants
            //Console.WriteLine("enter a string");
            //string str = Convert.ToString(Console.ReadLine());  
            //for(int i =0;i<str.Length;i++)
            //{
            //    //a e i o u
            //    if (str[i] =='a')
            //    {
            //        Console.WriteLine("Vowel is " + str[i]);
            //        vowel+=1;
            //    }
            //    else if (str[i] == 'e')
            //    {
            //        Console.WriteLine("Vowel is " + str[i]);
            //        vowel += 1;
            //    }
            //    else if (str[i] == 'i')
            //    {
            //        Console.WriteLine("Vowel is " + str[i]);
            //        vowel += 1;
            //    }
            //    else if (str[i] == 'o')
            //    {
            //        Console.WriteLine("Vowel is " + str[i]);
            //        vowel += 1;
            //    }
            //    else if (str[i] == 'u')
            //    {
            //        Console.WriteLine("Vowel is " + str[i]);
            //        vowel += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Constants are " + str[i]);
            //        constant += 1;
            //    }




            //}

            //Console.WriteLine("Vowels " + vowel);
            //Console.WriteLine("constants " + constant);

            //string str = "Rohan@#123";
            //int alphabet = 0;
            //int numbers = 0;
            //int specialchar = 0;
            //for(int i =0;i<str.Length;i++) 
            //{
            //    if (str[i]=='a'-'z')
            //    {
            //        alphabet += 1;
            //        //Console.WriteLine(alphabet);
            //    }
            //    else if (str[i]==0-10)
            //    {
            //        numbers += 1;
            //        //Console.WriteLine(numbers);

            //    }
            //    else
            //    {
            //        specialchar += 1;
            //    }

            //}
            //Console.WriteLine(alphabet);



            Console.WriteLine("Enter a string value");
            string str = Console.ReadLine();
            string str2 = "";
            for(int i= str.Length-1; i>=0; i--)
            {
                //Console.WriteLine(str[i]);
                str2 += str[i];
            }
            Console.WriteLine(str2);
        }
    }
}
