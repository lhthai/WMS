// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : ReceiptValidationDetail
//    File Name         : ENT_ReceiptValidationDetail.cs
//    Properties        : Allow_error_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_Not_on_ASN; Item_not_on_PO; Lottable_Validation_detail_ID; ModifiedBy; ModifiedDate; Overage_Hard_Error; Overage_Message; Overage_Override; Perform_Qty_Validation; Receipt_Without_ASN; Receipt_without_LPN; Receipt_without_PO;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Allow_error_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_Not_on_ASN; Item_not_on_PO; Lottable_Validation_detail_ID; ModifiedBy; ModifiedDate; Overage_Hard_Error; Overage_Message; Overage_Override; Perform_Qty_Validation; Receipt_Without_ASN; Receipt_without_LPN; Receipt_without_PO; ENT_Owners_Receipt_Validation_Detail_ID;
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
	[Table("tbl_ENT_ReceiptValidationDetail")]
    [Serializable]
	[DataContract]
    public partial class ENT_ReceiptValidationDetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Allow_error_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Allow_error_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "ReceiptValidationDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_Not_on_ASN")]        [DataMember]        public string Item_Not_on_ASN { get; set; }
			        [Column("Item_not_on_PO")]        [DataMember]        public string Item_not_on_PO { get; set; }
			        [Column("Lottable_Validation_detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Lottable_Validation_detail_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Overage_Hard_Error")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Overage_Hard_Error { get; set; }
			        [Column("Overage_Message")]        [DataMember]        public Nullable<bool> Overage_Message { get; set; }
			        [Column("Overage_Override")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Overage_Override { get; set; }
			        [Column("Perform_Qty_Validation")]        [DataMember]        public Nullable<bool> Perform_Qty_Validation { get; set; }
			        [Column("Receipt_Without_ASN")]        [DataMember]        public string Receipt_Without_ASN { get; set; }
			        [Column("Receipt_without_LPN")]        [DataMember]        public string Receipt_without_LPN { get; set; }
			        [Column("Receipt_without_PO")]        [DataMember]        public string Receipt_without_PO { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Allow_error_ID")]        public virtual LIST_Code LIST_Code_Allow_error_ID { get; set; }        [ForeignKey("Lottable_Validation_detail_ID")]        public virtual ENT_LottableValidationDetail ENT_LottableValidationDetail_Lottable_Validation_detail_ID { get; set; }		        public virtual ICollection<ENT_Owner> ENT_Owners_Receipt_Validation_Detail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_ReceiptValidationDetail> ENT_ReceiptValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_ReceiptValidationDetail.AsEnumerable().Select(s => new ENT_ReceiptValidationDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allow_error_ID =s.Allow_error_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Not_on_ASN =s.Item_Not_on_ASN,
										Item_not_on_PO =s.Item_not_on_PO,
										Lottable_Validation_detail_ID =s.Lottable_Validation_detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Overage_Hard_Error =s.Overage_Hard_Error,
										Overage_Message =s.Overage_Message,
										Overage_Override =s.Overage_Override,
										Perform_Qty_Validation =s.Perform_Qty_Validation,
										Receipt_Without_ASN =s.Receipt_Without_ASN,
										Receipt_without_LPN =s.Receipt_without_LPN,
										Receipt_without_PO =s.Receipt_without_PO,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_ReceiptValidationDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_ReceiptValidationDetail> ENT_ReceiptValidationDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_ReceiptValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_ReceiptValidationDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allow_error_ID =s.Allow_error_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Not_on_ASN =s.Item_Not_on_ASN,
										Item_not_on_PO =s.Item_not_on_PO,
										Lottable_Validation_detail_ID =s.Lottable_Validation_detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Overage_Hard_Error =s.Overage_Hard_Error,
										Overage_Message =s.Overage_Message,
										Overage_Override =s.Overage_Override,
										Perform_Qty_Validation =s.Perform_Qty_Validation,
										Receipt_Without_ASN =s.Receipt_Without_ASN,
										Receipt_without_LPN =s.Receipt_without_LPN,
										Receipt_without_PO =s.Receipt_without_PO,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_ReceiptValidationDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_ReceiptValidationDetail ENT_ReceiptValidationDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_ReceiptValidationDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_ReceiptValidationDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_ReceiptValidationDetail_Create(IEnumerable<ENT_ReceiptValidationDetail> items, string CreatedBy)
        {
            string ENT_ReceiptValidationDetail_List = string.Empty;
            string ENT_ReceiptValidationDetail_List_Serialized = string.Empty;
            string ENT_ReceiptValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_ReceiptValidationDetail> result = new List<ENT_ReceiptValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_ReceiptValidationDetail item in items)
                {
                    ENT_ReceiptValidationDetail dbItem = new ENT_ReceiptValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allow_error_ID =item.Allow_error_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Not_on_ASN =item.Item_Not_on_ASN;
								dbItem.Item_not_on_PO =item.Item_not_on_PO;
								dbItem.Lottable_Validation_detail_ID =item.Lottable_Validation_detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Overage_Hard_Error =item.Overage_Hard_Error;
								dbItem.Overage_Message =item.Overage_Message;
								dbItem.Overage_Override =item.Overage_Override;
								dbItem.Perform_Qty_Validation =item.Perform_Qty_Validation;
								dbItem.Receipt_Without_ASN =item.Receipt_Without_ASN;
								dbItem.Receipt_without_LPN =item.Receipt_without_LPN;
								dbItem.Receipt_without_PO =item.Receipt_without_PO;
					                   
                    ENT_ReceiptValidationDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_ReceiptValidationDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_ReceiptValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_ReceiptValidationDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_ReceiptValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_ReceiptValidationDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidationDetail_Create: {1} - {2}", CreatedBy, ENT_ReceiptValidationDetail_List, ENT_ReceiptValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_ReceiptValidationDetail_Create(ENT_ReceiptValidationDetail item, string CreatedBy)
        {
            string ENT_ReceiptValidationDetail_List = string.Empty;
            string ENT_ReceiptValidationDetail_List_Serialized = string.Empty;
            string ENT_ReceiptValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_ReceiptValidationDetail> result = new List<ENT_ReceiptValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_ReceiptValidationDetail dbItem = new ENT_ReceiptValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allow_error_ID =item.Allow_error_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Not_on_ASN =item.Item_Not_on_ASN;
								dbItem.Item_not_on_PO =item.Item_not_on_PO;
								dbItem.Lottable_Validation_detail_ID =item.Lottable_Validation_detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Overage_Hard_Error =item.Overage_Hard_Error;
								dbItem.Overage_Message =item.Overage_Message;
								dbItem.Overage_Override =item.Overage_Override;
								dbItem.Perform_Qty_Validation =item.Perform_Qty_Validation;
								dbItem.Receipt_Without_ASN =item.Receipt_Without_ASN;
								dbItem.Receipt_without_LPN =item.Receipt_without_LPN;
								dbItem.Receipt_without_PO =item.Receipt_without_PO;
					                    ENT_ReceiptValidationDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_ReceiptValidationDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_ReceiptValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_ReceiptValidationDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_ReceiptValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_ReceiptValidationDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidationDetail_Create: {1} - {2}", CreatedBy, ENT_ReceiptValidationDetail_List, ENT_ReceiptValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_ReceiptValidationDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_ReceiptValidationDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Allow_error_ID =s.Allow_error_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Not_on_ASN =s.Item_Not_on_ASN,
										Item_not_on_PO =s.Item_not_on_PO,
										Lottable_Validation_detail_ID =s.Lottable_Validation_detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Overage_Hard_Error =s.Overage_Hard_Error,
										Overage_Message =s.Overage_Message,
										Overage_Override =s.Overage_Override,
										Perform_Qty_Validation =s.Perform_Qty_Validation,
										Receipt_Without_ASN =s.Receipt_Without_ASN,
										Receipt_without_LPN =s.Receipt_without_LPN,
										Receipt_without_PO =s.Receipt_without_PO,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_ReceiptValidationDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_ReceiptValidationDetail_Update(IEnumerable<ENT_ReceiptValidationDetail> items, string ModifiedBy)
        {
            string ENT_ReceiptValidationDetail_List = string.Empty;
            string ENT_ReceiptValidationDetail_List_Serialized = string.Empty;
            string ENT_ReceiptValidationDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_ReceiptValidationDetail item in items)
                {
                    ENT_ReceiptValidationDetail dbItem = model.DBSet_ENT_ReceiptValidationDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_ReceiptValidationDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Allow_error_ID =item.Allow_error_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Not_on_ASN =item.Item_Not_on_ASN;
								dbItem.Item_not_on_PO =item.Item_not_on_PO;
								dbItem.Lottable_Validation_detail_ID =item.Lottable_Validation_detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Overage_Hard_Error =item.Overage_Hard_Error;
								dbItem.Overage_Message =item.Overage_Message;
								dbItem.Overage_Override =item.Overage_Override;
								dbItem.Perform_Qty_Validation =item.Perform_Qty_Validation;
								dbItem.Receipt_Without_ASN =item.Receipt_Without_ASN;
								dbItem.Receipt_without_LPN =item.Receipt_without_LPN;
								dbItem.Receipt_without_PO =item.Receipt_without_PO;
					                        

                        ENT_ReceiptValidationDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_ReceiptValidationDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_ReceiptValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_ReceiptValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidationDetail_Update: {1} - {2}", ModifiedBy, ENT_ReceiptValidationDetail_List, ENT_ReceiptValidationDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_ReceiptValidationDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_ReceiptValidationDetail_List = string.Empty;
            string ENT_ReceiptValidationDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_ReceiptValidationDetail> sendToTrashList = model.DBSet_ENT_ReceiptValidationDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_ReceiptValidationDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_ReceiptValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_ReceiptValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidationDetail_Destroy: {1}", ModifiedBy, ENT_ReceiptValidationDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

