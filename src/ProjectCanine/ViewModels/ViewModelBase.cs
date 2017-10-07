using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace ProjectCanine
{
    public class ViewModelBase : BaseViewModel
    {
        public IDataStore<CanineTest> DataStore => DependencyService.Get<IDataStore<CanineTest>>() ?? new MockDataStore();

    }
}
