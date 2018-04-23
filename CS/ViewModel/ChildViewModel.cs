using DevExpress.Mvvm;
using System.Windows.Input;

namespace Example.ViewModel {
    public class ChildViewModel : ViewModelBase {
        public ICommand ShowMessageCommand { get; private set; }
        public ChildViewModel() {
            ShowMessageCommand = new DelegateCommand(ShowMessage);
        }

        IMessageBoxService MessageBoxService { get { return GetService<IMessageBoxService>(ServiceSearchMode.PreferParents); } }
        void ShowMessage() {
            MessageBoxService.Show("This is ChildView");
        }
    }
}
