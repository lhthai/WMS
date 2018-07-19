// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Adjustment
//    File Name         : WHS_Adjustment.cs
//    Properties        : Adjustment_Date; CreatedBy; CreatedDate; ID; IsDeleted; ModifiedBy; ModifiedDate; Owner_ID; User_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Adjustment_Date; CreatedBy; CreatedDate; ID; IsDeleted; ModifiedBy; ModifiedDate; Owner_ID; User_ID; WHS_Adjustment_Details_Adjustment_ID;
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
	[Table("tbl_WHS_Adjustment")]
    [Serializable]
	[DataContract]
    public partial class WHS_Adjustment
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Adjustment_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Adjustment_Date { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Adjustment_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_ID { get; set; }
			        [Column("User_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> User_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }        [ForeignKey("User_ID")]        public virtual ENT_User ENT_User_User_ID { get; set; }		        public virtual ICollection<WHS_Adjustment_Detail> WHS_Adjustment_Details_Adjustment_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Adjustment> WHS_Adjustment_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Adjustment.AsEnumerable().Select(s => new WHS_Adjustment()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_Date =s.Adjustment_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										User_ID =s.User_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Adjustment>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Adjustment> WHS_Adjustment_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Adjustment_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Adjustment.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_Date =s.Adjustment_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										User_ID =s.User_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Adjustment_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Adjustment WHS_Adjustment_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Adjustment.Where(d => d.ID == ID).FirstOrDefault<WHS_Adjustment>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Adjustment_Create(IEnumerable<WHS_Adjustment> items, string CreatedBy)
        {
            string WHS_Adjustment_List = string.Empty;
            string WHS_Adjustment_List_Serialized = string.Empty;
            string WHS_Adjustment_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Adjustment> result = new List<WHS_Adjustment>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Adjustment item in items)
                {
                    WHS_Adjustment dbItem = new WHS_Adjustment();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_Date =item.Adjustment_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.User_ID =item.User_ID;
					                   
                    WHS_Adjustment_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Adjustment.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Adjustment_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Adjustment_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Adjustment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Adjustment_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Create: {1} - {2}", CreatedBy, WHS_Adjustment_List, WHS_Adjustment_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Adjustment_Create(WHS_Adjustment item, string CreatedBy)
        {
            string WHS_Adjustment_List = string.Empty;
            string WHS_Adjustment_List_Serialized = string.Empty;
            string WHS_Adjustment_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Adjustment> result = new List<WHS_Adjustment>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Adjustment dbItem = new WHS_Adjustment();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_Date =item.Adjustment_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.User_ID =item.User_ID;
					                    WHS_Adjustment_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Adjustment.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Adjustment_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Adjustment_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Adjustment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Adjustment_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Create: {1} - {2}", CreatedBy, WHS_Adjustment_List, WHS_Adjustment_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Adjustment_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Adjustment.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_Date =s.Adjustment_Date,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										User_ID =s.User_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Adjustment_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Adjustment_Update(IEnumerable<WHS_Adjustment> items, string ModifiedBy)
        {
            string WHS_Adjustment_List = string.Empty;
            string WHS_Adjustment_List_Serialized = string.Empty;
            string WHS_Adjustment_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Adjustment item in items)
                {
                    WHS_Adjustment dbItem = model.DBSet_WHS_Adjustment.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Adjustment_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Adjustment_Date =item.Adjustment_Date;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.User_ID =item.User_ID;
					                        

                        WHS_Adjustment_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Adjustment_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Adjustment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Adjustment_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Update: {1} - {2}", ModifiedBy, WHS_Adjustment_List, WHS_Adjustment_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Adjustment_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Adjustment_List = string.Empty;
            string WHS_Adjustment_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Adjustment> sendToTrashList = model.DBSet_WHS_Adjustment.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Adjustment item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Adjustment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Adjustment_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Destroy: {1}", ModifiedBy, WHS_Adjustment_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

