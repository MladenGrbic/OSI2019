namespace Login
{
    partial class dodizkat
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listPrva = new System.Windows.Forms.ListView();
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.listPrva);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 667);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(691, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Izbriši kategoriju";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(668, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(691, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj novu kategoriju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(668, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 38);
            this.textBox1.TabIndex = 6;
            // 
            // listPrva
            // 
            this.listPrva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naziv});
            this.listPrva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrva.GridLines = true;
            this.listPrva.HideSelection = false;
            this.listPrva.Location = new System.Drawing.Point(0, 0);
            this.listPrva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPrva.MultiSelect = false;
            this.listPrva.Name = "listPrva";
            this.listPrva.Size = new System.Drawing.Size(486, 665);
            this.listPrva.TabIndex = 5;
            this.listPrva.UseCompatibleStateImageBehavior = false;
            this.listPrva.View = System.Windows.Forms.View.Details;
            // 
            // naziv
            // 
            this.naziv.Text = "Kategorija";
            this.naziv.Width = 481;
            // 
            // dodizkat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "dodizkat";
            this.Size = new System.Drawing.Size(1495, 667);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listPrva;
        private System.Windows.Forms.ColumnHeader naziv;
    }
}
