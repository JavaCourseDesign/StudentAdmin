using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using StudentAdmin.Annotations;

namespace StudentAdmin
{
    public partial class StudentAdminPage : Page
    {
        public ObservableCollection<Person> Students { get; set; }
        
        public StudentAdminPage()
        {
            InitializeComponent();
        }

        private void DelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as ViewModels.DataGridViewModel;
            var student = StudentGrid.Items[StudentGrid.SelectedIndex] as Person;
            if (student == null || student.id == 0) return;
            viewModel?.DeleteHandler(student, true, StudentGrid.SelectedIndex);
        }
    }
}