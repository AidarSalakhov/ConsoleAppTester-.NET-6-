namespace ConsoleAppTester__.NET_
{
    internal class Messages
    {
        public static Dictionary<string, string> errors = new Dictionary<string, string>
        {
            { "ERROR_0_WRONG_KEY" , "[Ошибка 000] Вы нажали неверную клавишу!\n"},
            { "ERROR_1_TEST_DOSENT_EXIST" , "[Ошибка 001] Введённого вами теста не существует!\n"},
            { "ERROR_2_UNABLE_SAVE_TEST" , "[Ошибка 002] Не удалось сохранить тест!\n"},
            { "ERROR_3_ANSWER_DOSENT_EXIST_OR_WRONG_SYMBOL" , "[Ошибка 003] Вы ввели номер несуществующего ответа, либо некорректный символ. Ваш ответ засчитан как неверный!\n"},
            { "ERROR_4_WRONG_SYMBOL" , "[Ошибка 004] На Шаге 2 введите целое число!\n"},
            { "ERROR_5_WRONG_SYMBOL_OR_VALUE" , "[Ошибка 005] На Шаге 3 введите целое число, большее чем 1!\n"},
            { "ERROR_6_WRONG_SYMBOL_OR_VALUE" , "[Ошибка 006] На Шаге 6 введите целое число, не большее чем количество ответов!\n"},
            { "ERROR_7_UNABLE_LOAD_TEST" , "[Ошибка 007] Не удалось загрузить тест!\n"},
            { "ERROR_8_EMPTY_STRING" , "[Ошибка 008] Вы ввели пустую строку!\n"},
        };

        public static Dictionary<string, string> info = new Dictionary<string, string>
        {
            { "INFO_0_SELECT_TEST_OPERATION" , $"\t|  {Constants.ProgramName} v.2.0  |\n\t|----Выберите действие-----|\n\t|[S] - Пройти тест         |\n\t|[N] - Создать тест        |\n\t|[Esc] - Выйти из программы|\n"},
            { "INFO_1_TEST_SAVED" , "Тест сохранён в файл.\n"},
            { "INFO_2_NO_AVIABLE_TESTS" , "Нет доступных тестов для прохождения. Создайте новый.\n"},
            { "INFO_3_ENTER_TEST_NAME" , "\nВведите название теста для его прохождения:"},
            { "INFO_4_TEST_LOADED" , $"---Тест успешно загружен и начался в {DateTime.Now}---\n\nВопросы:"},
            { "INFO_5_AVAIABLE_TESTS" , "Доступные тесты:"},
            { "INFO_6_QUESTION_ANSWERS" , "Варианты ответов:"},
            { "INFO_7_ENTER_RIGHT_ANSWER" , "\nВведите номер правильного ответа:"},
            { "INFO_8_TEST_COMPLETED_SHOW_PERCENT_OF_RIGHT_ANSWERS" , $"---Тест завершён в {DateTime.Now}---\n\nПроцент правильных ответов: " },
            { "INFO_9_TEST_CONSTRUCTOR_STEP_1_OF_6_ENTER_NAME_OF_TEST" , "/Конструктор теста. Шаг 1 из 6/ Введите название теста:"},
            { "INFO_10_TEST_CONSTRUCTOR_STEP_2_OF_6_ENTER_QUESTIONS_COUNT" , "\n/Конструктор теста. Шаг 2 из 6/ Введите количество вопросов теста:"},
            { "INFO_11_TEST_CONSTRUCTOR_STEP_3_OF_6_ENTER_ANSWERS_COUNT" , "\n/Конструктор теста. Шаг 3 из 6/ Введите количество вариантов ответов вопроса (не менее 2):"},
            { "INFO_12_TEST_CONSTRUCTOR_STEP_4_OF_6_ENTER_TEST_QUESTION" , "/Конструктор теста. Шаг 4 из 6/ Введите вопрос теста #"},
            { "INFO_13_TEST_CONSTRUCTOR_STEP_5_OF_6_ENTER_ANSWERS" , "\n/Конструктор теста. Шаг 5 из 6/ Введите вариант ответа №"},
            { "INFO_14_TEST_CONSTRUCTOR_STEP_6_OF_6_ENTER_RIGHT_ANSWER" , "\n/Конструктор теста. Шаг 6 из 6/ Введите номер правильного ответа:"}
        };
    }
}
