using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky_IT2A
{
  public class Game
  {
    public List<Item> Items { get; } = new List<Item>();
    public int Top
    {
      get
      {
        if (Items.Count == 0)
        {
          return 0;
        }
        else if (Items.Count == 1)
        {
          return 5;
        }
        else
        {
          int top = 0;
          foreach (Item item in Items)
          {
            if(item.Y < top)
            {
              top = item.Y;
            }
          }
          return Math.Abs(top) + 5;
        }
      }
    }
    public int Bottom
    {
      get
      {
        if (Items.Count == 0)
        {
          return 0;
        }
        else if (Items.Count == 1)
        {
          return 5;
        }
        else
        {
          int bottom = 0;
          foreach (Item item in Items)
          {
            if (item.Y > bottom)
            {
              bottom = item.Y;
            }
          }
          return bottom + 5;
        }
      }
    }
    public int Left
    {
      get
      {
        if (Items.Count == 0)
        {
          return 0;
        }
        else if (Items.Count == 1)
        {
          return 5;
        }
        else
        {
          int left = 0;
          foreach (Item item in Items)
          {
            if (item.X < left)
            {
              left = item.Y;
            }
          }
          return Math.Abs(left) + 5;
        }
      }
    }
    public int Right
    {
      get
      {
        if (Items.Count == 0)
        {
          return 0;
        }
        else if (Items.Count == 1)
        {
          return 5;
        }
        else
        {
          int right = 0;
          foreach (Item item in Items)
          {
            if (item.X > right)
            {
              right = item.Y;
            }
          }
          return Math.Abs(right) + 5;
        }
      }
    }


  }
}
