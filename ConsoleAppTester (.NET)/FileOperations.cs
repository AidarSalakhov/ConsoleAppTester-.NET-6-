using Newtonsoft.Json;

namespace ConsoleAppTester__.NET_
{
    internal class FileOperations
    {
        public static void SaveTest(string testName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(TestOperations.newTest);
                File.WriteAllText(testName + Constants.SaveFileExtension, json);
            }
            catch (Exception)
            {
                MessagesViewer.Error("ERROR_2_UNABLE_SAVE_TEST");
                Menu.ShowMenu();
            }
        }

        public static List<Question> LoadTest(string testName)
        {
            try
            {
                string json = File.ReadAllText(testName + Constants.SaveFileExtension).ToString();
                return TestOperations.newTest = JsonConvert.DeserializeObject<List<Question>>(json);
            }
            catch (Exception)
            {
                MessagesViewer.Error("ERROR_7_UNABLE_LOAD_TEST");
                Menu.ShowMenu();
                return new List<Question>();
            }
        }

        public static void ViewDirectoryTests()
        {
            List<string> TxtFiles = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = dir.GetFiles("*" + Constants.SaveFileExtension + "*");

            foreach (FileInfo fi in files)
                TxtFiles.Add(fi.ToString());

            if (TxtFiles.Count < 1)
            {
                MessagesViewer.Info("INFO_2_NO_AVIABLE_TESTS");
                Menu.ShowMenu();
            }

            for (int i = 0; i < TxtFiles.Count; i++)
                Console.WriteLine(Path.GetFileNameWithoutExtension(TxtFiles[i]));
        }
    }
}
