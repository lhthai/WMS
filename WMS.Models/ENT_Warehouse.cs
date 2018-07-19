// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Warehouse
//    File Name         : ENT_Warehouse.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Server;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Server; WHS_Picking_Lists_Warehouse_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : True
//    Has IsDeleted     : True
//    Has ProfileID     : False
//
//------------------------------------------------------------------------------

#region using
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Web.Mvc;
using System.Linq;
using Kendo.Mvc.Extensions;
using log4net;
using WMSService;
using Kendo.Mvc.UI;
#endregion

namespace WMS.Models
{
	[Table("tbl_ENT_Warehouse")]
    [Serializable]
	[DataContract]
    public partial class ENT_Warehouse
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Warehouse_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Name")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Warehouse_Name_Required")]        public string Name { get; set; }
			        [Column("Server")]        [DataMember]        public string Server { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Delivery_Note> ENT_Delivery_Notes_Warehouse_ID { get; set; }        public virtual ICollection<WHS_Picking_List> WHS_Picking_Lists_Warehouse_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Warehouse> ENT_Warehouse_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Warehouse.AsEnumerable().Select(s => new ENT_Warehouse()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Server =s.Server,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Warehouse>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Warehouse> ENT_Warehouse_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Warehouse_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Warehouse.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Server =s.Server,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Warehouse_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Warehouse ENT_Warehouse_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Warehouse.Where(d => d.ID == ID).FirstOrDefault<ENT_Warehouse>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Warehouse_Create(IEnumerable<ENT_Warehouse> items, string CreatedBy)
        {
            string ENT_Warehouse_List = string.Empty;
            string ENT_Warehouse_List_Serialized = string.Empty;
            string ENT_Warehouse_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Warehouse> result = new List<ENT_Warehouse>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Warehouse item in items)
                {
                    ENT_Warehouse dbItem = new ENT_Warehouse();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Server =item.Server;
					                   
                    ENT_Warehouse_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Warehouse.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Warehouse_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Warehouse_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Warehouse_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Warehouse_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Warehouse_Create: {1} - {2}", CreatedBy, ENT_Warehouse_List, ENT_Warehouse_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Warehouse_Create(ENT_Warehouse item, string CreatedBy)
        {
            string ENT_Warehouse_List = string.Empty;
            string ENT_Warehouse_List_Serialized = string.Empty;
            string ENT_Warehouse_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Warehouse> result = new List<ENT_Warehouse>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Warehouse dbItem = new ENT_Warehouse();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Server =item.Server;
					                    ENT_Warehouse_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Warehouse.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Warehouse_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Warehouse_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Warehouse_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Warehouse_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Warehouse_Create: {1} - {2}", CreatedBy, ENT_Warehouse_List, ENT_Warehouse_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Warehouse_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Warehouse.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Server =s.Server,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Warehouse_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Warehouse_Update(IEnumerable<ENT_Warehouse> items, string ModifiedBy)
        {
            string ENT_Warehouse_List = string.Empty;
            string ENT_Warehouse_List_Serialized = string.Empty;
            string ENT_Warehouse_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Warehouse item in items)
                {
                    ENT_Warehouse dbItem = model.DBSet_ENT_Warehouse.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Warehouse_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Server =item.Server;
					                        

                        ENT_Warehouse_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Warehouse_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Warehouse_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Warehouse_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Warehouse_Update: {1} - {2}", ModifiedBy, ENT_Warehouse_List, ENT_Warehouse_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Warehouse_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Warehouse_List = string.Empty;
            string ENT_Warehouse_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Warehouse> sendToTrashList = model.DBSet_ENT_Warehouse.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Warehouse item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Warehouse_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Warehouse_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Warehouse_Destroy: {1}", ModifiedBy, ENT_Warehouse_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

