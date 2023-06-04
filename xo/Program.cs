using System;
using System.Linq;

namespace xo
{
    internal class Program
    {
        private static char x= 'x';
        private static char o = 'o';
         
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
        static void PrintMap(char[]map)
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < 9; i += 3)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(map[i + j] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }
        public static bool IsWin(char[] map)
        { 
            // Check rows
            for (int i = 0; i < 9; i += 3)
            {
                if (  map[i] != '-' && map[i] == map[i + 1] && map[i + 1] == map[i + 2] && map[i] == x && map[i + 1] == x && map[i + 2] == x)
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (map[i] == x  && map[i] == map[i + 3] && map[i + 3] == map[i + 6] && map[i+3] == x && map[i+6] == x)
                {
                    return true;
                }
            }

            // Check diagonals
            if (map[0] == map[4] && map[4] == map[8] && map[0]==x && map[4] == x && map[8] == x)
            {
                return true;
            }

            if (map[2] == map[4] && map[4] == map[6] && map[2] == x && map[4] == x && map[6] == x)
            {
                return true;
            }

            return false;
        }
        public static bool IsLose(char[]map)
        {
            // Check rows
            for (int i = 0; i < 9; i += 3)
            {
                if (map[i] != '-' && map[i] == map[i + 1] && map[i + 1] == map[i + 2] && map[i] == o && map[i + 1] == o && map[i + 2] == o)
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (   map[i] != '-' && map[i] == map[i + 3] && map[i + 3] == map[i + 6] && map[i] == o && map[i + 3] == o && map[i + 6] == o)
                {
                    return true;
                }
            }

            // Check diagonals
            if (map[0] != '-' && map[0] == map[4] && map[4] == map[8] && map[0] == o && map[4] == o && map[8] == o)
            {
                return true;
            }

            if (map[2] != '-' && map[2] == map[4] && map[4] == map[6] && map[2] == o && map[4] == o && map[6] == o)
            {
                return true;
            }

            return false;
        }
        public static bool IsEnd(char[ ]map)
        {
            //Determining end of game
            if (IsWin(map))
            {
                Console.Clear();
                Console.WriteLine("First Player Won !!!\n");
                PrintMap(map);
                return true;
            }
            if (IsLose(map))
            {
                Console.Clear();
                Console.WriteLine("Second Player Won !!!\n");
                PrintMap(map);
                return true;
            }
            if (!IsLose(map) && !IsWin(map) && mapIsFull(map))
            {
                Console.Clear();
                Console.WriteLine("Draw\n");
                PrintMap(map);
                return true;
            }
            return false;
        }
        static void Main()
        {  
            char[] map = new char[9]; 
             
            //the loop for the repeating the movenent by user
            do
            {    
                Console.Clear(); 
                //Print on array
                if ( !IsEnd(map))
                {
                   PrintMap(map);
                }
                else if (IsEnd(map))
                {
                    break;
                } 
                ReInput:
                //appropriation the 'x', is first player
                Console.WriteLine("First Player Put ur X");
                if (   int.TryParse(Console.ReadLine(),out int FirstPlayer) && map[FirstPlayer] != x & map[FirstPlayer] != o)
                {
                    map[FirstPlayer] = x;
                    Console.Clear() ;
                    PrintMap (map);
                }
                else if (!IsEnd(map))
                {
                    Console.WriteLine("it must be an digit!!!");
                    goto ReInput;
                } 
                ReRandom:
                if (IsEnd(map))
                {
                    break;
                }
                //appropriation value that will be the index of 'o'
                Console.WriteLine("Second Player Put ur 0");
                if (int.TryParse(Console.ReadLine(), out int SecondPlayer)&&  map[SecondPlayer] != x& map[SecondPlayer] != o  )
                    {
                        map[SecondPlayer] = o;
                    }
                    else if(!IsEnd(map)) 
                    {
                        Console.WriteLine("it must be an digit!!!");
                        goto ReRandom;
                    }
                 
                Console.Clear(); 
            } while (!IsEnd(map));
             
        }
           

    }
}
