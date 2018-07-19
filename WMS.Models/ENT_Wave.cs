// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Wave
//    File Name         : ENT_Wave.cs
//    Properties        : Create_On; CreatedBy; CreatedDate; Description; ID; IsDelete; ModifiedBy; ModifiedDate; SO_ID; User_ID; Wave_Code; Wave_Status_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Create_On; CreatedBy; CreatedDate; Description; ID; IsDelete; ModifiedBy; ModifiedDate; SO_ID; User_ID; Wave_Code; Wave_Status_ID; LIST_Code_Wave_Status_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : False
//    Has IsDeleted     : False
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
	[Table("tbl_ENT_Wave")]
    [Serializable]
	[DataContract]
    public partial class ENT_Wave
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Create_On")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Create_On { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Wave_ID_Required")]        public int ID { get; set; }
			        [Column("IsDelete")]        [DataMember]        public Nullable<bool> IsDelete { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("SO_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> SO_ID { get; set; }
			        [Column("User_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> User_ID { get; set; }
			        [Column("Wave_Code")]        [DataMember]        public string Wave_Code { get; set; }
			        [Column("Wave_Status_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Wave_Status_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("SO_ID")]        public virtual WHS_SO WHS_SO_SO_ID { get; set; }        [ForeignKey("User_ID")]        public virtual ENT_User ENT_User_User_ID { get; set; }        [ForeignKey("Wave_Status_ID")]        public virtual LIST_Code LIST_Code_Wave_Status_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Wave> ENT_Wave_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Wave.AsEnumerable().Select(s => new ENT_Wave()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Create_On =s.Create_On,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										SO_ID =s.SO_ID,
										User_ID =s.User_ID,
										Wave_Code =s.Wave_Code,
										Wave_Status_ID =s.Wave_Status_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Wave>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Wave> ENT_Wave_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Wave_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Wave.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Create_On =s.Create_On,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										SO_ID =s.SO_ID,
										User_ID =s.User_ID,
										Wave_Code =s.Wave_Code,
										Wave_Status_ID =s.Wave_Status_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Wave_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Wave ENT_Wave_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Wave.Where(d => d.ID == ID).FirstOrDefault<ENT_Wave>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Wave_Create(IEnumerable<ENT_Wave> items, string CreatedBy)
        {
            string ENT_Wave_List = string.Empty;
            string ENT_Wave_List_Serialized = string.Empty;
            string ENT_Wave_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Wave> result = new List<ENT_Wave>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Wave item in items)
                {
                    ENT_Wave dbItem = new ENT_Wave();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Create_On =item.Create_On;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.SO_ID =item.SO_ID;
								dbItem.User_ID =item.User_ID;
								dbItem.Wave_Code =item.Wave_Code;
								dbItem.Wave_Status_ID =item.Wave_Status_ID;
					                   
                    ENT_Wave_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Wave.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Wave_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Wave_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Wave_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Wave_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Wave_Create: {1} - {2}", CreatedBy, ENT_Wave_List, ENT_Wave_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Wave_Create(ENT_Wave item, string CreatedBy)
        {
            string ENT_Wave_List = string.Empty;
            string ENT_Wave_List_Serialized = string.Empty;
            string ENT_Wave_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Wave> result = new List<ENT_Wave>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Wave dbItem = new ENT_Wave();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Create_On =item.Create_On;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.SO_ID =item.SO_ID;
								dbItem.User_ID =item.User_ID;
								dbItem.Wave_Code =item.Wave_Code;
								dbItem.Wave_Status_ID =item.Wave_Status_ID;
					                    ENT_Wave_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Wave.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Wave_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Wave_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Wave_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Wave_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Wave_Create: {1} - {2}", CreatedBy, ENT_Wave_List, ENT_Wave_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Wave_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Wave.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Create_On =s.Create_On,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDelete =s.IsDelete,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										SO_ID =s.SO_ID,
										User_ID =s.User_ID,
										Wave_Code =s.Wave_Code,
										Wave_Status_ID =s.Wave_Status_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Wave_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Wave_Update(IEnumerable<ENT_Wave> items, string ModifiedBy)
        {
            string ENT_Wave_List = string.Empty;
            string ENT_Wave_List_Serialized = string.Empty;
            string ENT_Wave_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Wave item in items)
                {
                    ENT_Wave dbItem = model.DBSet_ENT_Wave.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Wave_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Create_On =item.Create_On;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDelete =item.IsDelete;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.SO_ID =item.SO_ID;
								dbItem.User_ID =item.User_ID;
								dbItem.Wave_Code =item.Wave_Code;
								dbItem.Wave_Status_ID =item.Wave_Status_ID;
					                        

                        ENT_Wave_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Wave_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Wave_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Wave_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Wave_Update: {1} - {2}", ModifiedBy, ENT_Wave_List, ENT_Wave_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Wave_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Wave_List = string.Empty;
            string ENT_Wave_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Wave> sendToTrashList = model.DBSet_ENT_Wave.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Wave item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Wave_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Wave_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Wave_Destroy: {1}", ModifiedBy, ENT_Wave_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

