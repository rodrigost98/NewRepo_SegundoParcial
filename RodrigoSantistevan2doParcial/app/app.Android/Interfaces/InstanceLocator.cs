using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using apo.app.ViewModels;
using apo.app.ViewModels;

namespace app.Droid.Interfaces
{
    public class InstanceLocator
    {
        #region Propeties
        public MainViewModel Main { get; set; }
        #endregion

        #region constructor
        public InstanceLocator()
        this Main = new MainViewModel();
        #endregion

        #region

        #endregion
    }
}