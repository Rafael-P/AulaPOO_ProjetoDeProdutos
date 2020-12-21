using System;

namespace AulaPOO_Produtos.classes
{
    public class Login
    {
        
        public bool Logado { get; set; }
        
        public Login(){

            Usuario user = new Usuario();
            Logar(user);

        }

        public void Logar(Usuario usuario){

            Console.WriteLine("Digite seu E-mail: ");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("Digite sua Senha: ");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == usuario.Email && senhaLogin == usuario.Senha)
            {
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso");
            }else{
                Console.WriteLine("Falha ao fazer login");
            }

        }

        public void Deslogar(){
            Logado = false;
        }
        

    }
}