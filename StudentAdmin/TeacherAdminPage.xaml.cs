using System.Windows;
using System.Windows.Controls;

namespace StudentAdmin
{
    public partial class TeacherAdminPage : Page
    {
        public TeacherAdminPage()
        {
            InitializeComponent();
        }

        private void DelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as ViewModels.DataGridViewModel;
            var teacher = TeacherGrid.Items[TeacherGrid.SelectedIndex] as Person;
            if (teacher == null || teacher.id == 0) return;
            viewModel?.DeleteHandler(teacher, false, TeacherGrid.SelectedIndex);
        }
    }
}