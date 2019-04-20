using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace WpfSample.ViewModels
{
    class MainWindowViewModel: BindableBase
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public MainWindowViewModel()
        {
            Text = "Hello World WPF";
        }
    }
}
