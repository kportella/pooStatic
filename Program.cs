using System;

namespace pooStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Danilo";
            ModoTexto.log = nome;
            //ModoTexto.Escrever("Qual é o seu nome");
            //nome = ModoTexto.Ler("Qual é o seu nome");
            ModoTexto.Ler("Olá " + ModoTexto.log);
            ModoTexto.Pausar();
        }

    }
}
