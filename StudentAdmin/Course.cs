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
                if (_linkId == 0)
                {
                    _linkId = value;
                    OnPropertyChanged();
                } else if (_linkId != value)
                {
                    _linkId = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }
        
        public int stu_id
        {
            get => _stuId;
            set
            {
                if (_stuId == 0)
                {
                    _stuId = value;
                    OnPropertyChanged();
                } else if (_stuId != value)
                {
                    _stuId = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }

        public int course_id
        {
            get => _courseId;
            set
            {
                if (_courseId == 0)
                {
                    _courseId = value;
                    OnPropertyChanged();
                } else if (_courseId != value)
                {
                    _courseId = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }

        public string course_name
        {
            get => _courseName;
            set
            {
                if (_courseName == null)
                {
                    _courseName = value;
                    OnPropertyChanged();
                } else if (_courseName != value)
                {
                    _courseName = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }

        public int teacher_id
        {
            get => _teacherId;
            set
            {
                if (_teacherId == 0)
                {
                    _teacherId = value;
                    OnPropertyChanged();
                } else if (_teacherId != value)
                {
                    _teacherId = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }
        
        public int grade
        {
            get => _grade;
            set
            {
                if (_grade == 0)
                {
                    _grade = value;
                    OnPropertyChanged();
                } else if (_grade != value)
                {
                    _grade = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/course/update?linkId={_linkId}&studentId={_stuId}&courseId={_courseId}&courseName={_courseName}&teacherId={_teacherId}&grade={_grade}");
                    OnPropertyChanged();
                }
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}