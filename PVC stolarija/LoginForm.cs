using System;
using System.Windows.Forms;

namespace PVC_stolarija
{
    public partial class LoginForm : Form
    {

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Uspešno ste se prijavili kao administrator!");
                MainForm adminForm = new MainForm();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "korisnik" && password == "korisnik")
            {
                MessageBox.Show("Uspešno ste se prijavili kao korisnik!");
                MainForm userForm = new MainForm();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
            }
        }

        private List<Korisnik> KreirajDemoKorisnike()
        {
            var admin = new Uloga { IdUloge = 1, NazivUloge = "Administrator" };
            var prodavac = new Uloga { IdUloge = 2, NazivUloge = "Prodavac" };

            return new List<Korisnik>
            {
        new Korisnik { IdKorisnika = 1, KorisnickoIme = "admin", Lozinka = "123", Uloga = admin },
        new Korisnik { IdKorisnika = 2, KorisnickoIme = "marko", Lozinka = "111", Uloga = prodavac }
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // ništa ne radi — samo sprečava grešku
        }

        public LoginForm()
        {
            InitializeComponent();
        }

    }
}
