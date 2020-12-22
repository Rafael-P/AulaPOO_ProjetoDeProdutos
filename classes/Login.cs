using System;

namespace AulaPOO_Produtos.classes
{
    public class Login
    {
        
        public bool Logado { get; set; }
        
        public Login(){

            Usuario user = new Usuario();
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }

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


        public void GerarMenu(){

            Produto produto = new Produto();
            Marca marca = new Marca();

            int opcao;

            do
            {
                
                Console.WriteLine("Seja bem vindo ao nosso sistema!");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("[1] - Cadastrar produto");
                Console.WriteLine("[2] - Listar produto");
                Console.WriteLine("[3] - Deletar produto");
                Console.WriteLine("[4] - Cadastrar marca");
                Console.WriteLine("[5] - Listar marca");
                Console.WriteLine("[6] - Deletar marca");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        produto.Cadastrar();
                        break;

                    case 2:
                        produto.Listar();
                        break;

                    case 3:
                        Console.WriteLine("Digite o codigo do produto para excluir");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;

                    case 4:
                        marca.CadastrarMarca();
                        break;

                    case 5:
                        marca.Listar();
                        break;

                    case 6:
                        Console.WriteLine("Digite o nome da marca para excluir");
                        string nome = Console.ReadLine();
                        marca.Deletar(nome);
                        break;

                    case 0:
                        Console.WriteLine("Agradecemos pela sua preferencia!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                

            } while (opcao != 0);

        }//gerar menu


    }
}