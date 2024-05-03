using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D_Notepad_back.Models
{
    [Table("pensamentos")]
    public class Pensamento
    {
        [Key]
        public int id { get; private set; }
        public string conteudo { get; private set; }
        public string autoria { get; private set; }
        public string modelo { get; private set; }

        public Pensamento(string conteudo, string autoria, string modelo)
        {
            this.conteudo = conteudo;
            this.autoria = autoria;
            this.modelo = modelo;
        }

        public void AtualizarPensamento(string novoConteudo, string novaAutoria, string novoModelo)
        {
            conteudo = novoConteudo;
            autoria = novaAutoria;
            modelo = novoModelo;
        }

        public void AtualizarConteudo(string novoConteudo)
        {
            conteudo = novoConteudo;
        }

        public void AtualizarAutoria(string novaAutoria)
        {
            autoria = novaAutoria;
        }

        public void AtualizarModelo(string novoModelo)
        {
            modelo = novoModelo;
        }
    }
}
