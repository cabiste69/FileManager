using Avalonia.Controls;

namespace FileManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid g =  this.FindControl<Grid>("g");
            Button b = new Button();
            b.Content = "aaaaaa";
            g.Children.Add(b);
        }
    }
}