
namespace Steganografija_slike
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OdaberiSliku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tekst = new System.Windows.Forms.RichTextBox();
            this.lbl_ImeDatoteke = new System.Windows.Forms.Label();
            this.btn_Enkodiraj = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Dekodiraj = new System.Windows.Forms.Button();
            this.txt_DekodiraniTekst = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OdaberiSliku
            // 
            this.btn_OdaberiSliku.Location = new System.Drawing.Point(49, 37);
            this.btn_OdaberiSliku.Name = "btn_OdaberiSliku";
            this.btn_OdaberiSliku.Size = new System.Drawing.Size(103, 23);
            this.btn_OdaberiSliku.TabIndex = 0;
            this.btn_OdaberiSliku.Text = "Odaberi bitmap";
            this.btn_OdaberiSliku.UseVisualStyleBackColor = true;
            this.btn_OdaberiSliku.Click += new System.EventHandler(this.btn_OdaberiSliku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tekst za enkodiranje";
            // 
            // txt_Tekst
            // 
            this.txt_Tekst.Location = new System.Drawing.Point(49, 176);
            this.txt_Tekst.Name = "txt_Tekst";
            this.txt_Tekst.Size = new System.Drawing.Size(309, 182);
            this.txt_Tekst.TabIndex = 3;
            this.txt_Tekst.Text = "Upišite neki tekst";
            // 
            // lbl_ImeDatoteke
            // 
            this.lbl_ImeDatoteke.AutoSize = true;
            this.lbl_ImeDatoteke.Location = new System.Drawing.Point(168, 47);
            this.lbl_ImeDatoteke.Name = "lbl_ImeDatoteke";
            this.lbl_ImeDatoteke.Size = new System.Drawing.Size(141, 13);
            this.lbl_ImeDatoteke.TabIndex = 4;
            this.lbl_ImeDatoteke.Text = "Nijedan bitmap nije odabran.";
            // 
            // btn_Enkodiraj
            // 
            this.btn_Enkodiraj.Location = new System.Drawing.Point(283, 364);
            this.btn_Enkodiraj.Name = "btn_Enkodiraj";
            this.btn_Enkodiraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Enkodiraj.TabIndex = 5;
            this.btn_Enkodiraj.Text = "Enkodiraj";
            this.btn_Enkodiraj.UseVisualStyleBackColor = true;
            this.btn_Enkodiraj.Click += new System.EventHandler(this.btn_Enkodiraj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(171, 84);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Broj bitova po pikselu:";
            // 
            // btn_Dekodiraj
            // 
            this.btn_Dekodiraj.Location = new System.Drawing.Point(664, 364);
            this.btn_Dekodiraj.Name = "btn_Dekodiraj";
            this.btn_Dekodiraj.Size = new System.Drawing.Size(75, 23);
            this.btn_Dekodiraj.TabIndex = 9;
            this.btn_Dekodiraj.Text = "Dekodiraj";
            this.btn_Dekodiraj.UseVisualStyleBackColor = true;
            this.btn_Dekodiraj.Click += new System.EventHandler(this.btn_Dekodiraj_Click);
            // 
            // txt_DekodiraniTekst
            // 
            this.txt_DekodiraniTekst.Location = new System.Drawing.Point(430, 176);
            this.txt_DekodiraniTekst.Name = "txt_DekodiraniTekst";
            this.txt_DekodiraniTekst.ReadOnly = true;
            this.txt_DekodiraniTekst.Size = new System.Drawing.Size(309, 182);
            this.txt_DekodiraniTekst.TabIndex = 10;
            this.txt_DekodiraniTekst.Text = "Za dekodiranje odaberite bitmapu i pritisnite \'Dekodiraj\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dekodiran tekst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DekodiraniTekst);
            this.Controls.Add(this.btn_Dekodiraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_Enkodiraj);
            this.Controls.Add(this.lbl_ImeDatoteke);
            this.Controls.Add(this.txt_Tekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OdaberiSliku);
            this.Name = "Form1";
            this.Text = "Steganografija u slikama";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OdaberiSliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_Tekst;
        private System.Windows.Forms.Label lbl_ImeDatoteke;
        private System.Windows.Forms.Button btn_Enkodiraj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Dekodiraj;
        private System.Windows.Forms.RichTextBox txt_DekodiraniTekst;
        private System.Windows.Forms.Label label3;
    }
}

