namespace ConsoleAppTester__.NET_
{
    internal class MessagesViewer
    {
        public static void Error(string code, bool line = true)
        {
            StylesSelector.SetColor("Red", true);
            if (line)
            {
                Console.WriteLine(Messages.errors[code]);
            }
            else
            {
                Console.Write(Messages.errors[code]);
            }
            StylesSelector.SetColor("Red", false);
        }

        public static void Info(string code, bool line = true)
        {
            StylesSelector.SetColor("Green", true);
            if (line)
            {
                Console.WriteLine(Messages.info[code]);
            }
            else
            {
                Console.Write(Messages.info[code]);
            }
            StylesSelector.SetColor("Green", false);
        }

        public static void MathOperations(int value, bool line = true)
        {
            StylesSelector.SetColor("Yellow", true);
            if (line)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
            StylesSelector.SetColor("Yellow", false);
        }

        public static void MathOperations(string value, bool line = true)
        {
            StylesSelector.SetColor("Yellow", true);
            if (line)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
            StylesSelector.SetColor("Yellow", false);
        }
    }
}