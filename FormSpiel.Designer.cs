namespace wwmDev
{
    partial class FormSpiel
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
            groupBox1 = new GroupBox();
            buttonSkip = new Button();
            buttonJocker7525 = new Button();
            buttonJoker5050 = new Button();
            buttonAntwort1 = new Button();
            buttonAnwort2 = new Button();
            buttonAnwort3 = new Button();
            buttonAntwort4 = new Button();
            label1 = new Label();
            labelNickName = new Label();
            checkedListBox1 = new CheckedListBox();
            labelFrage = new Label();
            label2 = new Label();
            buttonStart = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSkip);
            groupBox1.Controls.Add(buttonJocker7525);
            groupBox1.Controls.Add(buttonJoker5050);
            groupBox1.Location = new Point(45, 169);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(414, 631);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Joker";
            // 
            // buttonSkip
            // 
            buttonSkip.Location = new Point(58, 450);
            buttonSkip.Margin = new Padding(4, 2, 4, 2);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(267, 122);
            buttonSkip.TabIndex = 2;
            buttonSkip.TabStop = false;
            buttonSkip.Text = "skip";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // buttonJocker7525
            // 
            buttonJocker7525.Location = new Point(58, 282);
            buttonJocker7525.Margin = new Padding(4, 2, 4, 2);
            buttonJocker7525.Name = "buttonJocker7525";
            buttonJocker7525.Size = new Size(267, 122);
            buttonJocker7525.TabIndex = 1;
            buttonJocker7525.Text = "75/25";
            buttonJocker7525.UseVisualStyleBackColor = true;
            buttonJocker7525.Click += buttonJocker7525_Click;
            // 
            // buttonJoker5050
            // 
            buttonJoker5050.Location = new Point(58, 113);
            buttonJoker5050.Margin = new Padding(4, 2, 4, 2);
            buttonJoker5050.Name = "buttonJoker5050";
            buttonJoker5050.Size = new Size(267, 122);
            buttonJoker5050.TabIndex = 0;
            buttonJoker5050.Text = "50/50";
            buttonJoker5050.UseVisualStyleBackColor = true;
            buttonJoker5050.Click += buttonJoker5050_Click;
            // 
            // buttonAntwort1
            // 
            buttonAntwort1.Location = new Point(522, 375);
            buttonAntwort1.Margin = new Padding(4, 2, 4, 2);
            buttonAntwort1.Name = "buttonAntwort1";
            buttonAntwort1.Size = new Size(702, 137);
            buttonAntwort1.TabIndex = 1;
            buttonAntwort1.Text = "Antwort 1";
            buttonAntwort1.UseVisualStyleBackColor = true;
            buttonAntwort1.Click += buttonAuswertung;
            // 
            // buttonAnwort2
            // 
            buttonAnwort2.Location = new Point(1263, 375);
            buttonAnwort2.Margin = new Padding(4, 2, 4, 2);
            buttonAnwort2.Name = "buttonAnwort2";
            buttonAnwort2.Size = new Size(702, 137);
            buttonAnwort2.TabIndex = 2;
            buttonAnwort2.Text = "Antwort 2";
            buttonAnwort2.UseVisualStyleBackColor = true;
            buttonAnwort2.Click += buttonAuswertung;
            // 
            // buttonAnwort3
            // 
            buttonAnwort3.Location = new Point(522, 565);
            buttonAnwort3.Margin = new Padding(4, 2, 4, 2);
            buttonAnwort3.Name = "buttonAnwort3";
            buttonAnwort3.Size = new Size(702, 137);
            buttonAnwort3.TabIndex = 3;
            buttonAnwort3.Text = "Antwort 3";
            buttonAnwort3.UseVisualStyleBackColor = true;
            buttonAnwort3.Click += buttonAuswertung;
            // 
            // buttonAntwort4
            // 
            buttonAntwort4.Location = new Point(1263, 565);
            buttonAntwort4.Margin = new Padding(4, 2, 4, 2);
            buttonAntwort4.Name = "buttonAntwort4";
            buttonAntwort4.Size = new Size(702, 137);
            buttonAntwort4.TabIndex = 4;
            buttonAntwort4.Text = "Antwort 4";
            buttonAntwort4.UseVisualStyleBackColor = true;
            buttonAntwort4.Click += buttonAuswertung;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(457, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 51);
            label1.TabIndex = 5;
            label1.Text = "Spieler:";
            // 
            // labelNickName
            // 
            labelNickName.AutoSize = true;
            labelNickName.Font = new Font("Segoe UI", 14F);
            labelNickName.Location = new Point(639, 45);
            labelNickName.Margin = new Padding(4, 0, 4, 0);
            labelNickName.Name = "labelNickName";
            labelNickName.Size = new Size(184, 51);
            labelNickName.TabIndex = 6;
            labelNickName.Text = "nickname";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "5000", "1000", "200", "50" });
            checkedListBox1.Location = new Point(2070, 375);
            checkedListBox1.Margin = new Padding(4, 2, 4, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(418, 220);
            checkedListBox1.TabIndex = 7;
            // 
            // labelFrage
            // 
            labelFrage.AutoSize = true;
            labelFrage.Font = new Font("Segoe UI", 14F);
            labelFrage.Location = new Point(540, 247);
            labelFrage.Margin = new Padding(4, 0, 4, 0);
            labelFrage.Name = "labelFrage";
            labelFrage.Size = new Size(115, 51);
            labelFrage.TabIndex = 8;
            labelFrage.Text = "Frage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(540, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 51);
            label2.TabIndex = 9;
            label2.Text = "Frage:";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(1022, 816);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(537, 131);
            buttonStart.TabIndex = 10;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // FormSpiel
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2645, 1321);
            Controls.Add(buttonStart);
            Controls.Add(label2);
            Controls.Add(labelFrage);
            Controls.Add(checkedListBox1);
            Controls.Add(labelNickName);
            Controls.Add(label1);
            Controls.Add(buttonAntwort4);
            Controls.Add(buttonAnwort3);
            Controls.Add(buttonAnwort2);
            Controls.Add(buttonAntwort1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormSpiel";
            Text = "FormSpiel";
            Load += FormSpiel_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonSkip;
        private Button buttonJocker7525;
        private Button buttonJoker5050;
        private Button buttonAntwort1;
        private Button buttonAnwort2;
        private Button buttonAnwort3;
        private Button buttonAntwort4;
        private Label label1;
        private Label labelNickName;
        private CheckedListBox checkedListBox1;
        private Label labelFrage;
        private Label label2;
        private Button buttonStart;
    }
}