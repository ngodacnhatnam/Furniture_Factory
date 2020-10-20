using System;

namespace Furniture_Store {
    class Program {
        static void Main(string[] args) {
            Clients person;
            Console.WriteLine("\r\n------------Welcome to UMA----------------");
            person = new Clients(new ArtDec_Fact(), "1");
            Console.WriteLine("\r\n You have produced " + person.GetChairName()); 
            person = new Clients(new Modern_Fact(), "3");
            Console.WriteLine("\r\n You have produced " + person.GetTableName());
            person = new Clients(new Vic_Fact(), "2");
            Console.WriteLine("\r\n You have produced " + person.GetTableName()); 
            person = new Clients(new ArtDec_Fact(), "1");
            Console.WriteLine("\r\n You have produced " + person.GetSofaName());
            person = new Clients(new Modern_Fact(), "3");
            Console.WriteLine("\r\n You have produced " + person.GetChairName());
            person = new Clients(new Vic_Fact(), "2");
            Console.WriteLine("\r\n You have ordered " + person.GetSofaName());
        }
    }
}
