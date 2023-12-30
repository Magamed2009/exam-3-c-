public abstract class Animal
{
    private string _name = Console.ReadLine();
    public string  Name{ get{return _name;} set{_name = value;}}
    public Animal(string name)
    {
        _name = name;
    } 
    public abstract void Greets();
}
public class Cat : Animal
{
    public Cat(string name)
    {
        Name = name;
    }
    public override void Greets()
    {
        System.Console.WriteLine("Meow");
    }
}
public class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
    }
    public override void Greets()
    {
        System.Console.WriteLine("Woof");
    }
    public void Greets(Dog another)
    {
        System.Console.WriteLine("Woooof");
    }
}
public class BigDog : Dog
{
    public BigDog (string name)
    {
        Name = name;
    }
    public override void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public void Greets(Dog another)
    {
        System.Console.WriteLine("WooooooW");
    }
    public void Greets(BigDog another)
    {
        System.Console.WriteLine("WoooooooooW");
    }
}