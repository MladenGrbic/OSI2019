namespace Login
{
    partial class Pocetna
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPrva = new System.Windows.Forms.ListView();
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPrva
            // 
            this.listPrva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv,
            this.kategorija,
            this.datum,
            this.mjesto,
            this.opis});
            this.listPrva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrva.GridLines = true;
            this.listPrva.HideSelection = false;
            this.listPrva.Location = new System.Drawing.Point(0, 0);
            this.listPrva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPrva.MultiSelect = false;
            this.listPrva.Name = "listPrva";
            this.listPrva.Size = new System.Drawing.Size(1492, 667);
            this.listPrva.TabIndex = 5;
            this.listPrva.UseCompatibleStateImageBehavior = false;
            this.listPrva.View = System.Windows.Forms.View.Details;
            this.listPrva.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.funkcija);
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 300;
            // 
            // kategorija
            // 
            this.kategorija.Text = "Kategorija";
            this.kategorija.Width = 200;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 96;
            // 
            // mjesto
            // 
            this.mjesto.Text = "Mjesto";
            this.mjesto.Width = 200;
            // 
            // opis
            // 
            this.opis.Text = "Opis";
            this.opis.Width = 317;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listPrva);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 667);
            this.panel1.TabIndex = 6;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Pocetna";
            this.Size = new System.Drawing.Size(1495, 667);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPrva;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader kategorija;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader mjesto;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Panel panel1;
    }
}
