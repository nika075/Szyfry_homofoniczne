namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        char[,] homophones = new char[26, 3];
        char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J','K','L','M',
        'N','O','P','Q','R','S','T','U','V','W','X','Y','Z' };
        List<char> allPossibleHomophones= new List<char>();
        String oldText = String.Empty;
        bool encryption = false;

        public Form1()
        {
            InitializeComponent();
            cbVersion.SelectedIndex = 0; 
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            encrypt();
            encryption = true;
            
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            if (encryption == true)
            {
                decrypt();
            }
            
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String version = cbVersion.Text;
            
            switch (version) {
                case "wersja 1":
                    theInitializationArrayOfHomophones_v1();
                    break;
                case "wersja 2":
                    theInitializationArrayOfHomophones_v2();
                    break;
            
            }
            encryption = false;
       
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            if (tbMessage.Text.All(characterFromTheMessage => char.IsLetter(characterFromTheMessage)))
            {
                oldText = tbMessage.Text;
                tbMessage.Text = oldText;

                tbMessage.BackColor = Color.White;
                tbMessage.ForeColor = Color.Black;
            }
            else
            {
                tbMessage.Text = oldText;
                tbMessage.BackColor = Color.Red;
                tbMessage.ForeColor = Color.White;
                MessageBox.Show("Akceptowalne sa tylko litery.");
            }
            tbMessage.SelectionStart = tbMessage.Text.Length;
        }

        private void theInitializationArrayOfHomophones_v1()
        {
            for (int i = 0; i < 26; i++)
            {
                homophones[i, 0] = (char)(33 + i);
                for (int j = 1; j < 3; j++)
                {
                    homophones[i, j] = (char)(33 + i + j * 26);
                }

            }
        }

        private void theInitializationArrayOfHomophones_v2()
        {
            listOfHomophones();
            int randIndex= 0;
            Random rand = new Random();
            int rands = allPossibleHomophones.ToArray().Length;
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    randIndex = rand.Next(rands);
                    homophones[i, j] = allPossibleHomophones[randIndex];
                    allPossibleHomophones.Remove(allPossibleHomophones[randIndex]);
                    rands--;
                }

            }

        }

        private void listOfHomophones()
        {
            for (int i = 33; i < 126; i++)
            {
                allPossibleHomophones.Add((char)i);
            }
        }

        private void encrypt() {
            tbEncryptedMessage.Text = "";
            int randIndex = 0;
            Random rand = new Random();
            foreach (char singleCharacter in tbMessage.Text)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (singleCharacter.Equals(alphabet[i]))
                    {
                        randIndex = rand.Next(3);
                        tbEncryptedMessage.Text += homophones[i, randIndex];
                    }
                }
            }
        }

        private void decrypt() {
            tbDecryptedMessage.Text = "";
            foreach (char singleCharacter in tbEncryptedMessage.Text)
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (singleCharacter.Equals(homophones[i, j]))
                        {
                            tbDecryptedMessage.Text += alphabet[i];
                        }
                    }

                }
            }
        }
    }
}