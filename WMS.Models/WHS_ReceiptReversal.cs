// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : ReceiptReversal
//    File Name         : WHS_ReceiptReversal.cs
//    Properties        : Adjustment_number_ID; ASN_ID; CreatedBy; CreatedDate; Effective_date; ID; IsDeleted; ModifiedBy; ModifiedDate;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Adjustment_number_ID; ASN_ID; CreatedBy; CreatedDate; Effective_date; ID; IsDeleted; ModifiedBy; ModifiedDate; WHS_ReceiptReversalDetails_Receipt_reversal_ID;
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
	[Table("tbl_WHS_ReceiptReversal")]
    [Serializable]
	[DataContract]
    public partial class WHS_ReceiptReversal
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Adjustment_number_ID")]        [DataMember]        public string Adjustment_number_ID { get; set; }
			        [Column("ASN_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ASN_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Effective_date")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Effective_date { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "ReceiptReversal_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("ASN_ID")]        public virtual WHS_ASN WHS_ASN_ASN_ID { get; set; }		        public virtual ICollection<WHS_ReceiptReversalDetail> WHS_ReceiptReversalDetails_Receipt_reversal_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_ReceiptReversal> WHS_ReceiptReversal_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ReceiptReversal.AsEnumerable().Select(s => new WHS_ReceiptReversal()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_number_ID =s.Adjustment_number_ID,
										ASN_ID =s.ASN_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Effective_date =s.Effective_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_ReceiptReversal>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_ReceiptReversal> WHS_ReceiptReversal_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_ReceiptReversal_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_ReceiptReversal.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_number_ID =s.Adjustment_number_ID,
										ASN_ID =s.ASN_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Effective_date =s.Effective_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_ReceiptReversal_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_ReceiptReversal WHS_ReceiptReversal_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_ReceiptReversal.Where(d => d.ID == ID).FirstOrDefault<WHS_ReceiptReversal>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_ReceiptReversal_Create(IEnumerable<WHS_ReceiptReversal> items, string CreatedBy)
        {
            string WHS_ReceiptReversal_List = string.Empty;
            string WHS_ReceiptReversal_List_Serialized = string.Empty;
            string WHS_ReceiptReversal_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ReceiptReversal> result = new List<WHS_ReceiptReversal>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ReceiptReversal item in items)
                {
                    WHS_ReceiptReversal dbItem = new WHS_ReceiptReversal();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_number_ID =item.Adjustment_number_ID;
								dbItem.ASN_ID =item.ASN_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Effective_date =item.Effective_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                   
                    WHS_ReceiptReversal_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_ReceiptReversal.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ReceiptReversal_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ReceiptReversal_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_ReceiptReversal_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_ReceiptReversal_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_ReceiptReversal_Create: {1} - {2}", CreatedBy, WHS_ReceiptReversal_List, WHS_ReceiptReversal_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_ReceiptReversal_Create(WHS_ReceiptReversal item, string CreatedBy)
        {
            string WHS_ReceiptReversal_List = string.Empty;
            string WHS_ReceiptReversal_List_Serialized = string.Empty;
            string WHS_ReceiptReversal_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_ReceiptReversal> result = new List<WHS_ReceiptReversal>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_ReceiptReversal dbItem = new WHS_ReceiptReversal();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_number_ID =item.Adjustment_number_ID;
								dbItem.ASN_ID =item.ASN_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Effective_date =item.Effective_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                    WHS_ReceiptReversal_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_ReceiptReversal.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_ReceiptReversal_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_ReceiptReversal_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_ReceiptReversal_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_ReceiptReversal_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ReceiptReversal_Create: {1} - {2}", CreatedBy, WHS_ReceiptReversal_List, WHS_ReceiptReversal_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_ReceiptReversal_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_ReceiptReversal.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_number_ID =s.Adjustment_number_ID,
										ASN_ID =s.ASN_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Effective_date =s.Effective_date,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_ReceiptReversal_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_ReceiptReversal_Update(IEnumerable<WHS_ReceiptReversal> items, string ModifiedBy)
        {
            string WHS_ReceiptReversal_List = string.Empty;
            string WHS_ReceiptReversal_List_Serialized = string.Empty;
            string WHS_ReceiptReversal_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_ReceiptReversal item in items)
                {
                    WHS_ReceiptReversal dbItem = model.DBSet_WHS_ReceiptReversal.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_ReceiptReversal_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Adjustment_number_ID =item.Adjustment_number_ID;
								dbItem.ASN_ID =item.ASN_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Effective_date =item.Effective_date;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                        

                        WHS_ReceiptReversal_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_ReceiptReversal_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_ReceiptReversal_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ReceiptReversal_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ReceiptReversal_Update: {1} - {2}", ModifiedBy, WHS_ReceiptReversal_List, WHS_ReceiptReversal_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_ReceiptReversal_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_ReceiptReversal_List = string.Empty;
            string WHS_ReceiptReversal_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_ReceiptReversal> sendToTrashList = model.DBSet_WHS_ReceiptReversal.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_ReceiptReversal item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_ReceiptReversal_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_ReceiptReversal_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_ReceiptReversal_Destroy: {1}", ModifiedBy, WHS_ReceiptReversal_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

