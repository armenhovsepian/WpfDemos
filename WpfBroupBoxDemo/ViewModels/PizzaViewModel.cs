using System.ComponentModel;

namespace WpfBroupBoxDemo.ViewModels
{
    public class PizzaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _cheese;

        public bool Cheese
        {
            get { return _cheese; }
            set
            {
                if (_cheese != value)
                {
                    _cheese = value;
                    RaisePropertyChanged("Cheese");
                }
            }
        }


        private bool _mushroomds;

        public bool Mushrooms
        {
            get { return _mushroomds; }
            set
            {
                if (_mushroomds != value)
                {
                    _mushroomds = value;
                    RaisePropertyChanged("Mushrooms");
                }
            }
        }


        private bool _olives;

        public bool Olives
        {
            get { return _olives; }
            set
            {
                if (_olives != value)
                {
                    _olives = value;
                    RaisePropertyChanged("Olives");
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
