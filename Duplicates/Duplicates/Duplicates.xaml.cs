using System;
using System.Collections;
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
using System.Text.RegularExpressions;

namespace Duplicates
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
       
        HashSet<string> set = new HashSet<string>();
        HashSet<string> dupes = new HashSet<string>();

        //Unique List
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listType.Content = "Duplicates Removed";
            output.Text = "";
            foreach (string s in set)
            {
                output.Text += s + "\n";
            }
        }       
     


        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            set = new HashSet<string>();
            dupes = new HashSet<string>();
            string[] temp = Regex.Split(input.Text, "\n");
            foreach (string s in temp)
            {
                if (!set.Contains(s.Trim()))
                {
                    set.Add(s.Trim());
                }
                else {
                    dupes.Add(s.Trim());
                }
            }
        }

        //Duplicates list
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                listType.Content = "Duplicates";
                output.Text = "";
                foreach (string s in dupes)
                {
                    output.Text += s + "\n";
                }
            
        }
    }
        
}
