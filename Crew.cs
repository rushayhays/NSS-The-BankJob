using System;
using System.Collections.Generic;

namespace TheBankJob
{
    public class Crew
    {
        List<TeamMember> theCrew = new List<TeamMember>();

        public void AddTeamMember(TeamMember newGuy)
        {
            theCrew.Add(newGuy);
        }
        public void PrintCrewCount()
        {
            Console.WriteLine($"Yous got {theCrew.Count} members on your team");
            foreach(TeamMember guy in theCrew)
            {
                Console.WriteLine(@$"
                Name: {guy.Name}
                Skill Level: {guy.SkillLevel}
                Courage Factor: {guy.CourageFactor}
                -----------------------------------
                ");

            }
        }
        public int GetCrewSkill()
        {   
            int totalSkill = 0;
            foreach(TeamMember person in theCrew)
            {
                totalSkill += person.SkillLevel;
            }
            return totalSkill;
        }
    }
}
