namespace wwmDev
{
    partial class DialogScore
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
            listBoxScore = new ListBox();
            SuspendLayout();
            // 
            // listBoxScore
            // 
            listBoxScore.FormattingEnabled = true;
            listBoxScore.ItemHeight = 25;
            listBoxScore.Location = new Point(12, 12);
            listBoxScore.Name = "listBoxScore";
            listBoxScore.Size = new Size(591, 329);
            listBoxScore.TabIndex = 0;
            // 
            // DialogScore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 352);
            Controls.Add(listBoxScore);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DialogScore";
            Text = "Name für die Highscore-Liste";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxScore;
    }
}