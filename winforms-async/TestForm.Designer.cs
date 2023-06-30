namespace winforms_async
{
    partial class TestForm
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
            this.textBoxAsync1 = new winforms_async.TextBoxAsync();
            this.SuspendLayout();
            // 
            // textBoxAsync1
            // 
            this.textBoxAsync1.Enabled = false;
            this.textBoxAsync1.Location = new System.Drawing.Point(96, 27);
            this.textBoxAsync1.Name = "textBoxAsync1";
            this.textBoxAsync1.Size = new System.Drawing.Size(150, 31);
            this.textBoxAsync1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 286);
            this.Controls.Add(this.textBoxAsync1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxAsync textBoxAsync1;
    }
}