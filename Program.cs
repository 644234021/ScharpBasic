namespace ScharpBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("x = {0} y = {1}", 123, "yeah");
            //Console.WriteLine("{0,9} {1,9}", 12345, 678910);

            //Console.WriteLine("================");

            //Console.WriteLine("Enter your name ...");
            //String name = Console.ReadLine();
            //Console.WriteLine("Your name is {0}", name);

            //Console.WriteLine("Enter your height ...");
            //int height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your height is {0}", height);

            int score;
            string n;
            do
            {
                Console.WriteLine("Enter score");
                score = int.Parse(Console.ReadLine());

                if (score >= 80 && score <= 100)
                    Console.WriteLine("Grade = 4");
                else if (score >= 75 && score <= 79)
                    Console.WriteLine("Grade = 3.5");
                else if (score >= 70 && score <= 74)
                    Console.WriteLine("Grade = 3");
                else if (score >= 65 && score <= 69)
                    Console.WriteLine("Grade = 2.5");
                else if (score >= 60 && score <= 64)
                    Console.WriteLine("Grade = 2");
                else if (score >= 55 && score <= 59)
                    Console.WriteLine("Grade = 1.5");
                else if (score >= 50 && score <= 54)
                    Console.WriteLine("Grade = 1");
                else if (score >= 0 && score <= 49)
                    Console.WriteLine("Grade = 0");
                Console.WriteLine("Enter '00' to stop ");
            } while (score != 00);
            
        }
    }
}