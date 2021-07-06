using System;

namespace pooStatic
{
    public class ModoTexto
    {
        static public string log;
        static public void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }

        static public void Pausar()
        {
            Console.ReadKey();
        }
        static public string Ler()
        {
            return Console.ReadLine();
        }
        static public string Ler(string texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }
    }
}
