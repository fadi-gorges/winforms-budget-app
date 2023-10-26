using Microsoft.VisualBasic.ApplicationServices;

namespace dotnet_assignment_2.Models
{
    public class Income : Transaction
    {
        public Income() { }
        public Income(double nominal, DateTime date, string notes, User user) : base(nominal, date, notes, user)
        {

        }
        public void SaveToDatabase()
        {
            int id = GenerateID();
            string filePath = "transaction.txt"; // Define the file path where user data is stored
            string content = $"\n{id};{Nominal};{Date.Year}-{Date.Month}-{Date.Date};{Notes};000000; ;I"; // Create a string containing transaction data to be written to the file
            if (File.Exists(filePath)) // If the file exists, append the user data to it
            {
                File.AppendAllText(filePath, content);
            }
            else // If the file doesn't exist, create it and write the user data
            {
                File.WriteAllText(filePath, content);
            }
        }
    }

}