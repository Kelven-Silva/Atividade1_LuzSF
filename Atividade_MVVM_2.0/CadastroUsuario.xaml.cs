﻿using Atividade_MVVM_2._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Atividade_MVVM_2._0
{
    /// <summary>
    /// Lógica interna para CadastroUsuario.xaml
    /// </summary>
    public partial class CadastroUsuario : Window
    {
        public CadastroUsuario(ViewModelDetalhe vm) // recebendo a viewModel detalhe
        {
            InitializeComponent();
            DataContext = vm;
            
        }


    }
}
