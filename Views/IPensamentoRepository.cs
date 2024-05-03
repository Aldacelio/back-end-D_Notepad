using D_Notepad_back.Models;

namespace D_Notepad_back.Views
{
    public interface IPensamentoRepository
    {
        void Add(Pensamento pensamento);

        List<Pensamento> Get();

        Pensamento GetById(int id);
        void Update(Pensamento pensamento);
        void Delete(Pensamento pensamento);

    }
}
