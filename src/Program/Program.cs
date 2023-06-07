using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Persona a = new Persona (100, "Maria");
            Node n1 = new Node(1, a);
            Node n2 = new Node (2, new Persona(72, "Jose"));
            Node n3 = new Node(3, new Persona(39, "Alberto"));
            Node n4 = new Node(4, new Persona(45, "Lucas"));
            Node n5 = new Node(5, new Persona(50, "Joaquin"));
            Node n6 = new Node(6, new Persona(46, "Shakira"));
            Node n7 = new Node(7, new Persona(67, "Mario"));
            Node n8 = new Node(8, new Persona(70, "Marisa"));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            CensoEdad censita1 = new CensoEdad();
            censita1.Visit(n1);

            Console.WriteLine(censita1.edad);
        }
    }
}
