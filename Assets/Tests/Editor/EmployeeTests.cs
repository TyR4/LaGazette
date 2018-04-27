using NUnit.Framework;
using System;

public class EmployeeTests
{

    [Test]
    public void Test_EmployeesHaveStartingWages()
    {
        int startingWage = 10;
        Employee employee = new Employee(startingWage, 0);
        Assert.AreEqual(startingWage, employee.Wage);
    }

    [Test]
    public void Test_EmployeesCannotHaveNegativeWage()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Employee(-10, 0));
    }

    [Test]
    public void Test_EmployeesHaveSkillLevels()
    {
        Employee employee = new Employee(10, 1);
        Assert.AreEqual(1, employee.SkillLevel);
    }

}
