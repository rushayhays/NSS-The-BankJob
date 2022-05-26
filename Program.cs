using System;
using System.Collections.Generic;

namespace TheBankJob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Okay, so on a scale of 1 to 100, how difficult is it to steal from this place?");
            int banksDifficulty = int.Parse(Console.ReadLine());
            
            //Here we initialize an empty crew and create the Bank
            Crew bigBadCrew = new Crew();
            Bank firstNationalFatCats = new Bank(banksDifficulty);

            Console.WriteLine("");
            Console.WriteLine("So's now we know what you's gonna rob, who's gonna help you's do the job?");
            Console.WriteLine("--------------------------------------------------------------------------");
            while(true)
            {
                Console.WriteLine($"Enter team member name, or push ENTER to finalize your crew");
                string memberName =  Console.ReadLine();
                if(memberName== "")
                {
                    break;
                }
                Console.WriteLine($"Enter team member skill level");
                int memberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter team member courage");
                double memberCourage = double.Parse(Console.ReadLine());

                TeamMember member = new TeamMember(memberName, memberSkillLevel, memberCourage);
                member.PrintTeamMember();

                Console.WriteLine($"Do add {member.Name} to your crew?(y/n)");
                
                string userResponse = Console.ReadLine();
                if(userResponse == "y")
                {
                    bigBadCrew.AddTeamMember(member);
                } 

            }

            Console.WriteLine("");

            //Noew we have a crew, we practice for the job
            Console.WriteLine("So's we got a crew, how many trial runs do you wann do?");
            int trialRuns = int.Parse(Console.ReadLine());

            //Create the a heist and run it the set amount of times
            Heist theJob = new Heist(bigBadCrew, firstNationalFatCats);

            for(int x= 0; x < trialRuns; x++)
            {
                theJob.RunHeist();
            }

            Console.WriteLine("Okay, pretty good practice there, let's see how you did.");
            List<int> howYouDid = theJob.GetRunStats(); 
            Console.WriteLine(@$"
            Total Runs: {howYouDid[2]}
            Successful Runs: {howYouDid[0]}
            Failed Runs: {howYouDid[1]}
            ");
            

    
                

            
        }
    }
}
