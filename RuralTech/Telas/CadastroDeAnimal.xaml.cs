﻿using System;
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

namespace RuralTech.Telas
{
    /// <summary>
    /// Lógica interna para CadastroDeAnimal.xaml
    /// </summary>
    public partial class CadastroDeAnimal : Window
    {
        public CadastroDeAnimal()
        {
            InitializeComponent();
        }

        private void PackIcon_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            stack_barraLateral.Width = 1500;
        }
    }
}
