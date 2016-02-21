// -----------------------------------------------------------
// This program is private software, based on C# source code.
// To sell or change credits of this software is forbidden,
// except if someone approves it from the LeafyCoding INC. team.
// -----------------------------------------------------------
// Copyrights (c) 2016 LeafyYT-Downloader INC. All rights reserved.
// -----------------------------------------------------------

#region

using System.ComponentModel;
using System.Runtime.CompilerServices;

#endregion

namespace Leafy_MD5check.Classes
{
    internal sealed class SelectableViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _path;
        private string _result;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Path
        {
            get { return _path; }
            set
            {
                if (_path == value) return;
                _path = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get { return _result; }
            set
            {
                if (_result == value) return;
                _result = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}