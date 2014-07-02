using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTavo.AdapterPattern.Cliente
{
    public interface IClienteLog
    {
        string GuardarErrorLog(string error, string codigoError);
    }
}
