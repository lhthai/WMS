// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : ASN
//    File Name         : WHS_ASN.cs
//    Properties        : Actual_receipt_date; ASN_Code; Carrier_ID; CreatedBy; CreatedDate; Date_created; Expected_cube; Expected_weight; External_receipt; ID; IsDeleted; ModifiedBy; ModifiedDate; Note; ReceiptStatus_ID; Schedule_receipt_date; Supplier_ID; Total_Expected_Qty; Total_Receipted_Qty;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Actual_receipt_date; ASN_Code; Carrier_ID; CreatedBy; CreatedDate; Date_created; Expected_cube; Expected_weight; External_receipt; ID; IsDeleted; ModifiedBy; ModifiedDate; Note; ReceiptStatus_ID; Schedule_receipt_date; Supplier_ID; Total_Expected_Qty; Total_Receipted_Qty; WHS_Replenishments_ASN_Receipt_ID;
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
	[Table("tbl_WHS_ASN")]
    [Serializable]
	[DataContract]
    public partial class WHS_ASN
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Actual_receipt_date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Actual_receipt_date { get; set; }
			        [Column("ASN_Code")]        [DataMember]        public string ASN_Code { get; set; }
			        [Column("Carrier_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Carrier_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Date_created")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Date_created { get; set; }
			        [Column("Expected_cube")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Expected_cube { get; set; }
			        [Column("Expected_weight")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Expected_weight { get; set; }
			        [Column("PO_ID")]        [DataMember]        public string External_receipt { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "ASN_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Note")]        [DataMember]        public string Note { get; set; }
			        [Column("ReceiptStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ReceiptStatus_ID { get; set; }
			        [Column("Schedule_receipt_date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Schedule_receipt_date { get; set; }
			        [Column("Supplier_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Supplier_ID { get; set; }
			        [Column("Total_Expected_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Total_Expected_Qty { get; set; }
			        [Column("Total_Receipted_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Total_Receipted_Qty { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Carrier_ID")]        public virtual ENT_Carrier ENT_Carrier_Carrier_ID { get; set; }        [ForeignKey("ReceiptStatus_ID")]        public virtual LIST_Code LIST_Code_ReceiptStatus_ID { get; set; }        [ForeignKey("Supplier_ID")]        public virtual ENT_Supplier ENT_Supplier_Supplier_ID { get; set; }		        public virtual ICollection<WHS_ASNDetail> WHS_ASNDetails_ASN_ID { get; set; }        public virtual ICollection<WHS_ReceiptReversal> WHS_ReceiptReversals_ASN_ID { get; set; }        public virtual ICollection<WHS_Replenishment> WHS_Replenishments_ASN_Receipt_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_ASN> WHS_ASN_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ASN.AsEnumerable().Select(s => new WHS_ASN()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Actual_receipt_date =s.Actual_receipt_date,
										ASN_Code =s.ASN_Code,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_created =s.Date_created,
										Expected_cube =s.Expected_cube,
										Expected_weight =s.Expected_weight,
										External_receipt =s.External_receipt,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Schedule_receipt_date =s.Schedule_receipt_date,
										Supplier_ID =s.Supplier_ID,
										Total_Expected_Qty =s.Total_Expected_Qty,
										Total_Receipted_Qty =s.Total_Receipted_Qty,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_ASN>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_ASN> WHS_ASN_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_ASN_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ASN.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Actual_receipt_date =s.Actual_receipt_date,
										ASN_Code =s.ASN_Code,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_created =s.Date_created,
										Expected_cube =s.Expected_cube,
										Expected_weight =s.Expected_weight,
										External_receipt =s.External_receipt,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Schedule_receipt_date =s.Schedule_receipt_date,
										Supplier_ID =s.Supplier_ID,
										Total_Expected_Qty =s.Total_Expected_Qty,
										Total_Receipted_Qty =s.Total_Receipted_Qty,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_ASN_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_ASN WHS_ASN_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_ASN.Where(d => d.ID == ID).FirstOrDefault<WHS_ASN>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_ASN_Create(IEnumerable<WHS_ASN> items, string CreatedBy)
        {
            string WHS_ASN_List = string.Empty;
            string WHS_ASN_List_Serialized = string.Empty;
            string WHS_ASN_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ASN> result = new List<WHS_ASN>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ASN item in items)
                {
                    WHS_ASN dbItem = new WHS_ASN();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Actual_receipt_date =item.Actual_receipt_date;
								dbItem.ASN_Code =item.ASN_Code;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_created =item.Date_created;
								dbItem.Expected_cube =item.Expected_cube;
								dbItem.Expected_weight =item.Expected_weight;
								dbItem.External_receipt =item.External_receipt;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Schedule_receipt_date =item.Schedule_receipt_date;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Expected_Qty =item.Total_Expected_Qty;
								dbItem.Total_Receipted_Qty =item.Total_Receipted_Qty;
					                   
                    WHS_ASN_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_ASN.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ASN_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ASN_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_ASN_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_ASN_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_ASN_Create: {1} - {2}", CreatedBy, WHS_ASN_List, WHS_ASN_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_ASN_Create(WHS_ASN item, string CreatedBy)
        {
            string WHS_ASN_List = string.Empty;
            string WHS_ASN_List_Serialized = string.Empty;
            string WHS_ASN_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ASN> result = new List<WHS_ASN>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_ASN dbItem = new WHS_ASN();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Actual_receipt_date =item.Actual_receipt_date;
								dbItem.ASN_Code =item.ASN_Code;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_created =item.Date_created;
								dbItem.Expected_cube =item.Expected_cube;
								dbItem.Expected_weight =item.Expected_weight;
								dbItem.External_receipt =item.External_receipt;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Schedule_receipt_date =item.Schedule_receipt_date;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Expected_Qty =item.Total_Expected_Qty;
								dbItem.Total_Receipted_Qty =item.Total_Receipted_Qty;
					                    WHS_ASN_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_ASN.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ASN_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ASN_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_ASN_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_ASN_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASN_Create: {1} - {2}", CreatedBy, WHS_ASN_List, WHS_ASN_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_ASN_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_ASN.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Actual_receipt_date =s.Actual_receipt_date,
										ASN_Code =s.ASN_Code,
										Carrier_ID =s.Carrier_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_created =s.Date_created,
										Expected_cube =s.Expected_cube,
										Expected_weight =s.Expected_weight,
										External_receipt =s.External_receipt,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Schedule_receipt_date =s.Schedule_receipt_date,
										Supplier_ID =s.Supplier_ID,
										Total_Expected_Qty =s.Total_Expected_Qty,
										Total_Receipted_Qty =s.Total_Receipted_Qty,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_ASN_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_ASN_Update(IEnumerable<WHS_ASN> items, string ModifiedBy)
        {
            string WHS_ASN_List = string.Empty;
            string WHS_ASN_List_Serialized = string.Empty;
            string WHS_ASN_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ASN item in items)
                {
                    WHS_ASN dbItem = model.DBSet_WHS_ASN.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_ASN_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Actual_receipt_date =item.Actual_receipt_date;
								dbItem.ASN_Code =item.ASN_Code;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_created =item.Date_created;
								dbItem.Expected_cube =item.Expected_cube;
								dbItem.Expected_weight =item.Expected_weight;
								dbItem.External_receipt =item.External_receipt;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Schedule_receipt_date =item.Schedule_receipt_date;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.Total_Expected_Qty =item.Total_Expected_Qty;
								dbItem.Total_Receipted_Qty =item.Total_Receipted_Qty;
					                        

                        WHS_ASN_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_ASN_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_ASN_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ASN_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASN_Update: {1} - {2}", ModifiedBy, WHS_ASN_List, WHS_ASN_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_ASN_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_ASN_List = string.Empty;
            string WHS_ASN_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_ASN> sendToTrashList = model.DBSet_WHS_ASN.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_ASN item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_ASN_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ASN_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASN_Destroy: {1}", ModifiedBy, WHS_ASN_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

