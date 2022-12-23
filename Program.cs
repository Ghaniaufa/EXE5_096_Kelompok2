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
     }
}


