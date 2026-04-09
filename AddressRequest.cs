using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AddressRequest
    {
        public string Tara()
        {
            Console.Write("Va rog sa introduceti Tara: ");
            string Tara = Console.ReadLine();
           
            return Tara;
        }
        public string Oras()
        {
            Console.Write("Va rog sa introduceti Orasul: ");
            string Oras = Console.ReadLine();

            return Oras;
        }
        public string Strada()
        {
            Console.Write("Va rog sa introduceti Strada: ");
            string Strada = Console.ReadLine();
            return Strada;
        }
        public string Numar()
        {

            Console.Write("Va rog sa introduceti Numarul: ");
            string Numar = Console.ReadLine();
            return Numar;

        }
        public string ZipCode()
        {
            string ZipCode;
            do
            {
                Console.Write("Va rog sa introduceti Codul Postal: ");
                ZipCode = Console.ReadLine();
            } while (ZipCode.Length != 6);
            return ZipCode;
        }
        public string Scara()
        {
            Console.Write("Va rog sa introduceti Scara: ");
            string Scara = Console.ReadLine();
            return Scara;
        }
    }
}
