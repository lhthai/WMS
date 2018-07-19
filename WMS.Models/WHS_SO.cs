// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : SO
//    File Name         : WHS_SO.cs
//    Properties        : Actual_Ship_Date; Carrier_ID; CreatedBy; CreatedDate; Customer_ID; Driver_Name; ID; IsDelete; ModifiedBy; ModifiedDate; Order_Date; OutboundstatusID; Owner_ID; Priority_ID; Remark; Requested_Ship_Date; SO_Code; Total_Quantity; Truck_Number; Type_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Actual_Ship_Date; Carrier_ID; CreatedBy; CreatedDate; Customer_ID; Driver_Name; ID; IsDelete; ModifiedBy; ModifiedDate; Order_Date; OutboundstatusID; Owner_ID; Priority_ID; Remark; Requested_Ship_Date; SO_Code; Total_Quantity; Truck_Number; Type_ID; WHS_SO_Details_SO_ID;
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
	[Table("tbl_WHS_SO")]
    [Serializable]
	[DataContract]
    public partial class WHS_SO
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Actual_Ship_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Actual_Ship_Date { get; set; }
			        [Column("Carrier_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Carrier_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Customer_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Customer_ID { get; set; }
			        [Column("Driver_Name")]        [DataMember]        public string Driver_Name { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_ID_Required")]        public int ID { get; set; }
			        [Column("IsDelete")]        [DataMember]        public Nullable<bool> IsDelete { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Order_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Order_Date { get; set; }
			        [Column("OutboundstatusID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> OutboundstatusID { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Owner_ID_Required")]        public int Owner_ID { get; set; }
			        [Column("Priority_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Priority_ID { get; set; }
			        [Column("Remark")]        [DataMember]        public string Remark { get; set; }
			        [Column("Requested_Ship_Date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Requested_Ship_Date { get; set; }
			        [Column("SO_Code")]        [DataMember]        public string SO_Code { get; set; }
			        [Column("Total_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Total_Quantity { get; set; }
			        [Column("Truck_Number")]        [DataMember]        public string Truck_Number { get; set; }
			        [Column("Type_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "SO_Type_ID_Required")]        public int Type_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Carrier_ID")]        public virtual ENT_Carrier ENT_Carrier_Carrier_ID { get; set; }        [ForeignKey("Customer_ID")]        public virtual ENT_Customer ENT_Customer_Customer_ID { get; set; }        [ForeignKey("OutboundstatusID")]        public virtual LIST_Code LIST_Code_OutboundstatusID { get; set; }        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }        [ForeignKey("Priority_ID")]        public virtual LIST_Code LIST_Code_Priority_ID { get; set; }        [ForeignKey("Type_ID")]        public virtual LIST_Code LIST_Code_Type_ID { get; set; }		        public virtual ICollection<ENT_Wave> ENT_Waves_SO_ID { get; set; }        public virtual ICollection<WHS_SO_Detail> WHS_SO_Details_SO_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_SO> WHS_SO_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_SO.AsEnumerable().Select(s => new WHS_SO()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Actual_Ship_Date =s.Actual_Ship_Date,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Driver_Name =s.Driver_Name,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Date =s.Order_Date,
										OutboundstatusID =s.OutboundstatusID,
										Owner_ID =s.Owner_ID,
										Priority_ID =s.Priority_ID,
										Remark =s.Remark,
										Requested_Ship_Date =s.Requested_Ship_Date,
										SO_Code =s.SO_Code,
										Total_Quantity =s.Total_Quantity,
										Truck_Number =s.Truck_Number,
										Type_ID =s.Type_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_SO>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_SO> WHS_SO_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_SO_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_SO.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Actual_Ship_Date =s.Actual_Ship_Date,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Driver_Name =s.Driver_Name,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Date =s.Order_Date,
										OutboundstatusID =s.OutboundstatusID,
										Owner_ID =s.Owner_ID,
										Priority_ID =s.Priority_ID,
										Remark =s.Remark,
										Requested_Ship_Date =s.Requested_Ship_Date,
										SO_Code =s.SO_Code,
										Total_Quantity =s.Total_Quantity,
										Truck_Number =s.Truck_Number,
										Type_ID =s.Type_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_SO_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_SO WHS_SO_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_SO.Where(d => d.ID == ID).FirstOrDefault<WHS_SO>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_SO_Create(IEnumerable<WHS_SO> items, string CreatedBy)
        {
            string WHS_SO_List = string.Empty;
            string WHS_SO_List_Serialized = string.Empty;
            string WHS_SO_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_SO> result = new List<WHS_SO>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_SO item in items)
                {
                    WHS_SO dbItem = new WHS_SO();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Actual_Ship_Date =item.Actual_Ship_Date;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Driver_Name =item.Driver_Name;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Date =item.Order_Date;
								dbItem.OutboundstatusID =item.OutboundstatusID;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Priority_ID =item.Priority_ID;
								dbItem.Remark =item.Remark;
								dbItem.Requested_Ship_Date =item.Requested_Ship_Date;
								dbItem.SO_Code =item.SO_Code;
								dbItem.Total_Quantity =item.Total_Quantity;
								dbItem.Truck_Number =item.Truck_Number;
								dbItem.Type_ID =item.Type_ID;
					                   
                    WHS_SO_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_SO.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_SO_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_SO_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_SO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_SO_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Create: {1} - {2}", CreatedBy, WHS_SO_List, WHS_SO_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_SO_Create(WHS_SO item, string CreatedBy)
        {
            string WHS_SO_List = string.Empty;
            string WHS_SO_List_Serialized = string.Empty;
            string WHS_SO_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_SO> result = new List<WHS_SO>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_SO dbItem = new WHS_SO();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Actual_Ship_Date =item.Actual_Ship_Date;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Driver_Name =item.Driver_Name;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Date =item.Order_Date;
								dbItem.OutboundstatusID =item.OutboundstatusID;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Priority_ID =item.Priority_ID;
								dbItem.Remark =item.Remark;
								dbItem.Requested_Ship_Date =item.Requested_Ship_Date;
								dbItem.SO_Code =item.SO_Code;
								dbItem.Total_Quantity =item.Total_Quantity;
								dbItem.Truck_Number =item.Truck_Number;
								dbItem.Type_ID =item.Type_ID;
					                    WHS_SO_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_SO.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_SO_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_SO_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_SO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_SO_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Create: {1} - {2}", CreatedBy, WHS_SO_List, WHS_SO_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_SO_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_SO.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Actual_Ship_Date =s.Actual_Ship_Date,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Driver_Name =s.Driver_Name,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Order_Date =s.Order_Date,
										OutboundstatusID =s.OutboundstatusID,
										Owner_ID =s.Owner_ID,
										Priority_ID =s.Priority_ID,
										Remark =s.Remark,
										Requested_Ship_Date =s.Requested_Ship_Date,
										SO_Code =s.SO_Code,
										Total_Quantity =s.Total_Quantity,
										Truck_Number =s.Truck_Number,
										Type_ID =s.Type_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_SO_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_SO_Update(IEnumerable<WHS_SO> items, string ModifiedBy)
        {
            string WHS_SO_List = string.Empty;
            string WHS_SO_List_Serialized = string.Empty;
            string WHS_SO_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_SO item in items)
                {
                    WHS_SO dbItem = model.DBSet_WHS_SO.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_SO_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Actual_Ship_Date =item.Actual_Ship_Date;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Driver_Name =item.Driver_Name;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Order_Date =item.Order_Date;
								dbItem.OutboundstatusID =item.OutboundstatusID;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Priority_ID =item.Priority_ID;
								dbItem.Remark =item.Remark;
								dbItem.Requested_Ship_Date =item.Requested_Ship_Date;
								dbItem.SO_Code =item.SO_Code;
								dbItem.Total_Quantity =item.Total_Quantity;
								dbItem.Truck_Number =item.Truck_Number;
								dbItem.Type_ID =item.Type_ID;
					                        

                        WHS_SO_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_SO_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_SO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_SO_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Update: {1} - {2}", ModifiedBy, WHS_SO_List, WHS_SO_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_SO_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_SO_List = string.Empty;
            string WHS_SO_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_SO> sendToTrashList = model.DBSet_WHS_SO.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_SO item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_SO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_SO_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_SO_Destroy: {1}", ModifiedBy, WHS_SO_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

