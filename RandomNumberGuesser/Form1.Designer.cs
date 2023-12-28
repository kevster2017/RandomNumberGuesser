namespace RandomNumberGuesser
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
            btnGuess = new Button();
            txtNumGuess = new TextBox();
            lblNumber = new Label();
            txtOutput = new Label();
            btnStart = new Button();
            lblGuessed = new Label();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.DodgerBlue;
            btnGuess.FlatStyle = FlatStyle.Popup;
            btnGuess.ForeColor = SystemColors.ButtonHighlight;
            btnGuess.Location = new Point(164, 236);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(166, 69);
            btnGuess.TabIndex = 0;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += GuessNumber;
            // 
            // txtNumGuess
            // 
            txtNumGuess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumGuess.Location = new Point(125, 161);
            txtNumGuess.Name = "txtNumGuess";
            txtNumGuess.Size = new Size(238, 29);
            txtNumGuess.TabIndex = 2;
            txtNumGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber.Location = new Point(79, 112);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(355, 20);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "I am thinking of a number between: ";
            // 
            // txtOutput
            // 
            txtOutput.AutoSize = true;
            txtOutput.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtOutput.Location = new Point(566, 219);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(145, 50);
            txtOutput.TabIndex = 4;
            txtOutput.Text = "Output";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Location = new Point(187, 388);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 51);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start New Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblGuessed
            // 
            lblGuessed.AutoSize = true;
            lblGuessed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuessed.Location = new Point(582, 352);
            lblGuessed.Name = "lblGuessed";
            lblGuessed.Size = new Size(119, 15);
            lblGuessed.TabIndex = 6;
            lblGuessed.Text = "You guessed 0 times";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1001, 541);
            Controls.Add(lblGuessed);
            Controls.Add(btnStart);
            Controls.Add(txtOutput);
            Controls.Add(lblNumber);
            Controls.Add(txtNumGuess);
            Controls.Add(btnGuess);
            Name = "Form1";
            Text = "Number Guessing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuess;
        private Button btnReset;
        private TextBox txtNumGuess;
        private Label lblNumber;
        private Label Output;
        private Button btnStart;
        private Label lblGuessed;
        private Label txtOutput;
    }
}