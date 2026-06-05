using System;
using System.Windows.Forms;

namespace PVC_stolarija
{
    public partial class DodajPorudzbinuForm : Form
    {
        private readonly Porudzbina _porudzbina;

        public DodajPorudzbinuForm()
        {
            InitializeComponent();
            _porudzbina = new Porudzbina();
        }

        public DodajPorudzbinuForm(int id)
        {
            InitializeComponent();
            _porudzbina = Porudzbina.Ucitaj(id);
            PopuniPolja();
        }

        private void PopuniPolja()
        {
            txtKupac.Text     = _porudzbina.Kupac;
            dtpDatum.Value    = _porudzbina.DatumPorudzbine;
            txtVrsta.Text     = _porudzbina.VrstaProzora;
            txtDimenzije.Text = _porudzbina.Dimenzije;
            txtCena.Text      = _porudzbina.Cena.ToString();
            cmbStatus.Text    = _porudzbina.Status;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKupac.Text) ||
                string.IsNullOrWhiteSpace(txtVrsta.Text) ||
                !decimal.TryParse(txtCena.Text, out decimal cena) || cena <= 0)
            {
                MessageBox.Show("Molimo popunite sva obavezna polja (Kupac, Vrsta, Cena).");
                return;
            }

            _porudzbina.Kupac           = txtKupac.Text;
            _porudzbina.DatumPorudzbine = dtpDatum.Value;
            _porudzbina.VrstaProzora    = txtVrsta.Text;
            _porudzbina.Dimenzije       = txtDimenzije.Text;
            _porudzbina.Cena            = cena;
            _porudzbina.Status          = cmbStatus.Text;

            _porudzbina.Sacuvaj();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DodajPorudzbinuForm_Load(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
