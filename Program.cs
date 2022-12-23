using System;
namespace Exe5
{
    class Node
    {
        public string name;
        public Node next;
    }

    class queue
    {
        Node MAULA, GHANI;
        public queue()
        {
            MAULA = null;
            GHANI = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element :");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (MAULA == null)
            {
                MAULA = newnode;
                GHANI = newnode;
            }
        }
        public void delete()
        {
            if (MAULA == null)
            {
                Console.WriteLine("Queue Kosong !");
                return;
            }
            MAULA = MAULA.next;
            if (MAULA == null)
                GHANI = null;
        }

        public void display()
        {
            if (MAULA == null)
            {
                Console.WriteLine("Queue tidak ada!");
                return;
            }
            Node display;
            for (display = MAULA; display != null; display = display.next)
                Console.WriteLine(display.name);
        }

        class Program
        {
            static void Main(string[] args)
            {
                queue q = new queue();
                char ch;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Masukan Data : ");
                        Console.WriteLine("2. Menghapus Data : ");
                        Console.WriteLine("3. Display Data : ");
                        Console.WriteLine("4. Keluar : ");
                        Console.Write("\nMasukan Pilihannya : ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch(ch)
                        {
                            case '1':
                                q.insert();
                                break;
                            case '2':
                                q.delete();
                                break;
                            case '3':
                                q.display();
                                break;
                            case '4':
                                return;
                            default:
                                Console.WriteLine("Pilihan Salah");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Check the values");
                    }
                }
            }
        }
     }
}


