
namespace HelloWinFormsApp
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
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.labelWiek = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(131, 28);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 1;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labelImie.Location = new System.Drawing.Point(36, 31);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(30, 15);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "imię";
            this.labelImie.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(36, 79);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(55, 15);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "nazwisko";
            this.labelNazwisko.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(131, 75);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWiek.Location = new System.Drawing.Point(131, 117);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 23);
            this.textBoxWiek.TabIndex = 4;
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(36, 125);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(31, 15);
            this.labelWiek.TabIndex = 5;
            this.labelWiek.Text = "wiek\r\n";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(57, 177);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Kliknij";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(57, 241);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(74, 15);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "Komunikat 1";
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(175, 241);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(74, 15);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "Komunikat 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 318);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "Form1";
            this.Text = "Aplikacja Witaj!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

