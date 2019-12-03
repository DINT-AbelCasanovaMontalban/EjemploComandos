using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComandos
{
    public static class CustomCommands
    {

        public static readonly System.Windows.Input.RoutedUICommand Exit = new System.Windows.Input.RoutedUICommand(
            "Exit",
            "Exit",
            typeof(CustomCommands),
            new System.Windows.Input.InputGestureCollection()
            {
                new System.Windows.Input.KeyGesture(System.Windows.Input.Key.S,System.Windows.Input.ModifierKeys.Control)
            }
            );
    }
}
