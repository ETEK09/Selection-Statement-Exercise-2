using System.Runtime.CompilerServices;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            
            string subject = (Console.ReadLine());

            Console.WriteLine("______________");

            switch (subject.ToLower()) 
            {
                    case "math":
                    Console.WriteLine("I hate Math");
                    break;
                    
                    case "reading":
                    Console.WriteLine("I don't like reading either");
                    break;

                    case "history":
                    Console.WriteLine("History is cool");
                    break;

                    case "science":
                    Console.WriteLine("Science is my favorite");
                    break;

                    case "Art":
                    Console.WriteLine("Art is also fun");
                    break;

                    default:
                    Console.WriteLine("I don't know or have that class");
                    break;
            }
            }
    }
}