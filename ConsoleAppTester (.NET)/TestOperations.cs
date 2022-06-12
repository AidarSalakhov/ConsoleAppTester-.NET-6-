namespace ConsoleAppTester__.NET_
{
    internal class TestOperations
    {
        public static List<Question> newTest = new List<Question>();

        public static Question question = new Question();

        public static void StartTest()
        {
            ShowMessage.Info("INFO_5_AVAIABLE_TESTS");
            FileOperations.ViewDirectoryTests();
            ShowMessage.Info("INFO_3_ENTER_TEST_NAME");
            string testName = Console.ReadLine();
            FileOperations.LoadTest(testName);
            Console.Clear();
            ShowMessage.Info("INFO_4_TEST_LOADED");
            int userRightAnswers = 0;

            for (int i = 0; i < newTest.Count; i++)
            {
                Console.WriteLine($"\n{newTest[i].question}");
                ShowMessage.Info("INFO_6_QUESTION_ANSWERS");

                for (int j = 0; j < newTest[i].questionAnswers.Length; j++)
                    Console.Write($"{j + 1}) {newTest[i].questionAnswers[j]}\t");

                ShowMessage.Info("INFO_7_ENTER_RIGHT_ANSWER");

                if (!double.TryParse(Console.ReadLine(), out double userAnswer) || userAnswer > newTest[i].questionAnswers.Length || 1 > userAnswer)
                    ShowMessage.Error("ERROR_3_ANSWER_DOSENT_EXIST_OR_WRONG_SYMBOL");

                if (userAnswer == newTest[i].questionRightAnswer)
                    userRightAnswers++;
            }

            Console.Clear();
            ShowMessage.Info("INFO_8_TEST_COMPLETED_SHOW_PERCENT_OF_RIGHT_ANSWERS", false);
            Console.WriteLine(Math.Round((double)(userRightAnswers / Convert.ToDouble(newTest.Count) * 100)) + "%\n");
            newTest.Clear();
            Menu.ShowMenu();
        }

        public static void CreateNewTest()
        {
            newTest.Clear();
            ShowMessage.Info("INFO_9_TEST_CONSTRUCTOR_STEP_1_OF_6_ENTER_NAME_OF_TEST");
            string testName = Console.ReadLine();
            if (testName == "")
            {
                Console.Clear();
                ShowMessage.Error("ERROR_8_EMPTY_STRING");
                CreateNewTest();
            }

            ShowMessage.Info("INFO_10_TEST_CONSTRUCTOR_STEP_2_OF_6_ENTER_QUESTIONS_COUNT");
            if (!int.TryParse(Console.ReadLine(), out int testQuestionsCount))
            {
                Console.Clear();
                ShowMessage.Error("ERROR_5_WRONG_SYMBOL_OR_VALUE");
                CreateNewTest();
            }

            ShowMessage.Info("INFO_11_TEST_CONSTRUCTOR_STEP_3_OF_6_ENTER_ANSWERS_COUNT");
            if (!int.TryParse(Console.ReadLine(), out int questionAnswersCount) || questionAnswersCount < 2)
            {
                Console.Clear();
                ShowMessage.Error("ERROR_6_WRONG_SYMBOL_OR_VALUE");
                CreateNewTest();
            }

            for (int i = 0; i < testQuestionsCount; i++)
            {
                Console.Clear();
                ShowMessage.Info("INFO_12_TEST_CONSTRUCTOR_STEP_4_OF_6_ENTER_TEST_QUESTION", false);
                Console.WriteLine(i + 1);
                question.question = Console.ReadLine();

                if (question.question == "")
                {
                    Console.Clear();
                    ShowMessage.Error("ERROR_8_EMPTY_STRING");
                    CreateNewTest();
                }

                question.questionAnswers = new string[questionAnswersCount];

                for (int j = 0; j < questionAnswersCount; j++)
                {
                    ShowMessage.Info("INFO_13_TEST_CONSTRUCTOR_STEP_5_OF_6_ENTER_ANSWERS", false);
                    Console.WriteLine(j + 1);
                    question.questionAnswers[j] = Console.ReadLine();

                    if (question.questionAnswers[j] == "")
                    {
                        Console.Clear();
                        ShowMessage.Error("ERROR_8_EMPTY_STRING");
                        CreateNewTest();
                    }
                }

                ShowMessage.Info("INFO_14_TEST_CONSTRUCTOR_STEP_6_OF_6_ENTER_RIGHT_ANSWER");
                if (!int.TryParse(Console.ReadLine(), out question.questionRightAnswer) || question.questionRightAnswer > questionAnswersCount || question.questionRightAnswer < 1)
                {
                    Console.Clear();
                    ShowMessage.Error("ERROR_6_WRONG_SYMBOL_OR_VALUE");
                    CreateNewTest();
                }

                newTest.Add(question);
            }

            FileOperations.SaveTest(testName);
            Console.Clear();
            ShowMessage.Info("INFO_1_TEST_SAVED");
            Menu.ShowMenu();
        }
    }
}
