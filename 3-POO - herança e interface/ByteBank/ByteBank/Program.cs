﻿using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //TotalDeBonificao();
            UsarSistema();
            Console.WriteLine();

            //Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

            Console.ReadLine();
                        
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor luiza = new Diretor("123.456.789-98");
            luiza.Nome = "Luiza";
            luiza.Senha = "123";

            GerenteDeConta fabricio = new GerenteDeConta("123.456.789-98");
            fabricio.Nome = "Fabrício";
            fabricio.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistema.Logar(luiza, "123");
            sistema.Logar(fabricio, "abc");
            sistema.Logar(parceiro, "123456");
            
        }

        public static void TotalDeBonificao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario luiza = new Diretor("123.456.789-98");
            luiza.Nome = "Luiza";

            Funcionario eric = new Desenvolvedor("123.456.789-98");
            eric.Nome = "Eric";

            Funcionario fabricio = new GerenteDeConta("123.456.789-98");
            fabricio.Nome = "Fabrício";

            Funcionario breno = new Auxiliar("123.456.789-98");
            breno.Nome = "Breno";

            gerenciador.Registrar(luiza);
            gerenciador.Registrar(eric);
            gerenciador.Registrar(fabricio);
            gerenciador.Registrar(breno);

            Console.WriteLine("Bonificação da " + luiza.Nome + ": R$" + luiza.GetBonificacao());
            Console.WriteLine("Bonificação do " + eric.Nome + ": R$" + eric.GetBonificacao());
            Console.WriteLine("Bonificação do " + fabricio.Nome + ": R$" + fabricio.GetBonificacao());
            Console.WriteLine("Bonificação do " + breno.Nome + ": R$" + breno.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificação: R$" + gerenciador.GetTotalBonificacao());
        }
    }
}
