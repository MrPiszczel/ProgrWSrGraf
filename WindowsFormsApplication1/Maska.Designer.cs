namespace WindowsFormsApplication1
{
    partial class Maska
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
            this.pixel1 = new System.Windows.Forms.TextBox();
            this.pixel2 = new System.Windows.Forms.TextBox();
            this.pixel3 = new System.Windows.Forms.TextBox();
            this.pixel4 = new System.Windows.Forms.TextBox();
            this.pixel5 = new System.Windows.Forms.TextBox();
            this.pixel6 = new System.Windows.Forms.TextBox();
            this.pixel7 = new System.Windows.Forms.TextBox();
            this.pixel8 = new System.Windows.Forms.TextBox();
            this.pixel9 = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pixel1
            // 
            this.pixel1.Location = new System.Drawing.Point(62, 44);
            this.pixel1.Name = "pixel1";
            this.pixel1.Size = new System.Drawing.Size(30, 20);
            this.pixel1.TabIndex = 0;
            // 
            // pixel2
            // 
            this.pixel2.Location = new System.Drawing.Point(122, 44);
            this.pixel2.Name = "pixel2";
            this.pixel2.Size = new System.Drawing.Size(30, 20);
            this.pixel2.TabIndex = 1;
            // 
            // pixel3
            // 
            this.pixel3.Location = new System.Drawing.Point(180, 44);
            this.pixel3.Name = "pixel3";
            this.pixel3.Size = new System.Drawing.Size(30, 20);
            this.pixel3.TabIndex = 2;
            // 
            // pixel4
            // 
            this.pixel4.Location = new System.Drawing.Point(62, 90);
            this.pixel4.Name = "pixel4";
            this.pixel4.Size = new System.Drawing.Size(30, 20);
            this.pixel4.TabIndex = 3;
            // 
            // pixel5
            // 
            this.pixel5.Location = new System.Drawing.Point(122, 90);
            this.pixel5.Name = "pixel5";
            this.pixel5.Size = new System.Drawing.Size(30, 20);
            this.pixel5.TabIndex = 4;
            // 
            // pixel6
            // 
            this.pixel6.Location = new System.Drawing.Point(180, 90);
            this.pixel6.Name = "pixel6";
            this.pixel6.Size = new System.Drawing.Size(30, 20);
            this.pixel6.TabIndex = 5;
            // 
            // pixel7
            // 
            this.pixel7.Location = new System.Drawing.Point(62, 138);
            this.pixel7.Name = "pixel7";
            this.pixel7.Size = new System.Drawing.Size(30, 20);
            this.pixel7.TabIndex = 6;
            // 
            // pixel8
            // 
            this.pixel8.Location = new System.Drawing.Point(122, 138);
            this.pixel8.Name = "pixel8";
            this.pixel8.Size = new System.Drawing.Size(30, 20);
            this.pixel8.TabIndex = 7;
            // 
            // pixel9
            // 
            this.pixel9.Location = new System.Drawing.Point(180, 138);
            this.pixel9.Name = "pixel9";
            this.pixel9.Size = new System.Drawing.Size(30, 20);
            this.pixel9.TabIndex = 8;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(99, 197);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Accept";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Maska
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pixel9);
            this.Controls.Add(this.pixel8);
            this.Controls.Add(this.pixel7);
            this.Controls.Add(this.pixel6);
            this.Controls.Add(this.pixel5);
            this.Controls.Add(this.pixel4);
            this.Controls.Add(this.pixel3);
            this.Controls.Add(this.pixel2);
            this.Controls.Add(this.pixel1);
            this.Name = "Maska";
            this.Text = "Maska";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pixel1;
        private System.Windows.Forms.TextBox pixel2;
        private System.Windows.Forms.TextBox pixel3;
        private System.Windows.Forms.TextBox pixel4;
        private System.Windows.Forms.TextBox pixel5;
        private System.Windows.Forms.TextBox pixel6;
        private System.Windows.Forms.TextBox pixel7;
        private System.Windows.Forms.TextBox pixel8;
        private System.Windows.Forms.TextBox pixel9;
        private System.Windows.Forms.Button close;
    }
}