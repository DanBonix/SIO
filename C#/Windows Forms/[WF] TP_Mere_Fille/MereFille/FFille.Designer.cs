namespace MereFille
{
    partial class FFille
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
            this.lblChangeNom = new System.Windows.Forms.Label();
            this.tbNomFille = new System.Windows.Forms.TextBox();
            this.btnChangeNom = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangeNom
            // 
            this.lblChangeNom.AutoSize = true;
            this.lblChangeNom.Location = new System.Drawing.Point(2, 40);
            this.lblChangeNom.Name = "lblChangeNom";
            this.lblChangeNom.Size = new System.Drawing.Size(101, 13);
            this.lblChangeNom.TabIndex = 0;
            this.lblChangeNom.Text = "Je change de nom :";
            // 
            // tbNomFille
            // 
            this.tbNomFille.Location = new System.Drawing.Point(109, 40);
            this.tbNomFille.Name = "tbNomFille";
            this.tbNomFille.Size = new System.Drawing.Size(100, 20);
            this.tbNomFille.TabIndex = 1;
            // 
            // btnChangeNom
            // 
            this.btnChangeNom.Location = new System.Drawing.Point(215, 38);
            this.btnChangeNom.Name = "btnChangeNom";
            this.btnChangeNom.Size = new System.Drawing.Size(66, 23);
            this.btnChangeNom.TabIndex = 2;
            this.btnChangeNom.Text = "Changer";
            this.btnChangeNom.UseVisualStyleBackColor = true;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(109, 99);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(75, 23);
            this.btnMaMere.TabIndex = 3;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChangeNom);
            this.Controls.Add(this.tbNomFille);
            this.Controls.Add(this.lblChangeNom);
            this.Name = "FFille";
            this.Text = "FFille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChangeNom;
        private System.Windows.Forms.TextBox tbNomFille;
        private System.Windows.Forms.Button btnChangeNom;
        private System.Windows.Forms.Button btnMaMere;
    }
}