// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Zone
//    File Name         : WHS_Zone.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; IsDeleted; Location_ID; Max_Pallets_per_item; Max_Pick_Container; Max_Pick_Line; Maximum_Case_Count; Maximum_Cube; Maximum_Weight; ModifiedBy; ModifiedDate; PositiveValidationMethod_ID; Replenishment_MethodDetail_ID; ReplenishmentlevelDetail_ID; Zone_Code;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; IsDeleted; Location_ID; Max_Pallets_per_item; Max_Pick_Container; Max_Pick_Line; Maximum_Case_Count; Maximum_Cube; Maximum_Weight; ModifiedBy; ModifiedDate; PositiveValidationMethod_ID; Replenishment_MethodDetail_ID; ReplenishmentlevelDetail_ID; Zone_Code; WHS_Strategy_Putaway_Steps_zone_ID;
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
	[Table("tbl_WHS_Zone")]
    [Serializable]
	[DataContract]
    public partial class WHS_Zone
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Zone_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("Max_Pallets_per_item")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Max_Pallets_per_item { get; set; }
			        [Column("Max_Pick_Container")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Max_Pick_Container { get; set; }
			        [Column("Max_Pick_Line")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Max_Pick_Line { get; set; }
			        [Column("Maximum_Case_Count")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Maximum_Case_Count { get; set; }
			        [Column("Maximum_Cube")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Maximum_Cube { get; set; }
			        [Column("Maximum_Weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Maximum_Weight { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("PositiveValidationMethod_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> PositiveValidationMethod_ID { get; set; }
			        [Column("Replenishment_MethodDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Replenishment_MethodDetail_ID { get; set; }
			        [Column("ReplenishmentlevelDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ReplenishmentlevelDetail_ID { get; set; }
			        [Column("Zone_Code")]        [DataMember]        public string Zone_Code { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("PositiveValidationMethod_ID")]        public virtual LIST_Code LIST_Code_PositiveValidationMethod_ID { get; set; }        [ForeignKey("Replenishment_MethodDetail_ID")]        public virtual WHS_Replenishment WHS_Replenishment_Replenishment_MethodDetail_ID { get; set; }        [ForeignKey("ReplenishmentlevelDetail_ID")]        public virtual LIST_Code LIST_Code_ReplenishmentlevelDetail_ID { get; set; }		        public virtual ICollection<ENT_Item> ENT_Items_Zone_Id { get; set; }        public virtual ICollection<WHS_Location> WHS_Locations_Zone_ID { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_zone_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Zone> WHS_Zone_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Zone.AsEnumerable().Select(s => new WHS_Zone()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Location_ID =s.Location_ID,
										Max_Pallets_per_item =s.Max_Pallets_per_item,
										Max_Pick_Container =s.Max_Pick_Container,
										Max_Pick_Line =s.Max_Pick_Line,
										Maximum_Case_Count =s.Maximum_Case_Count,
										Maximum_Cube =s.Maximum_Cube,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										PositiveValidationMethod_ID =s.PositiveValidationMethod_ID,
										Replenishment_MethodDetail_ID =s.Replenishment_MethodDetail_ID,
										ReplenishmentlevelDetail_ID =s.ReplenishmentlevelDetail_ID,
										Zone_Code =s.Zone_Code,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Zone>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Zone> WHS_Zone_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Zone_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Zone.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Location_ID =s.Location_ID,
										Max_Pallets_per_item =s.Max_Pallets_per_item,
										Max_Pick_Container =s.Max_Pick_Container,
										Max_Pick_Line =s.Max_Pick_Line,
										Maximum_Case_Count =s.Maximum_Case_Count,
										Maximum_Cube =s.Maximum_Cube,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										PositiveValidationMethod_ID =s.PositiveValidationMethod_ID,
										Replenishment_MethodDetail_ID =s.Replenishment_MethodDetail_ID,
										ReplenishmentlevelDetail_ID =s.ReplenishmentlevelDetail_ID,
										Zone_Code =s.Zone_Code,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Zone_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Zone WHS_Zone_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Zone.Where(d => d.ID == ID).FirstOrDefault<WHS_Zone>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Zone_Create(IEnumerable<WHS_Zone> items, string CreatedBy)
        {
            string WHS_Zone_List = string.Empty;
            string WHS_Zone_List_Serialized = string.Empty;
            string WHS_Zone_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Zone> result = new List<WHS_Zone>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Zone item in items)
                {
                    WHS_Zone dbItem = new WHS_Zone();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Max_Pallets_per_item =item.Max_Pallets_per_item;
								dbItem.Max_Pick_Container =item.Max_Pick_Container;
								dbItem.Max_Pick_Line =item.Max_Pick_Line;
								dbItem.Maximum_Case_Count =item.Maximum_Case_Count;
								dbItem.Maximum_Cube =item.Maximum_Cube;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.PositiveValidationMethod_ID =item.PositiveValidationMethod_ID;
								dbItem.Replenishment_MethodDetail_ID =item.Replenishment_MethodDetail_ID;
								dbItem.ReplenishmentlevelDetail_ID =item.ReplenishmentlevelDetail_ID;
								dbItem.Zone_Code =item.Zone_Code;
					                   
                    WHS_Zone_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Zone.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Zone_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Zone_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Zone_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Zone_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Zone_Create: {1} - {2}", CreatedBy, WHS_Zone_List, WHS_Zone_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Zone_Create(WHS_Zone item, string CreatedBy)
        {
            string WHS_Zone_List = string.Empty;
            string WHS_Zone_List_Serialized = string.Empty;
            string WHS_Zone_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Zone> result = new List<WHS_Zone>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Zone dbItem = new WHS_Zone();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Max_Pallets_per_item =item.Max_Pallets_per_item;
								dbItem.Max_Pick_Container =item.Max_Pick_Container;
								dbItem.Max_Pick_Line =item.Max_Pick_Line;
								dbItem.Maximum_Case_Count =item.Maximum_Case_Count;
								dbItem.Maximum_Cube =item.Maximum_Cube;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.PositiveValidationMethod_ID =item.PositiveValidationMethod_ID;
								dbItem.Replenishment_MethodDetail_ID =item.Replenishment_MethodDetail_ID;
								dbItem.ReplenishmentlevelDetail_ID =item.ReplenishmentlevelDetail_ID;
								dbItem.Zone_Code =item.Zone_Code;
					                    WHS_Zone_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Zone.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Zone_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Zone_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Zone_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Zone_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Zone_Create: {1} - {2}", CreatedBy, WHS_Zone_List, WHS_Zone_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Zone_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Zone.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Location_ID =s.Location_ID,
										Max_Pallets_per_item =s.Max_Pallets_per_item,
										Max_Pick_Container =s.Max_Pick_Container,
										Max_Pick_Line =s.Max_Pick_Line,
										Maximum_Case_Count =s.Maximum_Case_Count,
										Maximum_Cube =s.Maximum_Cube,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										PositiveValidationMethod_ID =s.PositiveValidationMethod_ID,
										Replenishment_MethodDetail_ID =s.Replenishment_MethodDetail_ID,
										ReplenishmentlevelDetail_ID =s.ReplenishmentlevelDetail_ID,
										Zone_Code =s.Zone_Code,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Zone_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Zone_Update(IEnumerable<WHS_Zone> items, string ModifiedBy)
        {
            string WHS_Zone_List = string.Empty;
            string WHS_Zone_List_Serialized = string.Empty;
            string WHS_Zone_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Zone item in items)
                {
                    WHS_Zone dbItem = model.DBSet_WHS_Zone.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Zone_List += "[" + item.ID + "] ";
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
								dbItem.Location_ID =item.Location_ID;
								dbItem.Max_Pallets_per_item =item.Max_Pallets_per_item;
								dbItem.Max_Pick_Container =item.Max_Pick_Container;
								dbItem.Max_Pick_Line =item.Max_Pick_Line;
								dbItem.Maximum_Case_Count =item.Maximum_Case_Count;
								dbItem.Maximum_Cube =item.Maximum_Cube;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.PositiveValidationMethod_ID =item.PositiveValidationMethod_ID;
								dbItem.Replenishment_MethodDetail_ID =item.Replenishment_MethodDetail_ID;
								dbItem.ReplenishmentlevelDetail_ID =item.ReplenishmentlevelDetail_ID;
								dbItem.Zone_Code =item.Zone_Code;
					                        

                        WHS_Zone_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Zone_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Zone_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Zone_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Zone_Update: {1} - {2}", ModifiedBy, WHS_Zone_List, WHS_Zone_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Zone_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Zone_List = string.Empty;
            string WHS_Zone_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Zone> sendToTrashList = model.DBSet_WHS_Zone.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Zone item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Zone_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Zone_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Zone_Destroy: {1}", ModifiedBy, WHS_Zone_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

