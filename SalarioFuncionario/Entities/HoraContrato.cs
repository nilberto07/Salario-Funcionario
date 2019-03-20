using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFuncionario.Entities
{
    class HoraContrato
    {
        public DateTime Data { get; set; }
        public double VlrPorHora { get; set; }
        public int Hora { get; set; }


        public HoraContrato()
        {
        }

        public HoraContrato(DateTime data, double vlrporhora, int hora)
        {
            Data = data;
            VlrPorHora = vlrporhora;
            Hora = hora;
        }

        public double TotalValor()
        {
            return Hora * VlrPorHora;
        }
    }
}
