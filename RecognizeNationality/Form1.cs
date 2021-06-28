using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecognizeNationality
{
    public partial class RecognizeNationality : Form
    {

        private Point JapaneseLocation;
        private Point ChinnesLocation;
        private Point KoreanLocation;
        private Point ThaiLocation;

        private Point MouseDownLocation;
        private Point PictureBoxFirstLocation;

        private bool IsMouseDown = false;
        private bool IsCurrectSelection = false;

        private int TimerStepAfterMouseDown = 0;
        private int TimerStepWithoutMouseDown = 0;
        public int PictureGenerationCount = 0;

        Helper helper = new Helper();

        public RecognizeNationality()
        {
            InitializeComponent();
        }

        private void PictureboxStepTimer_Tick(object sender, EventArgs e)
        {
            if (PictureGenerationCount > 10)
            {
                MainpictureBox.Visible = false;
                PictureGenerationCount = 0;
                TimerStepAfterMouseDown = 0;
                TimerStepWithoutMouseDown = 0;
                PictureboxStepTimer.Stop();
            }

            if (IsMouseDown == true)
            {
                var directionPath = helper.GetDiraction(MainpictureBox.Location, JapaneseLocation, ChinnesLocation, KoreanLocation, ThaiLocation);
                switch (directionPath)
                {
                    case "JapaneseLocation":
                        MainpictureBox.Location = new Point((MainpictureBox.Location.X - 10), (MainpictureBox.Location.Y - 10));
                        IsCurrectSelection = helper.CheckSelectionIsTrue(MainpictureBox.ImageLocation, "Japanese");
                        TimerStepAfterMouseDown++;
                        break;
                    case "ChinnesLocation":
                        MainpictureBox.Location = new Point((MainpictureBox.Location.X + 10), (MainpictureBox.Location.Y - 10));
                        IsCurrectSelection = helper.CheckSelectionIsTrue(MainpictureBox.ImageLocation, "Chinnes");
                        TimerStepAfterMouseDown++;
                        break;
                    case "KoreanLocation":
                        MainpictureBox.Location = new Point((MainpictureBox.Location.X - 10), (MainpictureBox.Location.Y + 10));
                        IsCurrectSelection = helper.CheckSelectionIsTrue(MainpictureBox.ImageLocation, "Korean");
                        TimerStepAfterMouseDown++;
                        break;
                    case "ThaiLocation":
                        MainpictureBox.Location = new Point((MainpictureBox.Location.X + 10), (MainpictureBox.Location.Y + 10));
                        IsCurrectSelection = helper.CheckSelectionIsTrue(MainpictureBox.ImageLocation, "Thai");
                        TimerStepAfterMouseDown++;
                        break;
                }

                if (TimerStepAfterMouseDown == 20)
                {
                    lblScoreValue.Text = helper.CalculateScore(IsCurrectSelection, Convert.ToInt32(lblScoreValue.Text));
                    PictureboxStepTimer.Stop();
                    IsMouseDown = false;
                    TimerStepAfterMouseDown = 0;
                    MainpictureBox.Location = PictureBoxFirstLocation;
                    MainpictureBox.ImageLocation = helper.GetRandomPicture();
                    PictureGenerationCount++;
                    PictureboxStepTimer.Start();
                }
            }
            else
            {
                MainpictureBox.Location = new Point(MainpictureBox.Location.X, MainpictureBox.Location.Y + 10);
                if (TimerStepWithoutMouseDown == 40)
                {
                    TimerStepWithoutMouseDown = 0;
                    MainpictureBox.Location = PictureBoxFirstLocation;
                }
                TimerStepWithoutMouseDown++;
            }
        }

        #region Events
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (PictureGenerationCount > 10)
            {
                MessageBox.Show("You Should Reset Game");
            }

            PictureBoxFirstLocation = MainpictureBox.Location;
            MainpictureBox.Visible = true;
            MainpictureBox.ImageLocation = helper.GetRandomPicture();
            PictureGenerationCount++;
            PictureboxStepTimer.Start();
            MainpictureBox.AllowDrop = true;
            JapaneseLocation = pictureBoxJapanese.Location;
            ChinnesLocation = pictureBoxChinese.Location;
            KoreanLocation = pictureBoxKorean.Location;
            ThaiLocation = pictureBoxThai.Location;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RecognizeNationality NewForm = new RecognizeNationality();
            NewForm.Show();
            this.Dispose(false);
        }

        private void MainpictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                IsMouseDown = true;
            }
        }

        private void MainpictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MainpictureBox.Left = e.X + MainpictureBox.Left - MouseDownLocation.X;
                MainpictureBox.Top = e.Y + MainpictureBox.Top - MouseDownLocation.Y;
            }
        }

        #endregion
    }
}