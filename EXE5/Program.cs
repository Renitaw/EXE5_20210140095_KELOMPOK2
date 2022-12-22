using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EXE5
{
    class Node 
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Renita, Widiastuti;
        public queue()
        {
            Renita = null;
            Widiastuti = null;
        }
        public void insert()
        {
            string k2;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k2 = Console.ReadLine();
            newnode.name = k2;
            newnode.next = null;
            if (Renita == null)
            {
                Renita = newnode;
                Widiastuti = newnode;
                return;
            }
        }
    }
}
