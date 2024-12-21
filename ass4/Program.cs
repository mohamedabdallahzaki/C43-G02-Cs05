using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass4
{
    internal class Program
    {
        //public static void Changevalue ( ref int value)
        //{
        //    value = 20;
        //   Console.WriteLine (value);

        // //}

        //public static int Sumarr ( ref int [] arr)
        // {
        //     int sum = 0;
        //     if (arr != null)
        //         arr = [1, 4, 6, 8, 7];
        //         for (int i = 0; i < arr.Length; i++)
        //         {
        //             sum += arr[i];
        //         }
        //     return sum;
        // }


        //public static void MinMaxarray(int[] arr, ref int min, ref int max)
        //{

        //    min = arr[0];
        //    max = arr[0];

        //    foreach (int num in arr)
        //    {
        //        if (num < min)
        //        {
        //            min = num;
        //        }

        //        if (num > max)
        //        {
        //            max = num;
        //        }
        //    }
        //}


        static void Main(string[] args)
        {

            #region 1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.

            //int x = 5;
            ////Console.WriteLine(x); // 5
            //Changevalue (x); // 20 
            //Console.WriteLine(x);//5 x caann't change because x is passing by value it take copy from value of x after fun stack fram become to orginal value


            //Console.WriteLine (x);// 5
            //Changevalue ( ref x );//20
            //Console.WriteLine(x);// 20 the value change because when passing by ref the 2 variable become one any change in any variable it apper to anthor















            #endregion

            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //int[] arr2 = { 1, 2, 3, 4, 5};

            ////// passing by value 
            ////int res = Sumarr (arr2);
            ////Console.WriteLine (res);
            ////Console.WriteLine(arr2[0]); // the index[0] change because passing by value it refer to the address of original obj it can affect if we change part orginal obj77


            //// passing by ref 
            //int res = Sumarr (ref arr2);
            //Console.WriteLine(res);
            //foreach(int i in arr2)
            //{
            //    Console.WriteLine(i);
            //} // the values of arr2 change because the passing by ref the arr in fun = arr2 







            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void Calac (int a, int b, out int sum, out int sub)
            //{
            //    sum = a + b;   
            //    sub = a - b;   
            //}

            //int Subres, Sumres;
            //Calac(20, 10, out Subres , out Sumres);
            //Console.WriteLine($" Sub Equal : {Subres}");
            //Console.WriteLine($" Sum Equal : {Sumres}");

            #endregion

            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like Enter a number: The sum of the digits of the number 25 is: 7
            //Console.Write("Enter a number:");
            //int number = int.Parse(Console.ReadLine());
            //int res = CalcDigits(number);

            //Console.WriteLine($"The Sum of {number} Is Equal {res}");

            //static int CalcDigits(int num)
            //{
            //    int sum = 0;


            //    while (num != 0)
            //    {
            //        sum += num % 10;
            //        num /= 10;
            //    }

            //    return sum;


            #endregion

            #region  5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //    Console.Write("Enter number: ");
            //    int num = int.Parse(Console.ReadLine());

            //    bool isPrime = IsPrime(num);

            //    if (isPrime)
            //    {
            //        Console.WriteLine("The number is Prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is not prime");
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number < 2)
            //        return false;

            //    for (int i = 2; i < number; i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            //}




            #endregion

            #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] numbers = { 5, 1, 9, 3, 7, 8, 4 };

            //int min = 0;
            //int max = 0;

            ////minmaxarray(numbers, ref min, ref max);
            ////console.writeline($"minimum value: {min}");
            ////consle.writeline($"maximum value: {max}");



            #endregion

            #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //    Console.Write("Enter number :");
            //    int number = int.Parse(Console.ReadLine());

            //    int res = Factorial(number);

            //    Console.WriteLine($"The fact of {number} is {res}");




            //    static int Factorial(int number)
            //    {
            //        int fact = 1;

            //        for (int i = number; i >= 1 ; i--)
            //        {
            //            fact *= i;
            //        }

            //        return fact;
            //    }
            //}
            #endregion

            #region 8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter


            #endregion


        }
    }
 



