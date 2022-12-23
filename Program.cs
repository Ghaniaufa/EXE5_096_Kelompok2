using System;
namespace Exe5
{
    class QNode
    {
        public int key;
        public QNode next;
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}

class Queue
{
    public QNode maula, ghani;

    public Queue()
    {
        this.maula = this.ghani = null;
    }
    public void enqueue(int key)
    {

    }
}

