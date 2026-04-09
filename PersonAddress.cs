using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }
        public string Scara { get; set; }

        public string FullAddress
        {
            get 
            {
                return $"Tara = {State}, Oras = {City},\nStrada =  {Street}, Nr. = {Number}, Sc. =  {Scara},\nCP =  {ZipCode}"; 
            }
        }




    }
}
