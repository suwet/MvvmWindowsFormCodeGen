using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;
using System.ComponentModel;

namespace Rmx.ViewModels
{
	public  class ListCConfigViewModel : ViewModelBase
	{
		public ListCConfigViewModel()
		{
		}
		public ListCConfigViewModel(IEnumerable<CConfigViewModel> list )
		{
			CConfigViewModels = new BindingList<CConfigViewModel>(list.ToList());
		}
		public BindingList<CConfigViewModel> CConfigViewModels {get;set;}
	}
}