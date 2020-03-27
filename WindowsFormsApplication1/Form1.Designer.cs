namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.filePanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.maska = new System.Windows.Forms.Button();
            this.Mono2 = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.Button();
            this.Prog = new System.Windows.Forms.Button();
            this.Mono = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filePanel.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(364, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 443);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 443);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 34);
            this.button7.TabIndex = 0;
            this.button7.Text = "File";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Import
            // 
            this.Import.AccessibleName = "import";
            this.Import.Location = new System.Drawing.Point(0, 34);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(85, 34);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(0, 67);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(85, 34);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // filePanel
            // 
            this.filePanel.Controls.Add(this.button7);
            this.filePanel.Controls.Add(this.Clear);
            this.filePanel.Controls.Add(this.Import);
            this.filePanel.Location = new System.Drawing.Point(5, 12);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(85, 34);
            this.filePanel.TabIndex = 3;
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.maska);
            this.toolPanel.Controls.Add(this.Mono2);
            this.toolPanel.Controls.Add(this.Tools);
            this.toolPanel.Controls.Add(this.Prog);
            this.toolPanel.Controls.Add(this.Mono);
            this.toolPanel.Location = new System.Drawing.Point(96, 12);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(85, 34);
            this.toolPanel.TabIndex = 4;
            // 
            // maska
            // 
            this.maska.Location = new System.Drawing.Point(0, 127);
            this.maska.Name = "maska";
            this.maska.Size = new System.Drawing.Size(85, 34);
            this.maska.TabIndex = 4;
            this.maska.Text = "Maska";
            this.maska.UseVisualStyleBackColor = true;
            this.maska.Click += new System.EventHandler(this.maska_Click);
            // 
            // Mono2
            // 
            this.Mono2.Location = new System.Drawing.Point(0, 67);
            this.Mono2.Name = "Mono2";
            this.Mono2.Size = new System.Drawing.Size(85, 34);
            this.Mono2.TabIndex = 3;
            this.Mono2.Text = "Mono2";
            this.Mono2.UseVisualStyleBackColor = true;
            this.Mono2.Click += new System.EventHandler(this.Mono2_Click);
            // 
            // Tools
            // 
            this.Tools.Location = new System.Drawing.Point(0, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(85, 34);
            this.Tools.TabIndex = 2;
            this.Tools.Text = "Tools";
            this.Tools.UseVisualStyleBackColor = true;
            this.Tools.Click += new System.EventHandler(this.Tools_Click);
            // 
            // Prog
            // 
            this.Prog.Location = new System.Drawing.Point(0, 97);
            this.Prog.Name = "Prog";
            this.Prog.Size = new System.Drawing.Size(85, 34);
            this.Prog.TabIndex = 1;
            this.Prog.Text = "Prog";
            this.Prog.UseVisualStyleBackColor = true;
            this.Prog.Click += new System.EventHandler(this.Prog_Click);
            // 
            // Mono
            // 
            this.Mono.Location = new System.Drawing.Point(0, 34);
            this.Mono.Name = "Mono";
            this.Mono.Size = new System.Drawing.Size(85, 34);
            this.Mono.TabIndex = 0;
            this.Mono.Text = "Mono";
            this.Mono.UseVisualStyleBackColor = true;
            this.Mono.Click += new System.EventHandler(this.Mono_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(661, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 34);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 495);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filePanel.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button Tools;
        private System.Windows.Forms.Button Prog;
        private System.Windows.Forms.Button Mono;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button Mono2;
        private System.Windows.Forms.Button maska;
    }
}

