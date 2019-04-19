using System;
using DomainModel.Business;
using Xunit;

namespace DomainModel.Tests
{
    public class MatchUnitTest
    {
        [Fact]
        public void Match_Score()
        {
            //arrange
            var match = new Match("1234", "Home", "Visitor");

            //act
            match.Start()
                .Goal(TeamId.Home)
                .Goal(TeamId.Home)
                .Goal(TeamId.Visitor)
                .Finish();

            //assert
            Assert.Equal(new Score(2, 1), match.CurrentScore);
        }
    }
}
