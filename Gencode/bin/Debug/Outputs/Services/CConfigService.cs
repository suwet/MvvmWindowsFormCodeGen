using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using ReactiveUI;
using Dapper;

namespace Rmx.Service
{
	public  class CConfigService : BaseService
	{
        private CConfigDal _CConfigDal = new CConfigDal();

        public override void ConfigMapForService()
        {
            // access the TheMapper
            //TheMapper
        }

        // BindingList
		public List<CConfigViewModel> GetAll()    
        {    
           try
           {
                var results = _CConfigDal.GetAll();
                var datas = TheMapper.Map<List<CConfigViewModel>>(results);
                return datas;
           }
           catch(Exception ex)
           {
                throw;
           }
        }    

        public int Add(C_Config data)    
        {    
            try
           {
                return _CConfigDal.Insert(data);
           }
           catch(Exception ex)
           {
                throw;
           }
        }   
        
        public int Update(C_Config data)    
        {    
            try
           {
                return _CConfigDal.Update(data);
           }
           catch(Exception ex)
           {
                throw;
           }
        }  
        
        public int Delete(long Id)    
        {    
            try
           {
                return _CConfigDal.Delete(Id);
           }
           catch(Exception ex)
           {
                throw;
           }
        }    

        public C_Config GetById(long Id)    
        {    
             try
           {
                return _CConfigDal.GetById(Id);
           }
           catch(Exception ex)
           {
                throw;
           }
        }    
	}
}