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
            this.label1 = new System.Windows.Forms.Label();
            this.Odabir1 = new System.Windows.Forms.ComboBox();
            this.List1 = new System.Windows.Forms.ListView();
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite kategoriju";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Odabir1
            // 
            this.Odabir1.FormattingEnabled = true;
            this.Odabir1.Location = new System.Drawing.Point(4, 16);
            this.Odabir1.Margin = new System.Windows.Forms.Padding(2);
            this.Odabir1.Name = "Odabir1";
            this.Odabir1.Size = new System.Drawing.Size(185, 21);
            this.Odabir1.TabIndex = 2;
            this.Odabir1.Text = "...";
            this.Odabir1.SelectedIndexChanged += new System.EventHandler(this.Odabir1_SelectedIndexChanged_1);
            // 
            // List1
            // 
            this.List1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv,
            this.kategorija,
            this.datum,
            this.mjesto,
            this.opis});
            this.List1.GridLines = true;
            this.List1.HideSelection = false;
            this.List1.Location = new System.Drawing.Point(2, 41);
            this.List1.Margin = new System.Windows.Forms.Padding(2);
            this.List1.MultiSelect = false;
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(1115, 499);
            this.List1.TabIndex = 4;
            this.List1.UseCompatibleStateImageBehavior = false;
            this.List1.View = System.Windows.Forms.View.Details;
            this.List1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 200;
            // 
            // kategorija
            // 
            this.kategorija.Text = "Kategorija";
            this.kategorija.Width = 166;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 96;
            // 
            // mjesto
            // 
            this.mjesto.Text = "Mjesto";
            this.mjesto.Width = 150;
            // 
            // opis
            // 
            this.opis.Text = "Opis";
            this.opis.Width = 506;
            // 
            // Prva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.List1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odabir1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prva";
            this.Size = new System.Drawing.Size(1117, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Odabir1;
        private System.Windows.Forms.ListView List1;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader kategorija;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.ColumnHeader mjesto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
