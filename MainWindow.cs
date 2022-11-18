using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using SpaceVIL;

namespace InterfacePrototype
{
    internal class MainWindow: ActiveWindow
    {
        public override void InitWindow()
        {
            SetParameters(nameof(MainWindow), nameof(MainWindow), 800, 600);
            SetMinSize(400, 300);
            SetBackground(32, 34, 37);
        }
    }
}
