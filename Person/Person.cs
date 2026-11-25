public class Person
{
    private string? Name;
    private string? Address;

    public Person(string name,string address)
    {
        Name=name??"";
        Address=address??"";
    }
    public  string GetName()
    {
        return Name;
    }
    public string GetAddress()
    {
        return Address;
    }

    public virtual void SetAddress(string addres)
    {
        Console.WriteLine($"{addres}");
    }
    public virtual void SetName(string addres)
    {
        Console.WriteLine($"{addres}");
    }

    public virtual string ToString()
    {
       return $"Person[name={Name},addres={Address}";
    }


}