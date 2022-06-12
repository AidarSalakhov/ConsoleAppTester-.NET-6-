﻿namespace ConsoleAppTester__.NET_
{
    internal class Messages
    {
        public static Dictionary<int, string> errors = new Dictionary<int, string>
        {
            { 0 , "[Ошибка 000] Вы нажали неверную клавишу!\n"},
            { 1 , "[Ошибка 001] Введённого вами теста не существует!\n"},
            { 2 , "[Ошибка 002] Не удалось сохранить тест!\n"},
            { 3 , "[Ошибка 003] Вы ввели номер несуществующего ответа, либо некорректный символ. Ваш ответ засчитан как неверный!\n"},
            { 4 , "[Ошибка 004] На Шаге 2 введите целое число!\n"},
            { 5 , "[Ошибка 005] На Шаге 3 введите целое число, большее чем 1!\n"},
            { 6 , "[Ошибка 006] На Шаге 6 введите целое число, не большее чем количество ответов!\n"},
            { 7 , "[Ошибка 007] Не удалось загрузить тест!\n"},
            { 8 , "[Ошибка 008] Вы ввели пустую строку!\n"},
        };

        public static Dictionary<int, string> info = new Dictionary<int, string>
        {
            { 0 , $"\t|  {Constants.ProgramName} v.2.0  |\n\t|----Выберите действие-----|\n\t|[S] - Пройти тест         |\n\t|[N] - Создать тест        |\n\t|[Esc] - Выйти из программы|\n"},
            { 1 , "Тест сохранён в файл.\n"},
            { 2 , "Нет доступных тестов для прохождения. Создайте новый.\n"},
            { 3 , "\nВведите название теста для его прохождения:"},
            { 4 , $"---Тест успешно загружен и начался в {DateTime.Now}---\n\nВопросы:"},
            { 5 , "Доступные тесты:"},
            { 6 , "Варианты ответов:"},
            { 7 , "\nВведите номер правильного ответа:"},
            { 8 , $"---Тест завершён в {DateTime.Now}---\n\nПроцент правильных ответов: " },
            { 9 , "/Конструктор теста. Шаг 1 из 6/ Введите название теста:"},
            { 10 , "\n/Конструктор теста. Шаг 2 из 6/ Введите количество вопросов теста:"},
            { 11 , "\n/Конструктор теста. Шаг 3 из 6/ Введите количество вариантов ответов вопроса (не менее 2):"},
            { 12 , "/Конструктор теста. Шаг 4 из 6/ Введите вопрос теста #"},
            { 13 , "\n/Конструктор теста. Шаг 5 из 6/ Введите вариант ответа №"},
            { 14 , "\n/Конструктор теста. Шаг 6 из 6/ Введите номер правильного ответа:"}
        };
    }
}
