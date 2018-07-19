// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : LottableValidationDetailDetail
//    File Name         : ENT_LottableValidationDetailDetail.cs
//    Properties        : Conversion; CreatedBy; CreatedDate; DateCodeFormat; ID; IsDeleted; Lottable_conversion_ID; Lottable_Validation_Detail_ID; ModifiedBy; ModifiedDate; Sequence; ShelfLifeValidation; V_Date_fortmat_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Conversion; CreatedBy; CreatedDate; DateCodeFormat; ID; IsDeleted; Lottable_conversion_ID; Lottable_Validation_Detail_ID; ModifiedBy; ModifiedDate; Sequence; ShelfLifeValidation; V_Date_fortmat_ID; ENT_V_DateFormat_V_Date_fortmat_ID;
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
	[Table("tbl_ENT_LottableValidationDetailD")]
    [Serializable]
	[DataContract]
    public partial class ENT_LottableValidationDetailDetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Conversion")]        [DataMember]        public string Conversion { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("DateCodeFormat")]        [DataMember]        public string DateCodeFormat { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "LottableValidationDetailDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Lottable_conversion_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Lottable_conversion_ID { get; set; }
			        [Column("Lottable_Validation_Detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Lottable_Validation_Detail_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Sequence")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Sequence { get; set; }
			        [Column("ShelfLifeValidation")]        [DataMember]        public Nullable<bool> ShelfLifeValidation { get; set; }
			        [Column("V_Date_fortmat_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_Date_fortmat_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Lottable_conversion_ID")]        public virtual LIST_Code LIST_Code_Lottable_conversion_ID { get; set; }        [ForeignKey("Lottable_Validation_Detail_ID")]        public virtual ENT_LottableValidationDetail ENT_LottableValidationDetail_Lottable_Validation_Detail_ID { get; set; }        [ForeignKey("V_Date_fortmat_ID")]        public virtual ENT_V_DateFormat ENT_V_DateFormat_V_Date_fortmat_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_LottableValidationDetailDetail> ENT_LottableValidationDetailDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidationDetailDetail.AsEnumerable().Select(s => new ENT_LottableValidationDetailDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Conversion =s.Conversion,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										DateCodeFormat =s.DateCodeFormat,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_conversion_ID =s.Lottable_conversion_ID,
										Lottable_Validation_Detail_ID =s.Lottable_Validation_Detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										ShelfLifeValidation =s.ShelfLifeValidation,
										V_Date_fortmat_ID =s.V_Date_fortmat_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_LottableValidationDetailDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_LottableValidationDetailDetail> ENT_LottableValidationDetailDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_LottableValidationDetailDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidationDetailDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Conversion =s.Conversion,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										DateCodeFormat =s.DateCodeFormat,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_conversion_ID =s.Lottable_conversion_ID,
										Lottable_Validation_Detail_ID =s.Lottable_Validation_Detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										ShelfLifeValidation =s.ShelfLifeValidation,
										V_Date_fortmat_ID =s.V_Date_fortmat_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_LottableValidationDetailDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_LottableValidationDetailDetail ENT_LottableValidationDetailDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_LottableValidationDetailDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_LottableValidationDetailDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_LottableValidationDetailDetail_Create(IEnumerable<ENT_LottableValidationDetailDetail> items, string CreatedBy)
        {
            string ENT_LottableValidationDetailDetail_List = string.Empty;
            string ENT_LottableValidationDetailDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetailDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidationDetailDetail> result = new List<ENT_LottableValidationDetailDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidationDetailDetail item in items)
                {
                    ENT_LottableValidationDetailDetail dbItem = new ENT_LottableValidationDetailDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Conversion =item.Conversion;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.DateCodeFormat =item.DateCodeFormat;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_conversion_ID =item.Lottable_conversion_ID;
								dbItem.Lottable_Validation_Detail_ID =item.Lottable_Validation_Detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.ShelfLifeValidation =item.ShelfLifeValidation;
								dbItem.V_Date_fortmat_ID =item.V_Date_fortmat_ID;
					                   
                    ENT_LottableValidationDetailDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_LottableValidationDetailDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidationDetailDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidationDetailDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_LottableValidationDetailDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_LottableValidationDetailDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetailDetail_Create: {1} - {2}", CreatedBy, ENT_LottableValidationDetailDetail_List, ENT_LottableValidationDetailDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_LottableValidationDetailDetail_Create(ENT_LottableValidationDetailDetail item, string CreatedBy)
        {
            string ENT_LottableValidationDetailDetail_List = string.Empty;
            string ENT_LottableValidationDetailDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetailDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidationDetailDetail> result = new List<ENT_LottableValidationDetailDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_LottableValidationDetailDetail dbItem = new ENT_LottableValidationDetailDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Conversion =item.Conversion;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.DateCodeFormat =item.DateCodeFormat;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_conversion_ID =item.Lottable_conversion_ID;
								dbItem.Lottable_Validation_Detail_ID =item.Lottable_Validation_Detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.ShelfLifeValidation =item.ShelfLifeValidation;
								dbItem.V_Date_fortmat_ID =item.V_Date_fortmat_ID;
					                    ENT_LottableValidationDetailDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_LottableValidationDetailDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidationDetailDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidationDetailDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_LottableValidationDetailDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_LottableValidationDetailDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetailDetail_Create: {1} - {2}", CreatedBy, ENT_LottableValidationDetailDetail_List, ENT_LottableValidationDetailDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_LottableValidationDetailDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_LottableValidationDetailDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Conversion =s.Conversion,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										DateCodeFormat =s.DateCodeFormat,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_conversion_ID =s.Lottable_conversion_ID,
										Lottable_Validation_Detail_ID =s.Lottable_Validation_Detail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										ShelfLifeValidation =s.ShelfLifeValidation,
										V_Date_fortmat_ID =s.V_Date_fortmat_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_LottableValidationDetailDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_LottableValidationDetailDetail_Update(IEnumerable<ENT_LottableValidationDetailDetail> items, string ModifiedBy)
        {
            string ENT_LottableValidationDetailDetail_List = string.Empty;
            string ENT_LottableValidationDetailDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetailDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidationDetailDetail item in items)
                {
                    ENT_LottableValidationDetailDetail dbItem = model.DBSet_ENT_LottableValidationDetailDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_LottableValidationDetailDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Conversion =item.Conversion;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.DateCodeFormat =item.DateCodeFormat;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_conversion_ID =item.Lottable_conversion_ID;
								dbItem.Lottable_Validation_Detail_ID =item.Lottable_Validation_Detail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.ShelfLifeValidation =item.ShelfLifeValidation;
								dbItem.V_Date_fortmat_ID =item.V_Date_fortmat_ID;
					                        

                        ENT_LottableValidationDetailDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_LottableValidationDetailDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_LottableValidationDetailDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidationDetailDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetailDetail_Update: {1} - {2}", ModifiedBy, ENT_LottableValidationDetailDetail_List, ENT_LottableValidationDetailDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_LottableValidationDetailDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_LottableValidationDetailDetail_List = string.Empty;
            string ENT_LottableValidationDetailDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_LottableValidationDetailDetail> sendToTrashList = model.DBSet_ENT_LottableValidationDetailDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_LottableValidationDetailDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_LottableValidationDetailDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidationDetailDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetailDetail_Destroy: {1}", ModifiedBy, ENT_LottableValidationDetailDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

