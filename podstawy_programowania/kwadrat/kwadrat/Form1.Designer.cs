namespace kwadrat
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
            this.lblBok = new System.Windows.Forms.Label();
            this.btnwyczysc = new System.Windows.Forms.Button();
            this.btnzamknij = new System.Windows.Forms.Button();
            this.text_bok = new System.Windows.Forms.TextBox();
            this.textobw = new System.Windows.Forms.TextBox();
            this.textpole = new System.Windows.Forms.TextBox();
            this.lblObw = new System.Windows.Forms.Label();
            this.LblPole = new System.Windows.Forms.Label();
            this.lblkomunikat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBok
            // 
            this.lblBok.AutoSize = true;
            this.lblBok.Location = new System.Drawing.Point(33, 35);
            this.lblBok.Name = "lblBok";
            this.lblBok.Size = new System.Drawing.Size(26, 13);
            this.lblBok.TabIndex = 0;
            this.lblBok.Text = "Bok";
            this.lblBok.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnwyczysc
            // 
            this.btnwyczysc.Location = new System.Drawing.Point(36, 165);
            this.btnwyczysc.Name = "btnwyczysc";
            this.btnwyczysc.Size = new System.Drawing.Size(126, 26);
            this.btnwyczysc.TabIndex = 4;
            this.btnwyczysc.Text = "Wyczyść";
            this.btnwyczysc.UseVisualStyleBackColor = true;
            this.btnwyczysc.Click += new System.EventHandler(this.btnwyczysc_Click);
            // 
            // btnzamknij
            // 
            this.btnzamknij.Location = new System.Drawing.Point(193, 165);
            this.btnzamknij.Name = "btnzamknij";
            this.btnzamknij.Size = new System.Drawing.Size(126, 26);
            this.btnzamknij.TabIndex = 5;
            this.btnzamknij.Text = "Zamknij";
            this.btnzamknij.UseVisualStyleBackColor = true;
            this.btnzamknij.Click += new System.EventHandler(this.btnzamknij_Click);
            // 
            // text_bok
            // 
            this.text_bok.Location = new System.Drawing.Point(117, 38);
            this.text_bok.Name = "text_bok";
            this.text_bok.Size = new System.Drawing.Size(142, 20);
            this.text_bok.TabIndex = 6;
            this.text_bok.TextChanged += new System.EventHandler(this.textBok_TextChanged_TextChanged);
            // 
            // textobw
            // 
            this.textobw.Enabled = false;
            this.textobw.Location = new System.Drawing.Point(117, 79);
            this.textobw.Name = "textobw";
            this.textobw.Size = new System.Drawing.Size(142, 20);
            this.textobw.TabIndex = 7;
            this.textobw.TextChanged += new System.EventHandler(this.textobw_TextChanged);
            // 
            // textpole
            // 
            this.textpole.Enabled = false;
            this.textpole.Location = new System.Drawing.Point(117, 118);
            this.textpole.Name = "textpole";
            this.textpole.Size = new System.Drawing.Size(142, 20);
            this.textpole.TabIndex = 8;
            this.textpole.TextChanged += new System.EventHandler(this.textpole_TextChanged);
            // 
            // lblObw
            // 
            this.lblObw.AutoSize = true;
            this.lblObw.Location = new System.Drawing.Point(33, 79);
            this.lblObw.Name = "lblObw";
            this.lblObw.Size = new System.Drawing.Size(41, 13);
            this.lblObw.TabIndex = 9;
            this.lblObw.Text = "Obwód";
            // 
            // LblPole
            // 
            this.LblPole.AutoSize = true;
            this.LblPole.Location = new System.Drawing.Point(33, 121);
            this.LblPole.Name = "LblPole";
            this.LblPole.Size = new System.Drawing.Size(28, 13);
            this.LblPole.TabIndex = 10;
            this.LblPole.Text = "Pole";
            // 
            // lblkomunikat
            // 
            this.lblkomunikat.AutoSize = true;
            this.lblkomunikat.ForeColor = System.Drawing.Color.Red;
            this.lblkomunikat.Location = new System.Drawing.Point(288, 45);
            this.lblkomunikat.Name = "lblkomunikat";
            this.lblkomunikat.Size = new System.Drawing.Size(0, 13);
            this.lblkomunikat.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 219);
            this.Controls.Add(this.lblkomunikat);
            this.Controls.Add(this.LblPole);
            this.Controls.Add(this.lblObw);
            this.Controls.Add(this.textpole);
            this.Controls.Add(this.textobw);
            this.Controls.Add(this.text_bok);
            this.Controls.Add(this.btnzamknij);
            this.Controls.Add(this.btnwyczysc);
            this.Controls.Add(this.lblBok);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBok;
        private System.Windows.Forms.Button btnwyczysc;
        private System.Windows.Forms.Button btnzamknij;
        private System.Windows.Forms.TextBox text_bok;
        private System.Windows.Forms.TextBox textobw;
        private System.Windows.Forms.TextBox textpole;
        private System.Windows.Forms.Label lblObw;
        private System.Windows.Forms.Label LblPole;
        private System.Windows.Forms.Label lblkomunikat;
    }
}

