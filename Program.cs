using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.Write(i+", ");
            }
        }
         // Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i%2!=0)
                {
                    Console.Write(i+", ");
                }
            }
        }
        public static void PrintSum()
        {
            int sum=0;
            for (int i = 0; i <= 255; i++)
            {
                sum=sum+i;
                Console.WriteLine("New number: "+i+" Sum: "+sum);
            }
        }
        // Iterating through an Array
        public static void LoopArray(int[] PrintNumbers)
        {
            foreach (var num in PrintNumbers)
            {
                Console.WriteLine(num);
            }
        }
        // Find Max
        public static int FindMax(int[] numbers)
        {
            int max =numbers[0];
            foreach (var num in numbers)
            {
                if (max<num)
                {
                    max=num;
                }
            }
            Console.WriteLine("The max number is "+ max);
            return max;
        }
        // Get Average
        public static int GetAvg(int[] numbers)
        {
            int sum =0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum=sum+numbers[i];
            }
            int avg = sum/(numbers.Length);
            return avg;
        }
        // Array with Odd Numbers
        public static int[] OddArray()
        {
            int[] NumArr= new int[128];
            int index=0;
            for (int i = 1; i <=255; i++)
            {
                if (i%2!=0)
                {
                    NumArr[index++]=i;
                }
            }
            return NumArr;
        }
        // Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>y)
                {
                    count++;
                }
            }
            return count;
        }
        // Square the Values
        public static int[] SquareArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]=numbers[i]*numbers[i];
            }
            return numbers;
        }
        // Eliminate Negative Numbers
        public static int[] ElimNeg(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    numbers[i]=0;
                }
            }
            return numbers;
        }
        // Min, Max, and Average
        public static void MinMaxAvg(int[] numbers)
        {
            int sum =0;
            int max=numbers[0];
            int min=numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max<numbers[i])
                {
                    max=numbers[i];
                }
                if (min>numbers[i])
                {
                    min=numbers[i];
                }
                sum=sum+numbers[i];
            }
            int avg = sum/(numbers.Length);
            Console.WriteLine("Max: "+max);
            Console.WriteLine("Min: "+min);
            Console.WriteLine("Avg: "+avg);
        
        }
        // Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i <numbers.Length-1; i++)
            {
                numbers[i]=numbers[i+1];
            }
            numbers[numbers.Length-1]=0;
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        // Number to String
        public static object[] NegToString(int[] numbers)
        {
            object[] list= new object[numbers.Length] ;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    list[i]="Dojo";
                }
                else
                {
                    list[i]=numbers[i];
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] arr=new int[] {1,2,3,-4,5};
            // LoopArray(arr);
            // Console.WriteLine(FindMax(arr));
            // Console.WriteLine("The average is "+GetAvg(arr));
            // Console.Write("[");
            // foreach (var item in OddArray())
            // {
                
            //     Console.Write(item+",");
                
            // }
            // Console.Write("]");
            // Console.WriteLine("There are "+GreaterThanY(arr,-6)+" numbers greater than y");
            //  Console.Write("[");
            // foreach(var item in SquareArray(arr))
            // {
            //     Console.Write(item+",");
            // }
            // Console.Write("]");
            
            // foreach (var item in ElimNeg(arr))
            // {
            //     Console.WriteLine(item);
            // }

            // MinMaxAvg(arr);
            // ShiftValues(arr);
            foreach (var item in NegToString(arr))
            {
                Console.WriteLine(item);
            }
        }
    }
}
