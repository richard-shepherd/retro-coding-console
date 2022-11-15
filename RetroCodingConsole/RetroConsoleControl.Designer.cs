namespace RetroCodingConsole
{
    partial class RetroConsoleControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlSplitter = new System.Windows.Forms.SplitContainer();
            this.ctrlGroupBox_Screen = new System.Windows.Forms.GroupBox();
            this.ctrlGroupBox_Log = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSplitter)).BeginInit();
            this.ctrlSplitter.Panel1.SuspendLayout();
            this.ctrlSplitter.Panel2.SuspendLayout();
            this.ctrlSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlSplitter
            // 
            this.ctrlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlSplitter.Location = new System.Drawing.Point(0, 0);
            this.ctrlSplitter.Name = "ctrlSplitter";
            this.ctrlSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ctrlSplitter.Panel1
            // 
            this.ctrlSplitter.Panel1.Controls.Add(this.ctrlGroupBox_Screen);
            // 
            // ctrlSplitter.Panel2
            // 
            this.ctrlSplitter.Panel2.Controls.Add(this.ctrlGroupBox_Log);
            this.ctrlSplitter.Size = new System.Drawing.Size(832, 659);
            this.ctrlSplitter.SplitterDistance = 485;
            this.ctrlSplitter.TabIndex = 2;
            // 
            // ctrlGroupBox_Screen
            // 
            this.ctrlGroupBox_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlGroupBox_Screen.Location = new System.Drawing.Point(0, 0);
            this.ctrlGroupBox_Screen.Name = "ctrlGroupBox_Screen";
            this.ctrlGroupBox_Screen.Size = new System.Drawing.Size(832, 485);
            this.ctrlGroupBox_Screen.TabIndex = 1;
            this.ctrlGroupBox_Screen.TabStop = false;
            this.ctrlGroupBox_Screen.Text = "Screen";
            // 
            // ctrlGroupBox_Log
            // 
            this.ctrlGroupBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlGroupBox_Log.Location = new System.Drawing.Point(0, 0);
            this.ctrlGroupBox_Log.Name = "ctrlGroupBox_Log";
            this.ctrlGroupBox_Log.Size = new System.Drawing.Size(832, 170);
            this.ctrlGroupBox_Log.TabIndex = 2;
            this.ctrlGroupBox_Log.TabStop = false;
            this.ctrlGroupBox_Log.Text = "Log";
            // 
            // RetroConsoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlSplitter);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "RetroConsoleControl";
            this.Size = new System.Drawing.Size(832, 659);
            this.ctrlSplitter.Panel1.ResumeLayout(false);
            this.ctrlSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSplitter)).EndInit();
            this.ctrlSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer ctrlSplitter;
        private GroupBox ctrlGroupBox_Screen;
        private GroupBox ctrlGroupBox_Log;
    }
}