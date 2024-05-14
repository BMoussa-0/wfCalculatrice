namespace wfCalculatrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNb2 = new TextBox();
            txtNb1 = new TextBox();
            btnAjouter = new Button();
            btnEffacer = new Button();
            Nb1 = new Label();
            Nb2 = new Label();
            SuspendLayout();
            // 
            // txtNb2
            // 
            txtNb2.Location = new Point(429, 137);
            txtNb2.Name = "txtNb2";
            txtNb2.Size = new Size(100, 23);
            txtNb2.TabIndex = 0;
            // 
            // txtNb1
            // 
            txtNb1.Location = new Point(429, 38);
            txtNb1.Name = "txtNb1";
            txtNb1.Size = new Size(100, 23);
            txtNb1.TabIndex = 1;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(175, 225);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(454, 225);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(75, 23);
            btnEffacer.TabIndex = 3;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += btnEffacer_Click;
            // 
            // Nb1
            // 
            Nb1.AutoSize = true;
            Nb1.Location = new Point(343, 46);
            Nb1.Name = "Nb1";
            Nb1.Size = new Size(60, 15);
            Nb1.TabIndex = 4;
            Nb1.Text = "Nombre 1";
            // 
            // Nb2
            // 
            Nb2.AutoSize = true;
            Nb2.Location = new Point(343, 145);
            Nb2.Name = "Nb2";
            Nb2.Size = new Size(60, 15);
            Nb2.TabIndex = 5;
            Nb2.Text = "Nombre 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Nb2);
            Controls.Add(Nb1);
            Controls.Add(btnEffacer);
            Controls.Add(btnAjouter);
            Controls.Add(txtNb1);
            Controls.Add(txtNb2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNb2;
        private TextBox txtNb1;
        private Button btnAjouter;
        private Button btnEffacer;
        private Label Nb1;
        private Label Nb2;
    }
}