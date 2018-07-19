// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : LottableValidation
//    File Name         : ENT_LottableValidation.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; IsDeleted; Lottable_Validation_Key; ModifiedBy; ModifiedDate;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; IsDeleted; Lottable_Validation_Key; ModifiedBy; ModifiedDate; ENT_LottableValidationDetails_V_Lot_ID;
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
	[Table("tbl_ENT_LottableValidation")]
    [Serializable]
	[DataContract]
    public partial class ENT_LottableValidation
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "LottableValidation_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Lottable_Validation_Key")]        [DataMember]        public string Lottable_Validation_Key { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Item> ENT_Items_V_Lot_ID { get; set; }        public virtual ICollection<ENT_LottableValidationDetail> ENT_LottableValidationDetails_V_Lot_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_LottableValidation> ENT_LottableValidation_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidation.AsEnumerable().Select(s => new ENT_LottableValidation()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_Validation_Key =s.Lottable_Validation_Key,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_LottableValidation>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_LottableValidation> ENT_LottableValidation_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_LottableValidation_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_LottableValidation.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_Validation_Key =s.Lottable_Validation_Key,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_LottableValidation_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_LottableValidation ENT_LottableValidation_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_LottableValidation.Where(d => d.ID == ID).FirstOrDefault<ENT_LottableValidation>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_LottableValidation_Create(IEnumerable<ENT_LottableValidation> items, string CreatedBy)
        {
            string ENT_LottableValidation_List = string.Empty;
            string ENT_LottableValidation_List_Serialized = string.Empty;
            string ENT_LottableValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidation> result = new List<ENT_LottableValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidation item in items)
                {
                    ENT_LottableValidation dbItem = new ENT_LottableValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_Validation_Key =item.Lottable_Validation_Key;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                   
                    ENT_LottableValidation_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_LottableValidation.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidation_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_LottableValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_LottableValidation_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidation_Create: {1} - {2}", CreatedBy, ENT_LottableValidation_List, ENT_LottableValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_LottableValidation_Create(ENT_LottableValidation item, string CreatedBy)
        {
            string ENT_LottableValidation_List = string.Empty;
            string ENT_LottableValidation_List_Serialized = string.Empty;
            string ENT_LottableValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_LottableValidation> result = new List<ENT_LottableValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_LottableValidation dbItem = new ENT_LottableValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Lottable_Validation_Key =item.Lottable_Validation_Key;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                    ENT_LottableValidation_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_LottableValidation.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_LottableValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_LottableValidation_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_LottableValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_LottableValidation_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidation_Create: {1} - {2}", CreatedBy, ENT_LottableValidation_List, ENT_LottableValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_LottableValidation_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_LottableValidation.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Lottable_Validation_Key =s.Lottable_Validation_Key,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_LottableValidation_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_LottableValidation_Update(IEnumerable<ENT_LottableValidation> items, string ModifiedBy)
        {
            string ENT_LottableValidation_List = string.Empty;
            string ENT_LottableValidation_List_Serialized = string.Empty;
            string ENT_LottableValidation_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_LottableValidation item in items)
                {
                    ENT_LottableValidation dbItem = model.DBSet_ENT_LottableValidation.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_LottableValidation_List += "[" + item.ID + "] ";
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
								dbItem.Lottable_Validation_Key =item.Lottable_Validation_Key;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                        

                        ENT_LottableValidation_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_LottableValidation_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_LottableValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidation_Update: {1} - {2}", ModifiedBy, ENT_LottableValidation_List, ENT_LottableValidation_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_LottableValidation_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_LottableValidation_List = string.Empty;
            string ENT_LottableValidation_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_LottableValidation> sendToTrashList = model.DBSet_ENT_LottableValidation.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_LottableValidation item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_LottableValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_LottableValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_LottableValidation_Destroy: {1}", ModifiedBy, ENT_LottableValidation_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

