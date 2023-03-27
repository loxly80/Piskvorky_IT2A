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
    Game game;

    public MainWindow()
    {
      game = new Game();
      game.Move(0, 0);
      game.Move(1, 1);
      InitializeComponent();
      Background = Brushes.DarkGray;
    }

    private Grid CreateGrid(int size, Game game)
    {
      Grid grid = new Grid();
      grid.Width = size * game.Width;
      grid.Height = size * game.Height;
      for (int x = 0; x < game.Width; x++)
      {
        grid.ColumnDefinitions.Add(new ColumnDefinition());
      }
      for (int y = 0; y < game.Height; y++)
      {
        grid.RowDefinitions.Add(new RowDefinition());
      }
      this.AddChild(grid);
      return grid;
    }

    private void FillGridWithButtons(Grid grid, Game game)
    {
      Button button;
      for (int x = 0; x < grid.ColumnDefinitions.Count(); x++)
      {
        for (int y = 0; y < grid.RowDefinitions.Count(); y++)
        {
          button = new Button();
          button.Background = Brushes.White;
          button.VerticalAlignment = VerticalAlignment.Stretch;
          button.HorizontalAlignment = HorizontalAlignment.Stretch;
          Grid.SetColumn(button, x);
          Grid.SetRow(button, y);
          grid.Children.Add(button);
          Item? item = game.Items.Find(i => i.X == x && i.Y == y);
          if(item != null)
          {

          }
        }
      }
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
      var grid = CreateGrid(50, game);
      FillGridWithButtons(grid, game);
    }
  }
}
