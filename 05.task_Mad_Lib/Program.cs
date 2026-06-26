namespace _5.task_Mad_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            string? color, pluralNoun, celebrity;

            Console.Write("Enter A color: ");
            color = Console.ReadLine();

            Console.Write("Enter A pluralNoun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter A celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");
        }
    }
}


