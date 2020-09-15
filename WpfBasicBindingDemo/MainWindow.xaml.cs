using System.ComponentModel;
using System.Windows;

namespace WpfBasicBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //var B = new Binding("FirstName") { Source = PersonFinder.Person };
            //B.Mode = BindingMode.OneWay;
            //txtName.SetBinding(TextBlock.TextProperty, B);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Manual trigger or manual update
            //var bindingExpression = txtName.GetBindingExpression(TextBlock.TextProperty);
            //(bindingExpression.ResolvedSource as Person).FirstName = "Alen";
            //bindingExpression.UpdateTarget();


            // 
            PersonFinder.Person.FirstName = "Adam";

        }
    }

    public class Person : INotifyPropertyChanged
    {
        
        private string _lastName;

        public Person()
        {
            FirstName = "Armen";
            LastName = "Hovsepian";
        }

        // propfull
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;

                _firstName = value;
                Notify("FirstName");
            }
        }

        public string LastName { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class PersonFinder
    {
        private static Person _person;
        public PersonFinder()
        {

        }

        public static Person Person
        {
            get
            {
                if (_person == null)
                    _person = new Person();
                return _person;
            }
        }

    }
}
