using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_pattern
{
    public static class Factory
    {
        public static IMetodoentrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "tecnología" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio")
                return new EntregaMoto();
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else if (tipoProducto == "Accesorio" && peso < 2 && !urgente)
                return new EntregaBicicleta();
            else
                return new EntregaMoto(); // valor por defecto
        }

    }
}
