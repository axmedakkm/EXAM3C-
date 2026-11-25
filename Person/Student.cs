public class Student : Person
{
    private string? Program;
    private int Year;
    private double Fee;

    public Student(
        string Name,
        string Address,
        string Program,
        int Year,
        double Fee
    ) : base(Name, Address)
    {
        this.Program = Program ?? "";
        this.Year = Year;
        this.Fee = Fee;
    }

    public virtual string GetProgram()
    {
        return Program;
    }
    public virtual void SetProgram(string pr)
    {
        Program=pr;
    }

    public  int GetYear()
    {
        return Year;
    }
    public  void SetYear(int year)
    {
        Year=year;
    }
    public  double GetFee()
    {
        return Fee;
    }
    public virtual void SetFee(double fee)
    {
        Fee=fee;
    }

    public override string ToString()
    {
       return $"Student[Student[name={GetName()},addres={GetAddress()}],programm={Program},year={Year},fee={Fee}]";
    }


}