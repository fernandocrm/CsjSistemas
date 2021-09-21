using CsjSistemas.LocaisReciclagem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CsjSistemas.LocaisReciclagem.Domain.Entity
{
    public class LocaisReciclagem : IAggregateRoot
    {
        [Key]
        public Int64 LocalReciclagem_Id { get; private set; }
        public string Identificacao { get; private set; }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public string NumeroEndereco { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public float Capacidade { get; private set; }
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }

        protected LocaisReciclagem() { }
        public LocaisReciclagem(
            Int64 localReciclagem_Id,
            string identificacao,
            string cep,
            string logradouro,
            string numeroEndereco,
            string complemento,
            string bairro,
            string cidade,
            float capacidade, 
            string latitude,
            string longitude)
        {
            LocalReciclagem_Id = localReciclagem_Id;
            Identificacao = identificacao;
            CEP = cep;
            Logradouro = logradouro;
            NumeroEndereco = numeroEndereco;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Capacidade = capacidade;
            Latitude = latitude;
            Longitude = longitude;
            Validar();
        }


        public void Validar()
        {
            Validacoes.ValidarSeVazio(Identificacao, "O campo Identificacao não pode estar vazio");
            Validacoes.ValidarSeVazio(CEP, "O campo CEP não pode estar vazio");
            Validacoes.ValidarSeVazio(Logradouro, "O campo Logradouro não pode estar vazio");
            Validacoes.ValidarSeVazio(Bairro, "O campo Bairro não pode estar vazio");
            Validacoes.ValidarSeVazio(Cidade, "O campo Cidade não pode estar vazio");
            Validacoes.ValidarSeNulo(Capacidade, "O campo Capacidade não pode estar vazio");
            Validacoes.ValidarSeNulo(Latitude, "O campo Latitude não pode estar vazio");
            Validacoes.ValidarSeNulo(Longitude, "O campo Longitude não pode estar vazio");
        }
    }
}
