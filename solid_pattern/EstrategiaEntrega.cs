using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_pattern
{
    public class EntregaDron : IMetodoentrega
    {
        public double CalcularCosto(int km) => km * 20;
        public string TipoEntrega() => "Dron";
    }
    public class EntregaMoto : IMetodoentrega {
        public double CalcularCosto(int km) => km * 10;
        public string TipoEntrega() => "Moto";
    }
    public class EntregaCamion: IMetodoentrega
    {
        public double CalcularCosto(int km) => km * 5;
        public string TipoEntrega() => "Camion";
    }   
}
