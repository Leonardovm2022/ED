// Leonardo Vecchi Meirelles
// 12011ECP002

using ListaFinalEDEx2;
using System.Diagnostics.CodeAnalysis;

BinarySearchTree bst = new BinarySearchTree();

while (true)
{
    Console.WriteLine("[1] Inserir um inteiro na Árvore Binária");
    Console.WriteLine("[2] Remover um inteiro da Árvore Binária");
    Console.WriteLine("[3] Imprimir a Árvore Binária");
    Console.WriteLine("[4] Imprimir a Ordem dos Números dada pelo Algorítmo de Busca em Árvore Binária");
    Console.WriteLine("[5] SAIR");
    Console.Write("Selecione uma opção: ");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine();
            Console.Write("Escolha um inteiro para inserir: ");
            int data = int.Parse(Console.ReadLine());
            bst.Insert(data);
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("|------------ Valor Inserido! --------------|");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine();
            Console.Write("Escolha um inteiro para remover: ");
            data = int.Parse(Console.ReadLine());
            bst.Remove(data);
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("|------------ Valor Removido! --------------|");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("|------------ Árvore Binária: --------------|");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine();
            bst.PrintTree();
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine();
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine("|----------- Valores Ordenados: ------------|");
            Console.WriteLine("|-------------------------------------------|");
            Console.WriteLine();
            bst.Inorder(bst.root);
            Console.WriteLine();
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("_________________¶¶¶1___¶¶¶____¶¶¶1_______________\r\n__________________¶¶¶____¶¶¶____1¶¶1______________\r\n___________________¶¶¶____¶¶¶____¶¶¶______________\r\n___________________¶¶¶____¶¶¶____¶¶¶______________\r\n__________________¶¶¶____1¶¶1___1¶¶1______________\r\n________________1¶¶¶____¶¶¶____¶¶¶1_______________\r\n______________1¶¶¶____¶¶¶1___¶¶¶1_________________\r\n_____________¶¶¶1___1¶¶1___1¶¶1___________________\r\n____________1¶¶1___1¶¶1___1¶¶1____________________\r\n____________1¶¶1___1¶¶1___1¶¶¶____________________\r\n_____________¶¶¶____¶¶¶1___¶¶¶1___________________\r\n______________¶¶¶¶___1¶¶¶___1¶¶¶__________________\r\n_______________1¶¶¶1___¶¶¶1___¶¶¶¶________________\r\n_________________1¶¶1____¶¶¶____¶¶¶_______________\r\n___________________¶¶1____¶¶1____¶¶1______________\r\n___________________¶¶¶____¶¶¶____¶¶¶______________\r\n__________________1¶¶1___1¶¶1____¶¶1______________\r\n_________________¶¶¶____¶¶¶1___1¶¶1_______________\r\n________________11_____111_____11_________________\r\n__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶¶¶¶¶¶¶¶¶¶__1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶_______¶¶__1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶_______¶¶__1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶_______¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n1¶¶_______¶¶__1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n_¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n_¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶________\r\n__________¶¶___1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶1________\r\n__________1¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶_________\r\n____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶11__________\r\n11_____________________________________________111\r\n1¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶1\r\n__¶¶111111111¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶111111111¶__");
            Environment.Exit(0);
            break;
    }
}





