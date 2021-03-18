
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
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(105, 30);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 1;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxImie;
    }
}

