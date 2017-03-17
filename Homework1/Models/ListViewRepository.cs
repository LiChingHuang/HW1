using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Homework1.Models
{   
	public  class ListViewRepository : EFRepository<ListView>, IListViewRepository
	{

	}

	public  interface IListViewRepository : IRepository<ListView>
	{

	}
}