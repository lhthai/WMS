// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Strategy_Putaway
//    File Name         : WHS_Strategy_Putaway.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; ModifiedBy; ModifiedDate; Name;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; ModifiedBy; ModifiedDate; Name; WHS_Strategy_Putaway_Steps_putaway_strategy_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : True
//    Has IsDeleted     : False
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
	[Table("tbl_WHS_Strategy_Putaway")]
    [Serializable]
	[DataContract]
    public partial class WHS_Strategy_Putaway
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Strategy_Putaway_ID_Required")]        public int ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Name")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Strategy_Putaway_Name_Required")]        public string Name { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Item> ENT_Items_Putaway_Strategy_Id { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Putaway_Strategy_ID { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_putaway_strategy_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Strategy_Putaway> WHS_Strategy_Putaway_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Strategy_Putaway.AsEnumerable().Select(s => new WHS_Strategy_Putaway()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Strategy_Putaway>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Strategy_Putaway> WHS_Strategy_Putaway_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Strategy_Putaway_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Strategy_Putaway.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Strategy_Putaway_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Strategy_Putaway WHS_Strategy_Putaway_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Strategy_Putaway.Where(d => d.ID == ID).FirstOrDefault<WHS_Strategy_Putaway>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Strategy_Putaway_Create(IEnumerable<WHS_Strategy_Putaway> items, string CreatedBy)
        {
            string WHS_Strategy_Putaway_List = string.Empty;
            string WHS_Strategy_Putaway_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Strategy_Putaway> result = new List<WHS_Strategy_Putaway>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Strategy_Putaway item in items)
                {
                    WHS_Strategy_Putaway dbItem = new WHS_Strategy_Putaway();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
					                   
                    WHS_Strategy_Putaway_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Strategy_Putaway.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Strategy_Putaway_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Strategy_Putaway_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Strategy_Putaway_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Strategy_Putaway_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Create: {1} - {2}", CreatedBy, WHS_Strategy_Putaway_List, WHS_Strategy_Putaway_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Strategy_Putaway_Create(WHS_Strategy_Putaway item, string CreatedBy)
        {
            string WHS_Strategy_Putaway_List = string.Empty;
            string WHS_Strategy_Putaway_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Strategy_Putaway> result = new List<WHS_Strategy_Putaway>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Strategy_Putaway dbItem = new WHS_Strategy_Putaway();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
					                    WHS_Strategy_Putaway_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Strategy_Putaway.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Strategy_Putaway_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Strategy_Putaway_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Strategy_Putaway_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Create: {1} - {2}", CreatedBy, WHS_Strategy_Putaway_List, WHS_Strategy_Putaway_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Strategy_Putaway_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Strategy_Putaway.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Strategy_Putaway_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Strategy_Putaway_Update(IEnumerable<WHS_Strategy_Putaway> items, string ModifiedBy)
        {
            string WHS_Strategy_Putaway_List = string.Empty;
            string WHS_Strategy_Putaway_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Strategy_Putaway item in items)
                {
                    WHS_Strategy_Putaway dbItem = model.DBSet_WHS_Strategy_Putaway.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Strategy_Putaway_List += "[" + item.ID + "] ";
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
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
					                        

                        WHS_Strategy_Putaway_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Strategy_Putaway_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Strategy_Putaway_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Update: {1} - {2}", ModifiedBy, WHS_Strategy_Putaway_List, WHS_Strategy_Putaway_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Strategy_Putaway_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Strategy_Putaway_List = string.Empty;
            string WHS_Strategy_Putaway_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Strategy_Putaway> sendToTrashList = model.DBSet_WHS_Strategy_Putaway.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Strategy_Putaway item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Strategy_Putaway_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Destroy: {1}", ModifiedBy, WHS_Strategy_Putaway_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

