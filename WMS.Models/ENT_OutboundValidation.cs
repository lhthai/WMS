// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : OutboundValidation
//    File Name         : ENT_OutboundValidation.cs
//    Properties        : Conditional_Validation_ID; CreatedBy; CreatedDate; Customer_ID; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Outbound_validation_code; Owner_ID; Type;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Conditional_Validation_ID; CreatedBy; CreatedDate; Customer_ID; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Outbound_validation_code; Owner_ID; Type; ENT_OutboundValidationDetails_Outbound_validation_ID;
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
	[Table("tbl_ENT_OutboundValidation")]
    [Serializable]
	[DataContract]
    public partial class ENT_OutboundValidation
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Conditional_Validation_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Conditional_Validation_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Customer_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Customer_ID { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "OutboundValidation_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Outbound_validation_code")]        [DataMember]        public string Outbound_validation_code { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_ID { get; set; }
			        [Column("Type")]        [DataMember]        public string Type { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Conditional_Validation_ID")]        public virtual ENT_OutboundValidation Parent { get; set; }        [ForeignKey("Customer_ID")]        public virtual ENT_Customer ENT_Customer_Customer_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }		        public virtual ICollection<ENT_OutboundValidation> ENT_OutboundValidations_Conditional_Validation_ID { get; set; }        public virtual ICollection<ENT_OutboundValidationDetail> ENT_OutboundValidationDetails_Outbound_validation_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_OutboundValidation> ENT_OutboundValidation_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_OutboundValidation.AsEnumerable().Select(s => new ENT_OutboundValidation()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Conditional_Validation_ID =s.Conditional_Validation_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_code =s.Outbound_validation_code,
										Owner_ID =s.Owner_ID,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_OutboundValidation>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_OutboundValidation> ENT_OutboundValidation_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_OutboundValidation_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_OutboundValidation.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Conditional_Validation_ID =s.Conditional_Validation_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_code =s.Outbound_validation_code,
										Owner_ID =s.Owner_ID,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_OutboundValidation_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_OutboundValidation ENT_OutboundValidation_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_OutboundValidation.Where(d => d.ID == ID).FirstOrDefault<ENT_OutboundValidation>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_OutboundValidation_Create(IEnumerable<ENT_OutboundValidation> items, string CreatedBy)
        {
            string ENT_OutboundValidation_List = string.Empty;
            string ENT_OutboundValidation_List_Serialized = string.Empty;
            string ENT_OutboundValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_OutboundValidation> result = new List<ENT_OutboundValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_OutboundValidation item in items)
                {
                    ENT_OutboundValidation dbItem = new ENT_OutboundValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Conditional_Validation_ID =item.Conditional_Validation_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_code =item.Outbound_validation_code;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Type =item.Type;
					                   
                    ENT_OutboundValidation_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_OutboundValidation.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_OutboundValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_OutboundValidation_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_OutboundValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_OutboundValidation_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidation_Create: {1} - {2}", CreatedBy, ENT_OutboundValidation_List, ENT_OutboundValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_OutboundValidation_Create(ENT_OutboundValidation item, string CreatedBy)
        {
            string ENT_OutboundValidation_List = string.Empty;
            string ENT_OutboundValidation_List_Serialized = string.Empty;
            string ENT_OutboundValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_OutboundValidation> result = new List<ENT_OutboundValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_OutboundValidation dbItem = new ENT_OutboundValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Conditional_Validation_ID =item.Conditional_Validation_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_code =item.Outbound_validation_code;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Type =item.Type;
					                    ENT_OutboundValidation_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_OutboundValidation.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_OutboundValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_OutboundValidation_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_OutboundValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_OutboundValidation_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidation_Create: {1} - {2}", CreatedBy, ENT_OutboundValidation_List, ENT_OutboundValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_OutboundValidation_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_OutboundValidation.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Conditional_Validation_ID =s.Conditional_Validation_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_code =s.Outbound_validation_code,
										Owner_ID =s.Owner_ID,
										Type =s.Type,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_OutboundValidation_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_OutboundValidation_Update(IEnumerable<ENT_OutboundValidation> items, string ModifiedBy)
        {
            string ENT_OutboundValidation_List = string.Empty;
            string ENT_OutboundValidation_List_Serialized = string.Empty;
            string ENT_OutboundValidation_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_OutboundValidation item in items)
                {
                    ENT_OutboundValidation dbItem = model.DBSet_ENT_OutboundValidation.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_OutboundValidation_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Conditional_Validation_ID =item.Conditional_Validation_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_code =item.Outbound_validation_code;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Type =item.Type;
					                        

                        ENT_OutboundValidation_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_OutboundValidation_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_OutboundValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_OutboundValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidation_Update: {1} - {2}", ModifiedBy, ENT_OutboundValidation_List, ENT_OutboundValidation_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_OutboundValidation_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_OutboundValidation_List = string.Empty;
            string ENT_OutboundValidation_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_OutboundValidation> sendToTrashList = model.DBSet_ENT_OutboundValidation.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_OutboundValidation item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_OutboundValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_OutboundValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidation_Destroy: {1}", ModifiedBy, ENT_OutboundValidation_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

