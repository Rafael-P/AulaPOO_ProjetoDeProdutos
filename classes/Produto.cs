using System;
using System.Collections.Generic;

namespace AulaPOO_Produtos.classes
{
    public class Produto
    {
        
        public int Codigo { get; set; }
    
        public string NomeProduto { get; set; }
    
        public float Preco { get; set; }
    
        public DateTime DataCadastro = DateTime.Now;
    
        public Marca Marca = new Marca();
    
        public Usuario CadastradoPor { get; set; }
    
        List<Produto> ListaDeProdutos = new List<Produto>();
        


        public void Cadastrar(){

        Produto novoProduto = new Produto();

        Console.WriteLine("Digite o codigo do produto: ");
        novoProduto.Codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do produto: ");
        novoProduto.NomeProduto = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto: ");
        novoProduto.Preco = float.Parse(Console.ReadLine());

        DataCadastro = DateTime.Now;

        //Atribuimos nossa marca atraves de um metodo criado para cadastro 
        //Marca = Marca.CadastrarMarca();

        //Atribuimos o usuario atraves do metodo construtor 
        CadastradoPor = new Usuario();

        ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
                Console.WriteLine("");
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){

            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
            Console.WriteLine("Produto deletado");

        }


    }
}