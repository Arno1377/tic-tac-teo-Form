namespace tic_tac_teo_Form
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lblplayer1 = new Label();
            lblplayer2 = new Label();
            lblplayer1moves = new Label();
            lblplayer1games = new Label();
            lblplayer1wins = new Label();
            lblplayer2moves = new Label();
            lblplayer2games = new Label();
            lblplayer2wins = new Label();
            lblplayer1M = new Label();
            lblplayer2M = new Label();
            lblplayer1G = new Label();
            lblplayer2G = new Label();
            lblplayer1W = new Label();
            lblplayer2W = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 12);
            btn1.Name = "btn1";
            btn1.Size = new Size(186, 167);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnclick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(204, 12);
            btn2.Name = "btn2";
            btn2.Size = new Size(186, 167);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnclick;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(396, 12);
            btn3.Name = "btn3";
            btn3.Size = new Size(186, 167);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnclick;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 185);
            btn4.Name = "btn4";
            btn4.Size = new Size(186, 167);
            btn4.TabIndex = 5;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnclick;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(204, 185);
            btn5.Name = "btn5";
            btn5.Size = new Size(186, 167);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnclick;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(396, 185);
            btn6.Name = "btn6";
            btn6.Size = new Size(186, 167);
            btn6.TabIndex = 3;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnclick;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 358);
            btn7.Name = "btn7";
            btn7.Size = new Size(186, 167);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnclick;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(204, 358);
            btn8.Name = "btn8";
            btn8.Size = new Size(186, 167);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnclick;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(396, 358);
            btn9.Name = "btn9";
            btn9.Size = new Size(186, 167);
            btn9.TabIndex = 6;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnclick;
            // 
            // lblplayer1
            // 
            lblplayer1.AutoSize = true;
            lblplayer1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblplayer1.Location = new Point(12, 558);
            lblplayer1.Name = "lblplayer1";
            lblplayer1.Size = new Size(111, 31);
            lblplayer1.TabIndex = 9;
            lblplayer1.Text = "Player 1 :";
            // 
            // lblplayer2
            // 
            lblplayer2.AutoSize = true;
            lblplayer2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblplayer2.Location = new Point(12, 619);
            lblplayer2.Name = "lblplayer2";
            lblplayer2.Size = new Size(117, 31);
            lblplayer2.TabIndex = 10;
            lblplayer2.Text = "Player 2 : ";
            // 
            // lblplayer1moves
            // 
            lblplayer1moves.AutoSize = true;
            lblplayer1moves.Location = new Point(204, 567);
            lblplayer1moves.Name = "lblplayer1moves";
            lblplayer1moves.Size = new Size(17, 20);
            lblplayer1moves.TabIndex = 11;
            lblplayer1moves.Text = "0";
            // 
            // lblplayer1games
            // 
            lblplayer1games.AutoSize = true;
            lblplayer1games.Location = new Point(349, 567);
            lblplayer1games.Name = "lblplayer1games";
            lblplayer1games.Size = new Size(17, 20);
            lblplayer1games.TabIndex = 12;
            lblplayer1games.Text = "0";
            // 
            // lblplayer1wins
            // 
            lblplayer1wins.AutoSize = true;
            lblplayer1wins.Location = new Point(510, 567);
            lblplayer1wins.Name = "lblplayer1wins";
            lblplayer1wins.Size = new Size(17, 20);
            lblplayer1wins.TabIndex = 13;
            lblplayer1wins.Text = "0";
            // 
            // lblplayer2moves
            // 
            lblplayer2moves.AutoSize = true;
            lblplayer2moves.Location = new Point(204, 630);
            lblplayer2moves.Name = "lblplayer2moves";
            lblplayer2moves.Size = new Size(17, 20);
            lblplayer2moves.TabIndex = 14;
            lblplayer2moves.Text = "0";
            // 
            // lblplayer2games
            // 
            lblplayer2games.AutoSize = true;
            lblplayer2games.Location = new Point(349, 628);
            lblplayer2games.Name = "lblplayer2games";
            lblplayer2games.Size = new Size(17, 20);
            lblplayer2games.TabIndex = 15;
            lblplayer2games.Text = "0";
            // 
            // lblplayer2wins
            // 
            lblplayer2wins.AutoSize = true;
            lblplayer2wins.Location = new Point(510, 630);
            lblplayer2wins.Name = "lblplayer2wins";
            lblplayer2wins.Size = new Size(17, 20);
            lblplayer2wins.TabIndex = 16;
            lblplayer2wins.Text = "0";
            // 
            // lblplayer1M
            // 
            lblplayer1M.AutoSize = true;
            lblplayer1M.Location = new Point(130, 567);
            lblplayer1M.Name = "lblplayer1M";
            lblplayer1M.Size = new Size(63, 20);
            lblplayer1M.TabIndex = 17;
            lblplayer1M.Text = "Moves : ";
            // 
            // lblplayer2M
            // 
            lblplayer2M.AutoSize = true;
            lblplayer2M.Location = new Point(130, 630);
            lblplayer2M.Name = "lblplayer2M";
            lblplayer2M.Size = new Size(63, 20);
            lblplayer2M.TabIndex = 18;
            lblplayer2M.Text = "Moves : ";
            // 
            // lblplayer1G
            // 
            lblplayer1G.AutoSize = true;
            lblplayer1G.Location = new Point(278, 567);
            lblplayer1G.Name = "lblplayer1G";
            lblplayer1G.Size = new Size(65, 20);
            lblplayer1G.TabIndex = 19;
            lblplayer1G.Text = "Games : ";
            // 
            // lblplayer2G
            // 
            lblplayer2G.AutoSize = true;
            lblplayer2G.Location = new Point(278, 630);
            lblplayer2G.Name = "lblplayer2G";
            lblplayer2G.Size = new Size(65, 20);
            lblplayer2G.TabIndex = 20;
            lblplayer2G.Text = "Games : ";
            // 
            // lblplayer1W
            // 
            lblplayer1W.AutoSize = true;
            lblplayer1W.Location = new Point(432, 567);
            lblplayer1W.Name = "lblplayer1W";
            lblplayer1W.Size = new Size(52, 20);
            lblplayer1W.TabIndex = 21;
            lblplayer1W.Text = "Wins : ";
            // 
            // lblplayer2W
            // 
            lblplayer2W.AutoSize = true;
            lblplayer2W.Location = new Point(432, 630);
            lblplayer2W.Name = "lblplayer2W";
            lblplayer2W.Size = new Size(52, 20);
            lblplayer2W.TabIndex = 22;
            lblplayer2W.Text = "Wins : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 688);
            Controls.Add(lblplayer2W);
            Controls.Add(lblplayer1W);
            Controls.Add(lblplayer2G);
            Controls.Add(lblplayer1G);
            Controls.Add(lblplayer2M);
            Controls.Add(lblplayer1M);
            Controls.Add(lblplayer2wins);
            Controls.Add(lblplayer2games);
            Controls.Add(lblplayer2moves);
            Controls.Add(lblplayer1wins);
            Controls.Add(lblplayer1games);
            Controls.Add(lblplayer1moves);
            Controls.Add(lblplayer2);
            Controls.Add(lblplayer1);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lblplayer1;
        private Label lblplayer2;
        private Label lblplayer1moves;
        private Label lblplayer1games;
        private Label lblplayer1wins;
        private Label lblplayer2moves;
        private Label lblplayer2games;
        private Label lblplayer2wins;
        private Label lblplayer1M;
        private Label lblplayer2M;
        private Label lblplayer1G;
        private Label lblplayer2G;
        private Label lblplayer1W;
        private Label lblplayer2W;
    }
}