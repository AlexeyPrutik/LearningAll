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
using System.Windows.Navigation;
using System.Windows.Shapes;

using LearningAll.Terms;

namespace LearningAll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class UsingMyDelegate 
    {
        // Изучаю работу с делегатами в этом классе
        // https://msdn.microsoft.com/ru-ru/library/ms173172.aspx
        // -----------------------------------------------------

        private TextBox textBox;
        public void CallbackIt(string message)
        {
            textBox.Text = message;
        }
        public UsingMyDelegate(TextBox textBoxDelegate)
        {
            textBox = textBoxDelegate;
            MyDelegate myDel = new MyDelegate();
            myDel.MethodWithCallback(10, 20, CallbackIt);
        }
    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            UsingMyDelegate MyDelegate = new UsingMyDelegate(textBoxDelegate);
        }
    }
}
