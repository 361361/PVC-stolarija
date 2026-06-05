using System;
using System.Windows.Forms;

namespace PVC_stolarija
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            TabPage tabPorudzbine = new TabPage("Porudžbine");
            PorudzbineForm porudzbineForm = new PorudzbineForm();
            porudzbineForm.TopLevel = false;
            porudzbineForm.FormBorderStyle = FormBorderStyle.None;
            porudzbineForm.Dock = DockStyle.Fill;
            tabPorudzbine.Controls.Add(porudzbineForm);
            porudzbineForm.Show();

            TabPage tabDodaj = new TabPage("Dodaj porudžbinu");
            DodajPorudzbinuForm dodajForm = new DodajPorudzbinuForm();
            dodajForm.TopLevel = false;
            dodajForm.FormBorderStyle = FormBorderStyle.None;
            dodajForm.Dock = DockStyle.Fill;
            tabDodaj.Controls.Add(dodajForm);
            dodajForm.Show();

            tabControl.TabPages.Add(tabPorudzbine);
            tabControl.TabPages.Add(tabDodaj);

            this.Controls.Add(tabControl);
        }
    }
}
