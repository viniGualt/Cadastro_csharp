namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:\n1. Criar Produto\n2. Criar Cliente\n3. Criar Pedido" +
                    "\n4. Exibir Produtos\n5. Exibir Cliente\n6. Exibir pedidos\n7. Exibir pedido por Cliente" +
                    "\n0. Sair");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Opção selecionada: Criar Produto");
                        break;
                    case "2":
                        Console.WriteLine("Opção selecionada: Criar Cliente");
                        break;
                    case "3":
                        Console.WriteLine("Opção selecionada: Criar Pedido");
                        break;
                    case "4":
                        Console.WriteLine("Opção selecionada: Exibir Produtos");
                        break;
                    case "5":
                        Console.WriteLine("Opção selecionada: Exibir Cliente");
                        break;
                    case "6":
                        Console.WriteLine("Opção selecionada: Exibir Pedidos");
                        break;
                    case "9":
                        Console.WriteLine("Opção selecionada: Exibir Pedidos por Cliente");
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Digite uma opção válida.");
                        break;
                }
            }
        }
    }
}
