Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace Example.ViewModel

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _ShowMessageCommand As ICommand

        Public Property ShowMessageCommand As ICommand
            Get
                Return _ShowMessageCommand
            End Get

            Private Set(ByVal value As ICommand)
                _ShowMessageCommand = value
            End Set
        End Property

        Private ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        Public Sub New()
            ShowMessageCommand = New DelegateCommand(AddressOf ShowMessage)
        End Sub

        Private Sub ShowMessage()
            MessageBoxService.Show("This is MainView!")
        End Sub
    End Class
End Namespace
