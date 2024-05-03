namespace D_Notepad_back.Views
{
    public class PensamentoViewModel
    {
        public PensamentoViewModel()
        {
            conteudo = string.Empty;
            autoria = string.Empty;
            modelo = string.Empty;
        }

        public string conteudo { get; set; }
        public string autoria { get; set; }
        public string modelo { get; set; }


    }
}
