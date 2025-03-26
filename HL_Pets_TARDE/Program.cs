using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL_Pets_TARDE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "# HL PETS - SISTEMA DE CONTROLE VETERINÁRIO :.";
            bool sair = false;
            while (sair != true)
            {
                Console.Clear();
                Console.WriteLine(" HL PETS - MENU PRINCIPAL");
                Console.WriteLine("1 - Cadastrar Clientes\n" +
                                  "2 - Listar Clientes\n" +
                                  "3 - Cadrastrar Animal\n" +
                                  "4 - Listar Animais\n" +
                                  "5 - Cadastrar Produto\n" +
                                  "6 - Listar Produtos\n" +
                                  "7 - Saldo em caixa\n" +
                                  "8 - Medicar animal\n" +
                                  "9 - Vender Produto\n" +
                                  "0 - Sair\n\n" +
                                  "Digite a opção:");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Pessoa p1 = new Pessoa();
                    p1.Cadastrar();
                    Clinica.NovoCliente(p1);
                }
                else if (opcao == 2)
                {
                    Clinica.ListarClientes();
                }
                else if (opcao == 3)
                {
                    Animal novo = new Animal();
                    novo.Cadastrar();
                    Clinica.NovoAnimal(novo);
                }
                else if (opcao == 4)
                {
                    Clinica.ListarAnimais();
                }
                else if (opcao == 5)
                {
                    Produto produto = new Produto();
                    produto.Cadastrar();
                    Clinica.NovoProduto(produto);
                }
                else if (opcao == 6) 
                {
                   Clinica.ListarProdutos();
                }
                else if (opcao == 7)
                {
                    Clinica.Saldo();
                }
                else if(opcao == 8)
                {
                    bool escolheuAnima = false;
                    while (!escolheuAnima) { 
                        Console.Clear();
                        Console.WriteLine("> MEDICAÇÃO - ANIMAL");
                        Clinica.ListarAnimais();
                        if (Clinica.animais.Count > 0)
                        {
                            Console.WriteLine("Digite o nome do animal: ");
                            string nomeAnimal = Console.ReadLine();

                            Animal animalProcurado = Clinica.animais.Find(a => a.nome == nomeAnimal);

                            if (animalProcurado != null)
                            {
                                escolheuAnima = true;


                                bool escolheuProduto = false;
                                while (!escolheuProduto)
                                {
                                    Console.Clear();
                                    Clinica.ListarProdutos();
                                    Console.WriteLine("\nDigite o NOME DO PRODUTO: ");
                                    string nomeProduto = Console.ReadLine();

                                    Produto produtoProcurado = Clinica.produtos.Find(p => p.getNome() == nomeProduto);
                                    if (produtoProcurado != null)
                                    {
                                        escolheuProduto = true;
                                        Clinica.Medicar(animalProcurado, produtoProcurado);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{nomeProduto} não cadastrado. Tente novamente.\n");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{nomeAnimal} não cadastrado. Tente novamente.\n");
                                Console.ReadKey();
                            }
                        }
                        escolheuAnima = true;
                    }   
                }
                else if(opcao == 9)
                {
                    bool escolheuProduto = false;
                    while (!escolheuProduto)
                    {
                        Console.Clear();
                        Console.WriteLine("> VENDA DE PRODUTOS");
                        if(Clinica.produtos.Count > 0)
                        {
                            Clinica.ListarProdutos();
                            Console.WriteLine("Digite o NOME DO PRODUTO:");
                            string nomeProduto = Console.ReadLine();

                            Produto produtoPeocurado = Clinica.produtos.Find(p => p.getNome() == nomeProduto);

                            if(produtoPeocurado != null)
                            {
                                Console.WriteLine($"Quantos {nomeProduto} deseja? ");
                                int qtd = int.Parse(Console.ReadLine());

                                bool escolheuCliente = false;
                                while (!escolheuCliente)
                                {
                                    Console.Clear();
                                    Clinica.ListarClientes();
                                    Console.WriteLine("\nDigite o CPF do CLIENTE:");
                                    string cpf = Console.ReadLine();

                                    Pessoa pessoaProcurada = Clinica.clientes.Find(c => c.GetCpf() == cpf);

                                    if(pessoaProcurada != null)
                                    {
                                        escolheuCliente = true;
                                        Clinica.Vender(produtoPeocurado, qtd, pessoaProcurada);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n CPF {cpf} Não cadastrado");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{nomeProduto} não escontrado. Tente novamente.\n");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n--- SEM REGISTRO ---\n");
                            Console.ForegroundColor= ConsoleColor.White;
                            escolheuProduto = true;
                            Console.WriteLine("[pressione ENTER]");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                    } 
                }else if(opcao == 0)
                {
                    sair = true;
                    Console.WriteLine("Saindo...");
                } 
            }
            Console.ReadKey();
        }
    }
}
