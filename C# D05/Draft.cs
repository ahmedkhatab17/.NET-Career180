class Human
{
    protected string name;
    public void MyName()
    {
        System.Console.WriteLine("say ur name");
    }
}
class Male:Human
{
    public Male(string _name)
    {
        name=_name;
    }
    public void MyName()
    {
        System.Console.WriteLine($"my name is {name}");
    }
}
class Female:Human
{
    public Female(string _name)
    {
        name=_name;
    }
    public void MyName()
    {
        System.Console.WriteLine($"my name is {name}");
    }
}

Main()
{
    Human h1=new Female("Habeeba");
    h1.MyName();
    //say ur name
    ///logic says
    ///my name is habeeba
}