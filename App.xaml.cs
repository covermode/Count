using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Count
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            if (MessageBox.Show("An unhandled exception has occured: " + 
                e.Exception.GetType().Name + 
                " - " + 
                e.Exception.Message + 
                "\n\nClose application?", "Error!", MessageBoxButton.YesNo, MessageBoxImage.Error) == MessageBoxResult.Yes)
            {
                e.Handled = true;
                this.Shutdown();
            }
        }
    }
}
