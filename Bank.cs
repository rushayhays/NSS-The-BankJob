using System;

namespace TheBankJob
{
    public class Bank
    {
        private int _difficultyLevel;

        public Bank(int theDifficulty)
        {
            _difficultyLevel = theDifficulty;
        }

        public int GetDifficultyLevel()
        {
            return _difficultyLevel;
        }
    }
}