using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Infos infor = new Infos();

            //cadastro pessoa
            Console.WriteLine("Seja bem-vindo ao nosso sistema de estoque.");
            Console.WriteLine("Como gostaria de ser chamado(a)?");
            infor.nome = Console.ReadLine();

            //cadastro itens
            Console.WriteLine("Legal!");
            Console.WriteLine(infor.nome + ", vamos para o uso de nosso sistema.");

            Console.WriteLine();
            Console.WriteLine("Nosso sistema consegue armazenar até 20 itens: ");
            Console.WriteLine(infor.nome + ", quantos itens deseja adicionar o estoque?");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i <= quant; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item1 + ", terá quantas unidades?");
                    infor.quant1 = int.Parse(Console.ReadLine());
                }
                else if (i == 2)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item2 + ", terá quantas unidade?");
                    infor.quant2 = int.Parse(Console.ReadLine());
                }
                else if (i == 3)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item3 + ", terá quantas unidades?");
                    infor.quant3 = int.Parse(Console.ReadLine());
                }
                else if (i == 4)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item4 + ", terá quantas unidades?");
                    infor.quant4 = int.Parse(Console.ReadLine());
                }
                else if (i == 5)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item5 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item5 + ", terá quantas unidades?");
                    infor.quant5 = int.Parse(Console.ReadLine());
                }
                else if (i == 6)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item6 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item6 + ", terá quantas unidades?");
                    infor.quant6 = int.Parse(Console.ReadLine());

                }
                else if (i == 7)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item7 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item7 + ", terá quantas unidades?");
                    infor.quant7 = int.Parse(Console.ReadLine());
                }
                else if (i == 8)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item8 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item8 + ", terá quantas unidades?");
                    infor.quant8 = int.Parse(Console.ReadLine());
                }
                else if (i == 9)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item9 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item9 + ", terá quantas unidades?");
                    infor.quant9 = int.Parse(Console.ReadLine());
                }
                else if (i == 10)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item10 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item10 + ", terá quantas unidades?");
                    infor.quant10 = int.Parse(Console.ReadLine());
                }
                else if (i == 11)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item11 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item11 + ", terá quantas unidades?");
                    infor.quant11 = int.Parse(Console.ReadLine());
                }
                else if (i == 12)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item12 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item12 + ", terá quantas unidades?");
                    infor.quant12 = int.Parse(Console.ReadLine());
                }
                else if (i == 13)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item13 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item13 + ", terá quantas unidades?");
                    infor.quant13 = int.Parse(Console.ReadLine());
                }
                else if (i == 14)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item14 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item14 + ", terá quantas unidades?");
                    infor.quant14 = int.Parse(Console.ReadLine());
                }
                else if (i == 15)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item15 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item15 + ", terá quantas unidades?");
                    infor.quant15 = int.Parse(Console.ReadLine());
                }
                else if (i == 16)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item16 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item16 + ", terá quantas unidades?");
                    infor.quant16 = int.Parse(Console.ReadLine());
                }
                else if (i == 17)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item17 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item17 + ", terá quantas unidades?");
                    infor.quant17 = int.Parse(Console.ReadLine());
                }
                else if (i == 18)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item18 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item18 + ", terá quantas unidades?");
                    infor.quant18 = int.Parse(Console.ReadLine());
                }
                else if (i == 19)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item19 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item19 + ", terá quantas unidades?");
                    infor.quant19 = int.Parse(Console.ReadLine());
                }
                else if (i == 20)
                {
                    Console.WriteLine("Qual o nome do item: " + i);
                    infor.item20 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(infor.item20 + ", terá quantas unidades?");
                    infor.quant20 = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

     
            Console.WriteLine("Perfeito produtos cadastrado.");
            Console.WriteLine();

            //ações
            Console.WriteLine("Menu de acesso");
            Console.WriteLine("1. Visualização: ");
            Console.WriteLine("2. Remover item: ");
            Console.WriteLine("3. Mudar valor de estoque: ");
            Console.WriteLine("4. Finalizar: ");
            int id = int.Parse(Console.ReadLine());

            //menu
            while (id > 0 && id < 4)
            {
                //visualização
                if (id == 1)
                {
                    Console.WriteLine("MENU DE VISUALIZAÇÃO");
                    Console.WriteLine("Qual item deseja ver?");
                    int guia = int.Parse(Console.ReadLine());

                    while (guia > 0 && guia < 21)
                    {
                        if (guia == 1)
                        {
                            Console.WriteLine("Item: " + infor.item1);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 2)
                        {
                            Console.WriteLine("Item: " + infor.item2);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 3)
                        {
                            Console.WriteLine("Item: " + infor.item3);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 4)
                        {
                            Console.WriteLine("Item: " + infor.item4);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 5)
                        {
                            Console.WriteLine("Item: " + infor.item5);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 6)
                        {
                            Console.WriteLine("Item: " + infor.item6);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 7)
                        {
                            Console.WriteLine("Item: " + infor.item7);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 8)
                        {
                            Console.WriteLine("Item: " + infor.item8);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 9)
                        {
                            Console.WriteLine("Item: " + infor.item9);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 10)
                        {
                            Console.WriteLine("Item: " + infor.item10);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 11)
                        {
                            Console.WriteLine("Item: " + infor.item11);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 12)
                        {
                            Console.WriteLine("Item: " + infor.item12);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 13)
                        {
                            Console.WriteLine("Item: " + infor.item13);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 14)
                        {
                            Console.WriteLine("Item: " + infor.item14);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 15)
                        {
                            Console.WriteLine("Item: " + infor.item15);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 16)
                        {
                            Console.WriteLine("Item: " + infor.item16);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 17)
                        {
                            Console.WriteLine("Item: " + infor.item17);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 18)
                        {
                            Console.WriteLine("Item: " + infor.item18);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 19)
                        {
                            Console.WriteLine("Item: " + infor.item19);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (guia == 20)
                        {
                            Console.WriteLine("Item: " + infor.item20);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Invalido.");
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            guia = guia * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                    }

                }
                //Remover
                else if (id == 2)
                {
                    Console.WriteLine("MENU DE REMOÇÃO");
                    Console.WriteLine("Qual item dejesa remover?");
                    int idR = int.Parse(Console.ReadLine());
                    infor.removerItem(idR);

                    Console.WriteLine();
                    Console.WriteLine("Atualizado");

                    while (idR > 0 && idR < 21)
                    {
                        if (idR == 1)
                        {
                            Console.WriteLine(infor.item1 + ", possui: " + infor.quant1);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());

                        }
                        else if (idR == 2)
                        {
                            Console.WriteLine(infor.item2 + ", possui: " + infor.quant2);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 3)
                        {
                            Console.WriteLine(infor.item3 + ", possui: " + infor.quant3);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 4)
                        {
                            Console.WriteLine(infor.item4 + ", possui: " + infor.quant4);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 5)
                        {
                            Console.WriteLine(infor.item5 + ", possui: " + infor.quant5);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 6)
                        {
                            Console.WriteLine(infor.item6 + ", possui: " + infor.quant6);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 7)
                        {
                            Console.WriteLine(infor.item7 + ", possui: " + infor.quant7);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 8)
                        {
                            Console.WriteLine(infor.item8 + ", possui: " + infor.quant8);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 9)
                        {
                            Console.WriteLine(infor.item9 + ", possui: " + infor.quant9);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 10)
                        {
                            Console.WriteLine(infor.item10 + ", possui: " + infor.quant10);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 11)
                        {
                            Console.WriteLine(infor.item11 + ", possui: " + infor.quant11);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 12)
                        {
                            Console.WriteLine(infor.item12 + ", possui: " + infor.quant12);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 13)
                        {
                            Console.WriteLine(infor.item13 + ", possui: " + infor.quant13);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 14)
                        {
                            Console.WriteLine(infor.item14 + ", possui: " + infor.quant14);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 15)
                        {
                            Console.WriteLine(infor.item15 + ", possui: " + infor.quant15);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 16)
                        {
                            Console.WriteLine(infor.item16 + ", possui: " + infor.quant16);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 17)
                        {
                            Console.WriteLine(infor.item17 + ", possui: " + infor.quant17);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 18)
                        {
                            Console.WriteLine(infor.item18 + ", possui: " + infor.quant18);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 19)
                        {
                            Console.WriteLine(infor.item19 + ", possui: " + infor.quant19);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                        else if (idR == 20)
                        {
                            Console.WriteLine(infor.item20 + ", possui: " + infor.quant20);
                            Console.WriteLine();
                            Console.WriteLine("Proxima tarefa?");
                            Console.WriteLine("1. Visualização: ");
                            Console.WriteLine("2. Remover item: ");
                            Console.WriteLine("3. Mudar valor de estoque: ");
                            Console.WriteLine("4. Finalizar: ");
                            id = id * 0;
                            id = int.Parse(Console.ReadLine());
                        }
                    }

                }
                //Mudar valor de estoque
                else if (id == 3)
                {
                    Console.WriteLine("MENU DE ATUALIZAÇÃO DE ESTOQUE");
                    Console.WriteLine();
                    Console.WriteLine("CHEGOU MAIS ITENS OU SAIU?");
                    Console.WriteLine("'c' para chegou, 's' para saiu");
                    char attValor = char.Parse(Console.ReadLine().ToLower());



                    while (attValor == 'c' || attValor == 's')
                    {
                        //chegou
                        if (attValor == 'c')
                        {
                            Console.WriteLine("Legal.");
                            Console.WriteLine("Vamos atualizar qual item?");
                            Console.WriteLine("Por favor informe o numero dele: ");
                            infor.guiaAdd = int.Parse(Console.ReadLine());

                            if (infor.guiaAdd > 0 && infor.guiaAdd < 21)
                            {
                                Console.WriteLine("Agora me fale quantas unidades chegaram: ");
                                int idC = int.Parse(Console.ReadLine());
                                infor.addItem(idC);

                                Console.WriteLine();

                                if (infor.guiaAdd == 1)
                                {
                                    Console.WriteLine("O item: " + infor.item1 + ", agora possui: " + infor.quant1);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 2)
                                {
                                    Console.WriteLine("O item: " + infor.item2 + ", agora possui: " + infor.quant2);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 3)
                                {
                                    Console.WriteLine("O item: " + infor.item3 + ", agora possui: " + infor.quant3);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 4)
                                {
                                    Console.WriteLine("O item: " + infor.item4 + ", agora possui: " + infor.quant4);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 5)
                                {
                                    Console.WriteLine("O item: " + infor.item5 + ", agora possui: " + infor.quant5);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 6)
                                {
                                    Console.WriteLine("O item: " + infor.item6 + ", agora possui: " + infor.quant6);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 7)
                                {
                                    Console.WriteLine("O item: " + infor.item7 + ", agora possui: " + infor.quant7);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 8)
                                {
                                    Console.WriteLine("O item: " + infor.item8 + ", agora possui: " + infor.quant8);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 9)
                                {
                                    Console.WriteLine("O item: " + infor.item9 + ", agora possui: " + infor.quant9);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 10)
                                {
                                    Console.WriteLine("O item: " + infor.item10 + ", agora possui: " + infor.quant10);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 11)
                                {
                                    Console.WriteLine("O item: " + infor.item11 + ", agora possui: " + infor.quant11);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 12)
                                {
                                    Console.WriteLine("O item: " + infor.item12 + ", agora possui: " + infor.quant12);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 13)
                                {
                                    Console.WriteLine("O item: " + infor.item13 + ", agora possui: " + infor.quant13);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 14)
                                {
                                    Console.WriteLine("O item: " + infor.item14 + ", agora possui: " + infor.quant14);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 15)
                                {
                                    Console.WriteLine("O item: " + infor.item15 + ", agora possui: " + infor.quant15);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 16)
                                {
                                    Console.WriteLine("O item: " + infor.item16 + ", agora possui: " + infor.quant16);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 17)
                                {
                                    Console.WriteLine("O item: " + infor.item17 + ", agora possui: " + infor.quant17);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 18)
                                {
                                    Console.WriteLine("O item: " + infor.item18 + ", agora possui: " + infor.quant18);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 19)
                                {
                                    Console.WriteLine("O item: " + infor.item19 + ", agora possui: " + infor.quant19);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaAdd == 20)
                                {
                                    Console.WriteLine("O item: " + infor.item20 + ", agora possui: " + infor.quant20);
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Digitou errado.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }


                            }
                            else
                            {
                                Console.WriteLine("Digite novamente: ");
                                infor.guiaAdd = int.Parse(Console.ReadLine());
                            }
                        }
                        //saiu
                        else if (attValor == 's')
                        {
                            Console.WriteLine("Legal.");
                            Console.WriteLine("Vamos atualizar qual item?");
                            Console.WriteLine("Por favor informe o numero dele: ");
                            infor.guiaSub = int.Parse(Console.ReadLine());

                            if (infor.guiaSub > 0 && infor.guiaSub < 21)
                            {
                                Console.WriteLine("Informe quantos itens sairam: ");
                                int idS = int.Parse(Console.ReadLine());
                                infor.subItem(idS);

                                if (infor.guiaSub == 1)
                                {
                                    Console.WriteLine("O item " + infor.item1 + " agora possui: " + infor.quant1 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 2)
                                {
                                    Console.WriteLine("O item " + infor.item2 + " agora possui: " + infor.quant2 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 3)
                                {
                                    Console.WriteLine("O item " + infor.item3 + " agora possui: " + infor.quant3 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 4)
                                {
                                    Console.WriteLine("O item " + infor.item4 + " agora possui: " + infor.quant4 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 5)
                                {
                                    Console.WriteLine("O item " + infor.item5 + " agora possui: " + infor.quant5 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 6)
                                {
                                    Console.WriteLine("O item " + infor.item6 + " agora possui: " + infor.quant6 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 7)
                                {
                                    Console.WriteLine("O item " + infor.item7 + " agora possui: " + infor.quant7 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 8)
                                {
                                    Console.WriteLine("O item " + infor.item8 + " agora possui: " + infor.quant8 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 9)
                                {
                                    Console.WriteLine("O item " + infor.item9 + " agora possui: " + infor.quant9 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 10)
                                {
                                    Console.WriteLine("O item " + infor.item10 + " agora possui: " + infor.quant10 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 11)
                                {
                                    Console.WriteLine("O item " + infor.item11 + " agora possui: " + infor.quant11 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 12)
                                {
                                    Console.WriteLine("O item " + infor.item12 + " agora possui: " + infor.quant12 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 13)
                                {
                                    Console.WriteLine("O item " + infor.item13 + " agora possui: " + infor.quant13 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 14)
                                {
                                    Console.WriteLine("O item " + infor.item14 + " agora possui: " + infor.quant14 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 15)
                                {
                                    Console.WriteLine("O item " + infor.item15 + " agora possui: " + infor.quant15 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 16)
                                {
                                    Console.WriteLine("O item " + infor.item16 + " agora possui: " + infor.quant16 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 17)
                                {
                                    Console.WriteLine("O item " + infor.item17 + " agora possui: " + infor.quant17 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 18)
                                {
                                    Console.WriteLine("O item " + infor.item18 + " agora possui: " + infor.quant18 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 19)
                                {
                                    Console.WriteLine("O item " + infor.item19 + " agora possui: " + infor.quant19 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                                else if (infor.guiaSub == 20)
                                {
                                    Console.WriteLine("O item " + infor.item20 + " agora possui: " + infor.quant10 + " em estoque.");
                                    Console.WriteLine();
                                    Console.WriteLine("Qual o proximo passo?");
                                    Console.WriteLine("1. Visualização: ");
                                    Console.WriteLine("2. Remover item: ");
                                    Console.WriteLine("3. Mudar valor de estoque: ");
                                    Console.WriteLine("4. Finalizar: ");
                                    id = id * 0;
                                    attValor = ' ';
                                    id = int.Parse(Console.ReadLine());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Digite errado.");
                                Console.WriteLine();
                                Console.WriteLine("Qual o proximo passo?");
                                Console.WriteLine("1. Visualização: ");
                                Console.WriteLine("2. Remover item: ");
                                Console.WriteLine("3. Mudar valor de estoque: ");
                                Console.WriteLine("4. Finalizar: ");
                                id = id * 0;
                                attValor = ' ';
                                id = int.Parse(Console.ReadLine());
                            }
                        }
                        //digitou errado
                        else
                        {
                            Console.WriteLine("Valor invalido deseja tentar novamente ou sair?");
                            Console.WriteLine("'S' para sair, 'T' para tentar novamente");
                            char resp2 = char.Parse(Console.ReadLine().ToLower());

                            if (resp2 == 's')
                            {
                                Console.WriteLine("Menu de acesso");
                                Console.WriteLine("1. Visualização: ");
                                Console.WriteLine("2. Remover item: ");
                                Console.WriteLine("3. Mudar valor de estoque: ");
                                Console.WriteLine("4. Finalizar: ");
                                id = id * 0;
                                id = int.Parse(Console.ReadLine());
                            }
                            else if (resp2 == 't')
                            {
                                Console.WriteLine("CHEGOU MAIS ITENS OU SAIU?");
                                Console.WriteLine("'c' para chegou, 's' para saiu");
                                attValor = ' ';
                                attValor = char.Parse(Console.ReadLine());
                            }
                        }

                    }


                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

            //feedback
            Console.WriteLine();
            Console.WriteLine("Gostaria de nos avaliar?");
            Console.WriteLine("'s', Para sim/ 'n', Para não");
            char avaliacao = char.Parse(Console.ReadLine().ToLower());


            if(avaliacao == 's')
            {
                Console.WriteLine("Qual sua nota de 1 a 10?");
                int nota = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Sua nota foi: " + nota);
            }
            else
            {
                Console.WriteLine("Ok.");
            }



            //tchau
            Console.WriteLine("Até mais, obrigado por usar meu sistema.");

            Console.ReadLine();
        }
    }
}
