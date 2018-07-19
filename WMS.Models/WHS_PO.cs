// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : PO
//    File Name         : WHS_PO.cs
//    Properties        : C_System_POStatus_ID; CreatedBy; CreatedDate; Expected_receipt_date; ID; IsDeleted; ModifiedBy; ModifiedDate; Notes; Owner_ID; PO_Code; PO_date; ReceiptStatus_ID; Supplier_ID; Total_Order_Qty; UOM_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; C_System_POStatus_ID; CreatedBy; CreatedDate; Expected_receipt_date; ID; IsDeleted; ModifiedBy; ModifiedDate; Notes; Owner_ID; PO_Code; PO_date; ReceiptStatus_ID; Supplier_ID; Total_Order_Qty; UOM_ID; WHS_PODetails_PO_ID;
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
	[Table("tbl_WHS_PO")]
    [Serializable]
	[DataContract]
    public partial class WHS_PO
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("C_System_POStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> C_System_POStatus_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Expected_receipt_date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Expected_receipt_date { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "PO_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_ID { get; set; }
			        [Column("PO_Code")]        [DataMember]        public string PO_Code { get; set; }
			        [Column("PO_date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> PO_date { get; set; }
			        [Column("ReceiptStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ReceiptStatus_ID { get; set; }
			        [Column("Supplier_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Supplier_ID { get; set; }
			        [Column("Total_Order_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Total_Order_Qty { get; set; }
			        [Column("UOM_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("C_System_POStatus_ID")]        public virtual LIST_Code LIST_Code_C_System_POStatus_ID { get; set; }        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }        [ForeignKey("Supplier_ID")]        public virtual ENT_Supplier ENT_Supplier_Supplier_ID { get; set; }        [ForeignKey("UOM_ID")]        public virtual LIST_Code LIST_Code_UOM_ID { get; set; }		        public virtual ICollection<WHS_PODetail> WHS_PODetails_PO_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_PO> WHS_PO_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_PO.AsEnumerable().Select(s => new WHS_PO()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Expected_receipt_date =s.Expected_receipt_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										PO_Code =s.PO_Code,
										PO_date =s.PO_date,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Supplier_ID =s.Supplier_ID,
										Total_Order_Qty =s.Total_Order_Qty,
										UOM_ID =s.UOM_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_PO>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_PO> WHS_PO_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_PO_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_PO.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Expected_receipt_date =s.Expected_receipt_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										PO_Code =s.PO_Code,
										PO_date =s.PO_date,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Supplier_ID =s.Supplier_ID,
										Total_Order_Qty =s.Total_Order_Qty,
										UOM_ID =s.UOM_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_PO_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_PO WHS_PO_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_PO.Where(d => d.ID == ID).FirstOrDefault<WHS_PO>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_PO_Create(IEnumerable<WHS_PO> items, string CreatedBy)
        {
            string WHS_PO_List = string.Empty;
            string WHS_PO_List_Serialized = string.Empty;
            string WHS_PO_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_PO> result = new List<WHS_PO>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_PO item in items)
                {
                    WHS_PO dbItem = new WHS_PO();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Expected_receipt_date =item.Expected_receipt_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.PO_Code =item.PO_Code;
								dbItem.PO_date =item.PO_date;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Order_Qty =item.Total_Order_Qty;
								dbItem.UOM_ID =item.UOM_ID;
					                   
                    WHS_PO_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_PO.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_PO_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_PO_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_PO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_PO_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_PO_Create: {1} - {2}", CreatedBy, WHS_PO_List, WHS_PO_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_PO_Create(WHS_PO item, string CreatedBy)
        {
            string WHS_PO_List = string.Empty;
            string WHS_PO_List_Serialized = string.Empty;
            string WHS_PO_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_PO> result = new List<WHS_PO>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_PO dbItem = new WHS_PO();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Expected_receipt_date =item.Expected_receipt_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.PO_Code =item.PO_Code;
								dbItem.PO_date =item.PO_date;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Order_Qty =item.Total_Order_Qty;
								dbItem.UOM_ID =item.UOM_ID;
					                    WHS_PO_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_PO.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_PO_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_PO_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_PO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_PO_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PO_Create: {1} - {2}", CreatedBy, WHS_PO_List, WHS_PO_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_PO_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_PO.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Expected_receipt_date =s.Expected_receipt_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										PO_Code =s.PO_Code,
										PO_date =s.PO_date,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Supplier_ID =s.Supplier_ID,
										Total_Order_Qty =s.Total_Order_Qty,
										UOM_ID =s.UOM_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_PO_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_PO_Update(IEnumerable<WHS_PO> items, string ModifiedBy)
        {
            string WHS_PO_List = string.Empty;
            string WHS_PO_List_Serialized = string.Empty;
            string WHS_PO_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_PO item in items)
                {
                    WHS_PO dbItem = model.DBSet_WHS_PO.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_PO_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Expected_receipt_date =item.Expected_receipt_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.PO_Code =item.PO_Code;
								dbItem.PO_date =item.PO_date;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Order_Qty =item.Total_Order_Qty;
								dbItem.UOM_ID =item.UOM_ID;
					                        

                        WHS_PO_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_PO_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_PO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_PO_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PO_Update: {1} - {2}", ModifiedBy, WHS_PO_List, WHS_PO_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_PO_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_PO_List = string.Empty;
            string WHS_PO_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_PO> sendToTrashList = model.DBSet_WHS_PO.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_PO item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_PO_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_PO_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PO_Destroy: {1}", ModifiedBy, WHS_PO_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

