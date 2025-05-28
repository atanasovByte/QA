namespace demo_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            // If the user just presses Enter, ReadLine() returns null at end-of-stream,
            // or an empty string if input stream is still open—but for the sake of this demo
            // we’ll assume null to trigger the exception.
            string name = Console.ReadLine();

            // This call will throw an ArgumentNullException if name is null:
            Console.WriteLine($"Hello, {name.ToUpper()}!");
        }
    }
}
