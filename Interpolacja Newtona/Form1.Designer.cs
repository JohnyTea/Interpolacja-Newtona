namespace Interpolacja_Newtona
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.oblicz_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.X_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wynik_TB = new System.Windows.Forms.TextBox();
            this.punkty_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wzor_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oblicz_BTN
            // 
            this.oblicz_BTN.Location = new System.Drawing.Point(81, 119);
            this.oblicz_BTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oblicz_BTN.Name = "oblicz_BTN";
            this.oblicz_BTN.Size = new System.Drawing.Size(75, 23);
            this.oblicz_BTN.TabIndex = 5;
            this.oblicz_BTN.Text = "Oblicz";
            this.oblicz_BTN.UseVisualStyleBackColor = true;
            this.oblicz_BTN.Click += new System.EventHandler(this.oblicz_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Szukany x";
            // 
            // X_TB
            // 
            this.X_TB.Location = new System.Drawing.Point(81, 94);
            this.X_TB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.X_TB.Name = "X_TB";
            this.X_TB.Size = new System.Drawing.Size(76, 20);
            this.X_TB.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Wynik:";
            // 
            // wynik_TB
            // 
            this.wynik_TB.Enabled = false;
            this.wynik_TB.Location = new System.Drawing.Point(111, 155);
            this.wynik_TB.Margin = new System.Windows.Forms.Padding(2);
            this.wynik_TB.Name = "wynik_TB";
            this.wynik_TB.Size = new System.Drawing.Size(76, 20);
            this.wynik_TB.TabIndex = 21;
            // 
            // punkty_TB
            // 
            this.punkty_TB.Location = new System.Drawing.Point(81, 40);
            this.punkty_TB.Margin = new System.Windows.Forms.Padding(2);
            this.punkty_TB.Name = "punkty_TB";
            this.punkty_TB.Size = new System.Drawing.Size(76, 20);
            this.punkty_TB.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "x y";
            // 
            // Wzor_TB
            // 
            this.Wzor_TB.Enabled = false;
            this.Wzor_TB.Location = new System.Drawing.Point(25, 208);
            this.Wzor_TB.Margin = new System.Windows.Forms.Padding(2);
            this.Wzor_TB.Name = "Wzor_TB";
            this.Wzor_TB.Size = new System.Drawing.Size(613, 20);
            this.Wzor_TB.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 366);
            this.Controls.Add(this.Wzor_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punkty_TB);
            this.Controls.Add(this.wynik_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.X_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oblicz_BTN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button oblicz_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wynik_TB;
        private System.Windows.Forms.TextBox punkty_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wzor_TB;
    }
}

