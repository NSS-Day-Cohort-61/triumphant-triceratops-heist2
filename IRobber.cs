namespace Heist_2
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }

        int PercentageCut { get; set; }

        void PerformSkill(Bank bank);

        string Specialty {set; get; }
    }
}