using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonAddress personAdress = new PersonAddress();

            var cerereAdresa = new AddressRequest();

            personAdress.State = cerereAdresa.Tara();
            personAdress.City = cerereAdresa.Oras();
            personAdress.Street = cerereAdresa.Strada();
            personAdress.Number = cerereAdresa.Numar();
            personAdress.Scara = cerereAdresa.Scara();
            personAdress.ZipCode = cerereAdresa.ZipCode();

            Console.WriteLine(personAdress.FullAddress);

            Console.ReadLine();
        }
    }
}
