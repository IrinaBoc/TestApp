using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestApp
{
    class SomeSource:ViewModelBase
    {       
        private string _inputText;
        private bool _enabled;

        public SomeSource()
        {
            PopUpEnabled = true;
        }
        public bool TextInputDone {get; set; }
        public bool PopUpEnabled
        {
            get { return _enabled; }
            set
            {
                _enabled = value;
                OnPropertyChanged();
            }
        }
        public string InputIext
        {
            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetUserInputCommand
        {
            get
            {
                return new RelayCommand( (obj) =>
                {
                    TextInputDone = true;
                });
            }
        }
        internal string GetData()
        {
            try
            {
                while (!TextInputDone)
                {
                    
                }
                PopUpEnabled = false;
                return InputIext;
            }
            catch (Exception)
            {
                PopUpEnabled = false;               
            }
            return null;
        }
    }
}
