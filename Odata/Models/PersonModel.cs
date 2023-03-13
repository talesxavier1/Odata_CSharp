using System.ComponentModel.DataAnnotations;

namespace Odata.Models {
    public class PersonModel {
        [Key]
        public string cpf { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string rg { get; set; }
        public string data_nasc { get; set; }
        public string pai { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone_fixo { get; set; }
        public string celular { get; set; }
        public float altura { get; set; }
        public float peso { get; set; }
        public string tipo_sanguineo { get; set; }
        public string cor { get; set; }
    }
}
