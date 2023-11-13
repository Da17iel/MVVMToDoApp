using MVVMTodo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMTodo.Commands
{
    public class AddTaskCommand : CommandBase
    {
        public event EventHandler? CanExecuteChanged;

        private ShowAndCreateViewModel _showAndCreateViewModel;

        // you can add a constructor to a command
        public AddTaskCommand(ShowAndCreateViewModel showAndCreateViewModel)
        {
            _showAndCreateViewModel = showAndCreateViewModel;

            _showAndCreateViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            try
            {
                // Add the Task to the TaskList
                _showAndCreateViewModel.Tasks.Add(new Models.Task(
                    _showAndCreateViewModel.Title,
                    _showAndCreateViewModel.Description,
                    _showAndCreateViewModel.Status));

                // Clear the fields
                _showAndCreateViewModel.clearGUI();

                MessageBox.Show("Successfully added task!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
            catch
            {
                MessageBox.Show("Failed to add task!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ShowAndCreateViewModel.Title) ||
                e.PropertyName == nameof(ShowAndCreateViewModel.Tasks))
            {
                OnCanExecutedChanged();
            }
        }
    }
}
