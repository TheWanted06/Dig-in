using Dig_in;
using Dig_in.Class_Vault;
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
using Convert = Dig_in.Class_Vault.Convert;

namespace Just_Dig_in
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();


            CookBook cook = new CookBook();
            cook = Convert.Convert_to_object();
            List<Recipe> recipes = new List<Recipe>();
            recipes = cook.recipes;
            MyList.ItemsSource = cook.recipes;

        }
    }
}
