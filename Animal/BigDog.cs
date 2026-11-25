public class BigDog : Animal
{
    public BigDog(string Name):base(Name){}

    public override void Grets()
    {
        Console.WriteLine("Wooof");
    }
    public virtual void Grets(Dog another)
    {
        System.Console.WriteLine("Woooooow");
    }
    public void Grets(BigDog another)
    {
        System.Console.WriteLine("Wooooooooow");
    }
}