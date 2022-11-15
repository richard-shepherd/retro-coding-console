namespace TestApp
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
            this.retroConsoleControl1 = new RetroCodingConsole.RetroConsoleControl();
            this.SuspendLayout();
            // 
            // retroConsoleControl1
            // 
            this.retroConsoleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retroConsoleControl1.Location = new System.Drawing.Point(0, 0);
            this.retroConsoleControl1.Margin = new System.Windows.Forms.Padding(1);
            this.retroConsoleControl1.Name = "retroConsoleControl1";
            this.retroConsoleControl1.Size = new System.Drawing.Size(835, 637);
            this.retroConsoleControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 637);
            this.Controls.Add(this.retroConsoleControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RetroCodingConsole.RetroConsoleControl retroConsoleControl1;
    }
}