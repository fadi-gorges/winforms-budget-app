using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _31927_Assignment_2
{
    public abstract class Transaction
    {
        private int id;
        private double nominal;
        private DateTime date;
        private string notes;
        
        public Transaction(double nominal, DateTime date, string notes)
        {
            this.nominal = nominal;
            this.date = date;
            this.notes = notes;
        }
        public abstract void SaveToDatabase();
        public int GenerateID()
        {
            Random random = new Random();
            int randomNumber;
            do
                randomNumber = random.Next(10000000, 100000000);
            while (IDExists(randomNumber + ""));
            return randomNumber;
        }
        // Check if a user ID already exists
        private bool IDExists(string id)
        {
            try
            {
                string[] data = File.ReadAllLines("transaction.txt"); // Read all lines from the user database file
                try
                {
                    foreach (string temp in data) // Iterate through each line in the file
                    {
                        string[] x = temp.Split(';'); // Split the line into fields using ';' as the separator
                        if (x[0] == id) // Check if the first field (ID) matches the provided ID
                            return true;
                    }
                    return false; // If no matching ID is found, return false
                }
                catch (IndexOutOfRangeException)
                {
                    return false; // Indicate an issue, as the database format is incorrect
                }
            }
            catch (FileNotFoundException)
            {
                return false; // Indicate an issue, as the database file is missing
            }
        }
        public int Id { get => id; set => id = value; }
        public double Nominal { get => nominal; set => nominal = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
