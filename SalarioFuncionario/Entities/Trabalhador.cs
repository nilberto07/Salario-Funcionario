using SalarioFuncionario.Entities.Enums;
using System.Collections.Generic;

namespace SalarioFuncionario.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public TrabalhadorNivel Nivel { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } =
            new List<HoraContrato>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, TrabalhadorNivel nivel,
            double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddContrato(HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Salario(int ano, int mes)
        {
            double suma = BaseSalario;
            //Foreach: Pra Cada
            //in: na
            foreach(HoraContrato contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    suma += contrato.TotalValor();
                }
            }
            return suma;
        }
    }
}
