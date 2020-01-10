namespace Projektni_zadatak
{
    partial class Kategorija
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.List1 = new System.Windows.Forms.ListView();
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mjesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Odabir1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.List1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Odabir1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 667);
            this.panel1.TabIndex = 0;
            // 
            // List1
            // 
            this.List1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv,
            this.columnHeader1,
            this.datum,
            this.mjesto,
            this.opis});
            this.List1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List1.GridLines = true;
            this.List1.HideSelection = false;
            this.List1.Location = new System.Drawing.Point(1, 91);
            this.List1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List1.MultiSelect = false;
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(1494, 574);
            this.List1.TabIndex = 7;
            this.List1.UseCompatibleStateImageBehavior = false;
            this.List1.View = System.Windows.Forms.View.Details;
            this.List1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.funkcija);
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorija";
            this.columnHeader1.Width = 166;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberite kategoriju";
            // 
            // Odabir1
            // 
            this.Odabir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odabir1.FormattingEnabled = true;
            this.Odabir1.Location = new System.Drawing.Point(8, 40);
            this.Odabir1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Odabir1.Name = "Odabir1";
            this.Odabir1.Size = new System.Drawing.Size(245, 37);
            this.Odabir1.TabIndex = 5;
            this.Odabir1.Text = "...";
            this.Odabir1.SelectedIndexChanged += new System.EventHandler(this.Odabir1_SelectedIndexChanged);
            // 
            // Kategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kategorija";
            this.Size = new System.Drawing.Size(1495, 667);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView List1;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader datum;
        private System.Windows.Forms.ColumnHeader mjesto;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Odabir1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
