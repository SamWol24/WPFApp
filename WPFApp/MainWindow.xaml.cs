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

namespace WPFApp
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
        void CreateTask()
        {
            Task T;
            // ¿que es un delegado? Apuntador de funciones.
            // poe ejemplo: Ation (No devuelve valores) y Func (Devuelve Valores)
            Action Code = new Action(ShowMesage);
            T = new Task(Code);
            Task T2 = new Task(delegate
            {
                MessageBox.Show("Ejecutando el metodo anonimo.");
            }
            );
        }
        void ShowMesage()
        {
            MessageBox.Show("Ejecutando el metodo ShowMessege");
        }
        
    }
}