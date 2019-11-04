using System;

namespace Exercise
{
    public class Staffs : IInfo
    {
        public const double COEFFICIENT_SALARY = 2.2;
        public delegate void CheckFirstNameHandler();
        public event CheckFirstNameHandler CheckFirstName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfWorkDay { get; set; }
        public double Salary
        {
            get { return (NumberOfWorkDay * 100000) * COEFFICIENT_SALARY; }
        }
        

        public override string ToString()
        {
            return "Ten:" + FirstName + " " + LastName + "\t" + "Role: " + "Staff \t" + "Salary: " + String.Format("${0:0,0.00}", Salary); ;
        }
        
//        protected virtual void OnNumChanged()
//        {
//            CheckFirstName = FirstName;
//            if (FirstName == null)
//            {
//                ChangeNum();
//            }
//        }
    }
}