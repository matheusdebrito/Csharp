using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores
{
    internal class Quarto
    {
        public string Locatario { get; set; }
        public string Email { get; set; }

        //public string Locatario = "vago";
        //public string Email = "Vago";

        public override string ToString()
        {
            return ($"Locatário: {Locatario}, Email: {Email}");
        }
    }
}
