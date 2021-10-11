using System;

namespace VorsinArrayHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4 };
            Console.WriteLine("Which values would you like yto add?");
            string inputNumbers = Console.ReadLine();
            int[] secondArray = Array.ConvertAll(inputNumbers.Split(' '), int.Parse);
            Array.Resize(ref firstArray, firstArray.Length + secondArray.Length);
            Array.Copy(secondArray, 0, firstArray, firstArray.Length - secondArray.Length, secondArray.Length);

            Console.WriteLine(String.Join(",", firstArray));


        }
    }
}
