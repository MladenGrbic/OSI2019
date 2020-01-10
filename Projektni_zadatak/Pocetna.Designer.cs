namespace Projektni_zadatak
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.List1 = new System.Windows.Forms.ListView();
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.List1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1495, 667);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Spisak svih događaja:";
            // 
            // List1
            // 
            this.List1.BackColor = System.Drawing.Color.White;
            this.List1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv,
            this.columnHeader1,
            this.datum,
            this.mjesto,
            this.opis});
            this.List1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List1.GridLines = true;
            this.List1.HideSelection = false;
            this.List1.Location = new System.Drawing.Point(0, 53);
            this.List1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List1.MultiSelect = false;
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(1492, 614);
            this.List1.TabIndex = 7;
            this.List1.UseCompatibleStateImageBehavior = false;
            this.List1.View = System.Windows.Forms.View.Details;
            this.List1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.funkcija);
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 274;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorija";
            this.columnHeader1.Width = 170;
            // 
            // datum
            // 
            this.datum.Text = "Datum";
            this.datum.Width = 131;
            // 
            // mjesto
            // 
            this.mjesto.Text = "Mjesto";
            this.mjesto.Width = 164;
            // 
            // opis
            // 
            this.opis.Text = "Opis";
            this.opis.Width = 797;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pocetna";
            this.Size = new System.Drawing.Size(1495, 667);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView List1;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader mjesto;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Label label1;
    }
}
