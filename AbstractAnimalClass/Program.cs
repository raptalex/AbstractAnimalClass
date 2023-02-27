using System;

abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}

class Lizard : Animal
{
    public enum SexType { Male, Female, None }
    public override string Name { get; set; }
    public string Color { get; set; }
    public SexType Sex { get; set; }

    public Lizard()
    {
        Name = string.Empty;
        Color = string.Empty;
        Sex = SexType.None;
    }
    public Lizard(string _name, string _color, SexType _sex)
    {
        Name = _name;
        Color = _color;
        Sex = _sex;
    }
    public override string Describe()
    {
        return "My name is " + Name + ". I am a " + Sex.ToString().ToLower() + " lizard and my skin is " + Color.ToLower() + ".";
    }
}

class Program
{
    public static void Main()
    {
        Lizard lizard1 = new Lizard();
        lizard1.Name = "Mikey";
        lizard1.Color = "red";
        lizard1.Sex = Lizard.SexType.Male;

        Console.WriteLine(lizard1.Describe());

        Lizard lizard2 = new Lizard("Rachael", "Turquoise", Lizard.SexType.Female);

        Console.WriteLine(lizard2.Describe());
    }
}