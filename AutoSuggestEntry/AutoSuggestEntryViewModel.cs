using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutoSuggestEntry
{
    public class AutoSuggestEntryViewModel : NotifiedBase
    {
        private string _text;

        private List<SimpleListItem> _originalList;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SimpleListItem> Items { get; } = new ObservableCollection<SimpleListItem>();
    }
}
