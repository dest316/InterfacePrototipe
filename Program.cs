using SpaceVIL;
using System;

namespace InterfacePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpaceVIL.Common.CommonService.InitSpaceVILComponents();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}