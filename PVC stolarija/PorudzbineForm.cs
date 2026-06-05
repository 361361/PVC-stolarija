using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PVC_stolarija
{
    public partial class PorudzbineForm : Form
    {
        private readonly PorudzbineRepozitorijum _repozitorijum = new PorudzbineRepozitorijum();

        public PorudzbineForm()
        {
            InitializeComponent();
            dgvPorudzbine.CellEndEdit    += dgvPorudzbine_CellEndEdit;
            dgvPorudzbine.CellValidating += dgvPorudzbine_CellValidating;
        }

        private void InitializeComponent()
        {
            dgvPorudzbine    = new DataGridView();
            btnObrisi        = new Button();
            btnNazad         = new Button();
            lblStatus        = new Label();
            btnDodaj         = new Button();
            btnOsvezi        = new Button();
            btnFiltriraj     = new Button();
            btnStampaj       = new Button();
            btnIzmeni        = new Button();
            txtKupacFilter   = new TextBox();
            txtStatusFilter  = new TextBox();
            dtpDatumOd       = new DateTimePicker();
            dtpDatumDo       = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPorudzbine).BeginInit();
            SuspendLayout();

            // dgvPorudzbine
            dgvPorudzbine.AllowUserToAddRows                 = false;
            dgvPorudzbine.AllowUserToOrderColumns            = true;
            dgvPorudzbine.ColumnHeadersHeightSizeMode        = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorudzbine.Location                           = new Point(41, 37);
            dgvPorudzbine.Name                               = "dgvPorudzbine";
            dgvPorudzbine.Size                               = new Size(741, 368);
            dgvPorudzbine.TabIndex                           = 0;

            // btnNazad
            btnNazad.Location             = new Point(41, 424);
            btnNazad.Name                 = "btnNazad";
            btnNazad.Size                 = new Size(75, 23);
            btnNazad.TabIndex             = 2;
            btnNazad.Text                 = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click               += btnNazad_Click;

            // lblStatus
            lblStatus.AutoSize  = true;
            lblStatus.Location  = new Point(41, 4);
            lblStatus.Name      = "lblStatus";
            lblStatus.Size      = new Size(0, 15);
            lblStatus.TabIndex  = 3;

            // btnStampaj
            btnStampaj.Location             = new Point(120, 424);
            btnStampaj.Name                 = "btnStampaj";
            btnStampaj.Size                 = new Size(75, 23);
            btnStampaj.TabIndex             = 11;
            btnStampaj.Text                 = "Štampaj";
            btnStampaj.UseVisualStyleBackColor = true;
            btnStampaj.Click               += btnStampaj_Click;

            // btnFiltriraj
            btnFiltriraj.Location             = new Point(464, 424);
            btnFiltriraj.Name                 = "btnFiltriraj";
            btnFiltriraj.Size                 = new Size(75, 23);
            btnFiltriraj.TabIndex             = 6;
            btnFiltriraj.Text                 = "Filter";
            btnFiltriraj.UseVisualStyleBackColor = true;
            btnFiltriraj.Click               += btnFiltriraj_Click;

            // btnOsvezi
            btnOsvezi.Location             = new Point(545, 424);
            btnOsvezi.Name                 = "btnOsvezi";
            btnOsvezi.Size                 = new Size(75, 23);
            btnOsvezi.TabIndex             = 5;
            btnOsvezi.Text                 = "Osvezi";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click               += btnOsvezi_Click;

            // btnIzmeni
            btnIzmeni.Location             = new Point(464, 424);
            btnIzmeni.Name                 = "btnIzmeni";
            btnIzmeni.Size                 = new Size(75, 23);
            btnIzmeni.TabIndex             = 12;
            btnIzmeni.Text                 = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click               += btnIzmeni_Click;

            // btnDodaj
            btnDodaj.Location             = new Point(626, 424);
            btnDodaj.Name                 = "btnDodaj";
            btnDodaj.Size                 = new Size(75, 23);
            btnDodaj.TabIndex             = 4;
            btnDodaj.Text                 = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click               += btnDodaj_Click;

            // btnObrisi
            btnObrisi.Location             = new Point(707, 424);
            btnObrisi.Name                 = "btnObrisi";
            btnObrisi.Size                 = new Size(75, 23);
            btnObrisi.TabIndex             = 1;
            btnObrisi.Text                 = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click               += btnObrisi_Click;

            // txtKupacFilter
            txtKupacFilter.Location        = new Point(40, 456);
            txtKupacFilter.Name            = "txtKupacFilter";
            txtKupacFilter.PlaceholderText = "Kupac";
            txtKupacFilter.Size            = new Size(135, 23);
            txtKupacFilter.TabIndex        = 7;
            txtKupacFilter.TextChanged    += txtKupacFilter_TextChanged;

            // txtStatusFilter
            txtStatusFilter.Location        = new Point(181, 456);
            txtStatusFilter.Name            = "txtStatusFilter";
            txtStatusFilter.PlaceholderText = "Status";
            txtStatusFilter.Size            = new Size(135, 23);
            txtStatusFilter.TabIndex        = 8;
            txtStatusFilter.TextChanged    += txtStatusFilter_TextChanged;

            // dtpDatumOd
            dtpDatumOd.Location  = new Point(376, 456);
            dtpDatumOd.Name      = "dtpDatumOd";
            dtpDatumOd.Size      = new Size(200, 23);
            dtpDatumOd.TabIndex  = 9;

            // dtpDatumDo
            dtpDatumDo.Location  = new Point(582, 456);
            dtpDatumDo.Name      = "dtpDatumDo";
            dtpDatumDo.Size      = new Size(200, 23);
            dtpDatumDo.TabIndex  = 10;

            // PorudzbineForm
            ClientSize = new Size(848, 500);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(txtStatusFilter);
            Controls.Add(txtKupacFilter);
            Controls.Add(btnFiltriraj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnStampaj);
            Controls.Add(btnOsvezi);
            Controls.Add(btnDodaj);
            Controls.Add(lblStatus);
            Controls.Add(btnNazad);
            Controls.Add(btnObrisi);
            Controls.Add(dgvPorudzbine);
            Name  = "PorudzbineForm";
            Text  = "Porudžbine";
            Load += PorudzbineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPorudzbine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void PorudzbineForm_Load(object sender, EventArgs e)
        {
            PrikaziPorudzbine();
        }

        private void PrikaziPorudzbine()
        {
            var tabela = _repozitorijum.GetPorudzbine();
            dgvPorudzbine.DataSource = tabela;
            lblStatus.Text = $"Ukupan broj porudžbina: {tabela.Rows.Count}";
        }

        private void PrikaziPorudzbine(
            string kupac      = "",
            string status     = "",
            DateTime? datumOd = null,
            DateTime? datumDo = null)
        {
            var tabela = _repozitorijum.GetPorudzbine(kupac, status, datumOd, datumDo);
            dgvPorudzbine.DataSource = tabela;
            lblStatus.Text = $"Ukupan broj porudžbina: {tabela.Rows.Count}";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var dodajForm = new DodajPorudzbinuForm())
            {
                if (dodajForm.ShowDialog() == DialogResult.OK)
                    PrikaziPorudzbine();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvPorudzbine.CurrentRow == null)
            {
                MessageBox.Show("Izaberite porudžbinu za izmenu!");
                return;
            }
            int id = Convert.ToInt32(dgvPorudzbine.CurrentRow.Cells["ID"].Value);
            using (var izmeniForm = new DodajPorudzbinuForm(id))
            {
                if (izmeniForm.ShowDialog() == DialogResult.OK)
                    PrikaziPorudzbine();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPorudzbine.CurrentRow == null)
            {
                MessageBox.Show("Izaberite porudžbinu koju želite da obrišete!");
                return;
            }
            int id = Convert.ToInt32(dgvPorudzbine.CurrentRow.Cells["ID"].Value);
            var porudzbina = Porudzbina.Ucitaj(id);
            porudzbina.Obrisi();
            MessageBox.Show("Porudžbina obrisana!");
            PrikaziPorudzbine();
        }

        private void btnOsvezi_Click(object sender, EventArgs e)
        {
            PrikaziPorudzbine();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            PrikaziPorudzbine(
                txtKupacFilter.Text,
                txtStatusFilter.Text,
                dtpDatumOd.Value,
                dtpDatumDo.Value);
        }

        private void txtKupacFilter_TextChanged(object sender, EventArgs e) { }
        private void txtStatusFilter_TextChanged(object sender, EventArgs e) { }

        private void dgvPorudzbine_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = dgvPorudzbine.Columns[e.ColumnIndex].Name;
            string val = e.FormattedValue?.ToString() ?? "";

            if (col == "Kupac" && string.IsNullOrWhiteSpace(val))
            {
                dgvPorudzbine.Rows[e.RowIndex].ErrorText = "Kupac je obavezno polje!";
                e.Cancel = true;
            }
            else if (col == "Cena")
            {
                if (!decimal.TryParse(val, out decimal cena) || cena < 0)
                {
                    dgvPorudzbine.Rows[e.RowIndex].ErrorText = "Cena mora biti pozitivan broj!";
                    e.Cancel = true;
                }
            }
            else
            {
                dgvPorudzbine.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void dgvPorudzbine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPorudzbine.Rows[e.RowIndex];
            if (row.Cells["ID"].Value == null) return;

            int id = Convert.ToInt32(row.Cells["ID"].Value);

            var porudzbina = Porudzbina.Ucitaj(id);
            porudzbina.Kupac           = row.Cells["Kupac"].Value?.ToString()        ?? "";
            porudzbina.DatumPorudzbine = row.Cells["DatumPorudzbine"].Value != null
                                             ? Convert.ToDateTime(row.Cells["DatumPorudzbine"].Value)
                                             : DateTime.Now;
            porudzbina.VrstaProzora    = row.Cells["VrstaProzora"].Value?.ToString() ?? "";
            porudzbina.Dimenzije       = row.Cells["Dimenzije"].Value?.ToString()    ?? "";
            porudzbina.Cena            = row.Cells["Cena"].Value != null
                                             ? Convert.ToDecimal(row.Cells["Cena"].Value) : 0;
            porudzbina.Status          = row.Cells["Status"].Value?.ToString()       ?? "";

            porudzbina.Sacuvaj();
            lblStatus.Text = "Izmena sačuvana!";
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            DataTable tabela = (DataTable)dgvPorudzbine.DataSource;

            printDoc.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;
                Font naslov  = new Font("Arial", 14, FontStyle.Bold);
                Font header  = new Font("Arial", 9,  FontStyle.Bold);
                Font rowFont = new Font("Arial", 9);
                float x = 50, y = 50;
                float[] sirina = { 40, 100, 100, 80, 80, 80 };

                g.DrawString("PVC Stolarija - Porudžbine", naslov, Brushes.Black, x, y);
                y += 30;
                g.DrawString($"Datum štampe: {DateTime.Now:dd.MM.yyyy HH:mm}", rowFont, Brushes.Gray, x, y);
                y += 25;

                if (tabela != null)
                {
                    float xKol = x;
                    for (int k = 0; k < dgvPorudzbine.Columns.Count && k < sirina.Length; k++)
                    {
                        g.FillRectangle(Brushes.LightGray, xKol, y, sirina[k], 20);
                        g.DrawRectangle(Pens.Black, xKol, y, sirina[k], 20);
                        g.DrawString(dgvPorudzbine.Columns[k].HeaderText, header, Brushes.Black, xKol + 2, y + 3);
                        xKol += sirina[k];
                    }
                    y += 20;

                    foreach (DataRow dr in tabela.Rows)
                    {
                        xKol = x;
                        for (int k = 0; k < dgvPorudzbine.Columns.Count && k < sirina.Length; k++)
                        {
                            string val = dr[dgvPorudzbine.Columns[k].DataPropertyName
                                          ?? dgvPorudzbine.Columns[k].Name]?.ToString() ?? "";
                            g.DrawRectangle(Pens.LightGray, xKol, y, sirina[k], 18);
                            g.DrawString(val, rowFont, Brushes.Black, xKol + 2, y + 2);
                            xKol += sirina[k];
                        }
                        y += 18;
                        if (y > ev.PageBounds.Height - 60) { ev.HasMorePages = true; return; }
                    }
                }
                y += 10;
                g.DrawString(lblStatus.Text, header, Brushes.Black, x, y);
            };

            new PrintPreviewDialog { Document = printDoc }.ShowDialog();
        }
    }
}
