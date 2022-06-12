namespace ConsoleAppTester__.NET_
{
    internal class TestOperations
    {
        public static List<Question> newTest = new List<Question>();

        public static Question question = new Question();

        public static void StartTest()
        {
            ShowMessage.Info(5);
            FileOperations.ViewDirectoryTests();
            ShowMessage.Info(3);
            string testName = Console.ReadLine();
            FileOperations.LoadTest(testName);
            Console.Clear();
            ShowMessage.Info(4);
            int userRightAnswers = 0;

            for (int i = 0; i < newTest.Count; i++)
            {
                Console.WriteLine($"\n{newTest[i].question}");
                ShowMessage.Info(6);

                for (int j = 0; j < newTest[i].questionAnswers.Length; j++)
                    Console.Write($"{j + 1}) {newTest[i].questionAnswers[j]}\t");

                ShowMessage.Info(7);

                if (!double.TryParse(Console.ReadLine(), out double userAnswer) || userAnswer > newTest[i].questionAnswers.Length || 1 > userAnswer)
                    ShowMessage.Error(3);

                if (userAnswer == newTest[i].questionRightAnswer)
                    userRightAnswers++;
            }

            Console.Clear();
            ShowMessage.Info(8, false);
            Console.WriteLine(Math.Round((double)(userRightAnswers / Convert.ToDouble(newTest.Count) * 100)) + "%\n");
            newTest.Clear();
            Menu.ShowMenu();
        }

        public static void CreateNewTest()
        {
            newTest.Clear();
            ShowMessage.Info(9);
            string testName = Console.ReadLine();
            if (testName == "")
            {
                Console.Clear();
                ShowMessage.Error(8);
                CreateNewTest();
            }

            ShowMessage.Info(10);
            if (!int.TryParse(Console.ReadLine(), out int testQuestionsCount))
            {
                Console.Clear();
                ShowMessage.Error(5);
                CreateNewTest();
            }

            ShowMessage.Info(11);
            if (!int.TryParse(Console.ReadLine(), out int questionAnswersCount) || questionAnswersCount < 2)
            {
                Console.Clear();
                ShowMessage.Error(6);
                CreateNewTest();
            }

            for (int i = 0; i < testQuestionsCount; i++)
            {
                Console.Clear();
                ShowMessage.Info(12, false);
                Console.WriteLine(i + 1);
                question.question = Console.ReadLine();

                if (question.question == "")
                {
                    Console.Clear();
                    ShowMessage.Error(8);
                    CreateNewTest();
                }

                question.questionAnswers = new string[questionAnswersCount];

                for (int j = 0; j < questionAnswersCount; j++)
                {
                    ShowMessage.Info(13, false);
                    Console.WriteLine(j + 1);
                    question.questionAnswers[j] = Console.ReadLine();

                    if (question.questionAnswers[j] == "")
                    {
                        Console.Clear();
                        ShowMessage.Error(8);
                        CreateNewTest();
                    }
                }

                ShowMessage.Info(14);
                if (!int.TryParse(Console.ReadLine(), out question.questionRightAnswer) || question.questionRightAnswer > questionAnswersCount || question.questionRightAnswer < 1)
                {
                    Console.Clear();
                    ShowMessage.Error(6);
                    CreateNewTest();
                }

                newTest.Add(question);
            }

            FileOperations.SaveTest(testName);
            Console.Clear();
            ShowMessage.Info(1);
            Menu.ShowMenu();
        }
    }
}
