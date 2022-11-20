
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacWpfApp
{
    // [AddINotifyPropertyChangedInterface] as a simple alternative
    public partial class ServiceProperty: IServiceProperty, INotifyPropertyChanged
    {
        public ServiceProperty()
        {

        }

        public string Name { get; set; } = "Hello Fody";

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
