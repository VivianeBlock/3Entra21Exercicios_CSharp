using System;
using System.Collections.Generic;
using System.Linq;

namespace HerançaM_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1 a

            {
                //Empresa emp = new Empresa();
                //Console.WriteLine("Preencha a Empreza");
                //emp.Nome = CR();
                //emp.Idade = Convert.ToInt32(CR());
                //emp.Saldo = Convert.ToDouble(CR());
                //emp.QtdFuncionarios = int.Parse(CR());
                //emp.Cnpj = CR();
                //emp.Rua = CR();
                //emp.Cep = CR();
                //emp.Cidade = CR();
                //emp.Estado = CR();
                //emp.Rg = CR();
                //// formatar o CNPJ @"{0:00\.000\.000\/0000\-00}"
                //if (emp.QtdFuncionarios > 8)
                //{
                //    Console.WriteLine(@"{0}  {1}  {2:00\.000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
                //    Console.WriteLine("{0:c}  {1}", emp.Saldo, emp.QtdFuncionarios);
                //    Console.WriteLine("{0}  {1}  {2}", emp.Rua, emp.Cep, emp.Cidade);
                //    Console.WriteLine("{0}  {1}", emp.Estado, emp.Rg);
                //}
                //else
                //{
                //    Console.WriteLine("Micro empresa");
                //}

            }

            //Ex 1 b

            {

                //List<Carro> lista = new List<Carro>();
                //Carro car = new Carro();


                //Console.WriteLine("\tInformações carro {0}");

                //for (int i = 0; i < 3; i++)
                //{

                //    Console.WriteLine("Modelo:");
                //    car.Modelo = Console.ReadLine();
                //    Console.WriteLine("Cavalos Vapor:");
                //    car.Cv = Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine("Nome:");
                //    car.Nome = CR();
                //    Console.WriteLine("Idade:");
                //    car.Idade = Convert.ToInt32(CR());
                //    Console.WriteLine("Cnpj:");
                //    car.Cnpj = CR();
                //    Console.WriteLine("Rua:");
                //    car.Rua = CR();
                //    Console.WriteLine("Cep:");
                //    car.Cep = CR();
                //    Console.WriteLine("Cidade:");
                //    car.Cidade = CR();
                //    Console.WriteLine("Estado:");
                //    car.Estado = CR();
                //    Console.WriteLine("Rg:");
                //    car.Rg = CR();

                //    lista.Add(car);

                //}
                //List<Carro> aux2 = lista.OrderBy(car => car.Cv).ToList();

                //foreach (var item in aux2)
                //{
                //    Console.WriteLine("{0} -> {1}", item.Modelo, item.Cv);
                //}




            }

            //Ex 2 a

            {
                //int cond = 0;
                //Console.WriteLine("\tPreecnha os funcionarios:\n");


                //List<Funcionario> lista = new List<Funcionario>();

                //for (int i = 0; i < 3; i++)
                //{
                //    Funcionario fun = new Funcionario();

                //    Console.WriteLine("Nome:");
                //    fun.Nome = Console.ReadLine();
                //    Console.WriteLine("Idade:");
                //    fun.Idade = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Cargo:");
                //    fun.Cargo = Console.ReadLine();
                //    Console.WriteLine("Salario:");
                //    fun.Salario = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Rua:");
                //    fun.Cep = Console.ReadLine();
                //    Console.WriteLine("Cidade:");
                //    fun.Cidade = Console.ReadLine();
                //    Console.WriteLine("Estado:");
                //    fun.Estado = Console.ReadLine();

                //    if (fun.Salario < 1800)
                //    {
                //        cond++;
                //    }
                //    lista.Add(fun);
                //}

                //if (cond == 0)
                //{
                //    foreach (var item in lista)
                //    {
                //        Console.WriteLine();
                //        Console.WriteLine("{0} {1} {2} {3} ", item.Nome, item.Idade, item.Cargo, item.Salario);
                //        Console.WriteLine("{0} {1} {2} ", item.Cep, item.Cidade, item.Estado);


                //    }
                //}
                //else
                //{
                //    for (int i = 0; i < lista.Count; i++)
                //    {
                //        if (lista[i].Salario < 1800)
                //        {
                //            Console.WriteLine();
                //            Console.WriteLine("{0} {1} {2} {3} ", lista[i].Nome, lista[i].Idade, lista[i].Cargo, lista[i].Salario);
                //            Console.WriteLine("{0} {1} {2} ", lista[i].Cep, lista[i].Cidade, lista[i].Estado);
                //        }

                //    }
                //}





            }

            //Ex 2 b

            {

                //Console.WriteLine("\tInfornme os dados da Mae:\n");

                //Mae m = new Mae();
                //Console.WriteLine("Nome:");
                //m.Nome = Console.ReadLine();
                //Console.WriteLine("Idade:");
                //m.Idade = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Conjuge:");
                //m.Conjuge = Console.ReadLine();
                //Console.WriteLine("Numero de filhos:");
                //m.Filhos = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Cpf:");
                //m.Cpf = Console.ReadLine();
                //Console.WriteLine("Cep:");
                //m.Cep = Console.ReadLine();
                //Console.WriteLine("Cidade:");
                //m.Cidade = Console.ReadLine();
                //Console.WriteLine("Estado:");
                //m.Estado = Console.ReadLine();

                //Console.WriteLine("\t....................");
                //Console.WriteLine("\n\tDados Atuais:\n\n");
                //Console.WriteLine("{0} {1} {2} {3} {4}", m.Nome, m.Idade, m.Conjuge, m.Filhos, m.Cpf);
                //Console.WriteLine("{0} {1} {2}", m.Cep, m.Cidade, m.Estado);
                //Console.WriteLine("\n");
                //Console.WriteLine("Deseja alterar algo?\n(digite sim ou não)");
                //string cond = Console.ReadLine();

                //while (true)
                //{
                //    if (cond == "não")
                //    {
                //        Console.WriteLine("\n\tPrograma encerrado");
                //        break;
                //    }
                //    else
                //    {
                //        Console.WriteLine("\nInforme qual compo deseja modficar:");

                //        Console.WriteLine("\n1 - Nome;\n2 - Idade;\n3 - Conjuge;\n4 - Numero de filhos\n5 - Cpf;");
                //        Console.WriteLine("6 - Cep\n7 - Cidade;\n8 - Estado;");
                //        int opcao = Convert.ToInt32(Console.ReadLine());

                //        switch (opcao)
                //        {
                //            case 1:
                //                m.Nome = Console.ReadLine();
                //                break;
                //            case 2:
                //                m.Idade = Convert.ToInt32(Console.ReadLine());
                //                break;
                //            case 3:
                //                m.Conjuge = Console.ReadLine();
                //                break;
                //            case 4:
                //                m.Filhos = Convert.ToInt32(Console.ReadLine());
                //                break;
                //            case 5:
                //                m.Cpf = Console.ReadLine();
                //                break;
                //            case 6:
                //                m.Cep = Console.ReadLine();
                //                break;
                //            case 7:
                //                m.Cidade = Console.ReadLine();
                //                break;
                //            case 8:
                //                m.Estado = Console.ReadLine();
                //                break;
                //            default:
                //                Console.WriteLine("Opção invalida");
                //                break;
                //        }
                //        Console.WriteLine("\t....................");
                //        Console.WriteLine("\t....................");
                //        Console.WriteLine("\n\tDados Atuais:\n\n");
                //        Console.WriteLine("{0} {1} {2} {3} {4}", m.Nome, m.Idade, m.Conjuge, m.Filhos, m.Cpf);
                //        Console.WriteLine("{0} {1} {2}", m.Cep, m.Cidade, m.Estado);
                //        Console.WriteLine("\t....................");

                //    }

                //    Console.WriteLine("\n\tDeseja fazer mais alguma modificação?\n\t(digite sim ou não)");
                //    cond = Console.ReadLine();
                //    if (cond == "não")
                //    {
                //        Console.WriteLine("\nPrograma encerrado.");
                //        break;
                //    }
                //    else
                //    {
                //        cond = "sim";
                //    }
                //}


            }


            //Lista 2 Ex 1 a

            {


                //List<Casa> c = new List<Casa>();

                //for (int i = 0; i < 5; i++)
                //{
                //    Casa casa = new Casa();
                //    Console.WriteLine("Nome do dono:");
                //    casa.NomeDono = Console.ReadLine();
                //    Console.WriteLine("Numero de quartos:");
                //    casa.QuantQuarto = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Data de construção:");
                //    casa.DataDeConstrucao = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Rua:");
                //    casa.Rua = Console.ReadLine();
                //    Console.WriteLine("Cep:");
                //    casa.Cep = Console.ReadLine();
                //    Console.WriteLine("Cidade:");
                //    casa.Cidade = Console.ReadLine();
                //    Console.WriteLine("Estado:");
                //    casa.Estado = Console.ReadLine();

                //    c.Add(casa);

                //}


                //List<Casa> aux2 = c.OrderByDescending(casa => casa.QuantQuarto).ToList();

                //Console.WriteLine("\nListagem de casas\n\n");

                //foreach(var item in aux2)
                //{
                //    Console.WriteLine("{0} {1} {2} ", item.NomeDono, item.QuantQuarto, item.DataDeConstrucao);
                //    Console.WriteLine("{0} {1} {2} {3}", item.Rua, item.Cep, item.Cidade, item.Estado);
                //}


            }

        }

        public static string CR()
        {
            return Console.ReadLine();
        }

    }

}



