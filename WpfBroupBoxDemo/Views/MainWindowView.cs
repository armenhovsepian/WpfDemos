using WpfBroupBoxDemo.ViewModels;

namespace WpfBroupBoxDemo.Views
{
    public class MainWindowView
    {
        public MainWindowView()
        {
            _pizzaViewModel = new PizzaViewModel
            {
                Olives = true,
                Mushrooms = true
            };
            _saladViewModel = new SaladViewModel
            {
                Sezar = true,
                Fruit = true
            };
        }


        private PizzaViewModel _pizzaViewModel;

        public PizzaViewModel PizzaViewModel
        {
            get { return _pizzaViewModel; }
            set
            {
                _pizzaViewModel = value;
            }
        }


        private SaladViewModel _saladViewModel;

        public SaladViewModel SaladViewModel
        {
            get { return _saladViewModel; }
            set { _saladViewModel = value; }
        }

    }
}
