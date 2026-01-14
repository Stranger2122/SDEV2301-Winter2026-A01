namespace ControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int grade);

            // Comparison opertors are the same as Python and Javascript
            // <, >, <=, >=, ==, !=
            if (grade >= 90)
                Console.WriteLine("You got an A!");
            else if (grade >= 80)
                Console.WriteLine("You got a B!");
            else if (grade >= 70)
                Console.WriteLine("You got a C!");
            else if (grade >= 60)
                Console.WriteLine("You got a D!");
            else
                Console.WriteLine("You got an F!");

            Console.Write("Enter your age: ");
            success = int.TryParse(Console.ReadLine(), out int age);

            Console.Write("Are you a student (yes/no)? ");
            string isStudentResponse = Console.ReadLine();
            bool isStudent = isStudentResponse.ToLower() == "yes";

            // Logical Operators
            // and --- &&
            // or  --- ||
            // not --- !

            if (age < 18 || isStudent)
                Console.WriteLine("You are a tax evader.");
            if (age >= 18 && isStudent)
                Console.WriteLine("Discount on Pizza");
            if (!isStudent)
                Console.WriteLine("Full price pizza and taxes pour vous!");

            int counter = 0;
            Console.Write("Do you want to increase the counter? (y/n) ");
            bool increase = Console.ReadLine() == "y";

            // WHILE loops
            while (increase)
            {
                Console.WriteLine($"Current counter value: {counter}");
                Console.Write("How much would you like to increase the counter by? ");
                success = int.TryParse(Console.ReadLine(), out int val);

                if (success)
                {
                    counter += val;
                }
                else
                {
                    Console.WriteLine("Not valid. Try again.");
                }
                Console.Write("Do you want to increase the counter? (y/n) ");
                increase = Console.ReadLine() == "y";
            }

            // DO-WHILE loops
            // make sure to declare the variable you use in your loop condition before starting the do-while loop
            string upOrDown;
            do
            {
                Console.Write("Do you want to count up or down? ");
                upOrDown = Console.ReadLine();

                if (upOrDown != "up" && upOrDown != "down")
                    Console.WriteLine("Invalid entry.");
            } while (upOrDown != "up" && upOrDown != "down");

            // FOR Loops
            if (upOrDown == "up")
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"Counter: {i + 1}");
                }
            }
            else
            {           
                for (int i = counter; i >= 0; i--)
                {
                    Console.WriteLine($"Counter: {i}");
                }
            }
        }

    }
}
