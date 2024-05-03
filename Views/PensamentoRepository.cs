using D_Notepad_back.Models;

namespace D_Notepad_back.Views
{
    public class PensamentoRepository : IPensamentoRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Pensamento pensamento)
        {
            _context.Pensamentos.Add(pensamento);
            _context.SaveChanges();
        }

        public List<Pensamento> Get()
        {
            return _context.Pensamentos.ToList();
        }

        public Pensamento GetById(int id)
        {
            var pensamento = _context.Pensamentos.FirstOrDefault(p => p.id == id);
            if (pensamento == null)
            {
                 throw new Exception("Pensamento não encontrado com o ID especificado.");
            }

            return pensamento;
        }

        public void Update(Pensamento pensamento)
        {
            var existingPensamento = _context.Pensamentos.FirstOrDefault(p => p.id == pensamento.id);
            if (existingPensamento != null)
            {
                existingPensamento.AtualizarConteudo(pensamento.conteudo);
                existingPensamento.AtualizarAutoria(pensamento.autoria);
                existingPensamento.AtualizarModelo(pensamento.modelo);

                _context.SaveChanges();
            }
        }

        public void Delete(Pensamento pensamento)
        {
            _context.Pensamentos.Remove(pensamento);
            _context.SaveChanges();
        }

    }
}
