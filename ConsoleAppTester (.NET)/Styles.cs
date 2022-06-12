namespace ConsoleAppTester__.NET_
{
    internal class Styles
    {
        public static void SetColor(string color, bool on)
        {
            if (color == "Green" & on)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if(color == "Green" & !on)
            {
                Console.ResetColor();
            }

            if (color == "Red" & on)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "Red" & !on)
            {
                Console.ResetColor();
            }
        }
    }
}
