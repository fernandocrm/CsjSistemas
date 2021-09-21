using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.WebAppMVC.Model
{
    public class LocalReciclagemModel
    {
        public Int64 LocalReciclagem_Id { get; set; }
        public string Identificacao { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string NumeroEndereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public float Capacidade { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
