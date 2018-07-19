// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : CycleCountValidationDetail
//    File Name         : ENT_CycleCountValidationDetail.cs
//    Properties        : CreatedBy; CreatedDate; ID; IsDeleted; LottableAdjustmentRule_ID; ModifiedBy; ModifiedDate; Negative_adjustment_lot; Negative_adjustment_lottable3; Negative_adjustment_lottable4; Positive_adjustment_lot; Positive_adjustment_lottable3; Positive_adjustment_lottable4; V_CycleCount_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; ID; IsDeleted; LottableAdjustmentRule_ID; ModifiedBy; ModifiedDate; Negative_adjustment_lot; Negative_adjustment_lottable3; Negative_adjustment_lottable4; Positive_adjustment_lot; Positive_adjustment_lottable3; Positive_adjustment_lottable4; V_CycleCount_ID; ENT_CycleCountValidation_V_CycleCount_ID;
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
	[Table("tbl_ENT_CycleCountValidationDetail")]
    [Serializable]
	[DataContract]
    public partial class ENT_CycleCountValidationDetail
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "CycleCountValidationDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("LottableAdjustmentRule_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> LottableAdjustmentRule_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Negative_adjustment_lot")]        [DataMember]        public string Negative_adjustment_lot { get; set; }
			        [Column("Negative_adjustment_lottable3")]        [DataMember]        public string Negative_adjustment_lottable3 { get; set; }
			        [Column("Negative_adjustment_lottable4")]        [DataMember]        public string Negative_adjustment_lottable4 { get; set; }
			        [Column("Positive_adjustment_lot")]        [DataMember]        public string Positive_adjustment_lot { get; set; }
			        [Column("Positive_adjustment_lottable3")]        [DataMember]        public string Positive_adjustment_lottable3 { get; set; }
			        [Column("Positive_adjustment_lottable4")]        [DataMember]        public string Positive_adjustment_lottable4 { get; set; }
			        [Column("V_CycleCount_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_CycleCount_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("LottableAdjustmentRule_ID")]        public virtual LIST_Code LIST_Code_LottableAdjustmentRule_ID { get; set; }        [ForeignKey("V_CycleCount_ID")]        public virtual ENT_CycleCountValidation ENT_CycleCountValidation_V_CycleCount_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_CycleCountValidationDetail> ENT_CycleCountValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleCountValidationDetail.AsEnumerable().Select(s => new ENT_CycleCountValidationDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LottableAdjustmentRule_ID =s.LottableAdjustmentRule_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Negative_adjustment_lot =s.Negative_adjustment_lot,
										Negative_adjustment_lottable3 =s.Negative_adjustment_lottable3,
										Negative_adjustment_lottable4 =s.Negative_adjustment_lottable4,
										Positive_adjustment_lot =s.Positive_adjustment_lot,
										Positive_adjustment_lottable3 =s.Positive_adjustment_lottable3,
										Positive_adjustment_lottable4 =s.Positive_adjustment_lottable4,
										V_CycleCount_ID =s.V_CycleCount_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_CycleCountValidationDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_CycleCountValidationDetail> ENT_CycleCountValidationDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_CycleCountValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleCountValidationDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LottableAdjustmentRule_ID =s.LottableAdjustmentRule_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Negative_adjustment_lot =s.Negative_adjustment_lot,
										Negative_adjustment_lottable3 =s.Negative_adjustment_lottable3,
										Negative_adjustment_lottable4 =s.Negative_adjustment_lottable4,
										Positive_adjustment_lot =s.Positive_adjustment_lot,
										Positive_adjustment_lottable3 =s.Positive_adjustment_lottable3,
										Positive_adjustment_lottable4 =s.Positive_adjustment_lottable4,
										V_CycleCount_ID =s.V_CycleCount_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_CycleCountValidationDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_CycleCountValidationDetail ENT_CycleCountValidationDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_CycleCountValidationDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_CycleCountValidationDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_CycleCountValidationDetail_Create(IEnumerable<ENT_CycleCountValidationDetail> items, string CreatedBy)
        {
            string ENT_CycleCountValidationDetail_List = string.Empty;
            string ENT_CycleCountValidationDetail_List_Serialized = string.Empty;
            string ENT_CycleCountValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleCountValidationDetail> result = new List<ENT_CycleCountValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleCountValidationDetail item in items)
                {
                    ENT_CycleCountValidationDetail dbItem = new ENT_CycleCountValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LottableAdjustmentRule_ID =item.LottableAdjustmentRule_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Negative_adjustment_lot =item.Negative_adjustment_lot;
								dbItem.Negative_adjustment_lottable3 =item.Negative_adjustment_lottable3;
								dbItem.Negative_adjustment_lottable4 =item.Negative_adjustment_lottable4;
								dbItem.Positive_adjustment_lot =item.Positive_adjustment_lot;
								dbItem.Positive_adjustment_lottable3 =item.Positive_adjustment_lottable3;
								dbItem.Positive_adjustment_lottable4 =item.Positive_adjustment_lottable4;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
					                   
                    ENT_CycleCountValidationDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_CycleCountValidationDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleCountValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleCountValidationDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_CycleCountValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_CycleCountValidationDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidationDetail_Create: {1} - {2}", CreatedBy, ENT_CycleCountValidationDetail_List, ENT_CycleCountValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_CycleCountValidationDetail_Create(ENT_CycleCountValidationDetail item, string CreatedBy)
        {
            string ENT_CycleCountValidationDetail_List = string.Empty;
            string ENT_CycleCountValidationDetail_List_Serialized = string.Empty;
            string ENT_CycleCountValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleCountValidationDetail> result = new List<ENT_CycleCountValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_CycleCountValidationDetail dbItem = new ENT_CycleCountValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LottableAdjustmentRule_ID =item.LottableAdjustmentRule_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Negative_adjustment_lot =item.Negative_adjustment_lot;
								dbItem.Negative_adjustment_lottable3 =item.Negative_adjustment_lottable3;
								dbItem.Negative_adjustment_lottable4 =item.Negative_adjustment_lottable4;
								dbItem.Positive_adjustment_lot =item.Positive_adjustment_lot;
								dbItem.Positive_adjustment_lottable3 =item.Positive_adjustment_lottable3;
								dbItem.Positive_adjustment_lottable4 =item.Positive_adjustment_lottable4;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
					                    ENT_CycleCountValidationDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_CycleCountValidationDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleCountValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleCountValidationDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_CycleCountValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_CycleCountValidationDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidationDetail_Create: {1} - {2}", CreatedBy, ENT_CycleCountValidationDetail_List, ENT_CycleCountValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_CycleCountValidationDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_CycleCountValidationDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LottableAdjustmentRule_ID =s.LottableAdjustmentRule_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Negative_adjustment_lot =s.Negative_adjustment_lot,
										Negative_adjustment_lottable3 =s.Negative_adjustment_lottable3,
										Negative_adjustment_lottable4 =s.Negative_adjustment_lottable4,
										Positive_adjustment_lot =s.Positive_adjustment_lot,
										Positive_adjustment_lottable3 =s.Positive_adjustment_lottable3,
										Positive_adjustment_lottable4 =s.Positive_adjustment_lottable4,
										V_CycleCount_ID =s.V_CycleCount_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_CycleCountValidationDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_CycleCountValidationDetail_Update(IEnumerable<ENT_CycleCountValidationDetail> items, string ModifiedBy)
        {
            string ENT_CycleCountValidationDetail_List = string.Empty;
            string ENT_CycleCountValidationDetail_List_Serialized = string.Empty;
            string ENT_CycleCountValidationDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleCountValidationDetail item in items)
                {
                    ENT_CycleCountValidationDetail dbItem = model.DBSet_ENT_CycleCountValidationDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_CycleCountValidationDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LottableAdjustmentRule_ID =item.LottableAdjustmentRule_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Negative_adjustment_lot =item.Negative_adjustment_lot;
								dbItem.Negative_adjustment_lottable3 =item.Negative_adjustment_lottable3;
								dbItem.Negative_adjustment_lottable4 =item.Negative_adjustment_lottable4;
								dbItem.Positive_adjustment_lot =item.Positive_adjustment_lot;
								dbItem.Positive_adjustment_lottable3 =item.Positive_adjustment_lottable3;
								dbItem.Positive_adjustment_lottable4 =item.Positive_adjustment_lottable4;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
					                        

                        ENT_CycleCountValidationDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_CycleCountValidationDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_CycleCountValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleCountValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidationDetail_Update: {1} - {2}", ModifiedBy, ENT_CycleCountValidationDetail_List, ENT_CycleCountValidationDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_CycleCountValidationDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_CycleCountValidationDetail_List = string.Empty;
            string ENT_CycleCountValidationDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_CycleCountValidationDetail> sendToTrashList = model.DBSet_ENT_CycleCountValidationDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_CycleCountValidationDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_CycleCountValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleCountValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidationDetail_Destroy: {1}", ModifiedBy, ENT_CycleCountValidationDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

