// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Adjustment_Detail
//    File Name         : WHS_Adjustment_Detail.cs
//    Properties        : Adjustment_ID; Adjustment_Quantity; AdjustmentReasonID; ASN_Detail_ID; CreatedBy; CreatedDate; Current_Quantity; ID; IsDeleted; Line; ModifiedBy; ModifiedDate; Pack_ID; Target_Quantity;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Adjustment_ID; Adjustment_Quantity; AdjustmentReasonID; ASN_Detail_ID; CreatedBy; CreatedDate; Current_Quantity; ID; IsDeleted; Line; ModifiedBy; ModifiedDate; Pack_ID; Target_Quantity; ENT_Pack_Pack_ID;
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
	[Table("tbl_WHS_Adjustment_Detail")]
    [Serializable]
	[DataContract]
    public partial class WHS_Adjustment_Detail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Adjustment_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Adjustment_ID { get; set; }
			        [Column("Adjustment_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Adjustment_Quantity { get; set; }
			        [Column("AdjustmentReasonID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> AdjustmentReasonID { get; set; }
			        [Column("ASN_Detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ASN_Detail_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Current_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Current_Quantity { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Adjustment_Detail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Line")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Line { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Pack_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Pack_ID { get; set; }
			        [Column("Target_Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Target_Quantity { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Adjustment_ID")]        public virtual WHS_Adjustment WHS_Adjustment_Adjustment_ID { get; set; }        [ForeignKey("AdjustmentReasonID")]        public virtual LIST_Code LIST_Code_AdjustmentReasonID { get; set; }        [ForeignKey("ASN_Detail_ID")]        public virtual WHS_ASNDetail WHS_ASNDetail_ASN_Detail_ID { get; set; }        [ForeignKey("Pack_ID")]        public virtual ENT_Pack ENT_Pack_Pack_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Adjustment_Detail> WHS_Adjustment_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Adjustment_Detail.AsEnumerable().Select(s => new WHS_Adjustment_Detail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_ID =s.Adjustment_ID,
										Adjustment_Quantity =s.Adjustment_Quantity,
										AdjustmentReasonID =s.AdjustmentReasonID,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Current_Quantity =s.Current_Quantity,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line =s.Line,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Target_Quantity =s.Target_Quantity,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Adjustment_Detail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Adjustment_Detail> WHS_Adjustment_Detail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Adjustment_Detail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Adjustment_Detail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_ID =s.Adjustment_ID,
										Adjustment_Quantity =s.Adjustment_Quantity,
										AdjustmentReasonID =s.AdjustmentReasonID,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Current_Quantity =s.Current_Quantity,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line =s.Line,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Target_Quantity =s.Target_Quantity,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Adjustment_Detail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Adjustment_Detail WHS_Adjustment_Detail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Adjustment_Detail.Where(d => d.ID == ID).FirstOrDefault<WHS_Adjustment_Detail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Adjustment_Detail_Create(IEnumerable<WHS_Adjustment_Detail> items, string CreatedBy)
        {
            string WHS_Adjustment_Detail_List = string.Empty;
            string WHS_Adjustment_Detail_List_Serialized = string.Empty;
            string WHS_Adjustment_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Adjustment_Detail> result = new List<WHS_Adjustment_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Adjustment_Detail item in items)
                {
                    WHS_Adjustment_Detail dbItem = new WHS_Adjustment_Detail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_ID =item.Adjustment_ID;
								dbItem.Adjustment_Quantity =item.Adjustment_Quantity;
								dbItem.AdjustmentReasonID =item.AdjustmentReasonID;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Current_Quantity =item.Current_Quantity;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line =item.Line;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Target_Quantity =item.Target_Quantity;
					                   
                    WHS_Adjustment_Detail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Adjustment_Detail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Adjustment_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Adjustment_Detail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Adjustment_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Adjustment_Detail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Detail_Create: {1} - {2}", CreatedBy, WHS_Adjustment_Detail_List, WHS_Adjustment_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Adjustment_Detail_Create(WHS_Adjustment_Detail item, string CreatedBy)
        {
            string WHS_Adjustment_Detail_List = string.Empty;
            string WHS_Adjustment_Detail_List_Serialized = string.Empty;
            string WHS_Adjustment_Detail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Adjustment_Detail> result = new List<WHS_Adjustment_Detail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Adjustment_Detail dbItem = new WHS_Adjustment_Detail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Adjustment_ID =item.Adjustment_ID;
								dbItem.Adjustment_Quantity =item.Adjustment_Quantity;
								dbItem.AdjustmentReasonID =item.AdjustmentReasonID;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Current_Quantity =item.Current_Quantity;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line =item.Line;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Target_Quantity =item.Target_Quantity;
					                    WHS_Adjustment_Detail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Adjustment_Detail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Adjustment_Detail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Adjustment_Detail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Adjustment_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Adjustment_Detail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Detail_Create: {1} - {2}", CreatedBy, WHS_Adjustment_Detail_List, WHS_Adjustment_Detail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Adjustment_Detail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Adjustment_Detail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Adjustment_ID =s.Adjustment_ID,
										Adjustment_Quantity =s.Adjustment_Quantity,
										AdjustmentReasonID =s.AdjustmentReasonID,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Current_Quantity =s.Current_Quantity,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line =s.Line,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_ID =s.Pack_ID,
										Target_Quantity =s.Target_Quantity,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Adjustment_Detail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Adjustment_Detail_Update(IEnumerable<WHS_Adjustment_Detail> items, string ModifiedBy)
        {
            string WHS_Adjustment_Detail_List = string.Empty;
            string WHS_Adjustment_Detail_List_Serialized = string.Empty;
            string WHS_Adjustment_Detail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Adjustment_Detail item in items)
                {
                    WHS_Adjustment_Detail dbItem = model.DBSet_WHS_Adjustment_Detail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Adjustment_Detail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Adjustment_ID =item.Adjustment_ID;
								dbItem.Adjustment_Quantity =item.Adjustment_Quantity;
								dbItem.AdjustmentReasonID =item.AdjustmentReasonID;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Current_Quantity =item.Current_Quantity;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line =item.Line;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_ID =item.Pack_ID;
								dbItem.Target_Quantity =item.Target_Quantity;
					                        

                        WHS_Adjustment_Detail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Adjustment_Detail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Adjustment_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Adjustment_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Detail_Update: {1} - {2}", ModifiedBy, WHS_Adjustment_Detail_List, WHS_Adjustment_Detail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Adjustment_Detail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Adjustment_Detail_List = string.Empty;
            string WHS_Adjustment_Detail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Adjustment_Detail> sendToTrashList = model.DBSet_WHS_Adjustment_Detail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Adjustment_Detail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Adjustment_Detail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Adjustment_Detail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Adjustment_Detail_Destroy: {1}", ModifiedBy, WHS_Adjustment_Detail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

