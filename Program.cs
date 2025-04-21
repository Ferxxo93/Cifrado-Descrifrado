using System;
using System.Collections.Generic;

class Program
{
    public static Dictionary<char, char> dicCypher = new Dictionary<char, char>();
    public static Dictionary<char, char> dicDeCypher = new Dictionary<char, char>();

    static void Main()
    {
        LoadDictionaries();

        while (true)
        {
            Console.WriteLine("1. Cifrar");
            Console.WriteLine("2. Descifrar");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "3")
            {
                break;
            }

            Console.Write("Ingresa el mensaje: ");
            string mensaje = Console.ReadLine();

            string resultado = ProcesarMensaje(mensaje, opcion == "1" ? dicCypher : dicDeCypher);

            Console.WriteLine("Resultado:");
            Console.WriteLine(resultado);

            Console.Write("¿Volver atrás? (S/N): ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                string revertido = ProcesarMensaje(resultado, opcion == "1" ? dicDeCypher : dicCypher);
                Console.WriteLine("Mensaje revertido:");
                Console.WriteLine(revertido);
            }
        }
    }

    static string ProcesarMensaje(string mensaje, Dictionary<char, char> diccionario)
    {
        Queue<char> cola = new Queue<char>(mensaje);
        Stack<char> pila = new Stack<char>();

        while (cola.Count > 0)
        {
            char c = cola.Dequeue();
            pila.Push(diccionario.ContainsKey(c) ? diccionario[c] : c);
        }

        string resultado = "";
        while (pila.Count > 0)
            resultado += pila.Pop();

        return resultado;
    }

    private static void LoadDictionaries()
    {
        
        dicCypher.Add('a', 'n');
        dicCypher.Add('b', 'o');
        dicCypher.Add('c', 'p');
        dicCypher.Add('d', 'q');
        dicCypher.Add('e', 'r');
        dicCypher.Add('f', 's');
        dicCypher.Add('g', 't');
        dicCypher.Add('h', 'u');
        dicCypher.Add('i', 'v');
        dicCypher.Add('j', 'w');
        dicCypher.Add('k', 'x');
        dicCypher.Add('l', 'y');
        dicCypher.Add('m', 'z');
        dicCypher.Add('n', 'a');
        dicCypher.Add('o', 'b');
        dicCypher.Add('p', 'c');
        dicCypher.Add('q', 'd');
        dicCypher.Add('r', 'e');
        dicCypher.Add('s', 'f');
        dicCypher.Add('t', 'g');
        dicCypher.Add('u', 'h');
        dicCypher.Add('v', 'i');
        dicCypher.Add('w', 'j');
        dicCypher.Add('x', 'k');
        dicCypher.Add('y', 'l');
        dicCypher.Add('z', 'm');
        dicCypher.Add(' ', '*');

        
        dicDeCypher.Add('n', 'a');
        dicDeCypher.Add('o', 'b');
        dicDeCypher.Add('p', 'c');
        dicDeCypher.Add('q', 'd');
        dicDeCypher.Add('r', 'e');
        dicDeCypher.Add('s', 'f');
        dicDeCypher.Add('t', 'g');
        dicDeCypher.Add('u', 'h');
        dicDeCypher.Add('v', 'i');
        dicDeCypher.Add('w', 'j');
        dicDeCypher.Add('x', 'k');
        dicDeCypher.Add('y', 'l');
        dicDeCypher.Add('z', 'm');
        dicDeCypher.Add('a', 'n');
        dicDeCypher.Add('b', 'o');
        dicDeCypher.Add('c', 'p');
        dicDeCypher.Add('d', 'q');
        dicDeCypher.Add('e', 'r');
        dicDeCypher.Add('f', 's');
        dicDeCypher.Add('g', 't');
        dicDeCypher.Add('h', 'u');
        dicDeCypher.Add('i', 'v');
        dicDeCypher.Add('j', 'w');
        dicDeCypher.Add('k', 'x');
        dicDeCypher.Add('l', 'y');
        dicDeCypher.Add('m', 'z');
        dicDeCypher.Add('*', ' ');
    }
}
