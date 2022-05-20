using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;

namespace Rmx.Models
{
	public  class C_Config : ModelBase
	{
		             public Int32 CF_ID {get;set;}    
             public String CF_Name {get;set;}    
             public String CF_Value {get;set;}    
             public String CF_Group {get;set;}    
             public String CF_Description {get;set;}
	}
}