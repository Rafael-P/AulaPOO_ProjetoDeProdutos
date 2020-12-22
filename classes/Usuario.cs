using System;

namespace AulaPOO_Produtos.classes
{
    public class Usuario
    {
        public Usuario(){
            //Cadastrar usuário automaticamente quando essa classe for instanciada
            Cadastrar();
        }

        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = "Rafael";
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.Now;
        }

        public int Codigo { get; set; }
    
        public string Nome = "Rafael";
    
        public string Email { get; set; }
    
        public string Senha { get; set; }
    
        public DateTime DataCadastro = DateTime.Now;
        

        public void Cadastrar(){
            Nome = "Rafael";
            Email = "admin@admin.com";
            Senha = "12345";
            DataCadastro = DateTime.Now;
        }


        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }


    }
}