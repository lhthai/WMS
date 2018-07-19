// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : CycleClass
//    File Name         : ENT_CycleClass.cs
//    Properties        : CreatedBy; CreatedDate; Cycle_Class_Code; Days; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Percent_Negative_Variance; Percent_Positive_Variance; Value_Negative_Variance; Value_Positive_Variance;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Cycle_Class_Code; Days; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Percent_Negative_Variance; Percent_Positive_Variance; Value_Negative_Variance; Value_Positive_Variance; ENT_Owners_Cycle_Class_ID;
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
	[Table("tbl_ENT_CycleClass")]
    [Serializable]
	[DataContract]
    public partial class ENT_CycleClass
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
			        [Column("Cycle_Class_Code")]        [DataMember]        public string Cycle_Class_Code { get; set; }
			        [Column("Days")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Days { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "CycleClass_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Percent_Negative_Variance")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Percent_Negative_Variance { get; set; }
			        [Column("Percent_Positive_Variance")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Percent_Positive_Variance { get; set; }
			        [Column("Value_Negative_Variance")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Value_Negative_Variance { get; set; }
			        [Column("Value_Positive_Variance")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Value_Positive_Variance { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Item> ENT_Items_CycleClass_ID { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Cycle_Class_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_CycleClass> ENT_CycleClass_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleClass.AsEnumerable().Select(s => new ENT_CycleClass()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Class_Code =s.Cycle_Class_Code,
										Days =s.Days,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Percent_Negative_Variance =s.Percent_Negative_Variance,
										Percent_Positive_Variance =s.Percent_Positive_Variance,
										Value_Negative_Variance =s.Value_Negative_Variance,
										Value_Positive_Variance =s.Value_Positive_Variance,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_CycleClass>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_CycleClass> ENT_CycleClass_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_CycleClass_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleClass.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Class_Code =s.Cycle_Class_Code,
										Days =s.Days,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Percent_Negative_Variance =s.Percent_Negative_Variance,
										Percent_Positive_Variance =s.Percent_Positive_Variance,
										Value_Negative_Variance =s.Value_Negative_Variance,
										Value_Positive_Variance =s.Value_Positive_Variance,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_CycleClass_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_CycleClass ENT_CycleClass_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_CycleClass.Where(d => d.ID == ID).FirstOrDefault<ENT_CycleClass>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_CycleClass_Create(IEnumerable<ENT_CycleClass> items, string CreatedBy)
        {
            string ENT_CycleClass_List = string.Empty;
            string ENT_CycleClass_List_Serialized = string.Empty;
            string ENT_CycleClass_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleClass> result = new List<ENT_CycleClass>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleClass item in items)
                {
                    ENT_CycleClass dbItem = new ENT_CycleClass();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Class_Code =item.Cycle_Class_Code;
								dbItem.Days =item.Days;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Percent_Negative_Variance =item.Percent_Negative_Variance;
								dbItem.Percent_Positive_Variance =item.Percent_Positive_Variance;
								dbItem.Value_Negative_Variance =item.Value_Negative_Variance;
								dbItem.Value_Positive_Variance =item.Value_Positive_Variance;
					                   
                    ENT_CycleClass_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_CycleClass.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleClass_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleClass_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_CycleClass_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_CycleClass_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleClass_Create: {1} - {2}", CreatedBy, ENT_CycleClass_List, ENT_CycleClass_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_CycleClass_Create(ENT_CycleClass item, string CreatedBy)
        {
            string ENT_CycleClass_List = string.Empty;
            string ENT_CycleClass_List_Serialized = string.Empty;
            string ENT_CycleClass_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleClass> result = new List<ENT_CycleClass>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_CycleClass dbItem = new ENT_CycleClass();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Class_Code =item.Cycle_Class_Code;
								dbItem.Days =item.Days;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Percent_Negative_Variance =item.Percent_Negative_Variance;
								dbItem.Percent_Positive_Variance =item.Percent_Positive_Variance;
								dbItem.Value_Negative_Variance =item.Value_Negative_Variance;
								dbItem.Value_Positive_Variance =item.Value_Positive_Variance;
					                    ENT_CycleClass_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_CycleClass.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleClass_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleClass_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_CycleClass_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_CycleClass_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleClass_Create: {1} - {2}", CreatedBy, ENT_CycleClass_List, ENT_CycleClass_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_CycleClass_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_CycleClass.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Class_Code =s.Cycle_Class_Code,
										Days =s.Days,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Percent_Negative_Variance =s.Percent_Negative_Variance,
										Percent_Positive_Variance =s.Percent_Positive_Variance,
										Value_Negative_Variance =s.Value_Negative_Variance,
										Value_Positive_Variance =s.Value_Positive_Variance,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_CycleClass_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_CycleClass_Update(IEnumerable<ENT_CycleClass> items, string ModifiedBy)
        {
            string ENT_CycleClass_List = string.Empty;
            string ENT_CycleClass_List_Serialized = string.Empty;
            string ENT_CycleClass_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleClass item in items)
                {
                    ENT_CycleClass dbItem = model.DBSet_ENT_CycleClass.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_CycleClass_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Class_Code =item.Cycle_Class_Code;
								dbItem.Days =item.Days;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Percent_Negative_Variance =item.Percent_Negative_Variance;
								dbItem.Percent_Positive_Variance =item.Percent_Positive_Variance;
								dbItem.Value_Negative_Variance =item.Value_Negative_Variance;
								dbItem.Value_Positive_Variance =item.Value_Positive_Variance;
					                        

                        ENT_CycleClass_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_CycleClass_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_CycleClass_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleClass_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleClass_Update: {1} - {2}", ModifiedBy, ENT_CycleClass_List, ENT_CycleClass_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_CycleClass_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_CycleClass_List = string.Empty;
            string ENT_CycleClass_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_CycleClass> sendToTrashList = model.DBSet_ENT_CycleClass.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_CycleClass item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_CycleClass_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleClass_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleClass_Destroy: {1}", ModifiedBy, ENT_CycleClass_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

