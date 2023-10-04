// Task 1
// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 5, 2, 8, 1, 6, 9, 3, 7 };

//         int minValue = FindMinValue(numbers);

//         Console.WriteLine($"Massivdəki minimum dəyərdir: {minValue}");
//     }

//     static int FindMinValue(int[] array)
//     {
//         int minValue = array[0];

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] < minValue)
//             {
//                 minValue = array[i];
//             }
//         }

//         return minValue;
//     }
// }


// Task 2
// using System;
// class Program
// {
//     static void Main()
//     {
//         double circleArea = CalculateArea(5.0);
//         double rectangleArea = CalculateArea(4.0, 6.0);
//         double parallelepipedArea = CalculateArea(3.0, 4.0, 5);
//         double circleInTriangleArea = CalculateArea(3.0, 4.0, 5.0);

//         Console.WriteLine("Dairenin Sahesi: " + circleArea);
//         Console.WriteLine("Duzbucagin Sahesi: " + rectangleArea);
//         Console.WriteLine("Paralelepiped Sahesi: " + parallelepipedArea);
//         Console.WriteLine("Uchbucaqda dairenin Sahesi: " + circleInTriangleArea);
//     }

//         private const double Pi = Math.PI;

//     public static double CalculateArea(double radius)
//     {
//         return Pi * Math.Pow(radius, 2);
//     }

//     public static double CalculateArea(double length, double width)
//     {
//         return length * width;
//     }

//     public static double CalculateArea(double length, double width, int height)
//     {
//         return 2 * (length * width + length * height + width * height);
//     }

//     public static double CalculateArea(double sideA, double sideB, double sideC)
//     {
//         double semiperimeter = (sideA + sideB + sideC) / 2;
//         return Pi * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC) / semiperimeter;
//     }
// }


// Task 3 Optional)
using System;
public class NumberProcessor
{
    public static void Main(string[] args)
    {
        int number = GetPositiveNumber();
        int sum = CalculateSumOfDigits(number);
        Console.WriteLine("Reqemlerin cemi: " + sum);
    }

    public static bool IsNegative(int number)
    {
        return number < 0;
    }

    public static int GetPositiveNumber()
    {
        Console.Write("Eded daxil edin: ");
        int input = int.Parse(Console.ReadLine());

        if (IsNegative(input))
        {
            Console.WriteLine("Zehmet olmasa musbət reqem və ya sifir daxil etmeyin.");
            return GetPositiveNumber(); 
        }

        return input;
    }

    public static int CalculateSumOfDigits(int number)
    {
        if (number == 0)
        {
            return 0;
        }

        return (number % 10) + CalculateSumOfDigits(number / 10);
    }
}
