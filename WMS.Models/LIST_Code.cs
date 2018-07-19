// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Code
//    File Name         : LIST_Code.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Type;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Type; WHS_Zones_ReplenishmentlevelDetail_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : True
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
	[Table("tbl_LIST_Code")]
    [Serializable]
	[DataContract]
    public partial class LIST_Code
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
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_LIST), ErrorMessageResourceName = "Code_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Name")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_LIST), ErrorMessageResourceName = "Code_Name_Required")]        public string Name { get; set; }
			        [Column("Type")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Type { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Type")]        public virtual LIST_Code Parent { get; set; }		        public virtual ICollection<ENT_Carrier> ENT_Carriers_Billing_City { get; set; }        public virtual ICollection<ENT_Carrier> ENT_Carriers_Billing_District { get; set; }        public virtual ICollection<ENT_Carrier> ENT_Carriers_City { get; set; }        public virtual ICollection<ENT_Carrier> ENT_Carriers_District { get; set; }        public virtual ICollection<ENT_Customer> ENT_Customers_City { get; set; }        public virtual ICollection<ENT_Customer> ENT_Customers_District { get; set; }        public virtual ICollection<ENT_CycleCountValidationDetail> ENT_CycleCountValidationDetails_LottableAdjustmentRule_ID { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_C_System_Itemtype { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_Code_UOM_ID { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_ItemtypeDetail_ID { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_RotatebyDetail_ID { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_RotationDetail_ID { get; set; }        public virtual ICollection<ENT_LottableValidationDetailDetail> ENT_LottableValidationDetailDetails_Lottable_conversion_ID { get; set; }        public virtual ICollection<ENT_OutboundValidationDetail> ENT_OutboundValidationDetails_Code_Validation_routine_ID { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Billing_City { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Billing_District { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_City { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Rotation_Detail_By { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Rotation_Detail_ID { get; set; }        public virtual ICollection<ENT_Pack> ENT_Packs_UOM_CubeDetail_ID { get; set; }        public virtual ICollection<ENT_Pack> ENT_Packs_UOM_PackageDetail_ID { get; set; }        public virtual ICollection<ENT_Pack> ENT_Packs_UOM_QuantityDetail_ID { get; set; }        public virtual ICollection<ENT_Pack> ENT_Packs_UOM_WeightDetail_ID { get; set; }        public virtual ICollection<ENT_ReceiptValidationDetail> ENT_ReceiptValidationDetails_Allow_error_ID { get; set; }        public virtual ICollection<ENT_Supplier> ENT_Suppliers_Billing_City { get; set; }        public virtual ICollection<ENT_Supplier> ENT_Suppliers_Billing_District { get; set; }        public virtual ICollection<ENT_Supplier> ENT_Suppliers_City { get; set; }        public virtual ICollection<ENT_Supplier> ENT_Suppliers_District { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Code_Date_element_ID { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Code_date_field_ID { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Code_Date_type_ID { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Code_how_to_process_ID { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Date_type { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_Field_type { get; set; }        public virtual ICollection<ENT_Wave> ENT_Waves_Wave_Status_ID { get; set; }        public virtual ICollection<LIST_Code> LIST_Codes_Type { get; set; }        public virtual ICollection<WHS_Adjustment_Detail> WHS_Adjustment_Details_AdjustmentReasonID { get; set; }        public virtual ICollection<WHS_ASN> WHS_ASNs_ReceiptStatus_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_C_System_MovingspeedDetail_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Category_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Flag_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Location_StatusDetail_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Location_Type_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_LocationhandlingDetail_ID { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Movingspeed_ID { get; set; }        public virtual ICollection<WHS_Maintain_Hold> WHS_Maintain_Holds_Holdreason_ID { get; set; }        public virtual ICollection<WHS_Owner_Label> WHS_Owner_Labels_Case_Label_Type { get; set; }        public virtual ICollection<WHS_Owner_Label> WHS_Owner_Labels_LPN_Barcode_Format { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_PickStatus_ID { get; set; }        public virtual ICollection<WHS_PO> WHS_POs_C_System_POStatus_ID { get; set; }        public virtual ICollection<WHS_PO> WHS_POs_UOM_ID { get; set; }        public virtual ICollection<WHS_PODetail> WHS_PODetails_C_System_POStatus_ID { get; set; }        public virtual ICollection<WHS_SO> WHS_SOs_OutboundstatusID { get; set; }        public virtual ICollection<WHS_SO> WHS_SOs_Priority_ID { get; set; }        public virtual ICollection<WHS_SO> WHS_SOs_Type_ID { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_area_restriction_1 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_area_restriction_2 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_area_restriction_3 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Demention_Restriction_1 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Demention_Restriction_2 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Demention_Restriction_3 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Demention_Restriction_4 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Demention_Restriction_5 { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_Puttaway_Type_ID { get; set; }        public virtual ICollection<WHS_Transaction> WHS_Transactions_Activity_ID { get; set; }        public virtual ICollection<WHS_Zone> WHS_Zones_PositiveValidationMethod_ID { get; set; }        public virtual ICollection<WHS_Zone> WHS_Zones_ReplenishmentlevelDetail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class LIST
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<LIST_Code> LIST_Code_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new LIST_Code()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<LIST_Code>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<LIST_Code> LIST_Code_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult LIST_Code_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult LIST_Code_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public LIST_Code LIST_Code_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_LIST_Code.Where(d => d.ID == ID).FirstOrDefault<LIST_Code>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult LIST_Code_Create(IEnumerable<LIST_Code> items, string CreatedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<LIST_Code> result = new List<LIST_Code>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (LIST_Code item in items)
                {
                    LIST_Code dbItem = new LIST_Code();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                   
                    LIST_Code_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_LIST_Code.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    LIST_Code_List += "[" + item.ID + "] ";

                    result.Add(item);
                    LIST_Code_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + LIST_Code_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Create: {1} - {2}", CreatedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult LIST_Code_Create(LIST_Code item, string CreatedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<LIST_Code> result = new List<LIST_Code>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    LIST_Code dbItem = new LIST_Code();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                    LIST_Code_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_LIST_Code.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    LIST_Code_List += "[" + item.ID + "] ";

                    result.Add(item);
                    LIST_Code_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + LIST_Code_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Create: {1} - {2}", CreatedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult LIST_Code_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult LIST_Code_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool LIST_Code_Update(IEnumerable<LIST_Code> items, string ModifiedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (LIST_Code item in items)
                {
                    LIST_Code dbItem = model.DBSet_LIST_Code.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        LIST_Code_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                        

                        LIST_Code_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        LIST_Code_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + LIST_Code_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Update: {1} - {2}", ModifiedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string LIST_Code_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string LIST_Code_List = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<LIST_Code> sendToTrashList = model.DBSet_LIST_Code.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (LIST_Code item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + LIST_Code_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Destroy: {1}", ModifiedBy, LIST_Code_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

