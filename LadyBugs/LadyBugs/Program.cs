using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Field size
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];

            // This collection remains unchanged
            int[] initialIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(commandArg[0]);
                string direction = commandArg[1];
                int flyLenght = int.Parse(commandArg[2]);

                if(ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                if(field[ladyBugIndex] == 0)
                {
                    continue;
                }

               field[ladyBugIndex] = 0;
                if(direction == "left")
                {
                    flyLenght *= -1;
                }

                int nextIndex = ladyBugIndex + flyLenght;

                while(nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLenght;
                }

                if(nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
