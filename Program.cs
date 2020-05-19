using System;
using System.IO;
using System.Collections;
namespace Question_5_EX_1
{
    class Question_5_Ex_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the File Path to be Read as File 1: ");
        //Path should be give like .....   C:\Users\ehza5669\source\repos\Question_5_Ex_1\file_1.txt
            string nameFile1 = Console.ReadLine();

        // Path should be give like .....  C:\Users\ehza5669\source\repos\Question_5_Ex_1\file_2.txt
            Console.Write("Enter the File Path to be Read as File 2:");
            string nameFile2 = Console.ReadLine();

            if ((!File.Exists(nameFile1)) ||
                 (!File.Exists(nameFile2)))
            {
                Console.Write("File 1 or File 2 not exists");
                return;
            }

            try
            {
                StreamReader myfile = File.OpenText(nameFile1);

                ArrayList list = new ArrayList();

                string line;
                do
                {
                    line = myfile.ReadLine();
                    if (line != null)
                        list.Add(line);
                }

                while (line != null);
                myfile.Close();

                myfile = File.OpenText(nameFile2);

                line = "";

                do
                {
                    line = myfile.ReadLine();
                    if (line != null)
                        list.Add(line);
                }

                while (line != null);
                myfile.Close();

                list.Sort();

                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine(list[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ! Trying to open the file");
            }
        }
    }
}