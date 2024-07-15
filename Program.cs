using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const string Sum = "sum";
        const string Exit = "exit";
        List<int> dinamicArray = new List<int>();
        string dataFromUser;
        bool isRun = true;

        while (isRun)
        {
            Console.Write($"Inpout digit or command ({Sum} or {Exit}): ");
            dataFromUser = Console.ReadLine().ToLower();

            switch (dataFromUser)
            {
                case Sum:
                    ShowSum(dinamicArray);
                    break;
                case Exit:
                    isRun = false;
                    break;
                default:
                    AddNumber(dinamicArray, dataFromUser);
                    break;
            }
        }
    }

    static void ShowSum(List<int> dinamicArray)
    {
        int summaElementsOfArray = 0;
        for (int i = 0; i < dinamicArray.Count; i++)
            summaElementsOfArray += dinamicArray[i];

        Console.WriteLine("Summa elements of array = " + summaElementsOfArray);
    }

    static void AddNumber(List<int> dinamicArray, string dataFromUser)
    {
        if (int.TryParse(dataFromUser, out int rightNumber))
            dinamicArray.Add(rightNumber);
    }
}