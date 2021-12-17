using Atividade_MVVM_2._0.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;


namespace Atividade_MVVM_2._0.ViewModel   //AONDE QUE VAI MANTER A LISTA
{
    //ViEwModelLista que vai ser jogado na nossa MainWindows
    public class ViewModelLista : ViewModelBase   
    {
        //sempre que for trabalhar com lista nao esquecer o ObservableCollection , se  nao a lista nao vai ser notificada, que ela mudou , td que for lista 
        public ObservableCollection<UsuarioModel> Usuarios //Lista de Usuario
        {
            get;
            set;
        }

        public Command AdicionarCommand
        {
            get;
            set;
        }
        
        public Command <UsuarioModel> AlterarCommand  //<UsuarioModel> operador de tipo 
        {
            get;
            set;
        }

        public Command <UsuarioModel> ExcluirCommand
        {
            get;
            set;
        }


        
        public ViewModelLista()
        {
            Usuarios = new ObservableCollection<UsuarioModel>(); // intanciando a lista nova/ usuario novo            
            AdicionarCommand = new Command(Salvar);
            AlterarCommand = new Command<UsuarioModel>(Alterar);
            ExcluirCommand = new Command<UsuarioModel>(Excluir);
                                 
           
        }



        //metodo
        private void Salvar()
        {

            ViewModelDetalhe vm = new ViewModelDetalhe { Usuario = new UsuarioModel() }; //instancia uma view model detalhe , instanciando um Usuario vazio novo
            CadastroUsuario view = new CadastroUsuario(vm); // instancia da janela            
            view.ShowDialog();

            Usuarios.Add(vm.Usuario);// adicionando o usuario a nossa lista
        }

        //editar usuario
        private void Alterar(UsuarioModel model)
        {
            //Objeto temporario
            var temporario = new UsuarioModel { 

                Cidade = model.Cidade, 
                Cpf = model.Cpf, 
                Endereco = model.Endereco, 
                Nome = model.Nome ,
                NumeroRes = model.NumeroRes 
            
            }; //fim Objeto temporario
            
            ViewModelDetalhe vm = new ViewModelDetalhe { Usuario = temporario }; //instancia uma view model detalhe , instanciando um Usuario vazio novo
            CadastroUsuario view = new CadastroUsuario(vm); // instancia da janela
            view.ShowDialog();// abrindo a janela

            //verificar se o Usuario deu o OK
            if(view.DialogResult.HasValue && view.DialogResult == true)
            {
                model.Nome = temporario.Nome;
                model.Cidade = temporario.Cidade;
                model.Cpf = temporario.Cpf; 
                model.Endereco = temporario.Endereco;
                model.NumeroRes = temporario.NumeroRes;
            }
                        

        }

        //Excluindo o usuario
        private void Excluir(UsuarioModel model)
        {
            Usuarios.Remove(model);
        }

      
    }
}
