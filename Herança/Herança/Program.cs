using System;
using System.Collections.Generic;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exec
            {

                //Console.WriteLine("{0:#.###}", 1552.342885182);
                //Pessoa pes = new Pessoa();
                //Console.WriteLine("Por Favor insira uma pessoa");
                //pes.Nome = CR();
                //pes.Cpf = CR();
                //pes.Idade = Convert.ToInt32(CR());
                //pes.Rua = CR();
                //pes.Numero = CR();
                //pes.Cidade = CR();
                //pes.Estado = CR();

                //Console.WriteLine("------------//-------------®");
                //Console.WriteLine(@"{0} | {1:000\.000\.000\-00} | {2}", pes.Nome,Convert.ToInt64(pes.Cpf), pes.Idade);
                //Console.WriteLine("{0} |n{1} | {2} | {3}", pes.Rua, pes.Numero, pes.Cidade, pes.Estado);
            }

            ///////////////////////////////////////
            
            { 


            // Ex b:
            {

                //Empresa emp = new Empresa();
                //Console.WriteLine("\tINFORME:\n");
                //Console.WriteLine("\tO nome:");
                //emp.Nome = Console.ReadLine();
                //Console.WriteLine("\tA quantidade de funcionarios:");
                //emp.Funcionarios = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("\tA rua:");
                //emp.Rua = Console.ReadLine();
                //Console.WriteLine("\tA cidade:");
                //emp.Cidade = Console.ReadLine();
                //Console.WriteLine("\tO estado:");
                //emp.Estado = Console.ReadLine();

                //Console.WriteLine("\t\tDADOS DA EMPRESA:\n");
                //Console.WriteLine("\n{0}\n {1}\n {2}\n {3}\n {4}", emp.Nome,emp.Funcionarios,emp.Rua,emp.Cidade,emp.Estado);

            }


            //Ex c:
            {
                //List<Habitacao> lista = new List<Habitacao>();
                //for (int i = 0; i < 4; i++)
                //{
                //    Habitacao hab = new Habitacao();
                //    Console.WriteLine("informe o tipo de habitação:");
                //    hab.Tipo = Console.ReadLine();

                //    Console.WriteLine("Nome do dono:");
                //    hab.NomeDoDono = Console.ReadLine();

                //    Console.WriteLine("rua:");
                //    hab.Rua = Console.ReadLine();

                //    Console.WriteLine("cidade:");
                //    hab.Cidade = Console.ReadLine();

                //    Console.WriteLine("Informe o estado:");
                //    hab.Estado = Console.ReadLine();
                //    lista.Add(hab);

                //}

                //Console.WriteLine("...................................\n");

                //foreach (var item in lista)
                //{
                //    Console.WriteLine("{0} {1} {2} {3} {4} ", item.NomeDoDono, item.Rua, item.Cidade, item.Cidade, item.Estado);

                //}



            }

            //Ex 2 a:

            {

                //Pessoa2 pes = new Pessoa2();

                //Console.WriteLine("O nome da pessoa:");
                //pes.Nome = Console.ReadLine();
                //Console.WriteLine("Idade:");
                //pes.Idade = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("dopamina:");
                //pes.Dopamina = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("dinheiro no bolso:");
                //pes.DinheiroNoBolso = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("\n\n A pessoa deseja:\n\tTrabalhar = digite t\n\tComer = digite c\n\n");
                //string cond = Console.ReadLine();
                //if(cond == "c")
                //{
                //    Console.WriteLine("Informe o quanto");
                //    double kilos = Convert.ToDouble(Console.ReadLine());
                //    kilos = Pessoa2.Comer(kilos);
                //    pes.Dopamina += kilos; 
                //}
                //else if(cond == "t")
                //{
                //    Console.WriteLine("Informe o quanto");
                //    int trabalho = Convert.ToInt32(Console.ReadLine());
                //    double aux = Pessoa2.Trabalhar(trabalho);
                //    pes.DinheiroNoBolso += aux;
                //}


                //Console.WriteLine("\n{0}\n {1}\n {2}\n {3}\n ", pes.Nome, pes.Idade, pes.Dopamina, pes.DinheiroNoBolso);



            }


            //Ex 2 b:

            {

                //Cachorro cachorro = new Cachorro();
                //Console.WriteLine("Informe o nome do cachorro:");
                //cachorro.Nome = Console.ReadLine();
                //Console.WriteLine("Idade:");
                //cachorro.Dopamina = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Conforto");
                //cachorro.Conforto = Console.ReadLine();

                //Console.WriteLine("\tMENU:");
                //Console.WriteLine("\t1 - Comer\n\t2 - Descansar\n\t3 - Sair\n\n");
                //int cond = Convert.ToInt32(Console.ReadLine());

                //while (cond != 3)
                //{
                //    if (cond == 1)
                //    {
                //        Console.WriteLine("\tQuanto o cachorro irá comer?");
                //        double comer = Convert.ToDouble(Console.ReadLine());
                //        comer = Cachorro.Comer(comer);
                //        cachorro.Dopamina += comer;
                //        Console.WriteLine("\t{0}\n\t {1}\n\t {2} ", cachorro.Nome, cachorro.Dopamina, cachorro.Conforto);

                //        Console.WriteLine("\n\n\tMENU:");
                //        Console.WriteLine("\t1 - Comer\n\t2 - Descansar\n\t3 - Sair\n\n");
                //        cond = Convert.ToInt32(Console.ReadLine());


                //    }

                //    else if (cond == 2)
                //    {

                //        Console.WriteLine("\tQuanto o cachorro irá descansar?");
                //        int dormir = Convert.ToInt32(Console.ReadLine());
                //        double aux2 = Cachorro.Comer(dormir);
                //        cachorro.Conforto += aux2;
                //        Console.WriteLine("\t{0}\n\t {1}\n\t {2} ", cachorro.Nome, cachorro.Dopamina, cachorro.Conforto);

                //        Console.WriteLine("\n\n\tMENU:");
                //        Console.WriteLine("\t1 - Comer\n\t2 - Descansar\n\t3 - Sair\n\n");
                //        cond = Convert.ToInt32(Console.ReadLine());

                //    }
                //    else
                //    {
                //        Console.WriteLine("\t\tEssa opção não está no menu!");
                //        Console.WriteLine("\n\tTente novamente:");
                //        Console.WriteLine("\n\n\tMENU:");
                //        Console.WriteLine("\t1 - Comer\n\t2 - Descansar\n\t3 - Sair\n\n");
                //        cond = Convert.ToInt32(Console.ReadLine());

                //    }


                //}

                //Console.WriteLine("\t{0}\n\t {1}\n\t {2} ", cachorro.Nome, cachorro.Dopamina, cachorro.Conforto);

            }

            //Ex 2 c:

            {

                //Console.WriteLine("\tInforme o nome do Funcionario:");
                //Funcionario fun = new Funcionario();

                //fun.Nome = Console.ReadLine();
                //Console.WriteLine("\tDinheiro no bolso:");
                //fun.DinheiroNoBolso = Convert.ToDouble(Console.ReadLine());
                //if (fun.DinheiroNoBolso < 1520)
                //{
                //    double aux = 1520 - fun.DinheiroNoBolso;
                //    aux = aux / 24.52;
                //    Math.Ceiling(aux); // essa função arredonda!
                //    int aux2 = Convert.ToInt32(aux);

                //    Funcionario.Trabalhar(aux2);

                //}

            }

        }

         


        }

        //public static string CR()
        //{
        //    return Console.ReadLine();
        //}

    }
}
