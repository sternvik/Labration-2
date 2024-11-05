namespace WinFormGUI
{
    partial class AdminForm
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
            btnLäggTillFordon = new Button();
            label1 = new Label();
            btnUppdateraFordon = new Button();
            btnTaBortFordon = new Button();
            btnAvsluta = new Button();
            SuspendLayout();
            // 
            // btnLäggTillFordon
            // 
            btnLäggTillFordon.Location = new Point(297, 134);
            btnLäggTillFordon.Name = "btnLäggTillFordon";
            btnLäggTillFordon.Size = new Size(147, 23);
            btnLäggTillFordon.TabIndex = 0;
            btnLäggTillFordon.Text = "Lägg till fordon";
            btnLäggTillFordon.UseVisualStyleBackColor = true;
            btnLäggTillFordon.Click += btnLäggTillFordon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 80);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 1;
            label1.Text = "Välkommen!";
            // 
            // btnUppdateraFordon
            // 
            btnUppdateraFordon.Location = new Point(297, 163);
            btnUppdateraFordon.Name = "btnUppdateraFordon";
            btnUppdateraFordon.Size = new Size(147, 23);
            btnUppdateraFordon.TabIndex = 2;
            btnUppdateraFordon.Text = "Uppdatera fordon";
            btnUppdateraFordon.UseVisualStyleBackColor = true;
            btnUppdateraFordon.Click += btnUppdateraFordon_Click;
            // 
            // btnTaBortFordon
            // 
            btnTaBortFordon.Location = new Point(297, 192);
            btnTaBortFordon.Name = "btnTaBortFordon";
            btnTaBortFordon.Size = new Size(147, 23);
            btnTaBortFordon.TabIndex = 3;
            btnTaBortFordon.Text = "Ta bort fordon";
            btnTaBortFordon.UseVisualStyleBackColor = true;
            btnTaBortFordon.Click += btnTaBortFordon_Click;
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(297, 221);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(147, 23);
            btnAvsluta.TabIndex = 4;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvsluta);
            Controls.Add(btnTaBortFordon);
            Controls.Add(btnUppdateraFordon);
            Controls.Add(label1);
            Controls.Add(btnLäggTillFordon);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLäggTillFordon;
        private Label label1;
        private Button btnUppdateraFordon;
        private Button btnTaBortFordon;
        private Button btnAvsluta;
    }
}