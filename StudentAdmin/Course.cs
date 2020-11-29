using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentAdmin.Annotations;

namespace StudentAdmin
{
    public class Course: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _linkId;
        private int _stuId;
        private int _courseId;
        private string _courseName;
        private int _teacherId;
        private int _grade;
        
        public int link_id
        {
            get => _linkId;
            set
            {
                if (_linkId == value) return;
                _linkId = value;
                OnPropertyChanged();
            }
        }
        
        public int stu_id
        {
            get => _stuId;
            set
            {
                if (_stuId == value) return;
                _stuId = value;
                OnPropertyChanged();
            }
        }

        public int course_id
        {
            get => _courseId;
            set
            {
                if (_courseId == value) return;
                _courseId = value;
                OnPropertyChanged();
            }
        }

        public string course_name
        {
            get => _courseName;
            set
            {
                if (_courseName == value) return;
                _courseName = value;
                OnPropertyChanged();
            }
        }

        public int teacher_id
        {
            get => _teacherId;
            set
            {
                if (_teacherId == value) return;
                _teacherId = value;
                OnPropertyChanged();
            }
        }
        
        public int grade
        {
            get => _grade;
            set
            {
                if (_grade == value) return;
                _grade = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}