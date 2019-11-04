using System;

namespace Exercise
{
    public class Managers : IInfo
    {
        public const double COEFFICIENT_SALARY = 4.6;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfWorkDay { get; set; }
        public double Salary
        {
            get { return (NumberOfWorkDay * 100000) * COEFFICIENT_SALARY; }
        }
        public override string ToString()
        {
            return "Ten:" + FirstName + " " + LastName + "\t" + "Role: " + "Manager \t" + "Salary: " +
                   String.Format("${0:0,0.00}", Salary);
        }
    }
}