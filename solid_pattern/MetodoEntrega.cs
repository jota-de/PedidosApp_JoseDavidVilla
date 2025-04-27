using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_pattern
{
    public interface IMetodoentrega
    {
        double CalcularCosto(int km);
        string TipoEntrega();
    }
}
