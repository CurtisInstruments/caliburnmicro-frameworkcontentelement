using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Caliburn.Micro.FrameworkContentElement
{
  public static class FCETreeHelper
  {
    public static DependencyObject GetParent(DependencyObject reference)
    {
      System.Windows.FrameworkContentElement frameworkContentElement = reference as System.Windows.FrameworkContentElement;
      if (frameworkContentElement != null)
      {
        return frameworkContentElement.Parent;
      }
      else
      {
        FrameworkElement frameworkElement = reference as FrameworkElement;
        if (frameworkElement != null)
        {
          return frameworkElement.Parent;
        }

      }
      return null;
    }
  }
}
