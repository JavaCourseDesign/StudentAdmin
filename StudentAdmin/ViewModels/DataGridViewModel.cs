using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Data;
using StudentAdmin.Annotations;

namespace StudentAdmin.ViewModels
{
    public class DataGridViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Person> Students { get; set; }
        public ObservableCollection<Person> Teachers { get; set; }
        public ObservableCollection<Course> Courses { get; set; }

        public DataGridViewModel()
        {
            Students = JsonSerializer.Deserialize<ObservableCollection<Person>>(HttpClientHelper.Get("http://rinne.top:16384/student/list"));
            Teachers = JsonSerializer.Deserialize<ObservableCollection<Person>>(HttpClientHelper.Get("http://rinne.top:16384/teacher/list"));
            Courses = JsonSerializer.Deserialize<ObservableCollection<Course>>(HttpClientHelper.Get("http://rinne.top:16384/course/list"));
        }

        public void DeleteHandler(Person person, bool isStudent, int index)
        {
            if (isStudent)
            {
                Students.RemoveAt(index);
                HttpClientHelper.Get($"http://rinne.top:16384/student/del?id={person.id}");
            }
            else
            {
                Teachers.RemoveAt(index);
                HttpClientHelper.Get($"http://rinne.top:16384/teacher/del?id={person.id}");
            }
        }

        public void DeleteHandler(Course course, int index)
        {
            Courses.RemoveAt(index);
            HttpClientHelper.Get($"http://rinne.top:16384/course/del?linkId={course.link_id}");
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}