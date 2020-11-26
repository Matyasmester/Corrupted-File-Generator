using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CorruptFileGenerator
{
    public static class Master
    {
        public static void MakeFile(int FileSize, string FullPath)
        {
            string content = GenFileContents(FileSize);

            File.WriteAllText(FullPath, content);
        }

        private static string GenFileContents(int FileSize)
        {
            Random rand = new Random();

            string result = "";

            int val = 0;

            for(int i = 0; i < (FileSize / 100); i++)
            {
                val = rand.Next(1, 255);                                                 // We fill the contents of the file up to its one 100th part,
                result += (char)val;                                                     // copy this several times, then randomly sort it.
            }                                                                            // Almost the same results as manually filling it up in a single loop,
                                                                                         // but much faster and more cost-effective.
            for(int j = 0; j < 6; j++)
            {
                result += result;
            }

            result = new string(result.ToCharArray().OrderBy(s => (rand.Next(2) % 2) == 0).ToArray());

            return result;
        }
    }
}
