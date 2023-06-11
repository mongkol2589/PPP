using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] midScore, finalScore, sumScore;
            string[] studentName;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            studentName = new string[quantityOfStudent];
            midScore = new int[quantityOfStudent];
            finalScore = new int[quantityOfStudent];
            sumScore = new int[quantityOfStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iterator + 1} of {quantityOfStudent}) name : ");
                studentName[iterator] = Console.ReadLine();

                Console.Write($"Please key {studentName[iterator]}'s middle score : ");
                midScore[iterator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {studentName[iterator]}'s final score : ");
                finalScore[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                sumScore[iterator] = midScore[iterator] + finalScore[iterator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int _iterator = 0;

            do
            {
                float gradesScore = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (sumScore[_iterator] <= 49) gradesScore = 0f;
                else if (sumScore[_iterator] <= 54) gradesScore = 1f;
                else if (sumScore[_iterator] <= 59) gradesScore = 1.5f;
                else if (sumScore[_iterator] <= 64) gradesScore = 2f;
                else if (sumScore[_iterator] <= 69) gradesScore = 2.5f;
                else if (sumScore[_iterator] <= 74) gradesScore = 3f;
                else if (sumScore[_iterator] <= 79) gradesScore = 3.5f;
                else if (sumScore[_iterator] >= 80) gradesScore = 4f;

                #endregion

       

                Console.WriteLine($"{_iterator + 1}. {studentName[_iterator]} have a" +
                                $" total {sumScore[_iterator]} score or {gradesScore} grades.");
                _iterator++;
            } while (_iterator < quantityOfStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}