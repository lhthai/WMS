// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Pick_Detail
//    File Name         : WHS_Pick_Detail.cs
//    Properties        : CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Location_ID; Lot_Attribute_ID; ModifiedBy; ModifiedDate; Pack_ID; Picking_Line_No; PickStatus_ID; Quantity; SO_Detail_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Location_ID; Lot_Attribute_ID; ModifiedBy; ModifiedDate; Pack_ID; Picking_Line_No; PickStatus_ID; Quantity; SO_Detail_ID; WHS_SO_Detail_SO_Detail_ID;
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
	[Table("tbl_WHS_Pick_Detail")]
    [Serializable]
	[DataContract]
    public partial class WHS_Pick_Detail
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Pick_Detail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("Lot_Attribute_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Lot_Attribute_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Pack_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Pack_ID { get; set; }
			        [Column("Picking_Line_No")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Picking_Line_No { get; set; }
			        [Column("PickStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> PickStatus_ID { get; set; }
			        [Column("Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity { get; set; }
			        [Column("SO_Detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> SO_Detail_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("Lot_Attribute_ID")]        public virtual WHS_Lot_Attribute WHS_Lot_Attribute_Lot_Attribute_ID { get; set; }        [ForeignKey("Pack_ID")]        public virtual ENT_Pack ENT_Pack_Pack_ID { get; set; }        [ForeignKey("PickStatus_ID")]        public virtual LIST_Code LIST_Code_PickStatus_ID { get; set; }        [ForeignKey("SO_Detail_ID")]        public virtual WHS_SO_Detail WHS_SO_Detail_SO_Detail_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Pick_Detail> WHS_Pick_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Pick_Detail.AsEnumerable().Select(s => new WHS_Pick_Detail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_Attribute_ID =s.Lot_Attribute_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Picking_Line_No =s.Picking_Line_No,
										PickStatus_ID =s.PickStatus_ID,
										Quantity =s.Quantity,
										SO_Detail_ID =s.SO_Detail_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Pick_Detail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Pick_Detail> WHS_Pick_Detail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Pick_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Pick_Detail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_Attribute_ID =s.Lot_Attribute_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Picking_Line_No =s.Picking_Line_No,
										PickStatus_ID =s.PickStatus_ID,
										Quantity =s.Quantity,
										SO_Detail_ID =s.SO_Detail_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Pick_Detail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Pick_Detail WHS_Pick_Detail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Pick_Detail.Where(d => d.ID == ID).FirstOrDefault<WHS_Pick_Detail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Pick_Detail_Create(IEnumerable<WHS_Pick_Detail> items, string CreatedBy)
        {
            string WHS_Pick_Detail_List = string.Empty;
            string WHS_Pick_Detail_List_Serialized = string.Empty;
            string WHS_Pick_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Pick_Detail> result = new List<WHS_Pick_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Pick_Detail item in items)
                {
                    WHS_Pick_Detail dbItem = new WHS_Pick_Detail();

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
								dbItem.Lot_Attribute_ID =item.Lot_Attribute_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picking_Line_No =item.Picking_Line_No;
								dbItem.PickStatus_ID =item.PickStatus_ID;
								dbItem.Quantity =item.Quantity;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                   
                    WHS_Pick_Detail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Pick_Detail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Pick_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Pick_Detail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Pick_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Pick_Detail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Pick_Detail_Create: {1} - {2}", CreatedBy, WHS_Pick_Detail_List, WHS_Pick_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Pick_Detail_Create(WHS_Pick_Detail item, string CreatedBy)
        {
            string WHS_Pick_Detail_List = string.Empty;
            string WHS_Pick_Detail_List_Serialized = string.Empty;
            string WHS_Pick_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Pick_Detail> result = new List<WHS_Pick_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Pick_Detail dbItem = new WHS_Pick_Detail();

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
								dbItem.Lot_Attribute_ID =item.Lot_Attribute_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picking_Line_No =item.Picking_Line_No;
								dbItem.PickStatus_ID =item.PickStatus_ID;
								dbItem.Quantity =item.Quantity;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                    WHS_Pick_Detail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Pick_Detail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Pick_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Pick_Detail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Pick_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Pick_Detail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Pick_Detail_Create: {1} - {2}", CreatedBy, WHS_Pick_Detail_List, WHS_Pick_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Pick_Detail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Pick_Detail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lot_Attribute_ID =s.Lot_Attribute_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Picking_Line_No =s.Picking_Line_No,
										PickStatus_ID =s.PickStatus_ID,
										Quantity =s.Quantity,
										SO_Detail_ID =s.SO_Detail_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Pick_Detail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Pick_Detail_Update(IEnumerable<WHS_Pick_Detail> items, string ModifiedBy)
        {
            string WHS_Pick_Detail_List = string.Empty;
            string WHS_Pick_Detail_List_Serialized = string.Empty;
            string WHS_Pick_Detail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Pick_Detail item in items)
                {
                    WHS_Pick_Detail dbItem = model.DBSet_WHS_Pick_Detail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Pick_Detail_List += "[" + item.ID + "] ";
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
								dbItem.Lot_Attribute_ID =item.Lot_Attribute_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Picking_Line_No =item.Picking_Line_No;
								dbItem.PickStatus_ID =item.PickStatus_ID;
								dbItem.Quantity =item.Quantity;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                        

                        WHS_Pick_Detail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Pick_Detail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Pick_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Pick_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Pick_Detail_Update: {1} - {2}", ModifiedBy, WHS_Pick_Detail_List, WHS_Pick_Detail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Pick_Detail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Pick_Detail_List = string.Empty;
            string WHS_Pick_Detail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Pick_Detail> sendToTrashList = model.DBSet_WHS_Pick_Detail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Pick_Detail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Pick_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Pick_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Pick_Detail_Destroy: {1}", ModifiedBy, WHS_Pick_Detail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

