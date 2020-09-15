using System.ComponentModel;

namespace WpfBroupBoxDemo.ViewModels
{
    public class SaladViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _fruit;

        public bool Fruit
        {
            get { return _fruit; }
            set
            {
                if (_fruit != value)
                {
                    _fruit = value;
                    RaisePropertyChanged("Fruit");
                }
            }
        }



        private bool _pasta;

        public bool Pasta
        {
            get { return _pasta; }
            set
            {
                if (_pasta != value)
                {
                    _pasta = value;
                    RaisePropertyChanged("Pasta");
                }
            }
        }


        private bool _sezar;

        public bool Sezar
        {
            get { return _sezar; }
            set
            {
                if (_sezar != value)
                {
                    _sezar = value;
                    RaisePropertyChanged("Sezar");
                }
            }
        }


        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
