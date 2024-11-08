using System;
using System.Text;
using System.Windows.Forms;

namespace q2
{
    public partial class Form1 : Form
    {
        private Random random; // Declare Random object

        public Form1()
        {
            InitializeComponent();
            random = new Random(); // Initialize Random object
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            Output.Text = password; // Ensure Output is defined in your form
        }

        private string GeneratePassword()
        {
            StringBuilder password = new StringBuilder();

            // Ensure required components are included
            password.Append("45");         // Add two digits of registration number
            password.Append("ah");         // Add 'a' and 'h' from name Aali Shan
            password.Append("Robert");      // Add "Robert" from movie ironman 1st character
            password.Append("Leonardo");      // Add "leonardo" from movie the wolf of wallstreet 2nd character

            // Add random special characters (excluding '#')
            char[] specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?/~`".ToCharArray();
            while (password.Length < 14)
            {
                char specialChar;
                do
                {
                    specialChar = specialChars[random.Next(specialChars.Length)];
                } while (specialChar == '#'); // Exclude '#'

                password.Append(specialChar);
            }

            // Shuffle the password
            return Shuffle(password.ToString());
        }

        private string Shuffle(string password)
        {
            char[] array = password.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length);
                // Swap
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return new string(array);
        }
    }
}
