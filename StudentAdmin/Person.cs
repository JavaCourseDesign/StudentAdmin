using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentAdmin.Annotations;

namespace StudentAdmin
{
    public class Person: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _id;
        private string _name;
        private string _sex;

        public int id
        {
            get => _id;
            set
            {
                if (_id == 0)
                {
                    _id = value;
                    OnPropertyChanged();
                } else if (_id != value)
                {
                    _id = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/student/update?id={_id}&name={_name}&sex={_sex}");
                    OnPropertyChanged();
                }
            }
        }

        public string name {
            get => _name;
            set
            {
                if (_id == 0 && _sex != null)
                {
                    _name = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/student/add?name={_name}&sex={_sex}");
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(id));
                }
                if (_name == null)
                {
                    _name = value;
                    OnPropertyChanged();
                } else if (_name != value)
                {
                    _name = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/student/update?id={_id}&name={_name}&sex={_sex}");
                    OnPropertyChanged();
                }
            }
        }

        public string sex {
            get => _sex;
            set
            {
                if (_sex == null)
                {
                    _sex = value;
                    OnPropertyChanged();
                } else if (_sex != value)
                {
                    _sex = value;
                    HttpClientHelper.Get($"http://rinne.top:16384/student/update?id={_id}&name={_name}&sex={_sex}");
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