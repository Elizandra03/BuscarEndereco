using Newtonsoft.Json.Linq;

namespace BuscaEndereco.Models
{
    public class Endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string IBGE  { get; set; }
        public string GIA  { get; set; }
        public string DDD { get; set; }
        public string Siafi { get; set; }

        public Endereco(JToken token)
        {
            CEP = token.SelectToken("cep").ToString();
            Logradouro = token.SelectToken("logradouro").ToString();
            Complemento = token.SelectToken("complemento").ToString();
            Bairro = token.SelectToken("bairro").ToString();
            Localidade = token.SelectToken("localidade").ToString();
            UF = token.SelectToken("uf").ToString();
            IBGE = token.SelectToken("ibge").ToString();
            GIA = token.SelectToken("gia").ToString();
            DDD = token.SelectToken("ddd").ToString();
            Siafi = token.SelectToken("siafi").ToString();        
        }
    }
}
