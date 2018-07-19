// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Strategy_Putaway_Step
//    File Name         : WHS_Strategy_Putaway_Step.cs
//    Properties        : area_restriction_1; area_restriction_2; area_restriction_3; check_restriction; CreatedBy; CreatedDate; Demention_Restriction_1; Demention_Restriction_2; Demention_Restriction_3; Demention_Restriction_4; Demention_Restriction_5; from_location; ID; IsDeleted; ModifiedBy; ModifiedDate; Multi_Pallet; putaway_strategy_ID; Puttaway_Type_ID; step; to_location; zone_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; area_restriction_1; area_restriction_2; area_restriction_3; check_restriction; CreatedBy; CreatedDate; Demention_Restriction_1; Demention_Restriction_2; Demention_Restriction_3; Demention_Restriction_4; Demention_Restriction_5; from_location; ID; IsDeleted; ModifiedBy; ModifiedDate; Multi_Pallet; putaway_strategy_ID; Puttaway_Type_ID; step; to_location; zone_ID; WHS_Zone_zone_ID;
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
	[Table("tbl_WHS_Strategy_Putaway_Step")]
    [Serializable]
	[DataContract]
    public partial class WHS_Strategy_Putaway_Step
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("area_restriction_1")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> area_restriction_1 { get; set; }
			        [Column("area_restriction_2")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> area_restriction_2 { get; set; }
			        [Column("area_restriction_3")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> area_restriction_3 { get; set; }
			        [Column("check_restriction")]        [DataMember]        public Nullable<bool> check_restriction { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Demention_Restriction_1")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Demention_Restriction_1 { get; set; }
			        [Column("Demention_Restriction_2")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Demention_Restriction_2 { get; set; }
			        [Column("Demention_Restriction_3")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Demention_Restriction_3 { get; set; }
			        [Column("Demention_Restriction_4")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Demention_Restriction_4 { get; set; }
			        [Column("Demention_Restriction_5")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Demention_Restriction_5 { get; set; }
			        [Column("from_location")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> from_location { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Strategy_Putaway_Step_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Multi_Pallet")]        [DataMember]        public Nullable<bool> Multi_Pallet { get; set; }
			        [Column("putaway_strategy_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Strategy_Putaway_Step_putaway_strategy_ID_Required")]        public int putaway_strategy_ID { get; set; }
			        [Column("Puttaway_Type_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Puttaway_Type_ID { get; set; }
			        [Column("step")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Strategy_Putaway_Step_step_Required")]        public int step { get; set; }
			        [Column("to_location")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> to_location { get; set; }
			        [Column("zone_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> zone_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("area_restriction_1")]        public virtual LIST_Code LIST_Code_area_restriction_1 { get; set; }        [ForeignKey("area_restriction_2")]        public virtual LIST_Code LIST_Code_area_restriction_2 { get; set; }        [ForeignKey("area_restriction_3")]        public virtual LIST_Code LIST_Code_area_restriction_3 { get; set; }        [ForeignKey("Demention_Restriction_1")]        public virtual LIST_Code LIST_Code_Demention_Restriction_1 { get; set; }        [ForeignKey("Demention_Restriction_2")]        public virtual LIST_Code LIST_Code_Demention_Restriction_2 { get; set; }        [ForeignKey("Demention_Restriction_3")]        public virtual LIST_Code LIST_Code_Demention_Restriction_3 { get; set; }        [ForeignKey("Demention_Restriction_4")]        public virtual LIST_Code LIST_Code_Demention_Restriction_4 { get; set; }        [ForeignKey("Demention_Restriction_5")]        public virtual LIST_Code LIST_Code_Demention_Restriction_5 { get; set; }        [ForeignKey("from_location")]        public virtual WHS_Location WHS_Location_from_location { get; set; }        [ForeignKey("putaway_strategy_ID")]        public virtual WHS_Strategy_Putaway WHS_Strategy_Putaway_putaway_strategy_ID { get; set; }        [ForeignKey("Puttaway_Type_ID")]        public virtual LIST_Code LIST_Code_Puttaway_Type_ID { get; set; }        [ForeignKey("to_location")]        public virtual WHS_Location WHS_Location_to_location { get; set; }        [ForeignKey("zone_ID")]        public virtual WHS_Zone WHS_Zone_zone_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Step_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Strategy_Putaway_Step.AsEnumerable().Select(s => new WHS_Strategy_Putaway_Step()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										area_restriction_1 =s.area_restriction_1,
										area_restriction_2 =s.area_restriction_2,
										area_restriction_3 =s.area_restriction_3,
										check_restriction =s.check_restriction,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Demention_Restriction_1 =s.Demention_Restriction_1,
										Demention_Restriction_2 =s.Demention_Restriction_2,
										Demention_Restriction_3 =s.Demention_Restriction_3,
										Demention_Restriction_4 =s.Demention_Restriction_4,
										Demention_Restriction_5 =s.Demention_Restriction_5,
										from_location =s.from_location,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Multi_Pallet =s.Multi_Pallet,
										putaway_strategy_ID =s.putaway_strategy_ID,
										Puttaway_Type_ID =s.Puttaway_Type_ID,
										step =s.step,
										to_location =s.to_location,
										zone_ID =s.zone_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Strategy_Putaway_Step>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Step_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Strategy_Putaway_Step_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Strategy_Putaway_Step.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										area_restriction_1 =s.area_restriction_1,
										area_restriction_2 =s.area_restriction_2,
										area_restriction_3 =s.area_restriction_3,
										check_restriction =s.check_restriction,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Demention_Restriction_1 =s.Demention_Restriction_1,
										Demention_Restriction_2 =s.Demention_Restriction_2,
										Demention_Restriction_3 =s.Demention_Restriction_3,
										Demention_Restriction_4 =s.Demention_Restriction_4,
										Demention_Restriction_5 =s.Demention_Restriction_5,
										from_location =s.from_location,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Multi_Pallet =s.Multi_Pallet,
										putaway_strategy_ID =s.putaway_strategy_ID,
										Puttaway_Type_ID =s.Puttaway_Type_ID,
										step =s.step,
										to_location =s.to_location,
										zone_ID =s.zone_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Strategy_Putaway_Step_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Strategy_Putaway_Step WHS_Strategy_Putaway_Step_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Strategy_Putaway_Step.Where(d => d.ID == ID).FirstOrDefault<WHS_Strategy_Putaway_Step>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Strategy_Putaway_Step_Create(IEnumerable<WHS_Strategy_Putaway_Step> items, string CreatedBy)
        {
            string WHS_Strategy_Putaway_Step_List = string.Empty;
            string WHS_Strategy_Putaway_Step_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Step_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Strategy_Putaway_Step> result = new List<WHS_Strategy_Putaway_Step>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Strategy_Putaway_Step item in items)
                {
                    WHS_Strategy_Putaway_Step dbItem = new WHS_Strategy_Putaway_Step();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.area_restriction_1 =item.area_restriction_1;
								dbItem.area_restriction_2 =item.area_restriction_2;
								dbItem.area_restriction_3 =item.area_restriction_3;
								dbItem.check_restriction =item.check_restriction;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Demention_Restriction_1 =item.Demention_Restriction_1;
								dbItem.Demention_Restriction_2 =item.Demention_Restriction_2;
								dbItem.Demention_Restriction_3 =item.Demention_Restriction_3;
								dbItem.Demention_Restriction_4 =item.Demention_Restriction_4;
								dbItem.Demention_Restriction_5 =item.Demention_Restriction_5;
								dbItem.from_location =item.from_location;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Multi_Pallet =item.Multi_Pallet;
								dbItem.putaway_strategy_ID =item.putaway_strategy_ID;
								dbItem.Puttaway_Type_ID =item.Puttaway_Type_ID;
								dbItem.step =item.step;
								dbItem.to_location =item.to_location;
								dbItem.zone_ID =item.zone_ID;
					                   
                    WHS_Strategy_Putaway_Step_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Strategy_Putaway_Step.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Strategy_Putaway_Step_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Strategy_Putaway_Step_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Strategy_Putaway_Step_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Strategy_Putaway_Step_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Step_Create: {1} - {2}", CreatedBy, WHS_Strategy_Putaway_Step_List, WHS_Strategy_Putaway_Step_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Strategy_Putaway_Step_Create(WHS_Strategy_Putaway_Step item, string CreatedBy)
        {
            string WHS_Strategy_Putaway_Step_List = string.Empty;
            string WHS_Strategy_Putaway_Step_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Step_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Strategy_Putaway_Step> result = new List<WHS_Strategy_Putaway_Step>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Strategy_Putaway_Step dbItem = new WHS_Strategy_Putaway_Step();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.area_restriction_1 =item.area_restriction_1;
								dbItem.area_restriction_2 =item.area_restriction_2;
								dbItem.area_restriction_3 =item.area_restriction_3;
								dbItem.check_restriction =item.check_restriction;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Demention_Restriction_1 =item.Demention_Restriction_1;
								dbItem.Demention_Restriction_2 =item.Demention_Restriction_2;
								dbItem.Demention_Restriction_3 =item.Demention_Restriction_3;
								dbItem.Demention_Restriction_4 =item.Demention_Restriction_4;
								dbItem.Demention_Restriction_5 =item.Demention_Restriction_5;
								dbItem.from_location =item.from_location;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Multi_Pallet =item.Multi_Pallet;
								dbItem.putaway_strategy_ID =item.putaway_strategy_ID;
								dbItem.Puttaway_Type_ID =item.Puttaway_Type_ID;
								dbItem.step =item.step;
								dbItem.to_location =item.to_location;
								dbItem.zone_ID =item.zone_ID;
					                    WHS_Strategy_Putaway_Step_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Strategy_Putaway_Step.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Strategy_Putaway_Step_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Strategy_Putaway_Step_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Step_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Strategy_Putaway_Step_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Step_Create: {1} - {2}", CreatedBy, WHS_Strategy_Putaway_Step_List, WHS_Strategy_Putaway_Step_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Strategy_Putaway_Step_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Strategy_Putaway_Step.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										area_restriction_1 =s.area_restriction_1,
										area_restriction_2 =s.area_restriction_2,
										area_restriction_3 =s.area_restriction_3,
										check_restriction =s.check_restriction,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Demention_Restriction_1 =s.Demention_Restriction_1,
										Demention_Restriction_2 =s.Demention_Restriction_2,
										Demention_Restriction_3 =s.Demention_Restriction_3,
										Demention_Restriction_4 =s.Demention_Restriction_4,
										Demention_Restriction_5 =s.Demention_Restriction_5,
										from_location =s.from_location,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Multi_Pallet =s.Multi_Pallet,
										putaway_strategy_ID =s.putaway_strategy_ID,
										Puttaway_Type_ID =s.Puttaway_Type_ID,
										step =s.step,
										to_location =s.to_location,
										zone_ID =s.zone_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Strategy_Putaway_Step_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Strategy_Putaway_Step_Update(IEnumerable<WHS_Strategy_Putaway_Step> items, string ModifiedBy)
        {
            string WHS_Strategy_Putaway_Step_List = string.Empty;
            string WHS_Strategy_Putaway_Step_List_Serialized = string.Empty;
            string WHS_Strategy_Putaway_Step_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Strategy_Putaway_Step item in items)
                {
                    WHS_Strategy_Putaway_Step dbItem = model.DBSet_WHS_Strategy_Putaway_Step.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Strategy_Putaway_Step_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.area_restriction_1 =item.area_restriction_1;
								dbItem.area_restriction_2 =item.area_restriction_2;
								dbItem.area_restriction_3 =item.area_restriction_3;
								dbItem.check_restriction =item.check_restriction;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Demention_Restriction_1 =item.Demention_Restriction_1;
								dbItem.Demention_Restriction_2 =item.Demention_Restriction_2;
								dbItem.Demention_Restriction_3 =item.Demention_Restriction_3;
								dbItem.Demention_Restriction_4 =item.Demention_Restriction_4;
								dbItem.Demention_Restriction_5 =item.Demention_Restriction_5;
								dbItem.from_location =item.from_location;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Multi_Pallet =item.Multi_Pallet;
								dbItem.putaway_strategy_ID =item.putaway_strategy_ID;
								dbItem.Puttaway_Type_ID =item.Puttaway_Type_ID;
								dbItem.step =item.step;
								dbItem.to_location =item.to_location;
								dbItem.zone_ID =item.zone_ID;
					                        

                        WHS_Strategy_Putaway_Step_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Strategy_Putaway_Step_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Step_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Strategy_Putaway_Step_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Step_Update: {1} - {2}", ModifiedBy, WHS_Strategy_Putaway_Step_List, WHS_Strategy_Putaway_Step_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Strategy_Putaway_Step_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Strategy_Putaway_Step_List = string.Empty;
            string WHS_Strategy_Putaway_Step_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Strategy_Putaway_Step> sendToTrashList = model.DBSet_WHS_Strategy_Putaway_Step.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Strategy_Putaway_Step item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Strategy_Putaway_Step_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Strategy_Putaway_Step_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Strategy_Putaway_Step_Destroy: {1}", ModifiedBy, WHS_Strategy_Putaway_Step_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

