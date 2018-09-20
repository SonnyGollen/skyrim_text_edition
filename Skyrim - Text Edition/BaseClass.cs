using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyrim___Text_Edition
{
    class BaseClass
    {
        //Wraps words for the Console. Taken from Stackoverflow (20534318)
        public static void Text(string paragraph, int tabSize = 8)
        {
            string[] lines = paragraph
                .Replace("\t", new String(' ', tabSize))
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string process = lines[i];
                List<String> wrapped = new List<string>();

                while (process.Length > Console.WindowWidth)
                {
                    int wrapAt = process.LastIndexOf(' ', Math.Min(Console.WindowWidth - 1, process.Length));
                    if (wrapAt <= 0) break;

                    wrapped.Add(process.Substring(0, wrapAt));
                    process = process.Remove(0, wrapAt + 1);
                }

                foreach (string wrap in wrapped)
                {
                    Console.WriteLine(wrap);
                }

                Console.WriteLine(process);
            }
            Console.ReadLine();
        }

        public static void PlayerInput(string paragraph, int noOfQuestions, int tabSize = 8)
        {
            int x = 0;
            while (x == 0)
            {
                string[] lines = paragraph
                    .Replace("\t", new String(' ', tabSize))
                    .Split(new string[] {Environment.NewLine}, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {
                    string process = lines[i];
                    List<String> wrapped = new List<string>();

                    while (process.Length > Console.WindowWidth)
                    {
                        int wrapAt = process.LastIndexOf(' ', Math.Min(Console.WindowWidth - 1, process.Length));
                        if (wrapAt <= 0) break;

                        wrapped.Add(process.Substring(0, wrapAt));
                        process = process.Remove(0, wrapAt + 1);
                    }

                    foreach (string wrap in wrapped)
                    {
                        Console.WriteLine(wrap);
                    }

                    Console.WriteLine(process);
                }

                ///////////////////////////////////////////////

                string playerInput = Console.ReadLine();
                int playerInputCovertedToInt = 0;

                switch (playerInput)
                {
                    case "1":
                        playerInputCovertedToInt = Convert.ToInt32(playerInput);
                        break;
                    case "2":
                        playerInputCovertedToInt = Convert.ToInt32(playerInput);
                        break;
                    case "3":
                        playerInputCovertedToInt = Convert.ToInt32(playerInput);
                        break;
                    case "4":
                        playerInputCovertedToInt = Convert.ToInt32(playerInput);
                        break;
                }

                if (playerInputCovertedToInt > 0 && playerInputCovertedToInt <= noOfQuestions)
                {
                    Console.WriteLine("Answer: " + playerInputCovertedToInt);
                    Console.ReadLine();
                    x = 1;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    Console.ReadLine();
                }
            }
        }

            //string noOfQuestionsString = Convert.ToString(noOfQuestions);



            //Console.WriteLine(noOfQuestionsString);
    }
}
