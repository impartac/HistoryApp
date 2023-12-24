namespace HistoryApp
{
    partial class Form2
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
            panel2 = new Panel();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Cursor = Cursors.SizeAll;
            panel2.Location = new Point(-1000, -1000);
            panel2.Name = "panel2";
            panel2.Size = new Size(10038, 10013);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
    }
}