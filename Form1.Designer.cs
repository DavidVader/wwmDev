namespace wwmDev
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
            buttonSpielStart = new Button();
            buttonZeigeHighSocre = new Button();
            buttonAdmin = new Button();
            SuspendLayout();
            // 
            // buttonSpielStart
            // 
            buttonSpielStart.Location = new Point(279, 54);
            buttonSpielStart.Name = "buttonSpielStart";
            buttonSpielStart.Size = new Size(234, 92);
            buttonSpielStart.TabIndex = 0;
            buttonSpielStart.Text = "Spiel starten";
            buttonSpielStart.UseVisualStyleBackColor = true;
            buttonSpielStart.Click += buttonSpielStart_Click;
            // 
            // buttonZeigeHighSocre
            // 
            buttonZeigeHighSocre.Location = new Point(283, 179);
            buttonZeigeHighSocre.Name = "buttonZeigeHighSocre";
            buttonZeigeHighSocre.Size = new Size(234, 92);
            buttonZeigeHighSocre.TabIndex = 1;
            buttonZeigeHighSocre.Text = "Highscore";
            buttonZeigeHighSocre.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(283, 312);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(234, 92);
            buttonAdmin.TabIndex = 2;
            buttonAdmin.Text = "Administration";
            buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonZeigeHighSocre);
            Controls.Add(buttonSpielStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSpielStart;
        private Button buttonZeigeHighSocre;
        private Button buttonAdmin;
    }
}
