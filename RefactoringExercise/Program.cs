using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REFAKTORISERA KODEN
            //Fixa koden så den blir bättre att läsa och underhålla.
            //Lägg fokus på:
            //1- Undvik Repeterad kod. Ersätt den för metoder
            //2- Lägg kommentarer. Du kan väl gyssa vad koden gör och lägga den som kommentärer
            //3- Validera input. dvs, parsa och kolla att det är i rätt typ
            //4- Hantera errors. Informera om fel och/eller skapa kod som inte crashar.
            //5- Ge feedback till användaren. Om den skriver fel ska den få veta varför.
            
            int answer = -1;

            while (answer != 0)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n 1. A line\n 2. My Line\n 3. A Square\n 4. My Square\n 5. A border\n 6. My border\n 0. Exit");
                answer = int.Parse(Console.ReadLine());

                //Example Comment
                if (answer == 1)
                {
                       Blank();
                        for (int i = 0; i < 6; i++)
                        {
                        SpacedHashtag();
                    }
                }else if(answer == 2)
                {
                    for (int i = 0; i < Hashtags(); i++)
                    {
                       SpacedHashtag();
                    }
                }
                else if(answer == 3)
                {
                    Blank();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            DoubleHashtag();
                        }
                        Console.WriteLine();
                    }
                }
                else if(answer == 4)
                {
                    int time =Hashtags(); //this is changed so it sets the time variable to prevent reentring of input everytime the second for loop runs
                    for (int i = 0; i < time; i++)
                    {
                        for (int j = 0; j < time; j++)
                        {
                            DoubleHashtag();
                        }
                        Console.WriteLine();
                    }
                }
                else if (answer == 5)
                {
                    Blank();
                    for (int i = 0; i < 17; i++)
                    {
                        SpacedHashtag();
                    }
                    Console.WriteLine("\n# Static Border #");
                    for (int i = 0; i < 17; i++)
                    {
                        SpacedHashtag();
                    }
                }
                else if(answer == 6)
                {
                    string innerText="";
                    bool LoopEnd = false;
                    while (LoopEnd == false)// while loop added to ensure the max rule is followed
                    {
                        Console.WriteLine("Write a text of max 20 characters long:");
                        innerText = Console.ReadLine();
                        if (innerText.Length < 0 || innerText.Length > 20)
                        {
                            Console.WriteLine("input above the max of 20 or below 0 try again");
                        }
                        else { LoopEnd = true; }
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < innerText.Length+4; i++)
                    {
                        Hashtag();
                    }
                    Console.WriteLine("\n# "+innerText+" #");
                    for (int i = 0; i < innerText.Length+4; i++)
                    {
                        Hashtag();
                    }

                }
                else if (answer > 6 || answer <0)
                {
                    Console.WriteLine("Input outside the give options try again");// while loop added to ensure that the user knows what whent wrong
                }

                Console.WriteLine("\n \n Press any key to continue...");
                Console.ReadKey();
                
            }
            static int Hashtags() //this solves duplicate code
            {
                int times = 0;
                bool LoopEnd = false;
                while (LoopEnd == false) // while loop added to ensure the max rule is followed
                { 
                    Console.Write("How many hashtags (input an number max 10)? ");
                     times = int.Parse(Console.ReadLine());
                    if (times < 0 || times > 10)
                    {
                        Console.WriteLine("input above the max of 10 or below 0 try again");
                    }
                    else
                    {
                        LoopEnd = true;
                    }                   
                }
                Console.WriteLine("");
                return times;
            }
            static void Blank() //added to all the onces below to prevent dublicate code
            {
                Console.WriteLine("");
            }
            static void SpacedHashtag() 
            {
                Console.Write(" # ");
            }
            static void Hashtag()
            {
                Console.Write("#");
            }
            static void DoubleHashtag()
            {
                Console.Write("##");
            }
        }
    }
}
