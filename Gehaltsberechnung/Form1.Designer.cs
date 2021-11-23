
namespace Gehaltsberechnung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(83, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Brutto";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(78, 119);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(155, 26);
            this.txt.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(278, 119);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(132, 26);
            this.btn.TabIndex = 2;
            this.btn.Text = "Berechnen";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Location = new System.Drawing.Point(74, 251);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(0, 20);
            this.LBL.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 459);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label LBL;
    }
}

