// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Transaction
//    File Name         : WHS_Transaction.cs
//    Properties        : Activity_ID; Add_Date; CreatedBy; CreatedDate; Edit_Date; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; User_Add; User_Update;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Activity_ID; Add_Date; CreatedBy; CreatedDate; Edit_Date; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; User_Add; User_Update; ENT_Item_Item_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : False
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
	[Table("tbl_WHS_Transaction")]
    [Serializable]
	[DataContract]
    public partial class WHS_Transaction
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Activity_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Activity_ID { get; set; }
			        [Column("Add_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Add_Date { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Edit_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Edit_Date { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Transaction_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("User_Add")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> User_Add { get; set; }
			        [Column("User_Update")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> User_Update { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Activity_ID")]        public virtual LIST_Code LIST_Code_Activity_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Transaction> WHS_Transaction_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Transaction.AsEnumerable().Select(s => new WHS_Transaction()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Activity_ID =s.Activity_ID,
										Add_Date =s.Add_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Edit_Date =s.Edit_Date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_Add =s.User_Add,
										User_Update =s.User_Update,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Transaction>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Transaction> WHS_Transaction_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Transaction_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Transaction.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Activity_ID =s.Activity_ID,
										Add_Date =s.Add_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Edit_Date =s.Edit_Date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_Add =s.User_Add,
										User_Update =s.User_Update,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Transaction_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Transaction WHS_Transaction_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Transaction.Where(d => d.ID == ID).FirstOrDefault<WHS_Transaction>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Transaction_Create(IEnumerable<WHS_Transaction> items, string CreatedBy)
        {
            string WHS_Transaction_List = string.Empty;
            string WHS_Transaction_List_Serialized = string.Empty;
            string WHS_Transaction_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Transaction> result = new List<WHS_Transaction>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Transaction item in items)
                {
                    WHS_Transaction dbItem = new WHS_Transaction();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Activity_ID =item.Activity_ID;
								dbItem.Add_Date =item.Add_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Edit_Date =item.Edit_Date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_Add =item.User_Add;
								dbItem.User_Update =item.User_Update;
					                   
                    WHS_Transaction_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Transaction.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Transaction_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Transaction_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Transaction_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Transaction_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Transaction_Create: {1} - {2}", CreatedBy, WHS_Transaction_List, WHS_Transaction_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Transaction_Create(WHS_Transaction item, string CreatedBy)
        {
            string WHS_Transaction_List = string.Empty;
            string WHS_Transaction_List_Serialized = string.Empty;
            string WHS_Transaction_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Transaction> result = new List<WHS_Transaction>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Transaction dbItem = new WHS_Transaction();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Activity_ID =item.Activity_ID;
								dbItem.Add_Date =item.Add_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Edit_Date =item.Edit_Date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_Add =item.User_Add;
								dbItem.User_Update =item.User_Update;
					                    WHS_Transaction_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Transaction.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Transaction_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Transaction_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Transaction_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Transaction_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Transaction_Create: {1} - {2}", CreatedBy, WHS_Transaction_List, WHS_Transaction_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Transaction_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Transaction.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Activity_ID =s.Activity_ID,
										Add_Date =s.Add_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Edit_Date =s.Edit_Date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_Add =s.User_Add,
										User_Update =s.User_Update,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Transaction_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Transaction_Update(IEnumerable<WHS_Transaction> items, string ModifiedBy)
        {
            string WHS_Transaction_List = string.Empty;
            string WHS_Transaction_List_Serialized = string.Empty;
            string WHS_Transaction_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Transaction item in items)
                {
                    WHS_Transaction dbItem = model.DBSet_WHS_Transaction.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Transaction_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Activity_ID =item.Activity_ID;
								dbItem.Add_Date =item.Add_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Edit_Date =item.Edit_Date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_Add =item.User_Add;
								dbItem.User_Update =item.User_Update;
					                        

                        WHS_Transaction_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Transaction_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Transaction_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Transaction_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Transaction_Update: {1} - {2}", ModifiedBy, WHS_Transaction_List, WHS_Transaction_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Transaction_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Transaction_List = string.Empty;
            string WHS_Transaction_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Transaction> sendToTrashList = model.DBSet_WHS_Transaction.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Transaction item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Transaction_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Transaction_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Transaction_Destroy: {1}", ModifiedBy, WHS_Transaction_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

