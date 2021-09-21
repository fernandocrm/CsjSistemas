using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.WebAppMVC.Model
{
    public class RespostaLocalReciclagemModel : ResponseResultModel
    {
        public string title { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string description { get; set; }
        public string id { get; set; }
    }
}
