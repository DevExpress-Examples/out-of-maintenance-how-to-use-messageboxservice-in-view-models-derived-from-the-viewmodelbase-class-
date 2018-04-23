using DevExpress.Mvvm;
using System.Windows.Input;

namespace Example.ViewModel {
    public class MainViewModel : ViewModelBase {
        public ICommand ShowMessageCommand { get; private set; }
        IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(); } }

        public MainViewModel() {
            ShowMessageCommand = new DelegateCommand(ShowMessage);
        }
        void ShowMessage() {
            MessageBoxService.Show("This is MainView!");
        }
    }
}
