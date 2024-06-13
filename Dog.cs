using System;

public class Dog
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DogRace Race { get; set; }
    public int YearOfBirth { get; set; }

    public Dog(int id, string name, DogRace race, int yearOfBirth)
    {
        ID = id;
        Name = name;
        Race = race;
        YearOfBirth = yearOfBirth;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Race: {Race}, Born: {YearOfBirth}";
    }
}