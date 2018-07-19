// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : CycleCountValidation
//    File Name         : ENT_CycleCountValidation.cs
//    Properties        : CreatedBy; CreatedDate; Cycle_Count_Discrepancy_Template; Description; ID; IsDeleted; ModifiedBy; ModifiedDate;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Cycle_Count_Discrepancy_Template; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; ENT_Owners_V_Cycle_Count_ID;
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
	[Table("tbl_ENT_CycleCountValidation")]
    [Serializable]
	[DataContract]
    public partial class ENT_CycleCountValidation
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
			        [Column("Cycle_Count_Discrepancy_Template")]        [DataMember]        public string Cycle_Count_Discrepancy_Template { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "CycleCountValidation_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_CycleCountValidationDetail> ENT_CycleCountValidationDetails_V_CycleCount_ID { get; set; }        public virtual ICollection<ENT_Item> ENT_Items_V_CycleCount_ID { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_V_Cycle_Count_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_CycleCountValidation> ENT_CycleCountValidation_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleCountValidation.AsEnumerable().Select(s => new ENT_CycleCountValidation()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Count_Discrepancy_Template =s.Cycle_Count_Discrepancy_Template,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_CycleCountValidation>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_CycleCountValidation> ENT_CycleCountValidation_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_CycleCountValidation_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_CycleCountValidation.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Count_Discrepancy_Template =s.Cycle_Count_Discrepancy_Template,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_CycleCountValidation_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_CycleCountValidation ENT_CycleCountValidation_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_CycleCountValidation.Where(d => d.ID == ID).FirstOrDefault<ENT_CycleCountValidation>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_CycleCountValidation_Create(IEnumerable<ENT_CycleCountValidation> items, string CreatedBy)
        {
            string ENT_CycleCountValidation_List = string.Empty;
            string ENT_CycleCountValidation_List_Serialized = string.Empty;
            string ENT_CycleCountValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleCountValidation> result = new List<ENT_CycleCountValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleCountValidation item in items)
                {
                    ENT_CycleCountValidation dbItem = new ENT_CycleCountValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Count_Discrepancy_Template =item.Cycle_Count_Discrepancy_Template;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                   
                    ENT_CycleCountValidation_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_CycleCountValidation.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleCountValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleCountValidation_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_CycleCountValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_CycleCountValidation_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidation_Create: {1} - {2}", CreatedBy, ENT_CycleCountValidation_List, ENT_CycleCountValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_CycleCountValidation_Create(ENT_CycleCountValidation item, string CreatedBy)
        {
            string ENT_CycleCountValidation_List = string.Empty;
            string ENT_CycleCountValidation_List_Serialized = string.Empty;
            string ENT_CycleCountValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_CycleCountValidation> result = new List<ENT_CycleCountValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_CycleCountValidation dbItem = new ENT_CycleCountValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Count_Discrepancy_Template =item.Cycle_Count_Discrepancy_Template;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                    ENT_CycleCountValidation_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_CycleCountValidation.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_CycleCountValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_CycleCountValidation_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_CycleCountValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_CycleCountValidation_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidation_Create: {1} - {2}", CreatedBy, ENT_CycleCountValidation_List, ENT_CycleCountValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_CycleCountValidation_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_CycleCountValidation.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cycle_Count_Discrepancy_Template =s.Cycle_Count_Discrepancy_Template,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_CycleCountValidation_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_CycleCountValidation_Update(IEnumerable<ENT_CycleCountValidation> items, string ModifiedBy)
        {
            string ENT_CycleCountValidation_List = string.Empty;
            string ENT_CycleCountValidation_List_Serialized = string.Empty;
            string ENT_CycleCountValidation_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_CycleCountValidation item in items)
                {
                    ENT_CycleCountValidation dbItem = model.DBSet_ENT_CycleCountValidation.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_CycleCountValidation_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cycle_Count_Discrepancy_Template =item.Cycle_Count_Discrepancy_Template;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                        

                        ENT_CycleCountValidation_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_CycleCountValidation_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_CycleCountValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleCountValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidation_Update: {1} - {2}", ModifiedBy, ENT_CycleCountValidation_List, ENT_CycleCountValidation_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_CycleCountValidation_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_CycleCountValidation_List = string.Empty;
            string ENT_CycleCountValidation_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_CycleCountValidation> sendToTrashList = model.DBSet_ENT_CycleCountValidation.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_CycleCountValidation item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_CycleCountValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_CycleCountValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_CycleCountValidation_Destroy: {1}", ModifiedBy, ENT_CycleCountValidation_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

