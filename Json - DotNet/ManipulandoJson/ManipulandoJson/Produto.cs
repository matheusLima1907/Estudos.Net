using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ManipulandoJson
{
    [System.Runtime.Serialization.DataContract]
    public class Produto
    {
        //propriedades objeto produto
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public decimal PrecoVenda { get; set; }      
        public DateTime DataCadastro { get; set; }      
        public decimal PrecoCusto { get; set; }   
        public string DescricaoEtiqueta { get; set; }

        //construtor classe produto
        public Produto(int codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            PrecoVenda = preco;
        }
        //metodo p/ retornar informações produto
        public override string ToString()
        {
            return $"{Codigo} - {Nome} - {PrecoVenda}";
        }
    }
}
