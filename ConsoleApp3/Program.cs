using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] commands = new string[]
            {
                "push Привет! Это снова я! Пока!",
                "pop 5",
                "push Как твои успехи? Плохо?",
                "push qwertyuiop",
                "push 1234567890",
                "pop 26"
            };

            Console.WriteLine(ApplyCommands(commands));
        }

        private static string ApplyCommands(string[] commands)
        {
            var resultStr = new StringBuilder();
            foreach (var command in commands)
            {
                var words = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length > 0)
                {
                    if (words[0] == "push")
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (i == 0)
                                continue;
                            if (i == words.Length - 1)
                            {
                                resultStr.Append(words[i]);
                                continue;
                            }
                                
                            resultStr.Append($"{words[i]} ");
                        }
                    }
                    else if (words[0] == "pop")
                    {
                        var delete_count = Convert.ToInt32(words[1]);
                        if (resultStr.Length > delete_count)
                        {
                            resultStr.Remove(resultStr.Length - delete_count, delete_count);
                        }
                    }
                }
            }
            return resultStr.ToString();
        }

    }
}