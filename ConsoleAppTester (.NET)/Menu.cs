using System.Diagnostics;

namespace ConsoleAppTester__.NET_
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            MessagesViewer.Info("INFO_0_SELECT_TEST_OPERATION");

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.S:
                    Console.Clear();
                    TestOperations.StartTest();
                    break;

                case ConsoleKey.N:
                    Console.Clear();
                    TestOperations.CreateNewTest();
                    break;

                case ConsoleKey.Escape:
                    Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    MessagesViewer.Error("ERROR_0_WRONG_KEY");
                    ShowMenu();
                    break;
            }
        }
    }
}
