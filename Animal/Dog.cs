public class Dog : Animal
{
    public Dog(string Name):base(Name){}

    public override void Grets()
    {
        Console.WriteLine("Woof");
    }
    public void Grets(Dog another)
    {
        System.Console.WriteLine("Woooof");
    }
}