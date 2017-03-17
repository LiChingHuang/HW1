using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Homework1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(c => c.Id == id);  
            //return this.All().FirstOrDefault(p => p.ProductId == id);
        }

        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(c => false == c.isDelete);
        }

        public override void Delete(客戶資料 entity)
        {
           // this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;

            entity.isDelete = true;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}

    
    
}