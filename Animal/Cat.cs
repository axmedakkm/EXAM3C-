public class Cat : Animal
{
    public Cat(string Name):base(Name){}

    public override void Grets()
    {
        Console.WriteLine("Meow");
    }
}