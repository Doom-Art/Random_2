namespace Random_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.WriteLine("Please provide a minimum value");
            int min;
            while (!int.TryParse(Console.ReadLine().Trim(), out min))
            {
                Console.WriteLine("Please put in a valid number");
            }
            Console.WriteLine("Please provide a maximum value");
            int max = 0;
            while (!int.TryParse(Console.ReadLine().Trim(), out max) || max < min)
            {
                Console.WriteLine("Please put in a valid number");
            }
            Random rand = new Random();
            Console.Write("You're Random numbers are :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rand.Next(min, max + 1) + " ");
            }

            //part 2
            Console.WriteLine("Press enter to see your Dice Rolls");
            Console.ReadLine();
            Console.Clear();
            DiceDrawing(rand.Next(1, 7),2,0);
            DiceDrawing(rand.Next(1, 7),9,0);
            Console.WriteLine("\n\nPress enter to continue");
            Thread.Sleep(1000);
            Console.Read();
            Console.Clear();
            Thread.Sleep(500);

            //part 3
            Console.WriteLine("Please provide a minimum decimal value");
            double minTwo;
            while (!double.TryParse(Console.ReadLine().Trim(), out minTwo))
            {
                Console.WriteLine("Please put in a valid number");
            }
            Console.WriteLine("Please provide a maximum decimal value");
            double maxTwo = 0;
            while (!double.TryParse(Console.ReadLine().Trim(), out maxTwo) || maxTwo < minTwo)
            {
                Console.WriteLine("Please put in a valid number");
            }
            bool hasDecimal = int.TryParse(Convert.ToString(maxTwo), out int temp);
            Console.WriteLine("Please state how many decimal points should be rounded");
            int roundTo;
            while (!int.TryParse(Console.ReadLine().Trim(), out roundTo))
            {
                Console.WriteLine("Please put in a valid number");
            }
            Console.Write("You're random decimal values are: ");
            for (int i = 0; i <3; i++)
            {
                int tempRand;
                if (hasDecimal){
                    tempRand = rand.Next((int)Math.Truncate(minTwo), ((int)Math.Truncate(maxTwo)+1));
                }
                else{
                    tempRand = rand.Next((int)Math.Truncate(minTwo), ((int)Math.Truncate(maxTwo)));
                }
                double tempRandTwo = tempRand + rand.NextDouble();
                Console.Write(Math.Round(tempRandTwo,roundTo) + " ");
            }
            

        }
        /// <summary>
        /// Draws a dice face corrosponding to the number given.
        /// </summary>
        /// <param name="dice">An int value between 1-6 representing the die face you want printed. </param>
        public static void DiceDrawing(int dice, int x, int y)
        {
            
            if (dice == 1)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 2)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 3)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o  |");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|  o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 4)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|   |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 5)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("| o |");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
            else if (dice == 6)
            {
                Console.SetCursorPosition(x, y + 1); Console.Write("_____");
                Console.SetCursorPosition(x, y + 2); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 3); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 4); Console.Write("|o o|");
                Console.SetCursorPosition(x, y + 5); Console.Write("-----");
            }
        }
    }
}