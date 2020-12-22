using System;
using System.Collections.Generic;

namespace AulaPOO_Produtos.classes
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        List<Marca> Marcas = new List<Marca>();

        public Marca CadastrarMarca(){
            
            Marca novaMarca = new Marca();
            
            Console.WriteLine("Digite o codigo da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }


        Usuario user = new Usuario();

        public void Listar(){

            Console.WriteLine("Marcas cadastradas : ");

            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Cadastrado por: {item.user.Nome}");
            }

        }

        public void Deletar(string nome){

            Marca marcaDelete = Marcas.Find(n => n.NomeMarca == nome);
            Marcas.Remove(marcaDelete);
            Console.WriteLine($"Produto deletado: {nome}");

        }


    }
}