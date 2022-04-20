using System.Text;
using System.Threading.Tasks;

namespace webapimvc.Models
{
    public class Fornecedor 
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        

    }
}
