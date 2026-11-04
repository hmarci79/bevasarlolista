

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bevasarlolista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> bevasarlolista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frissites()
        {
            tb_ossz.Text = "Összes elem: " + bevasarlolista.Count.ToString();
            lb_lista.ItemsSource = null;
            lb_lista.ItemsSource = bevasarlolista;
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (tb_ujtermek.Text != "")
            {
                bevasarlolista.Add(tb_ujtermek.Text);
                tb_ujtermek.Text = "";
                Frissites();
            }
        }

        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {
            if (lb_lista.SelectedItem != null)
            {
                bevasarlolista.Remove(lb_lista.SelectedItem.ToString());
                Frissites();
            }
        }


    }
}