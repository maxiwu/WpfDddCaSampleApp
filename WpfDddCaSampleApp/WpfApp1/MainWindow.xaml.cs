using Autofac;
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
using WpfApp1.Region;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IContainer container)
        {
            InitializeComponent();

            TopRegion.Content = container.Resolve<TopView>();
            //BottomRegion.Content = container.Resolve<BottomView>();
            //LeftRegion.Content = container.Resolve<LeftView>();
            //RightRegion.Content = container.Resolve<RightView>();
            //CenterRegion.Content = container.Resolve<CenterView>();
        }
    }
}
