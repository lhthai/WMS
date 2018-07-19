// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Replenishment
//    File Name         : WHS_Replenishment.cs
//    Properties        : ASN_Receipt_ID; CreatedBy; CreatedDate; ID; Input_Qty; IsDeleted; Item_ID; ModifiedBy; ModifiedDate;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; ASN_Receipt_ID; CreatedBy; CreatedDate; ID; Input_Qty; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; WHS_Zones_Replenishment_MethodDetail_ID;
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
	[Table("tbl_WHS_Replenishment")]
    [Serializable]
	[DataContract]
    public partial class WHS_Replenishment
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("ASN_Receipt_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ASN_Receipt_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Replenishment_ID_Required")]        public int ID { get; set; }
			        [Column("Input_Qty")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Input_Qty { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("ASN_Receipt_ID")]        public virtual WHS_ASN WHS_ASN_ASN_Receipt_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }		        public virtual ICollection<WHS_Zone> WHS_Zones_Replenishment_MethodDetail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Replenishment> WHS_Replenishment_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Replenishment.AsEnumerable().Select(s => new WHS_Replenishment()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Receipt_ID =s.ASN_Receipt_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										Input_Qty =s.Input_Qty,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Replenishment>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Replenishment> WHS_Replenishment_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Replenishment_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Replenishment.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Receipt_ID =s.ASN_Receipt_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										Input_Qty =s.Input_Qty,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Replenishment_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Replenishment WHS_Replenishment_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Replenishment.Where(d => d.ID == ID).FirstOrDefault<WHS_Replenishment>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Replenishment_Create(IEnumerable<WHS_Replenishment> items, string CreatedBy)
        {
            string WHS_Replenishment_List = string.Empty;
            string WHS_Replenishment_List_Serialized = string.Empty;
            string WHS_Replenishment_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Replenishment> result = new List<WHS_Replenishment>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Replenishment item in items)
                {
                    WHS_Replenishment dbItem = new WHS_Replenishment();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Receipt_ID =item.ASN_Receipt_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.Input_Qty =item.Input_Qty;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                   
                    WHS_Replenishment_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Replenishment.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Replenishment_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Replenishment_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Replenishment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Replenishment_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Replenishment_Create: {1} - {2}", CreatedBy, WHS_Replenishment_List, WHS_Replenishment_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Replenishment_Create(WHS_Replenishment item, string CreatedBy)
        {
            string WHS_Replenishment_List = string.Empty;
            string WHS_Replenishment_List_Serialized = string.Empty;
            string WHS_Replenishment_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Replenishment> result = new List<WHS_Replenishment>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Replenishment dbItem = new WHS_Replenishment();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Receipt_ID =item.ASN_Receipt_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.Input_Qty =item.Input_Qty;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                    WHS_Replenishment_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Replenishment.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Replenishment_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Replenishment_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Replenishment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Replenishment_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Replenishment_Create: {1} - {2}", CreatedBy, WHS_Replenishment_List, WHS_Replenishment_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Replenishment_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Replenishment.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										ASN_Receipt_ID =s.ASN_Receipt_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										Input_Qty =s.Input_Qty,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Replenishment_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Replenishment_Update(IEnumerable<WHS_Replenishment> items, string ModifiedBy)
        {
            string WHS_Replenishment_List = string.Empty;
            string WHS_Replenishment_List_Serialized = string.Empty;
            string WHS_Replenishment_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Replenishment item in items)
                {
                    WHS_Replenishment dbItem = model.DBSet_WHS_Replenishment.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Replenishment_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.ASN_Receipt_ID =item.ASN_Receipt_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.Input_Qty =item.Input_Qty;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                        

                        WHS_Replenishment_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Replenishment_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Replenishment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Replenishment_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Replenishment_Update: {1} - {2}", ModifiedBy, WHS_Replenishment_List, WHS_Replenishment_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Replenishment_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Replenishment_List = string.Empty;
            string WHS_Replenishment_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Replenishment> sendToTrashList = model.DBSet_WHS_Replenishment.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Replenishment item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Replenishment_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Replenishment_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Replenishment_Destroy: {1}", ModifiedBy, WHS_Replenishment_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

