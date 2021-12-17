using System.ComponentModel;


namespace Atividade_MVVM_2._0.Model
{
    public abstract class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); // PropertyChanged?-> aki testa se alguem esta assinando o evento
        }


    }
}
