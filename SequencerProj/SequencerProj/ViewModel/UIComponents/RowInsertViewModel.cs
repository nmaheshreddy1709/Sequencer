using SequencerProj.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SequencerProj.ViewModel
{
    public class ProcessInsertViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoadSequence { get; set; }
        public ICommand SaveSequence { get; set; }
        public ICommand PreviewSequence { get; set; }
        public ProcessInsertViewModel()
        {
            LoadSequence = new ViewModelCommand(LoadSequenceMethod);
            SaveSequence = new ViewModelCommand(SaveSequenceMethod);
            PreviewSequence = new ViewModelCommand(PreviewSequenceMethod);
        }
        private void LoadSequenceMethod(object obj)
        {

        }
        private void SaveSequenceMethod(object obj)
        {

        }
        private void PreviewSequenceMethod(object obj)
        {

        }
    }
}
