using System;

namespace Basic_13
{
    public class Program
    {
        public static void PrintNumbers()
            {
                for(int i=0; i<=255; i++)
                {
                    System.Console.WriteLine(i);
                }
            }
        public static void PrintOdds()
        {
            for(int i=0; i<=255; i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
        int sum =0;
            for(int i=0; i<=255; i++)
            {
                sum+=i;
                System.Console.WriteLine($"New Number: {i} Sum: {sum}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int maxCount =numbers[0];
            for(int i=1; i<numbers.Length; i++)
            {
                if(numbers[i] > maxCount)
                {
                    maxCount = numbers[i];
                }
            }
            return maxCount;
        }

        public static void GetAverage(int[] numbers)
        {
            int avg = 0;
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum/numbers.Length;
            Console.WriteLine(avg);
        }

        // public static int[] OddArray()
        // {
        //     int[] numArr = new int[255];
        //     for(int i=0; i<255; i++)
        //     {
        //         numArr[i] = i;
        //     }
        //     return numArr;
        // }

        public static int GreaterThanY(int[] PrintNumbers, int y)
        {
            int count=0;
            for(int i=0; i<PrintNumbers.Length; i++ )
            {
                if(PrintNumbers[i] > y)
                {
                    count +=1;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i] *= numbers[i];
            }
            System.Console.WriteLine(numbers);
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]<0)
                {
                    numbers[i] = 0;
                }
            }
            System.Console.WriteLine(numbers);
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int count = 0;
            int avg = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i]; 
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                count += numbers[i];
            }
            avg = count/numbers.Length;
            System.Console.WriteLine($"Max: {max}");
            System.Console.WriteLine($"Min: {min}");
            System.Console.WriteLine($"Avg: {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                if(i+1 < numbers.Length)
                {
                    numbers[i] = numbers[i+1];
                }
                else{
                    numbers[i] = 0;
                }
                System.Console.WriteLine(numbers[i]);
            }
        }

        // public static object[] NumToString(int[] numbers)
        // {
        //     foreach(int v in numbers)
        //     {
        //         System.Console.WriteLine(v);
        //     }
        //     return numbers;
        // }

        public static void Main(string[] args)
        {
            int[] newArr = {1,-4,3,7,5,-2};
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(newArr);
            // Console.WriteLine(FindMax(newArr));
            // GetAverage(newArr);
            // Console.WriteLine(OddArray());
            // Console.WriteLine(GreaterThanY(newArr, 3));
            // SquareArrayValues(newArr);
            // EliminateNegatives(newArr);
            // MinMaxAverage(newArr);
            // ShiftValues(newArr);
            // NumToString(newArr);
        }
    }
}
