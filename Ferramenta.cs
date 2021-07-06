using System;

namespace pooStatic
{
    public class Ferramenta
    {
        private static int NextID;
        public Ferramenta(string nome, int durabilidade)
        {
            try
            {
                NextID++;
            }
            catch
            {
                NextID = 1;
            }
            this.ID = NextID;
            this.Nome = nome;
            this.Durabilidade = durabilidade;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Durabilidade { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("ID: " + this.ID + " - Nome: " + this.Nome + " - Durabilidade: " + this.Durabilidade);
        }

    }
}
