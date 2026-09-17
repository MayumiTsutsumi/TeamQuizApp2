namespace TeamQuizApp2
{
    public class ScoreManager
    {
        public int CorrectCount { get; private set; }
        public int TotalCount { get; private set; }

        public void Record(bool isCorrect)
        {
            TotalCount++;
            if (isCorrect) CorrectCount++;
        }

        public string GetResult()
        {
            if (TotalCount == 0) return "正解数: 0 / 0 （正答率 0.0%）";

            double correctanswerate = GetCorrectAnswerRate();
            return $"正解数: {CorrectCount} / {TotalCount} （正答率 {correctanswerate:F1}%）";

        }

        public double GetCorrectAnswerRate()
        {
            return (double)CorrectCount / TotalCount * 100;
        }

        public void GetPrize()
        {
            string msg = "";
            double correctanswerate = GetCorrectAnswerRate();

            if (TotalCount == 10)
            {
                msg = "10回解答しました！\n";

                //正解率：100 % の場合→プラチナ賞
                if (correctanswerate >= 100)
                {
                    msg += "プラチナ賞です！";
                }
                //正解率：90 % 以上の場合→金賞
                else if (correctanswerate >= 90)
                {
                    msg += "金賞です！";
                }
                //正解率：70 % 以上の場合→銀賞
                else if (correctanswerate >= 70)
                {
                    msg += "銀賞です！";
                }
                //正解率：50 % 以上の場合→銅賞
                else if (correctanswerate >= 50)
                {
                    msg += "銅賞です！";
                }
                //その他：参加賞
                else
                {
                    msg += "参加賞です！";
                }
                MessageBox.Show(msg);
            }
        }
    }
}