namespace WinFormGUI
{
    partial class MainMenuForm
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
            btnLoggaIn = new Button();
            btnSkapaKonto = new Button();
            GreenWheels = new Label();
            btnAvsluta = new Button();
            SuspendLayout();
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(300, 180);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(166, 23);
            btnLoggaIn.TabIndex = 0;
            btnLoggaIn.Text = "Logga in";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // btnSkapaKonto
            // 
            btnSkapaKonto.Location = new Point(300, 209);
            btnSkapaKonto.Name = "btnSkapaKonto";
            btnSkapaKonto.Size = new Size(166, 23);
            btnSkapaKonto.TabIndex = 1;
            btnSkapaKonto.Text = "Skapa konto";
            btnSkapaKonto.UseVisualStyleBackColor = true;
            btnSkapaKonto.Click += btnSkapaKonto_Click;
            // 
            // GreenWheels
            // 
            GreenWheels.AutoSize = true;
            GreenWheels.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GreenWheels.Location = new Point(300, 137);
            GreenWheels.Name = "GreenWheels";
            GreenWheels.Size = new Size(166, 29);
            GreenWheels.TabIndex = 2;
            GreenWheels.Text = "GreenWheels";
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(12, 415);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(75, 23);
            btnAvsluta.TabIndex = 3;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvsluta);
            Controls.Add(GreenWheels);
            Controls.Add(btnSkapaKonto);
            Controls.Add(btnLoggaIn);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoggaIn;
        private Button btnSkapaKonto;
        private Label GreenWheels;
        private Button btnAvsluta;
    }
}