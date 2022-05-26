using System;

namespace TheBankJob
{
    public class TeamMember
    {
        public string Name{get;set;}
        public int SkillLevel{get;set;}
        public double CourageFactor{get;set;}

        public TeamMember(string aName, int aSkillLevel, double aCourageFactor)
        {
            Name= aName;
            SkillLevel= aSkillLevel;
            CourageFactor= aCourageFactor;
        }

        public string PrintTeamMember()
        {
            return $"{Name} has a skill level of {SkillLevel} and a courage factor of {CourageFactor}";
        }
    }
}