using System.Text.RegularExpressions;

namespace Exercism.Exercises {
    public static class Identifier {
        public static string clearSpaces(string str) {
            return str.Replace(" ", "_").Replace("\0", "CTRL");
        }

        public static string clearNonLetters(string str) {
            return Regex.Replace(str, "[^\\p{L}_-]", "");
        }

        public static string clearGreekLetters(string str) {
            return Regex.Replace(str, "[\u03B1-\u03C9]", "");
        }

        public static string Clean(string str) {
            // No filtering if message is char or empty
            if (str.Length <= 1) {
                return str;
            }

            // Removing spaces and \0
            string strNoSpaces = clearSpaces(str);

            // Removing non-letters, except for underscores
            string strOnlyLetters = clearNonLetters(strNoSpaces);

            // Removing greek lowercase letters
            string strNoGreekLetters = clearGreekLetters(strOnlyLetters);

            if (!strNoGreekLetters.Contains('-')) {
                return strNoGreekLetters;
            }

            // Convert from kebab-case to camelCase
            string[] splitMessage = strNoGreekLetters.Split('-');
            string messageCamelCased = "";

            for (int i = 0; i < splitMessage.Length; i++) {
                if (i == 0) {
                    messageCamelCased += char.ToLower(splitMessage[i][0]) + splitMessage[i].Substring(1);
                } else {
                    messageCamelCased += char.ToUpper(splitMessage[i][0]) + splitMessage[i].Substring(1);
                }
            }

            return messageCamelCased;
        }

        public static void Executar() {
            Console.WriteLine(Identifier.Clean("my   Id"));
            Console.WriteLine(Identifier.Clean("my\0Id"));
            Console.WriteLine(Identifier.Clean("à-ḃç"));
            Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
            Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
            Console.WriteLine(Identifier.Clean("9 -abcĐ😀ω\0"));
        }
    }
}
