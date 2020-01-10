namespace Login
{
    partial class Prva
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
            this.button1 = new System.Windows.Forms.Button();
            this.obrisi = new System.Windows.Forms.Button();
            this.panelpri = new System.Windows.Forms.Panel();
            this.panelpri.SuspendLayout();
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
            this.listPrva.Size = new System.Drawing.Size(1492, 611);
            this.listPrva.TabIndex = 4;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(116, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(533, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uredi_Click);
            // 
            // obrisi
            // 
            this.obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisi.Location = new System.Drawing.Point(845, 617);
            this.obrisi.Margin = new System.Windows.Forms.Padding(4);
            this.obrisi.Name = "obrisi";
            this.obrisi.Size = new System.Drawing.Size(533, 43);
            this.obrisi.TabIndex = 6;
            this.obrisi.Text = "Obriši";
            this.obrisi.UseVisualStyleBackColor = true;
            this.obrisi.Click += new System.EventHandler(this.obrisi_Click);
            // 
            // panelpri
            // 
            this.panelpri.Controls.Add(this.listPrva);
            this.panelpri.Controls.Add(this.obrisi);
            this.panelpri.Controls.Add(this.button1);
            this.panelpri.Location = new System.Drawing.Point(0, 0);
            this.panelpri.Margin = new System.Windows.Forms.Padding(4);
            this.panelpri.Name = "panelpri";
            this.panelpri.Size = new System.Drawing.Size(1495, 667);
            this.panelpri.TabIndex = 7;
            // 
            // Prva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelpri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prva";
            this.Size = new System.Drawing.Size(1495, 667);
            this.panelpri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listPrva;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader kategorija;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader mjesto;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button obrisi;
        private System.Windows.Forms.Panel panelpri;
    }
}
