// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//
//------------------------------------------------------------------------------

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
#endregion

namespace WMS.Models
{
    public class DBContext: DbContext
    {
        //[begin coding block]//[end coding block]
        
		public DBContext()
        : base("DBConnectionString")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

		}
    }
}