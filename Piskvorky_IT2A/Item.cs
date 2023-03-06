using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky_IT2A
{
  public class Item
  {
    public int X { get; }
    public int Y { get; }
    public Icon Value { get; }

    public Item(int x, int y, Icon value)
    {
      X = x;
      Y = y;
      Value = value;
    }

    public enum Icon
    {
      Cross,
      Circle
    }
  }


}
