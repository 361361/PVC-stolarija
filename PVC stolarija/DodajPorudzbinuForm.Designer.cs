namespace PVC_stolarija
{
    partial class DodajPorudzbinuForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtKupac;
        private DateTimePicker dtpDatum;
        private TextBox txtVrsta;
        private TextBox txtDimenzije;
        private TextBox txtCena;
        private ComboBox cmbStatus;
        private Button btnSacuvaj;
        private Button btnOtkazi;

        private void InitializeComponent()
        {
            txtKupac = new TextBox();
            dtpDatum = new DateTimePicker();
            txtVrsta = new TextBox();
            txtDimenzije = new TextBox();
            txtCena = new TextBox();
            cmbStatus = new ComboBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            SuspendLayout();
            // 
            // txtKupac
            // 
            txtKupac.Location = new Point(21, 82);
            txtKupac.Name = "txtKupac";
            txtKupac.PlaceholderText = "Ime Kupca";
            txtKupac.Size = new Size(100, 23);
            txtKupac.TabIndex = 0;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(21, 227);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(200, 23);
            dtpDatum.TabIndex = 1;
            // 
            // txtVrsta
            // 
            txtVrsta.Location = new Point(21, 111);
            txtVrsta.Name = "txtVrsta";
            txtVrsta.PlaceholderText = "Vrsta";
            txtVrsta.Size = new Size(100, 23);
            txtVrsta.TabIndex = 2;
            // 
            // txtDimenzije
            // 
            txtDimenzije.Location = new Point(21, 140);
            txtDimenzije.Name = "txtDimenzije";
            txtDimenzije.PlaceholderText = "Dimenzije";
            txtDimenzije.Size = new Size(100, 23);
            txtDimenzije.TabIndex = 3;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(21, 169);
            txtCena.Name = "txtCena";
            txtCena.PlaceholderText = "Cena";
            txtCena.Size = new Size(100, 23);
            txtCena.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.Items.AddRange(new object[] { "Zakazan", "U izradi", "Gotov" });
            cmbStatus.Location = new Point(21, 198);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 5;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(683, 437);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(75, 23);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(21, 437);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(75, 23);
            btnOtkazi.TabIndex = 7;
            btnOtkazi.Text = "Otkazi";
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // DodajPorudzbinuForm
            // 
            ClientSize = new Size(770, 503);
            Controls.Add(cmbStatus);
            Controls.Add(txtKupac);
            Controls.Add(dtpDatum);
            Controls.Add(txtVrsta);
            Controls.Add(txtDimenzije);
            Controls.Add(txtCena);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOtkazi);
            Name = "DodajPorudzbinuForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
