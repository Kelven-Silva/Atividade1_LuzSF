using Atividade_MVVM_2._0.Model; // da pasta Model
using System.Windows;

namespace Atividade_MVVM_2._0.ViewModel
{
    public class ViewModelDetalhe : ViewModelBase
    {
        //propriedade Cliente , apertando o botão salvar ele entra aki no Usuario, que pega as propriedades da clase Model/UsuarioModel
        public UsuarioModel Usuario
        {
            get;
            set;
        }

        // quando o botão e do CRUD e selecionado o command e chamado
        public Command<Window> SalvarCommand { get; set; }
        
        public ViewModelDetalhe()
        {
            SalvarCommand = new Command<Window>(Confirmar);
        }

        private void Confirmar(Window janela)
        {
            janela.DialogResult = true; // definindo que o resultado do dialog e verdadeiro

            janela.Close();
        }

    }
}
