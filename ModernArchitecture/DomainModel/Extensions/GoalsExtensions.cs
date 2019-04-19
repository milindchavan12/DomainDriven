using System;
namespace DomainModel.Extensions
{
    public static class GoalsExtensions
    {
        public static int Increment(this int goal)
        {
            return goal++;
        }
    }
}
