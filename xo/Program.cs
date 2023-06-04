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
                if ( arr[i]=='\0'  &arr[i] !=x & arr[i] != o )
                {
                    return false;
                }
            }
            return true;
        } 
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
                 
             ReInput: 
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
                    goto ReInput;
                } 
                 ReRandom:
                
                //appropriation value that will be the index of 'o'
                int random = rnd.Next(9); 
                if (   map[random] != x& map[random] != o)
                    {
                        map[random] = o;
                    }
                    else if(!mapIsFull(map)) 
                    {
                        goto ReRandom;
                    }  
                Console.Clear();  
            } while (!mapIsFull(map));
             
        } 
     
}
}
