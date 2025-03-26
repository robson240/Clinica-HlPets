using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL_Pets_TARDE
{
    internal static class Clinica
    {
        public static List<Pessoa> clientes = new List<Pessoa>();
        public static List<Produto> produtos = new List<Produto>();
        public static List<Animal> animais = new List<Animal>();

        private static float saldo = 0;

        public static void Vender(Produto p, int qtd, Pessoa c)
        {
            Console.WriteLine($"{c.GetNome()} comprou {qtd} {p.getNome()} - Total {p.getValor() * qtd}");
            Clinica.saldo += p.getValor() * qtd;
            Console.WriteLine("...[pressione ENTER]");
            Console.ReadKey();
        }

        public static void Saldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo Atual: R$:{saldo}");
            Console.WriteLine("\n ...[Pressione ENTER]");
            Console.ReadKey();
        }

        public static void Medicar(Animal a, Produto p)
        {
            Console.WriteLine($"\n{a.nome} foi medicado com {p.getNome()} que custou R$ {p.getValor()}");
            Clinica.saldo += p.getValor();
            Console.WriteLine("\n...[Pessione ENTER]");
            Console.ReadKey();  
        }

        public static void NovoCliente(Pessoa novaPessoa)
        {
            clientes.Add(novaPessoa);
        }
        public static void NovoAnimal(Animal pet)
        {
            animais.Add(pet);
        }
        public static void NovoProduto(Produto item)
        {
            produtos.Add(item);
        }
        public static void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("### LISTA DE CLIENTES ###");

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"CPF: {cliente.GetCpf()}" +
                    $" - Nome: {cliente.GetNome()}" +
                    $" - Tel: {cliente.GetTelefone()}");
            }
            Console.WriteLine("> fim...[pressione ENTER]...");
            Console.ReadKey();
        }
        public static void ListarAnimais()
        {
            Console.Clear();
            Console.WriteLine("### LISTA DE ANIMAIS ###");
            if (animais.Count() > 0)
            {
                foreach (var pet in animais)
                {
                    Console.WriteLine($"{pet.tipo} - {pet.nome} " +
                        $" - CPF do Dono: {pet.getDono().GetCpf()}" +
                        $" - Dono: {pet.getDono().GetNome()}");
                }
            }
            else
            {
                Console.WriteLine("\n ============ SEM REGISTRO =========\n");
            }
            Console.WriteLine("> fim...[pressione ENTER]...");
            Console.ReadKey();
        }
        public static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("### LISTA DE PRODUTOS ###");

            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.getNome()} - R$ {item.getValor()}");
            }
            Console.WriteLine("> fim...[pressione ENTER]...");
            Console.ReadKey();
        }

    }
}
