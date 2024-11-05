namespace WinFormGUI
{
    partial class LoggaInForm
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
            label1 = new Label();
            txtAnvändarnamn = new TextBox();
            txtLösenord = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            btnAvsluta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 98);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 0;
            label1.Text = "Logga in";
            // 
            // txtAnvändarnamn
            // 
            txtAnvändarnamn.Location = new Point(320, 170);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(142, 23);
            txtAnvändarnamn.TabIndex = 1;
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(320, 215);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(142, 23);
            txtLösenord.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(387, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Logga in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "Användarnamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 218);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Lösenord";
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(12, 415);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(75, 23);
            btnAvsluta.TabIndex = 6;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // LoggaInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvsluta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtLösenord);
            Controls.Add(txtAnvändarnamn);
            Controls.Add(label1);
            Name = "LoggaInForm";
            Text = "LoggaInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAnvändarnamn;
        private TextBox txtLösenord;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Button btnAvsluta;
    }
}