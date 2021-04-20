using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        //   {
        //       var r = new Random();
        //       var favNumber = r.Next(1, 1000);



        //       Console.WriteLine("Try to guess my favorite number...");
        //       var userInput = int.Parse(Console.ReadLine());

        //       // IF ELSE STATEMENT

        //      if (userInput < favNumber)
        //       {
        //           Console.WriteLine(" Too Low! ");
        //       Console.WriteLine($"The number was really, {favNumber}");
        //       }
        //       else if (userInput > favNumber)
        //       {
        //           Console.WriteLine(" Too High!");
        //           Console.WriteLine($"The number was really, {favNumber}");
        //       }
        //       else if (userInput == favNumber)
        //       {
        //           Console.WriteLine("Nevermind, here is a taco!");

        //       }

        //   }
        //   // SWITCH CASE STATEMENT

        {
            //string subject = "C#";
            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class.");
                    break;
                case "Javascript":
                    Console.WriteLine("You are in the wrong class.");
                    break;
                case "SQL":
                    Console.WriteLine("This is also the wrong class.");

                    break;

                default:
                    Console.WriteLine("We teach coding here.");
                    break;
            }

        }

    }
}