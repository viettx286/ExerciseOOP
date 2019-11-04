namespace Exercise
{
    public interface IInfo
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        int NumberOfWorkDay { set; get; } 
        double Salary { get; }
    }
}