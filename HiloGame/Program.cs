namespace HiloGame
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to HiLo.");
                Console.WriteLine($"Gues number between 1 and {HiLo.MAXIMUM}.");

                while (HiLo.GetPot() > 0)
                {
                    Console.WriteLine("Press h for higher, l for lower, ? for buy a hint");
                    Console.WriteLine($"Or any other key for quit with {HiLo.GetPot()}.");
                    char key = Console.ReadKey(true).KeyChar;
                    if (key == 'h') HiLo.Guess(true);
                    else if (key == 'l') HiLo.Guess(false);
                    else if (key == '?') HiLo.Hint();
                    else return;
                    Console.ReadKey();
                }
                Console.WriteLine("The pot is empty.Bye!");
            }
    }
}
