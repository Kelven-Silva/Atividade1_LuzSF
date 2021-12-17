using System.ComponentModel;


namespace Atividade_MVVM_2._0.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); // PropertyChanged?-> aki testa se alguem esta assinando o evento
        }
    }
}
