using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nCADASTRO DE SETOR:\n");

            //Setor setor = new Setor();

            //Console.WriteLine("Informe o nome do Setor...: ");
            //setor.Nome = Console.ReadLine();

            //try
            //{
            //    SetorRepository sr = new SetorRepository();
            //    sr.AbrirConexao();
            //    sr.Inserir(setor);
            //    sr.FecharConexao();
            //    Console.WriteLine("\nSetor cadastrado com sucesso!\n");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("\nErro: " + e.Message);
            //}

            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIOS:\n");
            Funcionario funcionario = new Funcionario();
            funcionario.Setor = new Setor();

            Console.WriteLine("Informe o nome do Funcionário...: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do Funcionário...: ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Data de Admissão do Funcionário...: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o setor do Funcionário...: ");
            funcionario.Setor.IdSetor = int.Parse(Console.ReadLine());

            try
            {
                FuncionarioRepository fr = new FuncionarioRepository();
                fr.AbrirConexao();
                fr.Inserir(funcionario);
                fr.FecharConexao();
                Console.WriteLine("\nFuncionário cadastrado com sucesso!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
