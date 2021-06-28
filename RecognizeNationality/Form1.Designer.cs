
namespace RecognizeNationality
{
    partial class RecognizeNationality
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
            this.components = new System.ComponentModel.Container();
            this.lblJapanese = new System.Windows.Forms.Label();
            this.lblChinese = new System.Windows.Forms.Label();
            this.lblThai = new System.Windows.Forms.Label();
            this.PictureboxStepTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.MainpictureBox = new System.Windows.Forms.PictureBox();
            this.lblKorean = new System.Windows.Forms.Label();
            this.pictureBoxKorean = new System.Windows.Forms.PictureBox();
            this.pictureBoxThai = new System.Windows.Forms.PictureBox();
            this.pictureBoxJapanese = new System.Windows.Forms.PictureBox();
            this.pictureBoxChinese = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKorean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChinese)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJapanese
            // 
            this.lblJapanese.AutoSize = true;
            this.lblJapanese.BackColor = System.Drawing.Color.Transparent;
            this.lblJapanese.Location = new System.Drawing.Point(28, 106);
            this.lblJapanese.Name = "lblJapanese";
            this.lblJapanese.Size = new System.Drawing.Size(53, 13);
            this.lblJapanese.TabIndex = 0;
            this.lblJapanese.Text = "Japanese";
            // 
            // lblChinese
            // 
            this.lblChinese.AutoSize = true;
            this.lblChinese.BackColor = System.Drawing.Color.Transparent;
            this.lblChinese.Location = new System.Drawing.Point(923, 106);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(45, 13);
            this.lblChinese.TabIndex = 1;
            this.lblChinese.Text = "Chinese";
            // 
            // lblThai
            // 
            this.lblThai.AutoSize = true;
            this.lblThai.BackColor = System.Drawing.Color.Transparent;
            this.lblThai.Location = new System.Drawing.Point(923, 516);
            this.lblThai.Name = "lblThai";
            this.lblThai.Size = new System.Drawing.Size(28, 13);
            this.lblThai.TabIndex = 3;
            this.lblThai.Text = "Thai";
            // 
            // PictureboxStepTimer
            // 
            this.PictureboxStepTimer.Tick += new System.EventHandler(this.PictureboxStepTimer_Tick);
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(452, 3);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(71, 24);
            this.lblScoreTitle.TabIndex = 5;
            this.lblScoreTitle.Text = "Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(522, 7);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(18, 20);
            this.lblScoreValue.TabIndex = 6;
            this.lblScoreValue.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(499, 40);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainpictureBox
            // 
            this.MainpictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainpictureBox.Location = new System.Drawing.Point(424, 235);
            this.MainpictureBox.Name = "MainpictureBox";
            this.MainpictureBox.Size = new System.Drawing.Size(150, 150);
            this.MainpictureBox.TabIndex = 4;
            this.MainpictureBox.TabStop = false;
            this.MainpictureBox.Visible = false;
            this.MainpictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainpictureBox_MouseDown);
            this.MainpictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainpictureBox_MouseMove);
            // 
            // lblKorean
            // 
            this.lblKorean.AutoSize = true;
            this.lblKorean.BackColor = System.Drawing.Color.Transparent;
            this.lblKorean.Location = new System.Drawing.Point(28, 516);
            this.lblKorean.Name = "lblKorean";
            this.lblKorean.Size = new System.Drawing.Size(41, 13);
            this.lblKorean.TabIndex = 2;
            this.lblKorean.Text = "Korean";
            // 
            // pictureBoxKorean
            // 
            this.pictureBoxKorean.Image = global::RecognizeNationality.Properties.Resources.box;
            this.pictureBoxKorean.Location = new System.Drawing.Point(4, 532);
            this.pictureBoxKorean.Name = "pictureBoxKorean";
            this.pictureBoxKorean.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxKorean.TabIndex = 9;
            this.pictureBoxKorean.TabStop = false;
            // 
            // pictureBoxThai
            // 
            this.pictureBoxThai.Image = global::RecognizeNationality.Properties.Resources.box;
            this.pictureBoxThai.Location = new System.Drawing.Point(895, 532);
            this.pictureBoxThai.Name = "pictureBoxThai";
            this.pictureBoxThai.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxThai.TabIndex = 10;
            this.pictureBoxThai.TabStop = false;
            // 
            // pictureBoxJapanese
            // 
            this.pictureBoxJapanese.Image = global::RecognizeNationality.Properties.Resources.box;
            this.pictureBoxJapanese.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxJapanese.Name = "pictureBoxJapanese";
            this.pictureBoxJapanese.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxJapanese.TabIndex = 11;
            this.pictureBoxJapanese.TabStop = false;
            // 
            // pictureBoxChinese
            // 
            this.pictureBoxChinese.Image = global::RecognizeNationality.Properties.Resources.box;
            this.pictureBoxChinese.Location = new System.Drawing.Point(895, 3);
            this.pictureBoxChinese.Name = "pictureBoxChinese";
            this.pictureBoxChinese.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxChinese.TabIndex = 12;
            this.pictureBoxChinese.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(418, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // RecognizeNationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 635);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBoxChinese);
            this.Controls.Add(this.pictureBoxJapanese);
            this.Controls.Add(this.pictureBoxThai);
            this.Controls.Add(this.pictureBoxKorean);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.MainpictureBox);
            this.Controls.Add(this.lblThai);
            this.Controls.Add(this.lblKorean);
            this.Controls.Add(this.lblChinese);
            this.Controls.Add(this.lblJapanese);
            this.MaximizeBox = false;
            this.Name = "RecognizeNationality";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecognizeNationality";
            ((System.ComponentModel.ISupportInitialize)(this.MainpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKorean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJapanese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChinese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJapanese;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblKorean;
        private System.Windows.Forms.Label lblThai;
        private System.Windows.Forms.Timer PictureboxStepTimer;
        private System.Windows.Forms.PictureBox MainpictureBox;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBoxKorean;
        private System.Windows.Forms.PictureBox pictureBoxThai;
        private System.Windows.Forms.PictureBox pictureBoxJapanese;
        private System.Windows.Forms.PictureBox pictureBoxChinese;
        private System.Windows.Forms.Button btnStart;
    }
}

