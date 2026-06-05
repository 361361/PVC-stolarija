namespace PVC_stolarija
{
    partial class PorudzbineForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Deklaracije kontrola — logika je u PorudzbineForm.cs
        private System.Windows.Forms.DataGridView dgvPorudzbine;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.TextBox txtKupacFilter;
        private System.Windows.Forms.TextBox txtStatusFilter;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.Button btnIzmeni;
    }
}
