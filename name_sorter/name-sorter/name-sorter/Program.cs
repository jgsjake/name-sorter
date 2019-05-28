using System;

namespace name_sorter
{
    class Program
    {
        ///////////////////////////////////////////////////////////////
        ////                     Main Function                     ////
        ///////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            // File containing unsorted names
            string txtFile = @"C:\Users\admin\desktop\names.txt";
            // Initialize array of names
            string[] nameArray = getNamesFromTxtFile(txtFile);

            Console.WriteLine("  -- Name Sorting Application --  ");

            // Output raw data from txt file
            Console.WriteLine("\n\n" + "\t" + "List of unsorted names" + "\n");
            printNamesToConsole(nameArray);

            // Sort the name array in alphabetical order
            // Overwrite name array with sorted data
            nameArray = alphabetize(nameArray);

            // Output alphabetized data
            Console.WriteLine("\n\n" + "\t" + "List of sorted names" + "\n");
            printNamesToConsole(nameArray);

            // Save sorted name list to txt file
            saveSortedNames(nameArray);
        }

        ////                Get names from txt file                ////
        private static string[] getNamesFromTxtFile(string fileName)
        {
            // Read each line of the txt file
            // Append each line of the file to the string array
            string[] names = System.IO.File.ReadAllLines(fileName);

            // Return array to the main function
            return names;
        }

        ////                 Print array to console                ////
        static void printNamesToConsole(string[] names)
        {
            // Print every string in the names array
            foreach (string name in names)
            {
                // Print name
                Console.WriteLine("\t" + "Name: " + name);
            }
        }

        ////               Alphabetise the names array             ////
        private static string[] alphabetize(string[] names)
        {
            // Sort the string array
            Array.Sort<string>(names);

            // Retrun the sorted array to the main function
            return names;
        }

        ////            Save sorted name list to txt file          ////
        static void saveSortedNames(string[] names)
        {
            // Initialize destination file for the alphabetized list
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\admin\desktop\sorted-names-list.txt"))
            {
                // Write each string in the array to the txt file
                foreach (string name in names)
                {
                    // Write name
                    file.WriteLine(name);
                }
            }
        }
    }
}
