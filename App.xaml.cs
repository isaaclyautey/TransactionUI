using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TransactionUI.Services;
using TransactionUI.ViewModels;
using TransactionUI.Views;

namespace TransactionUI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var database = new Database();
                
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(database),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}