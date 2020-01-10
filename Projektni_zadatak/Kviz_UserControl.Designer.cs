namespace Projektni_zadatak
{
    partial class Kviz_UserControl
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
            this.Pitanje = new System.Windows.Forms.TextBox();
            this.StartKviz = new System.Windows.Forms.Button();
            this.Odg3 = new System.Windows.Forms.Button();
            this.Odg2 = new System.Windows.Forms.Button();
            this.Odg1 = new System.Windows.Forms.Button();
            this.ListaGradova = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Odabir grada:";
            // 
            // Pitanje
            // 
            this.Pitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pitanje.Location = new System.Drawing.Point(40, 65);
            this.Pitanje.Margin = new System.Windows.Forms.Padding(4);
            this.Pitanje.Multiline = true;
            this.Pitanje.Name = "Pitanje";
            this.Pitanje.Size = new System.Drawing.Size(1415, 289);
            this.Pitanje.TabIndex = 12;
            this.Pitanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pitanje.TextChanged += new System.EventHandler(this.Pitanje_TextChanged);
            // 
            // StartKviz
            // 
            this.StartKviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartKviz.Location = new System.Drawing.Point(412, 51);
            this.StartKviz.Margin = new System.Windows.Forms.Padding(4);
            this.StartKviz.Name = "StartKviz";
            this.StartKviz.Size = new System.Drawing.Size(185, 64);
            this.StartKviz.TabIndex = 11;
            this.StartKviz.Text = "Zapocni kviz";
            this.StartKviz.UseVisualStyleBackColor = true;
            this.StartKviz.Click += new System.EventHandler(this.StartKviz_Click);
            // 
            // Odg3
            // 
            this.Odg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odg3.Location = new System.Drawing.Point(40, 580);
            this.Odg3.Margin = new System.Windows.Forms.Padding(4);
            this.Odg3.Name = "Odg3";
            this.Odg3.Size = new System.Drawing.Size(1415, 50);
            this.Odg3.TabIndex = 10;
            this.Odg3.Text = "Odgovor 3";
            this.Odg3.UseVisualStyleBackColor = true;
            this.Odg3.Click += new System.EventHandler(this.Odg3_Click);
            // 
            // Odg2
            // 
            this.Odg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odg2.Location = new System.Drawing.Point(40, 490);
            this.Odg2.Margin = new System.Windows.Forms.Padding(4);
            this.Odg2.Name = "Odg2";
            this.Odg2.Size = new System.Drawing.Size(1415, 50);
            this.Odg2.TabIndex = 9;
            this.Odg2.Text = "Odgovor 2";
            this.Odg2.UseVisualStyleBackColor = true;
            this.Odg2.Click += new System.EventHandler(this.Odg2_Click);
            // 
            // Odg1
            // 
            this.Odg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odg1.Location = new System.Drawing.Point(40, 396);
            this.Odg1.Margin = new System.Windows.Forms.Padding(4);
            this.Odg1.Name = "Odg1";
            this.Odg1.Size = new System.Drawing.Size(1415, 50);
            this.Odg1.TabIndex = 8;
            this.Odg1.Text = "Odgovor 1";
            this.Odg1.UseVisualStyleBackColor = true;
            this.Odg1.Click += new System.EventHandler(this.Odg1_Click);
            // 
            // ListaGradova
            // 
            this.ListaGradova.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaGradova.FormattingEnabled = true;
            this.ListaGradova.Items.AddRange(new object[] {
            "Banja Luka",
            "Beograd",
            "London",
            "Moskva",
            "Pariz",
            "Rim"});
            this.ListaGradova.Location = new System.Drawing.Point(40, 78);
            this.ListaGradova.Margin = new System.Windows.Forms.Padding(4);
            this.ListaGradova.Name = "ListaGradova";
            this.ListaGradova.Size = new System.Drawing.Size(343, 39);
            this.ListaGradova.TabIndex = 7;
            this.ListaGradova.SelectedIndexChanged += new System.EventHandler(this.ListaGradova_SelectedIndexChanged);
            // 
            // Kviz_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pitanje);
            this.Controls.Add(this.StartKviz);
            this.Controls.Add(this.Odg3);
            this.Controls.Add(this.Odg2);
            this.Controls.Add(this.Odg1);
            this.Controls.Add(this.ListaGradova);
            this.Name = "Kviz_UserControl";
            this.Size = new System.Drawing.Size(1495, 667);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pitanje;
        private System.Windows.Forms.Button StartKviz;
        private System.Windows.Forms.Button Odg3;
        private System.Windows.Forms.Button Odg2;
        private System.Windows.Forms.Button Odg1;
        private System.Windows.Forms.ComboBox ListaGradova;
    }
}
