// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : SO_Detail
//    File Name         : WHS_SO_Detail.cs
//    Properties        : Allocated_Quantity; CreatedBy; CreatedDate; ID; IsDelete; Item_ID; ModifiedBy; ModifiedDate; Order_Quantity; Pack_ID; Picked_Quantity; Quantity; Shipped_Quantity; SO_ID; SO_Line_No;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Allocated_Quantity; CreatedBy; CreatedDate; ID; IsDelete; Item_ID; ModifiedBy; ModifiedDate; Order_Quantity; Pack_ID; Picked_Quantity; Quantity; Shipped_Quantity; SO_ID; SO_Line_No; WHS_Picking_Lists_SO_Detail_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : False
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
	[Table("tbl_WHS_SO_Detail")]
    [Serializable]
	[DataContract]
    public partial class WHS_SO_Detail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Allocated_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Allocated_Quantity { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDelete")]        [DataMember]        public Nullable<bool> IsDelete { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_Item_ID_Required")]        public int Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Order_Quantity")]        [DataMember]        [UIHint("Decimal")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_Order_Quantity_Required")]        public decimal Order_Quantity { get; set; }
			        [Column("Pack_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_Pack_ID_Required")]        public int Pack_ID { get; set; }
			        [Column("Picked_Quantity")]        [DataMember]        [UIHint("Decimal")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_Picked_Quantity_Required")]        public decimal Picked_Quantity { get; set; }
			        [Column("Quantity")]        [DataMember]        [UIHint("Decimal")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_Quantity_Required")]        public decimal Quantity { get; set; }
			        [Column("Shipped_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Shipped_Quantity { get; set; }
			        [Column("SO_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> SO_ID { get; set; }
			        [Column("SO_Line_No")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Detail_SO_Line_No_Required")]        public int SO_Line_No { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Pack_ID")]        public virtual ENT_Pack ENT_Pack_Pack_ID { get; set; }        [ForeignKey("SO_ID")]        public virtual WHS_SO WHS_SO_SO_ID { get; set; }		        public virtual ICollection<ENT_Delivery_Note> ENT_Delivery_Notes_SO_Detail_ID { get; set; }        public virtual ICollection<WHS_Packing_List> WHS_Packing_Lists_SO_Detail_ID { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_SO_Detail_ID { get; set; }        public virtual ICollection<WHS_Picking_List> WHS_Picking_Lists_SO_Detail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_SO_Detail> WHS_SO_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_SO_Detail.AsEnumerable().Select(s => new WHS_SO_Detail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allocated_Quantity =s.Allocated_Quantity,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDelete =s.IsDelete,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Quantity =s.Order_Quantity,
										Pack_ID =s.Pack_ID,
										Picked_Quantity =s.Picked_Quantity,
										Quantity =s.Quantity,
										Shipped_Quantity =s.Shipped_Quantity,
										SO_ID =s.SO_ID,
										SO_Line_No =s.SO_Line_No,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_SO_Detail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_SO_Detail> WHS_SO_Detail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_SO_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_SO_Detail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allocated_Quantity =s.Allocated_Quantity,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDelete =s.IsDelete,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Quantity =s.Order_Quantity,
										Pack_ID =s.Pack_ID,
										Picked_Quantity =s.Picked_Quantity,
										Quantity =s.Quantity,
										Shipped_Quantity =s.Shipped_Quantity,
										SO_ID =s.SO_ID,
										SO_Line_No =s.SO_Line_No,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_SO_Detail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_SO_Detail WHS_SO_Detail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_SO_Detail.Where(d => d.ID == ID).FirstOrDefault<WHS_SO_Detail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_SO_Detail_Create(IEnumerable<WHS_SO_Detail> items, string CreatedBy)
        {
            string WHS_SO_Detail_List = string.Empty;
            string WHS_SO_Detail_List_Serialized = string.Empty;
            string WHS_SO_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_SO_Detail> result = new List<WHS_SO_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_SO_Detail item in items)
                {
                    WHS_SO_Detail dbItem = new WHS_SO_Detail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allocated_Quantity =item.Allocated_Quantity;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Quantity =item.Order_Quantity;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picked_Quantity =item.Picked_Quantity;
								dbItem.Quantity =item.Quantity;
								dbItem.Shipped_Quantity =item.Shipped_Quantity;
								dbItem.SO_ID =item.SO_ID;
								dbItem.SO_Line_No =item.SO_Line_No;
					                   
                    WHS_SO_Detail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_SO_Detail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_SO_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_SO_Detail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_SO_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_SO_Detail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Detail_Create: {1} - {2}", CreatedBy, WHS_SO_Detail_List, WHS_SO_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_SO_Detail_Create(WHS_SO_Detail item, string CreatedBy)
        {
            string WHS_SO_Detail_List = string.Empty;
            string WHS_SO_Detail_List_Serialized = string.Empty;
            string WHS_SO_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_SO_Detail> result = new List<WHS_SO_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_SO_Detail dbItem = new WHS_SO_Detail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allocated_Quantity =item.Allocated_Quantity;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Quantity =item.Order_Quantity;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picked_Quantity =item.Picked_Quantity;
								dbItem.Quantity =item.Quantity;
								dbItem.Shipped_Quantity =item.Shipped_Quantity;
								dbItem.SO_ID =item.SO_ID;
								dbItem.SO_Line_No =item.SO_Line_No;
					                    WHS_SO_Detail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_SO_Detail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_SO_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_SO_Detail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_SO_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_SO_Detail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Detail_Create: {1} - {2}", CreatedBy, WHS_SO_Detail_List, WHS_SO_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_SO_Detail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_SO_Detail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Allocated_Quantity =s.Allocated_Quantity,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDelete =s.IsDelete,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Quantity =s.Order_Quantity,
										Pack_ID =s.Pack_ID,
										Picked_Quantity =s.Picked_Quantity,
										Quantity =s.Quantity,
										Shipped_Quantity =s.Shipped_Quantity,
										SO_ID =s.SO_ID,
										SO_Line_No =s.SO_Line_No,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_SO_Detail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_SO_Detail_Update(IEnumerable<WHS_SO_Detail> items, string ModifiedBy)
        {
            string WHS_SO_Detail_List = string.Empty;
            string WHS_SO_Detail_List_Serialized = string.Empty;
            string WHS_SO_Detail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_SO_Detail item in items)
                {
                    WHS_SO_Detail dbItem = model.DBSet_WHS_SO_Detail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_SO_Detail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Allocated_Quantity =item.Allocated_Quantity;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Quantity =item.Order_Quantity;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picked_Quantity =item.Picked_Quantity;
								dbItem.Quantity =item.Quantity;
								dbItem.Shipped_Quantity =item.Shipped_Quantity;
								dbItem.SO_ID =item.SO_ID;
								dbItem.SO_Line_No =item.SO_Line_No;
					                        

                        WHS_SO_Detail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_SO_Detail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_SO_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_SO_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Detail_Update: {1} - {2}", ModifiedBy, WHS_SO_Detail_List, WHS_SO_Detail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_SO_Detail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_SO_Detail_List = string.Empty;
            string WHS_SO_Detail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_SO_Detail> sendToTrashList = model.DBSet_WHS_SO_Detail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_SO_Detail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_SO_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_SO_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Detail_Destroy: {1}", ModifiedBy, WHS_SO_Detail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

