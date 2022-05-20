using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;
using AutoMapper;


namespace Rmx.Service
{
	public  class BaseService
	{
		public MapperConfiguration MapConfig {get;set;}

		public BaseService()
		{
			// https://docs.automapper.org/en/stable/Configuration.html
			MapConfig = new MapperConfiguration(cfg => 
			{
					cfg.CreateMap<C_Config,CConfigViewModel>();
					cfg.CreateMap<CConfigViewModel,C_Config>();
			}
			);

			TheMapper = new Mapper(MapConfig);
			//OrderDto dto = mapper.Map<DestinationType>(source);
		}

		public Mapper TheMapper {get;set;}

		public virtual void ConfigMapForService()
		{

		}
	}
}