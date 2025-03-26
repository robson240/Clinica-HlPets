using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL_Pets_TARDE
{
    internal class Produto
    {
        private string nome;
        private float valor;

        public void setNome(string nome) { this.nome = nome; }
        public string getNome() {  return this.nome; }
        public void setValor(float valor) { this.valor = valor; }
        public float getValor() { return this.valor; }
        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("#### CADASTRO DE PRODUTO #####");
            Console.WriteLine("Digite o nome:");
            this.nome = Console.ReadLine();
            Console.WriteLine("Digite o R$:");
            this.valor = float.Parse(Console.ReadLine());
            Console.WriteLine("\nCadastro realizado ...[pressione ENTER]");
            Console.ReadLine();
        }

    }
}
