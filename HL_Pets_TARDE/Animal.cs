using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL_Pets_TARDE
{
    internal class Animal
    {
        public string nome;
        public int idade;
        public string tipo;
        private Pessoa dono;

        public void setDono(Pessoa pessoa) { this.dono = pessoa; }
        public Pessoa getDono() { return dono; }
        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("#### CADASTRO DE ANIMAIS #####");
            Console.WriteLine("Digite o nome:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            this.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de animal:\n1 - Cachorro\n2 - Gato");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1) { this.tipo = "Cachorro"; }
            else if (tipo == 2) { this.tipo = "Gato"; }
            else { this.tipo = "Indefinido"; }

            bool escolha = false;
            while (!escolha)
            {
                Console.Clear();
                Clinica.ListarClientes();
                Console.WriteLine("\nDigite o CPF do responsável pelo animal:");
                string cpf = Console.ReadLine();

                Pessoa responsavel = Clinica.clientes.Find(cliente => cliente.GetCpf() == cpf);

                if (responsavel != null)
                {
                    this.setDono(responsavel);
                    escolha = true;
                }
                else
                {
                    Console.WriteLine("\nCPF não encontrado...[pressione ENTER]...");
                    Console.ReadKey();
                } 
            }
            Console.WriteLine("Cadastro realizado...[pressione ENTER]...");
            Console.ReadKey();
        }
    }
}
