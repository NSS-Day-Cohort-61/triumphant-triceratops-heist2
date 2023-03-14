namespace Heist_2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set;}
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}
        public string Specialty { get ; set ; }
        

        public LockSpecialist(string newName, int newSkillLevel, int newPercentageCut)
        {
            this.Name = newName;
            this.SkillLevel = newSkillLevel;
            this.PercentageCut = newPercentageCut;
            this.Specialty = "LockSpecialist";
        }

    

        public void PerformSkill(Bank bank)
        {

            /*
            1. Take the Bank parameter and decrement its appropriate security score by the SkillLevel. i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
            
            2. Print to the console the name of the robber and what action they are performing. i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
            
            3. If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"    
            */
            bank.VaultScore -= SkillLevel;
            System.Console.WriteLine($"{Name} is hacking the lock. Decreased vault security by {SkillLevel}");
            if (bank.VaultScore <= 0)
            {
                System.Console.WriteLine($"{Name} has hacked the lock!");
            }
        }
    }
}