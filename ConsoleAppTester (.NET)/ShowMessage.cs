namespace ConsoleAppTester__.NET_
{
    internal class ShowMessage
    {
        public static void Error(string code, bool line = true)
        {
            Styles.SetColor("Red", true);
            if (line)
            {
                Console.WriteLine(Messages.errors[code]);
            }
            else
            {
                Console.Write(Messages.errors[code]);
            }
            Styles.SetColor("Red", false);
        }

        public static void Info(string code, bool line = true)
        {
            Styles.SetColor("Green", true);
            if (line)
            {
                Console.WriteLine(Messages.info[code]);
            }
            else
            {
                Console.Write(Messages.info[code]);
            }
            Styles.SetColor("Green", false);
        }
    }
}