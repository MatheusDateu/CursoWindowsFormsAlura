namespace CursoWindowsFormsAlura
{
    partial class Form2
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_Limpa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 8);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nome_KeyDown);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(12, 37);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.txt_Msg.TabIndex = 1;
            this.txt_Msg.TabStop = false;
            // 
            // btn_Limpa
            // 
            this.btn_Limpa.Location = new System.Drawing.Point(329, 12);
            this.btn_Limpa.Name = "btn_Limpa";
            this.btn_Limpa.Size = new System.Drawing.Size(75, 28);
            this.btn_Limpa.TabIndex = 2;
            this.btn_Limpa.Text = "Limpa";
            this.btn_Limpa.UseVisualStyleBackColor = true;
            this.btn_Limpa.Click += new System.EventHandler(this.btn_Limpa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minus.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maius.";
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lower.Location = new System.Drawing.Point(368, 56);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.lbl_Lower.TabIndex = 5;
            // 
            // lblUpper
            // 
            this.lblUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpper.Location = new System.Drawing.Point(367, 97);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(32, 23);
            this.lblUpper.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lbl_Lower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Limpa);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Nome);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Nome;
        private TextBox txt_Msg;
        private Button btn_Limpa;
        private Label label1;
        private Label label2;
        private Label lbl_Lower;
        private Label lblUpper;
    }
}