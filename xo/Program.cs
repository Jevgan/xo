using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xo
{
    internal class Program
    {
        private static char x= 'x';
        private static char o = 'o';
        //
        public static bool MyArrayIsntFull(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool MyArrayIsntNull(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    return true;
                }
            } 
            return false;
        }
        //
        public static void ShowMap(char[] arr)
        {
            Console.Write($"[{arr[0]}][{arr[1]}][{arr[2]}]\n[{arr[3]}][{arr[4]}][{arr[5]}]\n[{arr[6]}][{arr[7]}][{arr[8]}]");
        }
        static void Main( )
        { 
            int input;
            char[] myArray = new char[9];
            Random rnd = new Random();

            int random=rnd.Next(8);

            bool isnotnull = MyArrayIsntNull(myArray);
            do
            {    
                Console.Clear();
                //print on array
                ShowMap(myArray);
                input = int.Parse(Console.ReadLine());
                //appropriation the value that inputing in showmap:)))
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (input==i)
                    {
                        myArray[i] =x;
                    }
                    else
                    {
                        myArray[random] = o;
                    } 
                }
                Console.Clear(); 

                 
            } while ( MyArrayIsntFull(myArray));               
        }
        
    }
}
