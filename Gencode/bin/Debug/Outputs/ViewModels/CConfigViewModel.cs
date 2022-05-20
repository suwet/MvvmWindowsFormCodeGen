using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;

namespace Rmx.ViewModels
{
	public  class CConfigViewModel : ViewModelBase
	{
		     private Int32 _cf_id;    
     private String _cf_name;    
     private String _cf_value;    
     private String _cf_group;    
     private String _cf_description;
		////////////////////////////
		             public Int32 CF_ID 
           {               get=> _cf_id;
               set=> this.RaiseAndSetIfChanged(ref _cf_id, value);
           }    
             public String CF_Name 
           {               get=> _cf_name;
               set=> this.RaiseAndSetIfChanged(ref _cf_name, value);
           }    
             public String CF_Value 
           {               get=> _cf_value;
               set=> this.RaiseAndSetIfChanged(ref _cf_value, value);
           }    
             public String CF_Group 
           {               get=> _cf_group;
               set=> this.RaiseAndSetIfChanged(ref _cf_group, value);
           }    
             public String CF_Description 
           {               get=> _cf_description;
               set=> this.RaiseAndSetIfChanged(ref _cf_description, value);
           }
	}
}