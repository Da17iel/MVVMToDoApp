using MVVMToDoApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMToDoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            
        }

        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow window = new MainWindow()
            {
                DataContext = new ShowAndCreateViewModel()
            };

            window.Show();

            base.OnStartup(e);
        }
    }
}
