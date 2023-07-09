// Leonardo Vecchi Meirelles
// 12011ECP002

using ListaFinalEDEx1;

class Program
{
    static void Main(string[] args)
    {
        ListaDE<double> lista = new ListaDE<double>();
        Fila<double> fila = new Fila<double>();
        Pilha<double> pilha = new Pilha<double>();

        while (true)
        {
            Console.WriteLine("[1] Criar uma lista de números reais");
            Console.WriteLine("[2] Criar uma fila de números reais");
            Console.WriteLine("[3] Criar uma pilha de números reais");
            Console.WriteLine("[4] SAIR");
            Console.Write("Selecione uma opção: ");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("[1] Inserir um número no início da lista");
                        Console.WriteLine("[2] Remover um número no início da lista");
                        Console.WriteLine("[3] Inserir um número no final da lista");
                        Console.WriteLine("[4] Remover um número no final da lista");
                        Console.WriteLine("[5] Voltar");
                        Console.Write("Selecione uma opção: ");
                        int opcaoLista = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (opcaoLista)
                        {
                            case 1:
                                Console.Write("Insira o número a ser inserido: ");
                                double numero = double.Parse(Console.ReadLine());
                                lista.insereNoInicio(numero);
                                Console.WriteLine();
                                break;
                            case 2:
                                lista.removeDoInicio();
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.Write("Insira o número a ser inserido: ");
                                double n = double.Parse(Console.ReadLine());
                                lista.insereNoFim(n);
                                Console.WriteLine();
                                break;
                            case 4:
                                lista.removeDoFim();
                                Console.WriteLine();
                                break;
                            case 5:
                                Console.WriteLine();
                                break;
                        }
                        if (opcaoLista == 5) break;
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    while (true)
                    {
                        Console.WriteLine("[1] Inserir um número na fila");
                        Console.WriteLine("[2] Remover um número da fila");
                        Console.WriteLine("[3] Voltar");
                        Console.Write("Selecione uma opção: ");

                        int opcaoFila = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        switch (opcaoFila)
                        {
                            case 1:
                                Console.Write("Insira o número a ser inserido: ");
                                double numero = double.Parse(Console.ReadLine());
                                fila.enqueue(numero);
                                Console.WriteLine();
                                break;
                            case 2:
                                fila.dequeue();
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.WriteLine();
                                break;
                        }
                        if (opcaoFila == 3) break;
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    while (true)
                    {
                        Console.WriteLine("[1] Inserir um número na pilha");
                        Console.WriteLine("[2] Remover um número da pilha");
                        Console.WriteLine("[3] Voltar");
                        Console.Write("Selecione uma opção: ");

                        int opcaoPilha = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (opcaoPilha)
                        {
                            case 1:
                                Console.Write("Insira o número a ser inserido: ");
                                double numero = double.Parse(Console.ReadLine());
                                pilha.push(numero);
                                Console.WriteLine();
                                break;
                            case 2:
                                pilha.pop();
                                Console.WriteLine();
                                break;
                            case 3:
                                Console.WriteLine();
                                break;
                        }
                        if (opcaoPilha == 3) break;
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine("|--------- Lista ---------|");
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine();
                    lista.imprime();
                    Console.WriteLine();
                    Console.WriteLine("|------------------------|");
                    Console.WriteLine("|--------- Fila ---------|");
                    Console.WriteLine("|------------------------|");
                    Console.WriteLine();
                    fila.imprime();
                    Console.WriteLine();
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine("|--------- Pilha ---------|");
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine();
                    pilha.imprime();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            if (opcao == 4) break;
        }
    }
}


