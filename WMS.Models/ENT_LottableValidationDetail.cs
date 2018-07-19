// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : LottableValidationDetail
//    File Name         : ENT_LottableValidationDetail.cs
//    Properties        : CreatedBy; CreatedDate; GenerateMask; ID; IsDeleted; Lottable_name; MaximumLength; ModifiedBy; ModifiedDate; Required; V_Lot_ID; Visible;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; GenerateMask; ID; IsDeleted; Lottable_name; MaximumLength; ModifiedBy; ModifiedDate; Required; V_Lot_ID; Visible; ENT_ReceiptValidationDetails_Lottable_Validation_detail_ID;
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
	[Table("tbl_ENT_LottableValidationDetail")]
    [Serializable]
	[DataContract]
    public partial class ENT_LottableValidationDetail
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
			        [Column("GenerateMask")]        [DataMember]        public string GenerateMask { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "LottableValidationDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Lottable_name")]        [DataMember]        public string Lottable_name { get; set; }
			        [Column("MaximumLength")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> MaximumLength { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Required")]        [DataMember]        public Nullable<bool> Required { get; set; }
			        [Column("V_Lot_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_Lot_ID { get; set; }
			        [Column("Visible")]        [DataMember]        public Nullable<bool> Visible { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("V_Lot_ID")]        public virtual ENT_LottableValidation ENT_LottableValidation_V_Lot_ID { get; set; }		        public virtual ICollection<ENT_LottableValidationDetailDetail> ENT_LottableValidationDetailDetails_Lottable_Validation_Detail_ID { get; set; }        public virtual ICollection<ENT_ReceiptValidationDetail> ENT_ReceiptValidationDetails_Lottable_Validation_detail_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_LottableValidationDetail> ENT_LottableValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidationDetail.AsEnumerable().Select(s => new ENT_LottableValidationDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										GenerateMask =s.GenerateMask,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_name =s.Lottable_name,
										MaximumLength =s.MaximumLength,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Required =s.Required,
										V_Lot_ID =s.V_Lot_ID,
										Visible =s.Visible,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_LottableValidationDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_LottableValidationDetail> ENT_LottableValidationDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_LottableValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidationDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										GenerateMask =s.GenerateMask,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_name =s.Lottable_name,
										MaximumLength =s.MaximumLength,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Required =s.Required,
										V_Lot_ID =s.V_Lot_ID,
										Visible =s.Visible,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_LottableValidationDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_LottableValidationDetail ENT_LottableValidationDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_LottableValidationDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_LottableValidationDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_LottableValidationDetail_Create(IEnumerable<ENT_LottableValidationDetail> items, string CreatedBy)
        {
            string ENT_LottableValidationDetail_List = string.Empty;
            string ENT_LottableValidationDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidationDetail> result = new List<ENT_LottableValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidationDetail item in items)
                {
                    ENT_LottableValidationDetail dbItem = new ENT_LottableValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.GenerateMask =item.GenerateMask;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_name =item.Lottable_name;
								dbItem.MaximumLength =item.MaximumLength;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Required =item.Required;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.Visible =item.Visible;
					                   
                    ENT_LottableValidationDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_LottableValidationDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidationDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_LottableValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_LottableValidationDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetail_Create: {1} - {2}", CreatedBy, ENT_LottableValidationDetail_List, ENT_LottableValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_LottableValidationDetail_Create(ENT_LottableValidationDetail item, string CreatedBy)
        {
            string ENT_LottableValidationDetail_List = string.Empty;
            string ENT_LottableValidationDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidationDetail> result = new List<ENT_LottableValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_LottableValidationDetail dbItem = new ENT_LottableValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.GenerateMask =item.GenerateMask;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_name =item.Lottable_name;
								dbItem.MaximumLength =item.MaximumLength;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Required =item.Required;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.Visible =item.Visible;
					                    ENT_LottableValidationDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_LottableValidationDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidationDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_LottableValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_LottableValidationDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetail_Create: {1} - {2}", CreatedBy, ENT_LottableValidationDetail_List, ENT_LottableValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_LottableValidationDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_LottableValidationDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										GenerateMask =s.GenerateMask,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_name =s.Lottable_name,
										MaximumLength =s.MaximumLength,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Required =s.Required,
										V_Lot_ID =s.V_Lot_ID,
										Visible =s.Visible,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_LottableValidationDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_LottableValidationDetail_Update(IEnumerable<ENT_LottableValidationDetail> items, string ModifiedBy)
        {
            string ENT_LottableValidationDetail_List = string.Empty;
            string ENT_LottableValidationDetail_List_Serialized = string.Empty;
            string ENT_LottableValidationDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidationDetail item in items)
                {
                    ENT_LottableValidationDetail dbItem = model.DBSet_ENT_LottableValidationDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_LottableValidationDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.GenerateMask =item.GenerateMask;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_name =item.Lottable_name;
								dbItem.MaximumLength =item.MaximumLength;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Required =item.Required;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.Visible =item.Visible;
					                        

                        ENT_LottableValidationDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_LottableValidationDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_LottableValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetail_Update: {1} - {2}", ModifiedBy, ENT_LottableValidationDetail_List, ENT_LottableValidationDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_LottableValidationDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_LottableValidationDetail_List = string.Empty;
            string ENT_LottableValidationDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_LottableValidationDetail> sendToTrashList = model.DBSet_ENT_LottableValidationDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_LottableValidationDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_LottableValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidationDetail_Destroy: {1}", ModifiedBy, ENT_LottableValidationDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

