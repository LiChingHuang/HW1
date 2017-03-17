using System;
using System.Linq;
using System.Collections.Generic;
using Homework1.Models;

namespace Homework1.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{

    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}