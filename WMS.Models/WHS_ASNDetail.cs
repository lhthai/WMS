// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : ASNDetail
//    File Name         : WHS_ASNDetail.cs
//    Properties        : ASN_ID; C_System_HoldCode_ID; CreatedBy; CreatedDate; Discrepancy_Qty; Expected_Qty; ID; IsDeleted; Item_ID; Location_ID; Lotable_1; Lotable_10; Lotable_11; Lotable_12; Lotable_2; Lotable_3; Lotable_4; Lotable_5; Lotable_6; LPN; ModifiedBy; ModifiedDate; Notes; Pack_ID; Pallet_Label; Receipt_Line_No; ReceiptStatus_ID; Received_Qty; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; UOM_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; ASN_ID; C_System_HoldCode_ID; CreatedBy; CreatedDate; Discrepancy_Qty; Expected_Qty; ID; IsDeleted; Item_ID; Location_ID; Lotable_1; Lotable_10; Lotable_11; Lotable_12; Lotable_2; Lotable_3; Lotable_4; Lotable_5; Lotable_6; LPN; ModifiedBy; ModifiedDate; Notes; Pack_ID; Pallet_Label; Receipt_Line_No; ReceiptStatus_ID; Received_Qty; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; UOM_ID; WHS_ReceiptReversalDetails_ASN_Detail_ID;
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
	[Table("tbl_WHS_ASNDetail")]
    [Serializable]
	[DataContract]
    public partial class WHS_ASNDetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("ASN_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ASN_ID { get; set; }
			        [Column("C_System_HoldCode_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> C_System_HoldCode_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Discrepancy_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Discrepancy_Qty { get; set; }
			        [Column("Expected_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Expected_Qty { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "ASNDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("Lotable_1")]        [DataMember]        public string Lotable_1 { get; set; }
			        [Column("Lotable_10")]        [DataMember]        public string Lotable_10 { get; set; }
			        [Column("Lotable_11")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lotable_11 { get; set; }
			        [Column("Lotable_12")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lotable_12 { get; set; }
			        [Column("Lotable_2")]        [DataMember]        public string Lotable_2 { get; set; }
			        [Column("Lotable_3")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lotable_3 { get; set; }
			        [Column("Lotable_4")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lotable_4 { get; set; }
			        [Column("Lotable_5")]        [DataMember]        public string Lotable_5 { get; set; }
			        [Column("Lotable_6")]        [DataMember]        public string Lotable_6 { get; set; }
			        [Column("LPN")]        [DataMember]        public string LPN { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Pack_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Pack_ID { get; set; }
			        [Column("Pallet_Label")]        [DataMember]        public string Pallet_Label { get; set; }
			        [Column("Receipt_Line_No")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Receipt_Line_No { get; set; }
			        [Column("ReceiptStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ReceiptStatus_ID { get; set; }
			        [Column("Received_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Received_Qty { get; set; }
			        [Column("UDF_1")]        [DataMember]        public string UDF_1 { get; set; }
			        [Column("UDF_2")]        [DataMember]        public string UDF_2 { get; set; }
			        [Column("UDF_3")]        [DataMember]        public string UDF_3 { get; set; }
			        [Column("UDF_4")]        [DataMember]        public string UDF_4 { get; set; }
			        [Column("UDF_5")]        [DataMember]        public string UDF_5 { get; set; }
			        [Column("UOM_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("ASN_ID")]        public virtual WHS_ASN WHS_ASN_ASN_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("Pack_ID")]        public virtual ENT_Pack ENT_Pack_Pack_ID { get; set; }        [ForeignKey("UOM_ID")]        public virtual ENT_Item ENT_Item_UOM_ID { get; set; }		        public virtual ICollection<WHS_Adjustment_Detail> WHS_Adjustment_Details_ASN_Detail_ID { get; set; }        public virtual ICollection<WHS_Consolidate> WHS_Consolidates_ASN_Detail_ID { get; set; }        public virtual ICollection<WHS_GoodReceiptNote> WHS_GoodReceiptNotes_ASN_Detail_ID { get; set; }        public virtual ICollection<WHS_Lot_Attribute> WHS_Lot_Attributes_ASN_Detail_ID { get; set; }        public virtual ICollection<WHS_ReceiptReversalDetail> WHS_ReceiptReversalDetails_ASN_Detail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_ASNDetail> WHS_ASNDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ASNDetail.AsEnumerable().Select(s => new WHS_ASNDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_ID =s.ASN_ID,
										C_System_HoldCode_ID =s.C_System_HoldCode_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Discrepancy_Qty =s.Discrepancy_Qty,
										Expected_Qty =s.Expected_Qty,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lotable_1 =s.Lotable_1,
										Lotable_10 =s.Lotable_10,
										Lotable_11 =s.Lotable_11,
										Lotable_12 =s.Lotable_12,
										Lotable_2 =s.Lotable_2,
										Lotable_3 =s.Lotable_3,
										Lotable_4 =s.Lotable_4,
										Lotable_5 =s.Lotable_5,
										Lotable_6 =s.Lotable_6,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Pack_ID =s.Pack_ID,
										Pallet_Label =s.Pallet_Label,
										Receipt_Line_No =s.Receipt_Line_No,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Received_Qty =s.Received_Qty,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										UOM_ID =s.UOM_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_ASNDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_ASNDetail> WHS_ASNDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_ASNDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ASNDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_ID =s.ASN_ID,
										C_System_HoldCode_ID =s.C_System_HoldCode_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Discrepancy_Qty =s.Discrepancy_Qty,
										Expected_Qty =s.Expected_Qty,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lotable_1 =s.Lotable_1,
										Lotable_10 =s.Lotable_10,
										Lotable_11 =s.Lotable_11,
										Lotable_12 =s.Lotable_12,
										Lotable_2 =s.Lotable_2,
										Lotable_3 =s.Lotable_3,
										Lotable_4 =s.Lotable_4,
										Lotable_5 =s.Lotable_5,
										Lotable_6 =s.Lotable_6,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Pack_ID =s.Pack_ID,
										Pallet_Label =s.Pallet_Label,
										Receipt_Line_No =s.Receipt_Line_No,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Received_Qty =s.Received_Qty,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										UOM_ID =s.UOM_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_ASNDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_ASNDetail WHS_ASNDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_ASNDetail.Where(d => d.ID == ID).FirstOrDefault<WHS_ASNDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_ASNDetail_Create(IEnumerable<WHS_ASNDetail> items, string CreatedBy)
        {
            string WHS_ASNDetail_List = string.Empty;
            string WHS_ASNDetail_List_Serialized = string.Empty;
            string WHS_ASNDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ASNDetail> result = new List<WHS_ASNDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ASNDetail item in items)
                {
                    WHS_ASNDetail dbItem = new WHS_ASNDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_ID =item.ASN_ID;
								dbItem.C_System_HoldCode_ID =item.C_System_HoldCode_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Discrepancy_Qty =item.Discrepancy_Qty;
								dbItem.Expected_Qty =item.Expected_Qty;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lotable_1 =item.Lotable_1;
								dbItem.Lotable_10 =item.Lotable_10;
								dbItem.Lotable_11 =item.Lotable_11;
								dbItem.Lotable_12 =item.Lotable_12;
								dbItem.Lotable_2 =item.Lotable_2;
								dbItem.Lotable_3 =item.Lotable_3;
								dbItem.Lotable_4 =item.Lotable_4;
								dbItem.Lotable_5 =item.Lotable_5;
								dbItem.Lotable_6 =item.Lotable_6;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Pallet_Label =item.Pallet_Label;
								dbItem.Receipt_Line_No =item.Receipt_Line_No;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Received_Qty =item.Received_Qty;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.UOM_ID =item.UOM_ID;
					                   
                    WHS_ASNDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_ASNDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ASNDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ASNDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_ASNDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_ASNDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_ASNDetail_Create: {1} - {2}", CreatedBy, WHS_ASNDetail_List, WHS_ASNDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_ASNDetail_Create(WHS_ASNDetail item, string CreatedBy)
        {
            string WHS_ASNDetail_List = string.Empty;
            string WHS_ASNDetail_List_Serialized = string.Empty;
            string WHS_ASNDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ASNDetail> result = new List<WHS_ASNDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_ASNDetail dbItem = new WHS_ASNDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_ID =item.ASN_ID;
								dbItem.C_System_HoldCode_ID =item.C_System_HoldCode_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Discrepancy_Qty =item.Discrepancy_Qty;
								dbItem.Expected_Qty =item.Expected_Qty;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lotable_1 =item.Lotable_1;
								dbItem.Lotable_10 =item.Lotable_10;
								dbItem.Lotable_11 =item.Lotable_11;
								dbItem.Lotable_12 =item.Lotable_12;
								dbItem.Lotable_2 =item.Lotable_2;
								dbItem.Lotable_3 =item.Lotable_3;
								dbItem.Lotable_4 =item.Lotable_4;
								dbItem.Lotable_5 =item.Lotable_5;
								dbItem.Lotable_6 =item.Lotable_6;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Pallet_Label =item.Pallet_Label;
								dbItem.Receipt_Line_No =item.Receipt_Line_No;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Received_Qty =item.Received_Qty;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.UOM_ID =item.UOM_ID;
					                    WHS_ASNDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_ASNDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ASNDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ASNDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_ASNDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_ASNDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASNDetail_Create: {1} - {2}", CreatedBy, WHS_ASNDetail_List, WHS_ASNDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_ASNDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_ASNDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										ASN_ID =s.ASN_ID,
										C_System_HoldCode_ID =s.C_System_HoldCode_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Discrepancy_Qty =s.Discrepancy_Qty,
										Expected_Qty =s.Expected_Qty,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Location_ID =s.Location_ID,
										Lotable_1 =s.Lotable_1,
										Lotable_10 =s.Lotable_10,
										Lotable_11 =s.Lotable_11,
										Lotable_12 =s.Lotable_12,
										Lotable_2 =s.Lotable_2,
										Lotable_3 =s.Lotable_3,
										Lotable_4 =s.Lotable_4,
										Lotable_5 =s.Lotable_5,
										Lotable_6 =s.Lotable_6,
										LPN =s.LPN,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Pack_ID =s.Pack_ID,
										Pallet_Label =s.Pallet_Label,
										Receipt_Line_No =s.Receipt_Line_No,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										Received_Qty =s.Received_Qty,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										UOM_ID =s.UOM_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_ASNDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_ASNDetail_Update(IEnumerable<WHS_ASNDetail> items, string ModifiedBy)
        {
            string WHS_ASNDetail_List = string.Empty;
            string WHS_ASNDetail_List_Serialized = string.Empty;
            string WHS_ASNDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ASNDetail item in items)
                {
                    WHS_ASNDetail dbItem = model.DBSet_WHS_ASNDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_ASNDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.ASN_ID =item.ASN_ID;
								dbItem.C_System_HoldCode_ID =item.C_System_HoldCode_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Discrepancy_Qty =item.Discrepancy_Qty;
								dbItem.Expected_Qty =item.Expected_Qty;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lotable_1 =item.Lotable_1;
								dbItem.Lotable_10 =item.Lotable_10;
								dbItem.Lotable_11 =item.Lotable_11;
								dbItem.Lotable_12 =item.Lotable_12;
								dbItem.Lotable_2 =item.Lotable_2;
								dbItem.Lotable_3 =item.Lotable_3;
								dbItem.Lotable_4 =item.Lotable_4;
								dbItem.Lotable_5 =item.Lotable_5;
								dbItem.Lotable_6 =item.Lotable_6;
								dbItem.LPN =item.LPN;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Pallet_Label =item.Pallet_Label;
								dbItem.Receipt_Line_No =item.Receipt_Line_No;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.Received_Qty =item.Received_Qty;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.UOM_ID =item.UOM_ID;
					                        

                        WHS_ASNDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_ASNDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_ASNDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ASNDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASNDetail_Update: {1} - {2}", ModifiedBy, WHS_ASNDetail_List, WHS_ASNDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_ASNDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_ASNDetail_List = string.Empty;
            string WHS_ASNDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_ASNDetail> sendToTrashList = model.DBSet_WHS_ASNDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_ASNDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_ASNDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ASNDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ASNDetail_Destroy: {1}", ModifiedBy, WHS_ASNDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

