public class Staff : Person
{
    private string? School { get; set; }
    private double Pay { get; set; }

    public Staff(
        string Name,
        string Address,
        string School,
        double Pay
    ) : base(Name, Address)
    {
        this.School=School;
        this.Pay=Pay;
    }

    public virtual string GetSchool()
    {
        return $"{School}";
    }
    public virtual string Getpay()
    {
        return $"{Pay}";
    }

    public virtual void SetSchool(string school)
    {
        School=school;
    }

    public virtual double GetPay()
    {
        return Pay;
    }
    public virtual void SetPay(double pay)
    {
        Pay=pay;
    }
    public override string ToString()
    {
        return $"Staff[name={GetName()},address={GetAddress()}],school={School},pay={Pay}";
    }

}