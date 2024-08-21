internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Data Types");

        // I used TryParse to handle invalid input
        Console.Write("Enter the pieces of apple: ");
        if (!int.TryParse(Console.ReadLine(), out int numberOfApple))
        {
            Console.WriteLine("Invalid input for number of apples.");
            return;
        }

        Console.Write("Enter total price of {0} apple(s): ", numberOfApple);
        if (!double.TryParse(Console.ReadLine(), out double totalPrice))
        {
            Console.WriteLine("Invalid input for total price.");
            return;
        }

        // Output the original and converted price
        // I used '$' for string interpolation for cleaner and easier to read for concatenation of string and variables
        Console.WriteLine($"\nThe value of Original price is {totalPrice}");

        //Convertion of Double to Int
        int convertedPrice = (int)Math.Floor(totalPrice);
        Console.WriteLine($"The value of Converted price is {convertedPrice}");
    }
}