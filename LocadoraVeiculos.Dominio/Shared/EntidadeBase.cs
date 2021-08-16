using System;

namespace LocadoraVeiculos.Dominio.Shared
{
    public abstract class EntidadeBase
    {
        public int Id;
       
        public abstract string Validar();

        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}