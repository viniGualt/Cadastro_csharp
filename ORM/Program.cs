namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SistemaPedidosContext())
            {
                context.Database.EnsureCreated();
                while (true)
                {
                    Console.WriteLine("Escolha uma opçao:");
                    Console.WriteLine("1.Criar Produto");
                    Console.WriteLine("2.Criar Cliente");
                    Console.WriteLine("3.Criar Pedido");
                    Console.WriteLine("4.Exibir Produto");
                    Console.WriteLine("5.Pesquisar Produto");
                    Console.WriteLine("6.Exibir Cliente"); 
                    Console.WriteLine("7.Pesquisar Cliente");
                    Console.WriteLine("8.Exibir Pedido");
                    Console.WriteLine("9.Exibir Pedido por Cliente");
                    Console.WriteLine("0.Sair");
                    var opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            CriarProdutos(context);
                            break;
                        case "2":
                            CriarCliente(context);
                            break;
                        case "3":
                            CriarPedido(context);
                            break;
                        case "4":
                            ExibirProdutos(context);
                            break;
                        case "5":
                            PesquisarProduto(context);
                            break;
                        case "6":
                            ExibirCliente(context);
                            break;
                        case "7":
                            PesquisarCliente(context);
                            break;
                        case "8":
                            ExibirPedido(context);
                            break;
                        case "9":
                            ExibirPedidoPorCliente(context);
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Opçao invalida");
                            break;
                        

                    }
                }
        }
    }
}
