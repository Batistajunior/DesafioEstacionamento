using System;
namespace diobootCamp.DesafioEstacionamento

{
    public class sistemaDeEstacionamento
    {
        public decimal PrecoInicial { get; }
        public decimal PrecoPorHora { get; }

        public sistemaDeEstacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.PrecoInicial = precoInicial;
            this.PrecoInicial = precoPorHora;
        }

        public List<veiculos> listaVeiculos = new List<veiculos>();

        public bool check;
        public bool VeiculoEstacionado(string entrada)
        {
            foreach (veiculos v in listaVeiculos)
            {
                string placaCheck = v.Placa;
                if (placaCheck == entrada)
                {
                    check = true;
                    listaVeiculos.Remove(v);
                    return check;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
    }
}

