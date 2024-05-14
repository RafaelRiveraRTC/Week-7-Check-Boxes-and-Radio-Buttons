using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_7_Check_Boxes_and_Radio_Buttons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPart1_Click(object sender, RoutedEventArgs e)
        {
           
          

            lblDisplayInfo.Content = FullOrder();

        }//btnPart1_Click

        public string FullOrder()
        {

            //Name of the Pizza Place
           //Pizza Size
           //The toppings
           

            string pizzaPlaceName = "Lito's Pizza Tower";

            string order = $"{pizzaPlaceName}\n\n";
            //The Pizza size
            order += PizzaSize();
            //The toppings
            order += Toppings();





            
            //Toppings

            return order;
        }//Full Order

        //Pizza Size
        public string PizzaSize()
        {
            string size = "";
            if ((bool)rbSmall.IsChecked) // If small pizza is checked
            {
                size += "Size :Small\n";
            }
            else if ((bool)rbmedium.IsChecked)// If medium pizza is checked
            {
                size += "Size :Medium\n";
            }
            else if ((bool)rbLarge.IsChecked)// If Large pizza is checked
            {
                size += "Size :Large\n";
            }
            else
            {
                size += "Size :X-Large\n";
            }
            lblDisplayInfo.Content = size;
            return size;
        }


        //Topings

        public string Toppings()
        {
            CheckBox sausage = chkSausage;
           
            //CheckBox pepperoni = chkPepperoni;
            bool isSausage = (bool)sausage.IsChecked;
            string toppings = "";
            if (isSausage)
            {
                toppings += $"Pizza has Sausage\n";
                //lblDisplayInfo.Content = $"Pizza has sausage";
            }
            else
            {
                toppings += $"Pizza Does not have Sausage\n";
                //lblDisplayInfo.Content = $"Pizza Does not have Sausage";
            }
            //lblDisplayInfo.Content = $"$ Has Sausage: {isSausage}";

            //Ternary

            // ? indicates to the computer that a ternary is being thrown 

            //evaluates a boolean expression and returns the results of 2 boolean expressions. Is a short hand to assign a value to a variable based on a condition
            bool isPepperoni = (bool)chkPepperoni.IsChecked;
            toppings += (isPepperoni) ? "Pizza has Pepperoni" :
                "Pizza does not have Pepperoni";


            //int number = (false) ? 5 : //if

            //    (false && true) ? 5 : // else if;this is an alternate short form for an if else statement;
            //    0;// else

            //variable = condition ? if true : if false;

            //Radio Button


           return toppings;
        }

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {

            List<RadioButton> themes = new List<RadioButton>();
            themes.Add(rbWhite);
            themes.Add(rbBlack);
            themes.Add(rbRed);
            themes.Add(rbBlue);


            foreach (RadioButton rb in themes)
            {
                if(rb != null)
                {
                    string chosenColor = rb.Content.ToString();
                    MessageBox.Show("This Works");
                    //Color color;
                    if (chosenColor == "White")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.White);
                    }
                    else if (chosenColor == "Black")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Black);
                    }
                    else if (chosenColor == "Red")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Red);
                    }
                    else if (chosenColor == "Blue")
                    {
                        canvasParent.Background = new SolidColorBrush(Colors.Blue);
                    }
                }
                

            }
        
            //Grab the 

            //
        }

        //part1
    }
}