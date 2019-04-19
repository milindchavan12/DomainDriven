using System;
using DomainModel.Extensions;

namespace DomainModel.Business
{
    public class Match
    {
        public Match(string id, string team1, string team2)
        {
            Id = id;
            Team1 = team1;
            Team2 = team2;
        }

        public string Id { get; private set; }
        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public MatchState State { get; internal set; }
        public Score CurrentScore { get; internal set; }
        public bool IsBallInPlay { get; internal set; }
        public int CurrentPeriod { get; internal set; }

        public bool IsInProgress()
        {
            return false;
        }

        #region Behaviour

        public Match Start()
        {
            CurrentScore = new Score(0, 0);
            State = MatchState.InProgress;
            return this;
        }

        public void Finish()
        {
            State = MatchState.Finished;
        }

        public Match Goal(TeamId id)
        {
            if(id == TeamId.Home)
            {
                CurrentScore = new Score(CurrentScore.TotalGoal1.Increment(), CurrentScore.TotalGoals2);
            }

            if (id == TeamId.Visitor)
            {
                CurrentScore = new Score(CurrentScore.TotalGoal1, CurrentScore.TotalGoals2.Increment());
            }
            return this;
        }
        #endregion
    }
}
