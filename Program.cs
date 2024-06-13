using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double baseFee = 1000; 

            Member member = new Member(1, "Ismail Hussein ", "Zealand 100, 4000 Roskilde", new DateTime(1999, 02, 25), "+45 28697200", "Ismail@outlook.com");
            Dog Ronaldo = new Dog(101, "Ronaldo", DogRace.Labrador, 2017);
            Dog Messi = new Dog(102, "Messi", DogRace.GoldenRetriever, 2018);

            member.RegisterDog(Ronaldo);
            member.RegisterDog(Messi);

            Console.WriteLine(member);
            Console.WriteLine($"Medlemsgebyr med rabat: {member.CalculateMembershipFee(baseFee)} DKK");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Der en i systemet fejl: " + ex.Message);
        }
    }
}