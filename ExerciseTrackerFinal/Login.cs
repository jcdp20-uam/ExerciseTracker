using System.Security.Cryptography;

namespace ExerciseTracker
{
    public partial class Login : Form
    {

        public HashSet<(String,String)>  logins = new HashSet<(String, String)> { ("Julio", "JulioPass123") };
        public Main main = new Main();

        public Login()
        {
            InitializeComponent();
        }

        private void submitLogin_Click(object sender, EventArgs e)
        {
            (String, String) loginCredentials = (userTextBox.Text, passwordTextBox.Text);

            if (this.logins.Contains(loginCredentials)) {
                this.Hide();
                main.Show();
                return;
            }

            MessageBox.Show("Credenciales Invalidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

     
    }
}
