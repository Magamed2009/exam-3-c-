class Person
{
    private string name = Console.ReadLine();
    private string address = Console.ReadLine();
    public string Name { get{return name;} set{name = value;} }
    public string Address { get{return address;} set{name = value;} }
    public Person(string name,string address)
    {
        Name = name;
        Address = address;   
    }
    public string GetName()
    {
        return $"{Name}";
    }
    public string GetAddress()
    {
        return $"{Address}";
    }
    public void SetAddress(string address)
    {
        Address = address;
    }
    public override string ToString()
    {
        return $"Person [name={Name},address={Address}]";
    }
}
class Student : Person
{
    string _program = Console.ReadLine();
    int _year = Convert.ToInt32(Console.ReadLine());
    double _fee = Convert.ToDouble(Console.ReadLine()); 
    public Student(string name, string address, string program,int year,double fee)
    {
        _program = program;
        _year = year;
        _fee = fee;
        Name = name;
        Address = address;
    }
    public string GetProgram()
    {
        return _program;
    }
    public void SetProgram(string program)
    {
        _program = program;
    }
    public int GetYear()
    {
        return _year;
    }
    public void SetYear(int year)
    {
        _year = year;
    }
    public double GetFee()
    {
        return _fee;
    }
    public void SetFee(double fee)
    {
        _fee = fee;
    }
    public override string ToString()
    {
        return $"Student [Person[name = {Name},address = {Address},program = {_program},year = {_year},fee = {_fee}]]";
    }
}
class Staff : Person
{
    string _school = Console.ReadLine();
    double _pay = Convert.ToDouble(Console.ReadLine());
    public Staff(string name, string address,string school,double pay) 
    {
        _school = school;
        _pay = pay;        
        Name = name;
        Address = address;
    }
    public string GetSchool()
    {
        return _school;
    }
    public void SetSchool(string school)
    {
        _school = school;
    }
    public double GetPay()
    {
        return _pay;
    }
    public void SetPay(double pay)
    {
        _pay = pay;
    }
    public override string ToString()
    {
        return $"Student [Person[name = {Name},address = {Address},program = {_school},pay = {_pay}]]";
    }
}