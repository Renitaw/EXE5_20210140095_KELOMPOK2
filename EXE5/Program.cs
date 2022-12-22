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
            Renita = newnode;
            Widiastuti = newnode;
        }
        public void delete()
        {
            if (Renita == null)
            {
                Console.WriteLine("Queue is Empty!!!");
                return;
            }
            Renita = Renita.next;
            if (Renita == null)
                Widiastuti = null;
        }
        public void display()
        {
            if (Renita == null)
            {
                Console.WriteLine("Queue is Empty or Filled !!!");
                return ;
            }
            Node display;
            for (display = Renita; display != null; display = display.next)
                 Console.WriteLine(display.name);
        }
       
    }
}
