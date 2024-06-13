using System;
using System.Collections.Generic;


public class Member
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public List<Dog> Dogs { get; private set; }

    public Member(int id, string name, string address, DateTime birthDate, string phone, string email)
    {
        ID = id;
        Name = name;
        Address = address;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
        Dogs = new List<Dog>();
        Console.WriteLine("Medlem registreret succesfuldt.");
    }

    public void RegisterDog(Dog dog)
    {
        Dogs.Add(dog);
        Console.WriteLine($"Hund tilføjet: {dog.Name}");
        if (Dogs.Count > 1)
        {
            Console.WriteLine("Du har nu registreret mere end en hund og får derfor 10% rabat på medlemskab.");
        }
    }

    public double CalculateMembershipFee(double baseFee)
    {
        double discount = Dogs.Count > 1 ? 0.9 : 1.0; // Giver rabat til mere end 2 hunde - så det godt!! 10% rabat 
        return baseFee * discount;
    }

    public override string ToString()
    {
        var dogsInfo = string.Join("\n", Dogs);
        return $"ID: {ID}, Navn: {Name}, Adresse: {Address}, Fødselsdato: {BirthDate.ToShortDateString()}, Telefon: {Phone}, Email: {Email}\nHunde:\n{dogsInfo}";
    }
}