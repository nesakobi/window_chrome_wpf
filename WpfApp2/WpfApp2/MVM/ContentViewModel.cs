using System.Collections.Generic;
using System.ComponentModel;

namespace WpfApp2.MVM
{
    internal class ContentViewModel : INotifyPropertyChanged
    {
        private RowItemModel? _rowItemModel;

        public ContentViewModel()
        {
            Items = new List<RowItemModel>()
            {
                new RowItemModel()
                {
                    FirstColumn = "Left - first",
                    LastColumn = "Right - last"
                }
            };

            MenuItems = new List<MenuItemModel>()
            {
                new MenuItemModel()
                {
                    Part1 = "Part 1",
                    Part2 = "Part 2"
                }
            };
        }

        public IEnumerable<RowItemModel> Items { get; set; }

        public RowItemModel? SelectedItem
        {
            get => _rowItemModel;
            set
            {
                if (_rowItemModel != value)
                {
                    _rowItemModel = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public IEnumerable<MenuItemModel> MenuItems { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
