namespace Heist_2
{
    public class Muscle : IRobber
    {
        public string Name { get; set;}
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}

        public string Specialty {get; set;}

        public Muscle(string newName, int newSkillLevel, int newPercentageCut)
        {
            this.Name = newName;
            this.SkillLevel = newSkillLevel;
            this.PercentageCut = newPercentageCut;
            this.Specialty = "Muscle";
        }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            System.Console.WriteLine($"{Name} is choke slamming the security guard out {SkillLevel}");
            if (bank.SecurityGuardScore <= 0)
            {
                System.Console.WriteLine($"{Name} has rendered the security guard unconscious");
            }
        }
    }
}