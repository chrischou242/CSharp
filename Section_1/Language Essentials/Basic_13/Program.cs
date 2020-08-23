using System;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            PrintNumbers();
            PrintOdds();
            PrintSum();
            int [] loopArray = new int [] {0,1,2,3,4,5,6,7};
            LoopArray( loopArray);
            int [] maxNumber = new int[] {0,-1,5,2,3};
            FindMax(maxNumber);
            int [] average = new int [] {0,1,2,3,4};
            FindAverage(average);
            OddNumbers();
            
            int [] GreaterThanY = new int[] {0,12,3,4,5};
            int num = 5;
            GreaterThan(GreaterThanY, num );
            
            int [] square = new int[] {0,5,10};
            SquareTheValues(square);
            
            int [] NegativeNumber = new int[] {-9, 0, 1,2,-4};
            EliminateNegativeNumber(NegativeNumber);
            
            int [] findNums = new int[] {0,1,2,3,4,5,6};
            MinMaxAverage(findNums);

            int [] shift = new int[] {0,1,2,3,4};
            ShiftValue(shift);
            ShiftValue(shift);
            foreach ( var nums in shift)
            {
                Console.WriteLine(nums);
            }

            int [] NumsArray= new int [] {0,-1,2,3,5};
            object [] NumsObject = NumToString(NumsArray); 
              foreach ( var nums in NumsObject)
            {
                Console.WriteLine(nums);
            }


        }
        public static void PrintNumbers()
        {
            for(int i=0; i<= 255; i++){
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for(int i=0; i<=255; i++){
                if(i%2 !=0){
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum=0;
            for(int i=0; i<=255; i++){
                sum = sum + i;
                Console.WriteLine("New Number: " +i+ " Sum " + sum);
            }

        }

        public static void LoopArray(int[] numbers)
        {
            for (int i=0; i<numbers.Length; i++){
                Console.WriteLine(i);
            }
        }

        public static void FindMax(int[] numbers)
        {
            int max =numbers[0];
            for (int i=0; i<numbers.Length; i++){
                
                if(numbers[i]>max){
                    max=numbers[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void FindAverage(int[] numbers)
        {
            int sum =0;
            int average =0;
            for (int i=0; i<numbers.Length; i++ ){
                sum = sum + numbers[i];
                average = sum/numbers.Length;
            }
            Console.WriteLine(average);
        }

        public static int[] OddNumbers()
        {
            for (int i=0; i<=255; i++){
                if (i %2 !=0){
                    Console.WriteLine(i);
                }
            }
            return i
               
        }

        public static void GreaterThan(int [] numbers , int Y)
        {
            for (int i=0; i<numbers.Length ; i++){
                if ( numbers[i] > Y){
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        public static void SquareTheValues(int [] numbers)
        {
            for (int i=0; i< numbers.Length; i++){
                numbers[i] = numbers[i] * numbers[i];
                Console.WriteLine(numbers[i]);
            }
        }

        public static void EliminateNegativeNumber(int [] numbers)
        {
            for (int i=0; i< numbers.Length; i++){
                if (numbers[i]<0){
                    numbers [i]=0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int min= numbers[0];
            int max = numbers[0];
            int sum =0;
            int average =0;
            for (int i =0; i< numbers.Length ; i++){
                sum = sum + numbers[i];
                average = sum/numbers.Length;
                if (numbers[i]>max){
                    max = numbers[i];
                }
                else {
                    min = numbers[i];
                }
                
            }
            Console.WriteLine($"Sum: {sum} { max}  {min}");
        }
        public static void ShiftValue(int [] numbers)
        {
            for ( int i=0 ; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] =0;
        }

        public static object[] NumToString(int[] numbers)
        {
            object [] nums = new object[numbers.Length];
            for (int i = 0; i < numbers.Length ; i++){
                if(numbers[i]<0){
                    nums[i]= "Dojo";
                }
                else
                {
                    nums[i] = numbers[i];
                }
            }
            return nums;
        }
    }

}  




// public static object[] NumToString(int[] numbers)
// {
//     // Write a function that takes an integer array and returns an object array 
//     // that replaces any negative number with the string 'Dojo'.
//     // For example, if array "numbers" is initially [-1, -3, 2] 
//     // your function should return an array with values ['Dojo', 'Dojo', 2].
// }

