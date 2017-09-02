using System.Text.RegularExpressions;
using static System.Console;

namespace AsciiConsole
{
    public static class Program
    {
        private static void Main() {

            // Loop until finished.
            while (true) {
                // Get input from the user.
                string[] words = Regex.Split(ReadLine(), "\\s+");

                // Loop through each word.
                foreach (string word in words) {

                    // The output string that will represent the current word as a 
                    // matrix of characters and their corresponding ASCII values.
                    string[] outputLine = new string[5];

                    // Loop through each character.
                    foreach (char character in word.ToCharArray()) {

                        // Format the word so that the character and ASCII value are 
                        // placed in separate rows, but in the same column.
                        outputLine[0] += "-----+";
                        outputLine[1] += string.Format("  {0}  |", character);
                        outputLine[2] += "-----+";
                        outputLine[3] += string.Format(" {0,3} |", (byte)character);
                        outputLine[4] += "-----+";
                    }

                    // Display the table.
                    foreach (string line in outputLine) {
                        Write(line + "\n");
                    }
                }

                // Formatting sugar.
                Write("\n\n");
            }
        }
    }
}
