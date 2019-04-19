namespace DomainModel.Business
{
    public sealed class Score
    {
        public Score(int goals1, int goals2)
        {
            TotalGoal1 = goals1;
            TotalGoals2 = goals2;
        }

        public int TotalGoal1 { get; private set; }
        public int TotalGoals2 { get; private set; }

        public override bool Equals(object obj)
        {
            var otherScore = obj as Score;
            if (otherScore == null)
                return false;

            return otherScore.TotalGoal1 == TotalGoal1 &&
                   otherScore.TotalGoals2 == TotalGoals2;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}