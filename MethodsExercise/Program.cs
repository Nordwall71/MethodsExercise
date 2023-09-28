namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite band?");
            string bandName = Console.ReadLine();
            Console.WriteLine("What is your least favorite band ?");
            string bandBandName = Console.ReadLine();
            Console.WriteLine("What is your favorite song by your favorite band?");
            string faveSong = Console.ReadLine();
            Console.WriteLine("What year did your fave band form?");
            string bandYear = Console.ReadLine();

            Console.WriteLine($"There are plenty of good bands out there, but probably none greater");
            Console.WriteLine($"{bandName}. Amid much turmoil in the year {bandYear}, they formed, much");
            Console.WriteLine($"to the chagrin of {bandBandName}, who immediately took cover.");
            Console.WriteLine($"Although they had plenty of good music, they are most known for the");
            Console.WriteLine($"song, {faveSong}.");

            int theSum = Mathematics(5, 5);
            Console.WriteLine(theSum);

            int theAnswer = Subtract(10, 5);
            Console.WriteLine(theAnswer);

            int otherAnswer = Multiply(10, 5);
            Console.WriteLine(otherAnswer);

            int lastAnswer = Divide(10, 5);
            Console.WriteLine(lastAnswer);






        }

        public static int Mathematics(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2) 
        
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2) 
        
        { 
            return num1 * num2;
        }

        public static int Divide(int num1, int num2) 
        
        { 
        return (num1 / num2);
        }

    
    }
}
