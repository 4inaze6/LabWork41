using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool menuIsOpen = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            menuIsOpen = !menuIsOpen;

            DoubleAnimation MenuAnimation = new DoubleAnimation
            {
                To = menuIsOpen ? 100 : 50,
                Duration = TimeSpan.FromSeconds(1),
            };

            DoubleAnimation StackPanelAnimation = new DoubleAnimation
            {
                To = menuIsOpen ? 80 : 0,
                Duration = TimeSpan.FromSeconds(1),
            };

            DoubleAnimation ButtonWidthAnimation = new DoubleAnimation
            {
                To = menuIsOpen ? 80 : 40,
                Duration = TimeSpan.FromSeconds(1),
            };

            DoubleAnimation ButtonHeightAnimation = new DoubleAnimation
            {
                To = menuIsOpen ? 80 : 40,
                Duration = TimeSpan.FromSeconds(1),
            };

            MainMenu.BeginAnimation(WidthProperty, MenuAnimation);
            BurgerStackPanel.BeginAnimation(WidthProperty, StackPanelAnimation);
            BurgerButton.BeginAnimation(WidthProperty, ButtonWidthAnimation);
            BurgerButton.BeginAnimation(HeightProperty, ButtonHeightAnimation);

        }
    }
}