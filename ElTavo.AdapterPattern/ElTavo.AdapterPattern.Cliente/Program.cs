using ElTavo.AdapterPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElTavo.AdapterPattern.Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            IClienteLog clienteLog = new LogAdapter();

            try
            {
                Console.Write("Digite el número a convertir...");
                var cadena = Console.ReadLine();
                var numero = Convert.ToInt16(cadena);
            }
            catch (Exception ex)
            {
                Console.Write(clienteLog.GuardarErrorLog(ex.Message, "2"));
                Console.ReadLine();
            }
        }
    }
}
