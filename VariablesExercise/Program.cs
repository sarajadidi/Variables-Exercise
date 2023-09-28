namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* I had some errors before, but it would usually be because I forgot a quotation mark 
             * or maybe a dollar sign or something along that line*/

            string myName = "Sara";

            int firstNumber = 20;

            char letter= 'X';

            bool isMarried = true;

            double myHeight = 63;

            decimal myNumber = 300.00m;

            string myDog = "Zeus";

            int dogAge = 2;


            Console.WriteLine($"My dog's name is {myDog}, he is {dogAge} years old.");
            Console.WriteLine($"Name: {myName}\nAge: {firstNumber}");

            Console.WriteLine("Enter Your Name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");


        }
    }
}
