namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "English":
                    Console.WriteLine("I like English too!");
                    break;
                case "Math":
                    Console.WriteLine("Math is hard");
                    break ;
                case "Science":
                    Console.WriteLine("Scicence is a good one.");
                    break;
                case "History":
                    Console.WriteLine("History is boring");
                    break;
                case "Language Arts":
                    Console.WriteLine("I've never understood the differnece between that and English");
                  break;
                default:
                    Console.WriteLine("I've never heard of that one!");
                    break;

            }
        }
    }
}