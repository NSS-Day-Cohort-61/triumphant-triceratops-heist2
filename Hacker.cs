namespace Heist_2
{
    public class Hacker : IRobber
    {
        public string Name { get; set;}
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}

        public string Specialty {get; set;}

        public Hacker(string newName, int newSkillLevel, int newPercentageCut)
        {
            this.Name = newName;
            this.SkillLevel = newSkillLevel;
            this.PercentageCut = newPercentageCut;
            this.Specialty = "Hacker";
        }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            System.Console.WriteLine($"{Name} is hacking the lock. Decreased vault security by {SkillLevel}");
            if (bank.AlarmScore <= 0)
            {
                System.Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}
