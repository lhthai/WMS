// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Move
//    File Name         : WHS_Move.cs
//    Properties        : CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Location_ID; LPN; ModifiedBy; ModifiedDate; Quantity; Quantity_Allocated; Quantity_Available; Quantity_To_Move; Status; To_Location; To_LPN;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Location_ID; LPN; ModifiedBy; ModifiedDate; Quantity; Quantity_Allocated; Quantity_Available; Quantity_To_Move; Status; To_Location; To_LPN; WHS_Consolidate_To_LPN;
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
	[Table("tbl_WHS_Move")]
    [Serializable]
	[DataContract]
    public partial class WHS_Move
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Move_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("LPN")]        [DataMember]        public string LPN { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity { get; set; }
			        [Column("Quantity_Allocated")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity_Allocated { get; set; }
			        [Column("Quantity_Available")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity_Available { get; set; }
			        [Column("Quantity_To_Move")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity_To_Move { get; set; }
			        [Column("Status")]        [DataMember]        public Nullable<bool> Status { get; set; }
			        [Column("To_Location")]        [DataMember]        public string To_Location { get; set; }
			        [Column("To_LPN")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> To_LPN { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("To_LPN")]        public virtual WHS_Consolidate WHS_Consolidate_To_LPN { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Move> WHS_Move_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Move.AsEnumerable().Select(s => new WHS_Move()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Quantity =s.Quantity,
										Quantity_Allocated =s.Quantity_Allocated,
										Quantity_Available =s.Quantity_Available,
										Quantity_To_Move =s.Quantity_To_Move,
										Status =s.Status,
										To_Location =s.To_Location,
										To_LPN =s.To_LPN,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Move>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Move> WHS_Move_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Move_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Move.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Quantity =s.Quantity,
										Quantity_Allocated =s.Quantity_Allocated,
										Quantity_Available =s.Quantity_Available,
										Quantity_To_Move =s.Quantity_To_Move,
										Status =s.Status,
										To_Location =s.To_Location,
										To_LPN =s.To_LPN,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Move_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Move WHS_Move_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Move.Where(d => d.ID == ID).FirstOrDefault<WHS_Move>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Move_Create(IEnumerable<WHS_Move> items, string CreatedBy)
        {
            string WHS_Move_List = string.Empty;
            string WHS_Move_List_Serialized = string.Empty;
            string WHS_Move_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Move> result = new List<WHS_Move>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Move item in items)
                {
                    WHS_Move dbItem = new WHS_Move();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Quantity =item.Quantity;
								dbItem.Quantity_Allocated =item.Quantity_Allocated;
								dbItem.Quantity_Available =item.Quantity_Available;
								dbItem.Quantity_To_Move =item.Quantity_To_Move;
								dbItem.Status =item.Status;
								dbItem.To_Location =item.To_Location;
								dbItem.To_LPN =item.To_LPN;
					                   
                    WHS_Move_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Move.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Move_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Move_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Move_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Move_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Move_Create: {1} - {2}", CreatedBy, WHS_Move_List, WHS_Move_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Move_Create(WHS_Move item, string CreatedBy)
        {
            string WHS_Move_List = string.Empty;
            string WHS_Move_List_Serialized = string.Empty;
            string WHS_Move_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Move> result = new List<WHS_Move>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Move dbItem = new WHS_Move();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Quantity =item.Quantity;
								dbItem.Quantity_Allocated =item.Quantity_Allocated;
								dbItem.Quantity_Available =item.Quantity_Available;
								dbItem.Quantity_To_Move =item.Quantity_To_Move;
								dbItem.Status =item.Status;
								dbItem.To_Location =item.To_Location;
								dbItem.To_LPN =item.To_LPN;
					                    WHS_Move_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Move.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Move_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Move_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Move_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Move_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Move_Create: {1} - {2}", CreatedBy, WHS_Move_List, WHS_Move_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Move_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Move.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Quantity =s.Quantity,
										Quantity_Allocated =s.Quantity_Allocated,
										Quantity_Available =s.Quantity_Available,
										Quantity_To_Move =s.Quantity_To_Move,
										Status =s.Status,
										To_Location =s.To_Location,
										To_LPN =s.To_LPN,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Move_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Move_Update(IEnumerable<WHS_Move> items, string ModifiedBy)
        {
            string WHS_Move_List = string.Empty;
            string WHS_Move_List_Serialized = string.Empty;
            string WHS_Move_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Move item in items)
                {
                    WHS_Move dbItem = model.DBSet_WHS_Move.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Move_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Quantity =item.Quantity;
								dbItem.Quantity_Allocated =item.Quantity_Allocated;
								dbItem.Quantity_Available =item.Quantity_Available;
								dbItem.Quantity_To_Move =item.Quantity_To_Move;
								dbItem.Status =item.Status;
								dbItem.To_Location =item.To_Location;
								dbItem.To_LPN =item.To_LPN;
					                        

                        WHS_Move_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Move_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Move_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Move_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Move_Update: {1} - {2}", ModifiedBy, WHS_Move_List, WHS_Move_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Move_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Move_List = string.Empty;
            string WHS_Move_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Move> sendToTrashList = model.DBSet_WHS_Move.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Move item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Move_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Move_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Move_Destroy: {1}", ModifiedBy, WHS_Move_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

