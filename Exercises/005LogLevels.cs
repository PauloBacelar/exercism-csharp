namespace Exercism.Exercises {
    class LogLine {
        public static string Message(string message) {
            return message.Split("]: ")[1].Trim();
        }

        public static string LogLevel(string message) {
            return message.Split("]: ")[0].Replace("[", "").ToLower();
        }

        public static string Reformat(string message) {
            return $"{Message(message)} ({LogLevel(message)})";
        }

        public static void Executar() {
            Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation\r\n"));
            Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation\r\n"));
            Console.WriteLine(LogLine.Reformat("[ERROR]: Invalid operation\r\n"));
        }
    }
}
