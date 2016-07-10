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
using MvvmCross.Droid.Shared.Attributes;
using Relax.Core.ViewModels;

namespace Relax.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.contentPanel, true)]
    [Register("relax.droid.fragments.HomeFragment")]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.Main;
            }
        }
    }
}