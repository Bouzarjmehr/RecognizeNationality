using RecognizeNationality.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace RecognizeNationality
{
    public class Helper
    {
        public bool CheckSelectionIsTrue(string PictureLocation, string Target)
        {
            if (PictureLocation.Contains(Target))
            {
                return true;
            }
            return false;
        }
        public string GetRandomPicture()
        {

            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string[] files = Directory.GetFiles(@"Nationalities\", "*.jpg");
            Random rnd = new Random();
            string rendomPicture = path + "\\" + files[rnd.Next(0, files.Length)];
            return rendomPicture;
        }

        public double GetDistance(Point source, Point target)
        {
            return Math.Sqrt((Math.Pow(Math.Abs(source.X - target.X), 2) + Math.Pow(Math.Abs(source.Y - target.Y), 2)));
        }

        public string GetDiraction(Point MainpictureBoxLocation, Point JapaneseLocation, Point ChinnesLocation, Point KoreanLocation, Point ThaiLocation)
        {
            List<Nationality> nationalities = new List<Nationality>();

            nationalities.Add(new Nationality()
            {
                Name = "JapaneseLocation",
                distince = GetDistance(MainpictureBoxLocation, JapaneseLocation)
            });

            nationalities.Add(new Nationality()
            {
                Name = "ChinnesLocation",
                distince = GetDistance(MainpictureBoxLocation, ChinnesLocation)
            });

            nationalities.Add(new Nationality()
            {
                Name = "KoreanLocation",
                distince = GetDistance(MainpictureBoxLocation, KoreanLocation)
            });

            nationalities.Add(new Nationality()
            {
                Name = "ThaiLocation",
                distince = GetDistance(MainpictureBoxLocation, ThaiLocation)
            });

            double distance = nationalities.Min(p => p.distince);
            List<Nationality> _nationality = nationalities.Where(x => x.distince == distance).ToList();

            return _nationality[0].Name;
        }

        public string CalculateScore(bool Result, int currentScope)
        {
            int score = 0;
            if (Result)
            {
                score = currentScope + 20;
            }
            else
            {
                score = currentScope - 5;
            }
            return score.ToString();
        }
    }
}
