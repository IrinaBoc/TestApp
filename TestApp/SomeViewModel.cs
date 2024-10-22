using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestApp
{
    class SomeViewModel: ViewModelBase
    {
        
        private SomeSource _context;

        public string Data { get; set; }
       
        public SomeSource PopUpContext
        {
            get { return _context; }
            set
            {
                _context = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetDataCommand
        {
            get
            {
                return new RelayCommand(async (obj) =>
                {                   
                    var ds = new SomeSource();
                    PopUpContext = ds;
                    Data = await Task.Run(() => ds.GetData());
                });
            }
        }

    
    }
}
