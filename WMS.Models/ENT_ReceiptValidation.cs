// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : ReceiptValidation
//    File Name         : ENT_ReceiptValidation.cs
//    Properties        : CreatedBy; CreatedDate; Default; ID; IsDeleted; ModifiedBy; ModifiedDate; V_Receipt_code;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Default; ID; IsDeleted; ModifiedBy; ModifiedDate; V_Receipt_code; ENT_Items_V_Receipt_ID;
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
	[Table("tbl_ENT_ReceiptValidation")]
    [Serializable]
	[DataContract]
    public partial class ENT_ReceiptValidation
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
			        [Column("Default")]        [DataMember]        public Nullable<bool> Default { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "ReceiptValidation_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("V_Receipt_code")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "ReceiptValidation_V_Receipt_code_Required")]        public string V_Receipt_code { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Item> ENT_Items_V_Receipt_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_ReceiptValidation> ENT_ReceiptValidation_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_ReceiptValidation.AsEnumerable().Select(s => new ENT_ReceiptValidation()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Default =s.Default,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Receipt_code =s.V_Receipt_code,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_ReceiptValidation>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_ReceiptValidation> ENT_ReceiptValidation_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_ReceiptValidation_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_ReceiptValidation.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Default =s.Default,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Receipt_code =s.V_Receipt_code,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_ReceiptValidation_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_ReceiptValidation ENT_ReceiptValidation_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_ReceiptValidation.Where(d => d.ID == ID).FirstOrDefault<ENT_ReceiptValidation>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_ReceiptValidation_Create(IEnumerable<ENT_ReceiptValidation> items, string CreatedBy)
        {
            string ENT_ReceiptValidation_List = string.Empty;
            string ENT_ReceiptValidation_List_Serialized = string.Empty;
            string ENT_ReceiptValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_ReceiptValidation> result = new List<ENT_ReceiptValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_ReceiptValidation item in items)
                {
                    ENT_ReceiptValidation dbItem = new ENT_ReceiptValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Default =item.Default;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Receipt_code =item.V_Receipt_code;
					                   
                    ENT_ReceiptValidation_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_ReceiptValidation.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_ReceiptValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_ReceiptValidation_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_ReceiptValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_ReceiptValidation_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidation_Create: {1} - {2}", CreatedBy, ENT_ReceiptValidation_List, ENT_ReceiptValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_ReceiptValidation_Create(ENT_ReceiptValidation item, string CreatedBy)
        {
            string ENT_ReceiptValidation_List = string.Empty;
            string ENT_ReceiptValidation_List_Serialized = string.Empty;
            string ENT_ReceiptValidation_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_ReceiptValidation> result = new List<ENT_ReceiptValidation>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_ReceiptValidation dbItem = new ENT_ReceiptValidation();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Default =item.Default;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Receipt_code =item.V_Receipt_code;
					                    ENT_ReceiptValidation_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_ReceiptValidation.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_ReceiptValidation_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_ReceiptValidation_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_ReceiptValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_ReceiptValidation_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidation_Create: {1} - {2}", CreatedBy, ENT_ReceiptValidation_List, ENT_ReceiptValidation_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_ReceiptValidation_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_ReceiptValidation.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Default =s.Default,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Receipt_code =s.V_Receipt_code,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_ReceiptValidation_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_ReceiptValidation_Update(IEnumerable<ENT_ReceiptValidation> items, string ModifiedBy)
        {
            string ENT_ReceiptValidation_List = string.Empty;
            string ENT_ReceiptValidation_List_Serialized = string.Empty;
            string ENT_ReceiptValidation_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_ReceiptValidation item in items)
                {
                    ENT_ReceiptValidation dbItem = model.DBSet_ENT_ReceiptValidation.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_ReceiptValidation_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Default =item.Default;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Receipt_code =item.V_Receipt_code;
					                        

                        ENT_ReceiptValidation_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_ReceiptValidation_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_ReceiptValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_ReceiptValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidation_Update: {1} - {2}", ModifiedBy, ENT_ReceiptValidation_List, ENT_ReceiptValidation_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_ReceiptValidation_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_ReceiptValidation_List = string.Empty;
            string ENT_ReceiptValidation_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_ReceiptValidation> sendToTrashList = model.DBSet_ENT_ReceiptValidation.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_ReceiptValidation item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_ReceiptValidation_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_ReceiptValidation_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_ReceiptValidation_Destroy: {1}", ModifiedBy, ENT_ReceiptValidation_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

