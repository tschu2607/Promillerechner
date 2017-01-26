namespace Promillerechner
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_menge = new System.Windows.Forms.TextBox();
            this.nud_groesse = new System.Windows.Forms.NumericUpDown();
            this.nud_alkoholanteil = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_maennlich = new System.Windows.Forms.RadioButton();
            this.rbtn_weiblich = new System.Windows.Forms.RadioButton();
            this.tbx_ergebnis = new System.Windows.Forms.TextBox();
            this.btn_berechnen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_groesse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alkoholanteil)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menge in ml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alkoholanteil in %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Größe";
            // 
            // tbx_menge
            // 
            this.tbx_menge.Location = new System.Drawing.Point(122, 72);
            this.tbx_menge.Name = "tbx_menge";
            this.tbx_menge.Size = new System.Drawing.Size(100, 20);
            this.tbx_menge.TabIndex = 6;
            // 
            // nud_groesse
            // 
            this.nud_groesse.Location = new System.Drawing.Point(122, 9);
            this.nud_groesse.Name = "nud_groesse";
            this.nud_groesse.Size = new System.Drawing.Size(100, 20);
            this.nud_groesse.TabIndex = 7;
            // 
            // nud_alkoholanteil
            // 
            this.nud_alkoholanteil.Location = new System.Drawing.Point(122, 41);
            this.nud_alkoholanteil.Name = "nud_alkoholanteil";
            this.nud_alkoholanteil.Size = new System.Drawing.Size(100, 20);
            this.nud_alkoholanteil.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Geschlecht";
            // 
            // rbtn_maennlich
            // 
            this.rbtn_maennlich.AutoSize = true;
            this.rbtn_maennlich.Location = new System.Drawing.Point(122, 108);
            this.rbtn_maennlich.Name = "rbtn_maennlich";
            this.rbtn_maennlich.Size = new System.Drawing.Size(68, 17);
            this.rbtn_maennlich.TabIndex = 10;
            this.rbtn_maennlich.TabStop = true;
            this.rbtn_maennlich.Text = "Männlich";
            this.rbtn_maennlich.UseVisualStyleBackColor = true;
            // 
            // rbtn_weiblich
            // 
            this.rbtn_weiblich.AutoSize = true;
            this.rbtn_weiblich.Location = new System.Drawing.Point(122, 131);
            this.rbtn_weiblich.Name = "rbtn_weiblich";
            this.rbtn_weiblich.Size = new System.Drawing.Size(66, 17);
            this.rbtn_weiblich.TabIndex = 11;
            this.rbtn_weiblich.TabStop = true;
            this.rbtn_weiblich.Text = "Weiblich";
            this.rbtn_weiblich.UseVisualStyleBackColor = true;
            // 
            // tbx_ergebnis
            // 
            this.tbx_ergebnis.Location = new System.Drawing.Point(15, 187);
            this.tbx_ergebnis.Name = "tbx_ergebnis";
            this.tbx_ergebnis.Size = new System.Drawing.Size(207, 20);
            this.tbx_ergebnis.TabIndex = 12;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(15, 157);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(207, 24);
            this.btn_berechnen.TabIndex = 14;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 208);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.tbx_ergebnis);
            this.Controls.Add(this.rbtn_weiblich);
            this.Controls.Add(this.rbtn_maennlich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_alkoholanteil);
            this.Controls.Add(this.nud_groesse);
            this.Controls.Add(this.tbx_menge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "frm_promillerechner";
            ((System.ComponentModel.ISupportInitialize)(this.nud_groesse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_alkoholanteil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_menge;
        private System.Windows.Forms.NumericUpDown nud_groesse;
        private System.Windows.Forms.NumericUpDown nud_alkoholanteil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_maennlich;
        private System.Windows.Forms.RadioButton rbtn_weiblich;
        private System.Windows.Forms.TextBox tbx_ergebnis;
        private System.Windows.Forms.Button btn_berechnen;
    }
}

