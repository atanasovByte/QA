namespace demo_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            // Loop until the user enters a non-empty name
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Name cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(name));

            // At this point, name is guaranteed to be non-null and non-whitespace
            Console.WriteLine($"Hello, {name.ToUpper()} !!");
            //Solution of issue #3 - added a do while
            //Fixes #3 - added a do while loop to prevent empty input
        }
    }
}
