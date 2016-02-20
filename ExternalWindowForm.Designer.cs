namespace ExternalMDIChild
{
    partial class ExternalWindowForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NotepadMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PaintMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuButton,
            this.ProgramsMenuButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuButton
            // 
            this.FileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuButton});
            this.FileMenuButton.Name = "FileMenuButton";
            this.FileMenuButton.Size = new System.Drawing.Size(37, 20);
            this.FileMenuButton.Text = "File";
            // 
            // ExitMenuButton
            // 
            this.ExitMenuButton.Name = "ExitMenuButton";
            this.ExitMenuButton.Size = new System.Drawing.Size(92, 22);
            this.ExitMenuButton.Text = "Exit";
            this.ExitMenuButton.Click += new System.EventHandler(this.ExitMenuButton_Click);
            // 
            // ProgramsMenuButton
            // 
            this.ProgramsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotepadMenuButton,
            this.CalculatorMenuButton,
            this.PaintMenuButton});
            this.ProgramsMenuButton.Name = "ProgramsMenuButton";
            this.ProgramsMenuButton.Size = new System.Drawing.Size(70, 20);
            this.ProgramsMenuButton.Text = "Programs";
            // 
            // NotepadMenuButton
            // 
            this.NotepadMenuButton.Name = "NotepadMenuButton";
            this.NotepadMenuButton.Size = new System.Drawing.Size(156, 22);
            this.NotepadMenuButton.Text = "Notepad";
            this.NotepadMenuButton.Click += new System.EventHandler(this.NotepadMenuButton_Click);
            // 
            // CalculatorMenuButton
            // 
            this.CalculatorMenuButton.Name = "CalculatorMenuButton";
            this.CalculatorMenuButton.Size = new System.Drawing.Size(156, 22);
            this.CalculatorMenuButton.Text = "Calculator";
            this.CalculatorMenuButton.Click += new System.EventHandler(this.CalculatorMenuButton_Click);
            // 
            // PaintMenuButton
            // 
            this.PaintMenuButton.Name = "PaintMenuButton";
            this.PaintMenuButton.Size = new System.Drawing.Size(152, 22);
            this.PaintMenuButton.Text = "Paint";
            this.PaintMenuButton.Click += new System.EventHandler(this.CommandLineMenuButton_Click);
            // 
            // WindowContainer
            // 
            this.WindowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowContainer.Location = new System.Drawing.Point(0, 24);
            this.WindowContainer.Name = "WindowContainer";
            this.WindowContainer.Size = new System.Drawing.Size(825, 489);
            this.WindowContainer.TabIndex = 3;
            // 
            // ExternalWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 535);
            this.Controls.Add(this.WindowContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExternalWindowForm";
            this.Text = "ExternalMDIChild";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ProgramsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem NotepadMenuButton;
        private System.Windows.Forms.Panel WindowContainer;
        private System.Windows.Forms.ToolStripMenuItem CalculatorMenuButton;
        private System.Windows.Forms.ToolStripMenuItem PaintMenuButton;
    }
}

