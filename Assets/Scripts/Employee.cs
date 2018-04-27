using System;

public class Employee
{

    public double Wage { get; private set; }
    public int SkillLevel { get; private set; }

    public Employee(int startingWage, int skillLevel)
    {
        if (startingWage < 0)
            throw new ArgumentOutOfRangeException();

        this.Wage = startingWage;
        this.SkillLevel = skillLevel;
    }

}