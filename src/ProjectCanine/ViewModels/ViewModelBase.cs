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
        public IDataStore<Test> DataStore => DependencyService.Get<IDataStore<Test>>() ?? new MockDataStore();

    }
}
