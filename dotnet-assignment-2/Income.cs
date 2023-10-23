using Microsoft.VisualBasic.ApplicationServices;

namespace _31927_Assignment_2
{
    public class Income : Transaction
    {
        public Income(double nominal, DateTime date, string notes) : base(nominal, date, notes)
        {
            
        }
        public override void SaveToDatabase()
        {
            int id = GenerateID();
            string filePath = "transaction.txt"; // Define the file path where user data is stored
            string content = $"\n{id};{this.Nominal};{this.Date.Year}-{this.Date.Month}-{this.Date.Date};{this.Notes};000000; ;I"; // Create a string containing transaction data to be written to the file
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