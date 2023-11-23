namespace label_progress_issue
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
            startProgressButton = new Button();
            progressLabel = new Label();
            SuspendLayout();
            // 
            // startProgressButton
            // 
            startProgressButton.Location = new Point(63, 51);
            startProgressButton.Name = "startProgressButton";
            startProgressButton.Size = new Size(75, 23);
            startProgressButton.TabIndex = 0;
            startProgressButton.Text = "Start";
            startProgressButton.UseVisualStyleBackColor = true;
            startProgressButton.Click += startProgressButton_Click;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(63, 87);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(39, 15);
            progressLabel.TabIndex = 1;
            progressLabel.Text = "Step 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 277);
            Controls.Add(progressLabel);
            Controls.Add(startProgressButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startProgressButton;
        private Label progressLabel;
    }
}