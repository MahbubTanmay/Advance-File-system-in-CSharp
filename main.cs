using System;
using System.Globalization;
using System.IO; //must added for file operation

namespace CSharp_Learning
{

    internal class MyClass
    {


        static void Main()
        {

            string filePath = "Players_Name.txt";

            string[] PlayerName = { "Player1", "Player2", "Player3", "Player4" };
            int[] PlayerLevel = { 2,3,6,8 };
            

              // Convert integer array to string array
            string[] PlayerLevelString = Array.ConvertAll(PlayerLevel, lvl => lvl.ToString());

            // Combine both arrays
            string[] PlayerData  = new string[PlayerName.Length + PlayerLevelString.Length]; //Define the size of array
        PlayerName.CopyTo(PlayerData, 0); // Copy PlayerName into PlayerData from position 0
        PlayerLevelString.CopyTo(PlayerData, PlayerName.Length); // Copy PlayerLevelString into PlayerData after PlayerName 




        


            if (!File.Exists(filePath)) //Check if file exist
            {
                //If Not exist
                Console.WriteLine("File does not exist. Creating now...");
                File.Create(filePath).Close();


            }
            else
            {
                //If exist 
                Console.WriteLine("Restored From Previous File");

            }

           
            File.WriteAllLines(filePath, PlayerData);
            Console.WriteLine("Saved to file.");






            string[] nameRestore;
            string[] Data;
            int[] levelRestore;

            Data = File.ReadAllLines(filePath);//restore data from file

// Initialize the arrays with the correct size
nameRestore = new string[Data.Length / 2];
levelRestore = new int[Data.Length / 2];

            for (int i = 0; i < Data.Length / 2; i++) //copy data
            {

                nameRestore[i] = Data[i];
                levelRestore[i] = Convert.ToInt32(Data[(Data.Length / 2)+i]);


            }


            Console.WriteLine($"Total Player: {Data.Length / 2}");


            for (int j = 0; j < Data.Length / 2; j++)
            {
                Console.WriteLine($"Player Name: {nameRestore[j]} and Player Level: {levelRestore[j]}");
            }
            









        }


    }





}
