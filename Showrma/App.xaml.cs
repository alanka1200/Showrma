using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Showrma.Model;


namespace Showrma
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ShavaEntities DB = new ShavaEntities();
        public static User LoginigUsers;
    }
}
