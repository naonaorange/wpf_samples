using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;
using Prism.Commands;

namespace WpfSample.ViewModels
{
    class MainWindowViewModel: BindableBase
    {
        private int num;

        //====================
        //Value Configuration
        //====================
        private string text;
        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        //====================
        //Initializer
        //====================
        public MainWindowViewModel()
        {
            num = 0;
            Text = "Hello World WPF";

            StartCommand = new DelegateCommand(Start);
        }

        //====================
        //Delegate Command
        //====================
        public DelegateCommand StartCommand { get; }
        public void Start()
        {
            Text = "Start Count " + num;
            num++;
        }
    }
}
