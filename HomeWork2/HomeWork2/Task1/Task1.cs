namespace Task1;

class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    private string _name;
    private int _age;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        private set { _age = value; }
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello , my name is {Name} and I am {Age} years old");
    }
}



