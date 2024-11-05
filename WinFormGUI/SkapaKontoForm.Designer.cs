namespace WinFormGUI
{
    partial class SkapaKontoForm
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
            btnRegister = new Button();
            txtAnvändarnamn = new TextBox();
            txtLösenord = new TextBox();
            comboBoxRoll = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAvlsuta = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(436, 280);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrera";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAnvändarnamn
            // 
            txtAnvändarnamn.Location = new Point(350, 113);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(161, 23);
            txtAnvändarnamn.TabIndex = 1;
            // 
            // txtLösenord
            // 
            txtLösenord.Location = new Point(350, 167);
            txtLösenord.Name = "txtLösenord";
            txtLösenord.Size = new Size(161, 23);
            txtLösenord.TabIndex = 2;
            // 
            // comboBoxRoll
            // 
            comboBoxRoll.FormattingEnabled = true;
            comboBoxRoll.Location = new Point(350, 221);
            comboBoxRoll.Name = "comboBoxRoll";
            comboBoxRoll.Size = new Size(161, 23);
            comboBoxRoll.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 50);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 4;
            label1.Text = "Skapa konto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 116);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Användarnamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Lösenord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 224);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "Roll";
            // 
            // btnAvlsuta
            // 
            btnAvlsuta.Location = new Point(12, 415);
            btnAvlsuta.Name = "btnAvlsuta";
            btnAvlsuta.Size = new Size(75, 23);
            btnAvlsuta.TabIndex = 8;
            btnAvlsuta.Text = "Avsluta";
            btnAvlsuta.UseVisualStyleBackColor = true;
            btnAvlsuta.Click += btnAvlsuta_Click;
            // 
            // SkapaKontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvlsuta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRoll);
            Controls.Add(txtLösenord);
            Controls.Add(txtAnvändarnamn);
            Controls.Add(btnRegister);
            Name = "SkapaKontoForm";
            Text = "SkapaKontoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtAnvändarnamn;
        private TextBox txtLösenord;
        private ComboBox comboBoxRoll;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAvlsuta;
    }
}