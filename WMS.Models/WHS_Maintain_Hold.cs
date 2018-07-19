// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Maintain_Hold
//    File Name         : WHS_Maintain_Hold.cs
//    Properties        : CreatedBy; CreatedDate; Date_Off; Date_On; Holdreason_ID; ID; IsDeleted; Item_ID; Location_ID; Lot_ID; ModifiedBy; ModifiedDate; User_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Date_Off; Date_On; Holdreason_ID; ID; IsDeleted; Item_ID; Location_ID; Lot_ID; ModifiedBy; ModifiedDate; User_ID; ENT_User_User_ID;
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
	[Table("tbl_WHS_Maintain_Hold")]
    [Serializable]
	[DataContract]
    public partial class WHS_Maintain_Hold
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
			        [Column("Date_Off")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Date_Off { get; set; }
			        [Column("Date_On")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Date_On { get; set; }
			        [Column("Holdreason_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Holdreason_ID { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Maintain_Hold_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("Lot_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Lot_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("User_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> User_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Holdreason_ID")]        public virtual LIST_Code LIST_Code_Holdreason_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("Lot_ID")]        public virtual WHS_Lot_Attribute WHS_Lot_Attribute_Lot_ID { get; set; }        [ForeignKey("User_ID")]        public virtual ENT_User ENT_User_User_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Maintain_Hold> WHS_Maintain_Hold_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Maintain_Hold.AsEnumerable().Select(s => new WHS_Maintain_Hold()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_Off =s.Date_Off,
										Date_On =s.Date_On,
										Holdreason_ID =s.Holdreason_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_ID =s.Lot_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_ID =s.User_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Maintain_Hold>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Maintain_Hold> WHS_Maintain_Hold_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Maintain_Hold_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Maintain_Hold.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_Off =s.Date_Off,
										Date_On =s.Date_On,
										Holdreason_ID =s.Holdreason_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_ID =s.Lot_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_ID =s.User_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Maintain_Hold_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Maintain_Hold WHS_Maintain_Hold_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Maintain_Hold.Where(d => d.ID == ID).FirstOrDefault<WHS_Maintain_Hold>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Maintain_Hold_Create(IEnumerable<WHS_Maintain_Hold> items, string CreatedBy)
        {
            string WHS_Maintain_Hold_List = string.Empty;
            string WHS_Maintain_Hold_List_Serialized = string.Empty;
            string WHS_Maintain_Hold_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Maintain_Hold> result = new List<WHS_Maintain_Hold>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Maintain_Hold item in items)
                {
                    WHS_Maintain_Hold dbItem = new WHS_Maintain_Hold();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_Off =item.Date_Off;
								dbItem.Date_On =item.Date_On;
								dbItem.Holdreason_ID =item.Holdreason_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_ID =item.Lot_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_ID =item.User_ID;
					                   
                    WHS_Maintain_Hold_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Maintain_Hold.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Maintain_Hold_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Maintain_Hold_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Maintain_Hold_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Maintain_Hold_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Maintain_Hold_Create: {1} - {2}", CreatedBy, WHS_Maintain_Hold_List, WHS_Maintain_Hold_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Maintain_Hold_Create(WHS_Maintain_Hold item, string CreatedBy)
        {
            string WHS_Maintain_Hold_List = string.Empty;
            string WHS_Maintain_Hold_List_Serialized = string.Empty;
            string WHS_Maintain_Hold_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Maintain_Hold> result = new List<WHS_Maintain_Hold>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Maintain_Hold dbItem = new WHS_Maintain_Hold();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_Off =item.Date_Off;
								dbItem.Date_On =item.Date_On;
								dbItem.Holdreason_ID =item.Holdreason_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_ID =item.Lot_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_ID =item.User_ID;
					                    WHS_Maintain_Hold_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Maintain_Hold.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Maintain_Hold_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Maintain_Hold_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Maintain_Hold_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Maintain_Hold_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Maintain_Hold_Create: {1} - {2}", CreatedBy, WHS_Maintain_Hold_List, WHS_Maintain_Hold_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Maintain_Hold_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Maintain_Hold.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_Off =s.Date_Off,
										Date_On =s.Date_On,
										Holdreason_ID =s.Holdreason_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_ID =s.Lot_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										User_ID =s.User_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Maintain_Hold_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Maintain_Hold_Update(IEnumerable<WHS_Maintain_Hold> items, string ModifiedBy)
        {
            string WHS_Maintain_Hold_List = string.Empty;
            string WHS_Maintain_Hold_List_Serialized = string.Empty;
            string WHS_Maintain_Hold_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Maintain_Hold item in items)
                {
                    WHS_Maintain_Hold dbItem = model.DBSet_WHS_Maintain_Hold.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Maintain_Hold_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_Off =item.Date_Off;
								dbItem.Date_On =item.Date_On;
								dbItem.Holdreason_ID =item.Holdreason_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_ID =item.Lot_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.User_ID =item.User_ID;
					                        

                        WHS_Maintain_Hold_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Maintain_Hold_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Maintain_Hold_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Maintain_Hold_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Maintain_Hold_Update: {1} - {2}", ModifiedBy, WHS_Maintain_Hold_List, WHS_Maintain_Hold_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Maintain_Hold_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Maintain_Hold_List = string.Empty;
            string WHS_Maintain_Hold_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Maintain_Hold> sendToTrashList = model.DBSet_WHS_Maintain_Hold.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Maintain_Hold item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Maintain_Hold_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Maintain_Hold_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Maintain_Hold_Destroy: {1}", ModifiedBy, WHS_Maintain_Hold_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

