using DataAccessLibrary;

namespace Application.Events
{
    public class BattleEvent
    {
        public static void BattleUpdate(HamsterModel Winner, HamsterModel Loser)
        {
            Winner.Games++;
            Winner.Wins++;
            Loser.Games++;
            Loser.Defeats++;
        }
    }
}
