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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RuralTech.Telas
{
    /// <summary>
    /// Lógica interna para CadastroDeAnimal.xaml
    /// </summary>
    public partial class CadastroDeAnimal : Window

    {
        private bool isMenuExpanded = false;
        public Thickness positionLogos = new Thickness(0, 90, 0, 0);
        
        public CadastroDeAnimal()
        {
            InitializeComponent();
            var posicaoLogos = "0,90";
            //positionLogos = posicaoLogos;
            MessageBox.Show(positionLogos.ToString());


        }

        private void PackIcon_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void imagem_status_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();

           
            if (isMenuExpanded)
            {

                appBar_Logos.Margin = positionLogos;
                animation.From = appBar_Esquerdo.ActualWidth;
                animation.To = 100;
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            }
            else
            {
                MessageBox.Show(positionLogos.ToString());

                appBar_Logos.Margin = positionLogos;
                animation.From = 0;
                animation.To = 400;
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            }
            isMenuExpanded = !isMenuExpanded;
            appBar_Esquerdo.BeginAnimation(FrameworkElement.WidthProperty, animation);
        }
    }
}
