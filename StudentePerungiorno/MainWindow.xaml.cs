using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentePerungiorno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_printer_Click(object sender, RoutedEventArgs e)
        {
            string nome = txt_nome.Text;
            string cognome = txt_cognome.Text;
            var compleanno = dtp_compleanno.SelectedDate;
            StreamWriter sw = new StreamWriter("Salvataggi.txt", false, Encoding.UTF8);
            sw.WriteLine($"Ciao {nome} {cognome} {compleanno}!");

            sw.Flush();
            sw.Close();
        }

        private void btn_great_Click(object sender, RoutedEventArgs e)
        {

            string nome = txt_nome.Text;
            string cognome = txt_cognome.Text;
            var compleanno = dtp_compleanno.SelectedDate;
            if(compleanno>DateTime.Today)
                MessageBox.Show("non puoi essere nato nel futuro", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (nome=="" || cognome=="")
            {
                MessageBox.Show("inserire nome e cognome", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
            }else
              lbl_risposta.Content = $"Ciao {nome} {cognome} {compleanno}!";
            
       
        }

        private void chb_inf_Checked(object sender, RoutedEventArgs e)
        {
            btn_printer.IsEnabled = true;

        }

        private void chb_inf_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_printer.IsEnabled = false;
        }
    }
}
