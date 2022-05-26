using System;
using System.Collections.Generic;

namespace TheBankJob
{
    public class Heist
    {
        public Crew BankCrew{get;set;}
        public Bank PlaceToHit{get;set;}

        private int _skillTotal{
            get
            {
                return BankCrew.GetCrewSkill();
            }
        }
        private int _successfulRuns;
        private int _failedRuns;

        public Heist(Crew someCrew, Bank somePlace)
        {
            BankCrew = someCrew;
            PlaceToHit = somePlace;
            _successfulRuns = 0;
            _failedRuns = 0;
        }

        public void RunHeist()
        {
            int heistLuckValue = new Random().Next(-10, 11);
            int difficulty = PlaceToHit.GetDifficultyLevel();

            Console.WriteLine(@$"
            Here's the breakdown:
            Teams Skill Level:{_skillTotal}
            Banks Difficulty:{difficulty}
            How Lucky you're feeling: {heistLuckValue}
            ");

            if(_skillTotal > difficulty + heistLuckValue)
            {
                Console.WriteLine("Success");
                _successfulRuns +=1;
            }
            else
            {
                Console.WriteLine("Failure");
                _failedRuns += 1;
            }
        }
        public List<int> GetRunStats()
        {
            List<int> heistStats = new List<int>{_successfulRuns,_failedRuns, _successfulRuns + _failedRuns};
            return heistStats;
        }
    }
}