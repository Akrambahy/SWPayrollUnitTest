using System;
using Xunit;
using SW.Payroll;
using Assert = Xunit.Assert;

namespace SW.Payroll.Tests;

public class Tests
{
    [Fact]
   
    public void CalculateBasicSalary_EmployHaveWeeks_ReturnsBasicSalary()
    {
        var employee = new Employee {Wage = 500m,WorkingDays = 20};

        var Salary = new SalarySlipProcessor();

        var actual = Salary.CalculateBasicSalary(employee);
        var exp = 10000m;
        Assert.Equal(exp, actual);
    }
    
    
}