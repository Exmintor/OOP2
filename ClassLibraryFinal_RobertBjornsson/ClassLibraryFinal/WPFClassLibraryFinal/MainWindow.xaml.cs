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
using ClassLibraryFinal;
using ClassLibraryFinal.NinjectModules;
using Ninject;
using WPFClassLibraryFinal.NinjectModules;
using WPFClassLibraryFinal.ViewModel;
using UnitTestFinal.NinjectModules;

namespace WPFClassLibraryFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IKernel kernel;
        ShippingViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            // Just inject everything we need
            kernel = new StandardKernel(new ShippingServiceModule(), new ShippingServiceTestModule(), new ShippingViewmodelModule());
            this.viewModel = kernel.Get<ShippingViewModel>();
            this.DataContext = viewModel;
            // The combo box needs an initial value so that it is not empty when the application is started
            this.cbShippingServices.SelectedIndex = 0;
        }
    }
}
