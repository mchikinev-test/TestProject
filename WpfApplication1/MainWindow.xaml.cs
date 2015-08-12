using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApplication1
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

        CollectionView myView;
        private void AddGrouping(object sender, RoutedEventArgs e)
        {
            //myView = (CollectionView)CollectionViewSource.GetDefaultView(myItemsControl.ItemsSource);
            //if (myView.CanGroup == true)
            //{
            //    PropertyGroupDescription groupDescription
            //        = new PropertyGroupDescription("@Type");
            //    myView.GroupDescriptions.Add(groupDescription);
            //}
            //else
            //    return;
        } 
 
        private void RemoveGrouping(object sender, RoutedEventArgs e)
        {
            //myView = (CollectionView)CollectionViewSource.GetDefaultView(myItemsControl.ItemsSource);
            //myView.GroupDescriptions.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}