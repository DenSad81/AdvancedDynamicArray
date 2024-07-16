using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const string CommandSum = "sum";
        const string CommandExit = "exit";
        List<int> digits = new List<int>();
        string dataFromUser;
        bool isRun = true;

        while (isRun)
        {
            Console.Write($"Inpout digit or command ({CommandSum} or {CommandExit}): ");
            dataFromUser = Console.ReadLine().ToLower();

            switch (dataFromUser)
            {
                case CommandSum:
                    ShowSum(digits);
                    break;

                case CommandExit:
                    isRun = false;
                    break;

                default:
                    AddNumber(digits, dataFromUser);
                    break;
            }
        }
    }

    static void ShowSum(List<int> digits)
    {
        int summaElementsOfArray = 0;

        for (int i = 0; i < digits.Count; i++)
            summaElementsOfArray += digits[i];

        Console.WriteLine("Summa elements of array = " + summaElementsOfArray);
    }

    static void AddNumber(List<int> digits, string dataFromUser)
    {
        if (int.TryParse(dataFromUser, out int rightNumber))
            digits.Add(rightNumber);
    }
}