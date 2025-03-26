using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL_Pets_TARDE
{
    internal class Pessoa
    {
        private string cpf;
        private string nome;
        private string telefone;
        private string endereco;

        public string GetCpf() { return cpf; }
        public string GetNome() { return nome; }
        public string GetTelefone() { return telefone; }
        public string GetEndereco() { return endereco; }
        public void setCpf(string cpf) { this.cpf = cpf; }
        public void setNome(string nome) { this.nome = nome; }
        public void setTelefone(string telefone) {  this.telefone = telefone;}
        public void setEndereco(string endereco) {  this.endereco = endereco;}

        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("#### CADASTRO DE CLIENTE ####");
            Console.WriteLine("Digite o nome:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            this.cpf= Console.ReadLine();
            Console.WriteLine("Digite o telefone:");
            this.telefone = Console.ReadLine();
            Console.WriteLine("Digite o endereço:");
            this.endereco= Console.ReadLine();
            Console.WriteLine("Cadastro concluído...[pressione ENTER]...");
            Console.ReadKey();
        }

    }
}
