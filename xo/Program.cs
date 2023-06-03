using System;
using System.Linq;

namespace xo
{
    internal class Program
    {
        private static char x= 'x';
        private static char o = 'o';
        //
        public static bool mapIsFull(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ( arr[i]=='\0' /*arr[i] !=x & arr[i] != o*/)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool mapIsntNull(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
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
        static void Main()
        {  
            char[] map = new char[9];
            Random rnd = new Random();
            bool isfull = mapIsFull(map);
            //the loop for the repeating the movenent by user
            do
            {    
                Console.Clear();
                //print on array
                if (!isfull)
                {
                   ShowMap(map);
                }
                 
             Repeat: 
                //appropriation the 'x' in the map 
                Console.WriteLine("\nInput the digit : ");
                if (!isfull&int.TryParse(Console.ReadLine(),out int input))
                {
                    map[input] = x;
                    Console.Clear() ;
                    ShowMap(map);
                }
                else   
                {
                    Console.WriteLine("it must be an digit!!!");
                    goto Repeat;
                }
                //appropriation value that will be the index of 'o'
                Repeat1:
                int random = rnd.Next(9);
                    if ( !isfull&map[random] != x& map[random] != o)
                    {
                        map[random] = o;
                    }
                    else
                    {
                        goto Repeat1;
                    } 
                if (isfull)
                {
                    Console.WriteLine("Tie");
                } 
                Console.Clear();  
            } while (!isfull);               
        }
        
    }
}
