using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.WebAppMVC.Model
{
    public class JsonResultModel
    {
        public List<LocalReciclagem> value { get; set; }
        public string declaredType { get; set; }
        public string statusCode { get; set; }
    }


    public class LocalReciclagem
    {
        public string bairro { get; set; }
        public string capacidade { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string identificacao { get; set; }
        public string localReciclagem_Id { get; set; }
        public string logradouro { get; set; }
        public string numeroEndereco { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
