using System.Windows;
using System.Windows.Controls;

namespace StudentAdmin
{
    public partial class CourseAdminPage : Page
    {
        public CourseAdminPage()
        {
            InitializeComponent();
        }

        private void DelBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as ViewModels.DataGridViewModel;
            var course = CourseGrid.Items[CourseGrid.SelectedIndex] as Course;
            if (course == null || course.link_id == 0) return;
            viewModel?.DeleteHandler(course, CourseGrid.SelectedIndex);
        }
    }
}