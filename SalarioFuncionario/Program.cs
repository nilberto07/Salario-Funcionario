using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalarioFuncionario.Entities;
using SalarioFuncionario.Entities.Enums;
using System.Globalization;


namespace SalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDept = Console.ReadLine();

            Console.WriteLine("Entre com a data do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel(Junior/Medio/Senior): ");
            string readNivel = Console.ReadLine();
            TrabalhadorNivel nivel;
            Enum.TryParse(readNivel, true, out nivel);
            Console.Write("Base salarial: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(nomeDept);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, baseSalarial, dept);

            Console.Write("Quantos contratos para esse trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre #{i} contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração de horas: ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(date, valorPorHora, horas);
                trabalhador.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o mes e o ano para calcular o ganho(MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: "+ trabalhador.Departamento.Nome);
            Console.WriteLine("Renda total " + mesEano + ": " + trabalhador.Salario(ano, mes).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
