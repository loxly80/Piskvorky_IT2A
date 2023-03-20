using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Piskvorky_IT2A
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Background = Brushes.DarkGray;
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
      Grid grid = new Grid();
      grid.Width = 150;
      grid.Height = 150;
      for (int x = 0; x < 3; x++)
      {
        grid.ColumnDefinitions.Add(new ColumnDefinition());
      }
      for (int y = 0; y < 3; y++)
      {
        grid.RowDefinitions.Add(new RowDefinition());
      }
      this.AddChild(grid);

      Button button;
      for(int x = 0; x < 3; x++)
      {
        for(int y = 0; y < 3; y++)
        {
          button = new Button();
          button.Background = Brushes.White;
          //button.Background = new LinearGradientBrush() 
          //{ 
          //  StartPoint=new Point(0,5),
          //  EndPoint=new Point(10,5),
          //  GradientStops = new GradientStopCollection() 
          //  { 
          //    new GradientStop(Colors.Transparent,0),
          //    new GradientStop(Colors.White,0.1)
          //  } 
          //};
          button.VerticalAlignment = VerticalAlignment.Stretch;
          button.HorizontalAlignment = HorizontalAlignment.Stretch;
          Grid.SetColumn(button, x);
          Grid.SetRow(button, y);
          grid.Children.Add(button);
        }
      }

    }
  }
}
