namespace assignment05
{
    internal class Program
    {
        #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void SwapTwoNumbers(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapTwoNumbersByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        #endregion

        #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        public static int SumArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[0] = 5000;
                sum += array[i];
            }
            return sum;
        }

        public static int SumArrayByReference(ref int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[0] = 5000;
                sum += array[i];
            }
            return sum;
        }
        #endregion

        #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //public static void OperationOnTwoNumbers (int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}
        #endregion

        #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        // Output should be like
        // Enter a number: 25
        // The sum of the digits of the number 25 is: 7

        //public static int SumOfDigits(int number) { 
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        //public static bool IsPrime (int number)
        //{
        //    if(number <= 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion

        #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //public static void MinMaxArray(ref int[] array, out int max, out int min)
        //{
        //    max = array[0];
        //    min = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }
        //    }
        //}
        #endregion

        #region 7 - Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter
        //public static void FactoricalNumbers(int number, out int factorial)
        //{
        //    factorial = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        factorial *= i;
        //    }
        //}
        #endregion

        #region 8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
        //public static string replacechar(string message, int index, char c)
        //{
        //    if (index >= message.Length || index < 0)
        //    {
        //        return "index is not valid";
        //    }
        //    else
        //    {
        //        char[] charInMessage = message.ToCharArray();
        //        charInMessage[index] = c;
        //        return new string(charInMessage);
        //    }
        //}

        #endregion
        static void Main(string[] args)
        {
            #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            // pass by value: pass the address of the arguments so it copy the reference
            //int x = 5;
            //int y = 10;
            //Console.WriteLine("Before calling Function:-");
            //Console.WriteLine($"value of x is: {x}");
            //Console.WriteLine($"value of x is: {y}");
            //SwapTwoNumbers(x,y);
            //Console.WriteLine("After calling Function:-");
            //Console.WriteLine($"value of x is: {x}");
            //Console.WriteLine($"value of x is: {y}");
            //--------------------------------------------------------------------------------------------------
            // pass by reference: pass the reference of the arguments so it copy the original reference
            //int x = 5;
            //int y = 10;
            //Console.WriteLine("Before calling Function:-");
            //Console.WriteLine($"value of x is: {x}");
            //Console.WriteLine($"value of x is: {y}");
            //SwapTwoNumbersByReference(ref x,ref y);
            //Console.WriteLine("After calling Function:-");
            //Console.WriteLine($"value of x is: {x}");
            //Console.WriteLine($"value of x is: {y}");
            #endregion

            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //value type: pass a copy of reference to array and  any modification will affect the original array
            //int[] array = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before changing values:-");
            //Console.WriteLine($"Value of first index is: {array[0]}");
            //int sum =SumArray(array);
            //Console.WriteLine($"Sum is: {sum}");
            //Console.WriteLine("After changing values:-");
            //Console.WriteLine($"Value of first index is: {array[0]}");
            //Console.WriteLine($"Sum is: {sum}");
            //--------------------------------------------------------------------------------------------------
            //Reference type: pass the original reference to array and  any modification will affect the original array
            //int[] array = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before changing values:-");
            //Console.WriteLine($"Value of first index is: {array[0]}");
            //int sum = SumArrayByReference(ref array);
            //Console.WriteLine($"Sum is: {sum}");
            //Console.WriteLine("After changing values:-");
            //Console.WriteLine($"Value of first index is: {array[0]}");
            //Console.WriteLine($"Sum is: {sum}");

            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //OperationOnTwoNumbers(5, 3, out int sum, out int sub);
            //Console.WriteLine($"Sum of Two Numbers: {sum}");
            //Console.WriteLine($"Sub of Two Numbers: {sub}");
            #endregion

            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            // Output should be like
            // Enter a number: 25
            // The sum of the digits of the number 25 is: 7

            //Console.Write("Enter a number: ");
            //bool isPasrsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isPasrsed) {
            //    Console.WriteLine($"The sum of the digits of the number {number} is : {SumOfDigits(number)}");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            #endregion

            #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter a number: ");
            //bool isPasrsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isPasrsed)
            //{
            //    if (IsPrime(number))
            //    {
            //        Console.WriteLine($"{number} is a prime number ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is not a prime number ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            #endregion

            #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //MinMaxArray(ref array, out int max, out int min);
            //Console.WriteLine($"Max number is: {max}");
            //Console.WriteLine($"Min number is: {min}");
            #endregion

            #region 7 - Create an iterative(non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter a number: ");
            //bool isPasrsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isPasrsed)
            //{
            //    FactoricalNumbers(number, out int result);
            //    Console.WriteLine($"Factorial of {number} is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            #endregion

            #region 8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //Console.Write("Enter a message: ");
            //string? message = Console.ReadLine();
            //Console.Write("Enter index Note: Index start from 0: ");
            //bool isPasrsed = int.TryParse(Console.ReadLine(), out int index);
            //if (isPasrsed)
            //{
            //    Console.Write("Enter a char: ");
            //    char.TryParse(Console.ReadLine(), out char c);
            //    Console.WriteLine(replacechar(message, index, c)); // Outputs: hallo
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

        }
    }
}
