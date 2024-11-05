namespace WinFormGUI
{
    partial class AnvändareForm
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
            btnHyraFordon = new Button();
            btnAvslutaHyra = new Button();
            btnRapporteraFordon = new Button();
            btnVisaHyreshistorik = new Button();
            btnLäggTillBetalningsmetod = new Button();
            btnAvsluta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 94);
            label1.Name = "label1";
            label1.Size = new Size(154, 29);
            label1.TabIndex = 0;
            label1.Text = "Välkommen!";
            // 
            // btnHyraFordon
            // 
            btnHyraFordon.Location = new Point(281, 148);
            btnHyraFordon.Name = "btnHyraFordon";
            btnHyraFordon.Size = new Size(154, 23);
            btnHyraFordon.TabIndex = 1;
            btnHyraFordon.Text = "Hyra fordon";
            btnHyraFordon.UseVisualStyleBackColor = true;
            btnHyraFordon.Click += btnHyraFordon_Click;
            // 
            // btnAvslutaHyra
            // 
            btnAvslutaHyra.Location = new Point(281, 177);
            btnAvslutaHyra.Name = "btnAvslutaHyra";
            btnAvslutaHyra.Size = new Size(154, 23);
            btnAvslutaHyra.TabIndex = 2;
            btnAvslutaHyra.Text = "Avsluta Hyrning";
            btnAvslutaHyra.UseVisualStyleBackColor = true;
            btnAvslutaHyra.Click += btnAvslutaHyra_Click;
            // 
            // btnRapporteraFordon
            // 
            btnRapporteraFordon.Location = new Point(281, 206);
            btnRapporteraFordon.Name = "btnRapporteraFordon";
            btnRapporteraFordon.Size = new Size(154, 23);
            btnRapporteraFordon.TabIndex = 3;
            btnRapporteraFordon.Text = "Rapportera fordon";
            btnRapporteraFordon.UseVisualStyleBackColor = true;
            btnRapporteraFordon.Click += btnRapporteraFordon_Click;
            // 
            // btnVisaHyreshistorik
            // 
            btnVisaHyreshistorik.Location = new Point(281, 235);
            btnVisaHyreshistorik.Name = "btnVisaHyreshistorik";
            btnVisaHyreshistorik.Size = new Size(154, 23);
            btnVisaHyreshistorik.TabIndex = 4;
            btnVisaHyreshistorik.Text = "Visa hyreshistorik";
            btnVisaHyreshistorik.UseVisualStyleBackColor = true;
            btnVisaHyreshistorik.Click += btnVisaHyreshistorik_Click;
            // 
            // btnLäggTillBetalningsmetod
            // 
            btnLäggTillBetalningsmetod.Location = new Point(281, 264);
            btnLäggTillBetalningsmetod.Name = "btnLäggTillBetalningsmetod";
            btnLäggTillBetalningsmetod.Size = new Size(154, 23);
            btnLäggTillBetalningsmetod.TabIndex = 5;
            btnLäggTillBetalningsmetod.Text = "Lägg till betalningsmetod";
            btnLäggTillBetalningsmetod.UseVisualStyleBackColor = true;
            btnLäggTillBetalningsmetod.Click += btnLäggTillBetalningsmetod_Click;
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(281, 293);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(154, 23);
            btnAvsluta.TabIndex = 6;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // AnvändareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvsluta);
            Controls.Add(btnLäggTillBetalningsmetod);
            Controls.Add(btnVisaHyreshistorik);
            Controls.Add(btnRapporteraFordon);
            Controls.Add(btnAvslutaHyra);
            Controls.Add(btnHyraFordon);
            Controls.Add(label1);
            Name = "AnvändareForm";
            Text = "AnvändareForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHyraFordon;
        private Button btnAvslutaHyra;
        private Button btnRapporteraFordon;
        private Button btnVisaHyreshistorik;
        private Button btnLäggTillBetalningsmetod;
        private Button btnAvsluta;
    }
}