namespace FizzBuzz
{
    public class FizzBuzzProgram
    {
        public static void Main(string[] args)
        {
            string input = null;

            while (input != "x")
            {
                Console.Write("Enter number, or 'x' to quit: ");
                input = Console.ReadLine();

                if(input != "x")
                {

                    Console.WriteLine(FizzBuzzCalc(input));
                }
            }
        }

        public static string FizzBuzzCalc(string input)
        {
            string result = "";
            // If user did not enter a number, "Invalid Item"
            if(string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int number))
            {
                return "Invalid Item";
            }
            // Number not divisible by 3 or 5
            else if (number % 3 != 0 && number % 5 != 0)
            {
                return "Divided " + input + " by 3" + System.Environment.NewLine + "Divided " + input + " by 5";
            } 
            // Number divisible by either 3 or 5 or both
            else
            {
                if(number % 3 == 0)
                {
                    result = "Fizz";
                }
                if(number % 5 == 0)
                {
                    result += "Buzz";
                }
            }
            return result;
        }
    }
}


