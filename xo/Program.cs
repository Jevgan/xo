using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xo
{
    internal class Program
    {
        public static string x= "x";
        public static string o = "o"; 
        public static bool MyArrayIsntNull(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] != null)
                {
                    return true;
                }
            }
            Console.WriteLine(  "U win");
            return false;
        }
        
        static void Main( )
        { 
            int input;
            string[] myArray = new string[9];
            Random rnd = new Random();
             
            do
            {
                
                //printing the array 
                    for (int i = 0; i < myArray.Length; i++)
                    { 
                            Console.Write($" [  {myArray[i]}  ] ");
                        if (i == 2 || i == 5 || i == 8)
                            Console.WriteLine();
                    }
                input = int.Parse(Console.ReadLine());

                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (input == i)
                        {
                            myArray[i] = x;
                            Console.Write($" [  {myArray[i]}  ] ");
                        }
                        else
                            Console.Write($" [  {myArray[i]}  ] ");
                        if (i == 2 || i == 5 || i == 8)
                            Console.WriteLine();
                    }


                 
                Console.ReadLine();
                Console.Clear(); 
                 
            } while (MyArrayIsntNull(myArray));               
        }
        
    }
}
