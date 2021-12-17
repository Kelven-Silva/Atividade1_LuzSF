

namespace Atividade_MVVM_2._0.Model
{
    public class UsuarioModel : ModelBase
    {

        private string nome;
        private string cpf;
        private string endereco;
        private string numeroRes;
        private string cidade;


        //PROPRIEDADE
        public string Nome
        {
            get { return nome; }
            set{nome = value; OnPropertyChanged("Nome"); }
        }

        public string Cpf
        {
            get { return cpf; }
            set{ cpf = value; OnPropertyChanged("Cpf"); }

        }

        public string Endereco
        {

            get { return endereco; }
            set{endereco = value; OnPropertyChanged("Endereco");}

        }

        public string NumeroRes
        {
            get { return numeroRes; }
            set{numeroRes = value; OnPropertyChanged("NumeroRes");}

        }

        public string Cidade
        {
            get { return cidade; }
            set{cidade = value; OnPropertyChanged("Cidade"); } // so um exemplo aonde e chamado para notifycar  //  OnPropertyChanged("Cidade"); -> aki notifica a view


        }


    }
}
