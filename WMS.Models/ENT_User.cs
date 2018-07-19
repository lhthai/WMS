// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : User
//    File Name         : ENT_User.cs
//    Properties        : CreatedBy; CreatedDate; Encrypt; Full_Name; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Password;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Encrypt; Full_Name; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Password; WHS_Maintain_Holds_User_ID;
//    New Properties    :
//    Out Update        :
//
//    Has Code          : False
//    Has Name          : True
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
	[Table("tbl_ENT_User")]
    [Serializable]
	[DataContract]
    public partial class ENT_User
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
			        [Column("Encrypt")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "User_Encrypt_Required")]        public string Encrypt { get; set; }
			        [Column("Full_Name")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "User_Full_Name_Required")]        public string Full_Name { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "User_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Name")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "User_Name_Required")]        public string Name { get; set; }
			        [Column("Password")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "User_Password_Required")]        public string Password { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Wave> ENT_Waves_User_ID { get; set; }        public virtual ICollection<WHS_Adjustment> WHS_Adjustments_User_ID { get; set; }        public virtual ICollection<WHS_GoodReceiptNote> WHS_GoodReceiptNotes_User_ID { get; set; }        public virtual ICollection<WHS_Maintain_Hold> WHS_Maintain_Holds_User_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_User> ENT_User_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_User.AsEnumerable().Select(s => new ENT_User()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Encrypt =s.Encrypt,
										Full_Name =s.Full_Name,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Password =s.Password,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_User>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_User> ENT_User_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_User_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_User.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Encrypt =s.Encrypt,
										Full_Name =s.Full_Name,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Password =s.Password,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_User_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_User ENT_User_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_User.Where(d => d.ID == ID).FirstOrDefault<ENT_User>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_User_Create(IEnumerable<ENT_User> items, string CreatedBy)
        {
            string ENT_User_List = string.Empty;
            string ENT_User_List_Serialized = string.Empty;
            string ENT_User_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_User> result = new List<ENT_User>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_User item in items)
                {
                    ENT_User dbItem = new ENT_User();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Encrypt =item.Encrypt;
								dbItem.Full_Name =item.Full_Name;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Password =item.Password;
					                   
                    ENT_User_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_User.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_User_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_User_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_User_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_User_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_User_Create: {1} - {2}", CreatedBy, ENT_User_List, ENT_User_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_User_Create(ENT_User item, string CreatedBy)
        {
            string ENT_User_List = string.Empty;
            string ENT_User_List_Serialized = string.Empty;
            string ENT_User_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_User> result = new List<ENT_User>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_User dbItem = new ENT_User();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Encrypt =item.Encrypt;
								dbItem.Full_Name =item.Full_Name;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Password =item.Password;
					                    ENT_User_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_User.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_User_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_User_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_User_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_User_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_User_Create: {1} - {2}", CreatedBy, ENT_User_List, ENT_User_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_User_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_User.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Encrypt =s.Encrypt,
										Full_Name =s.Full_Name,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Password =s.Password,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_User_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_User_Update(IEnumerable<ENT_User> items, string ModifiedBy)
        {
            string ENT_User_List = string.Empty;
            string ENT_User_List_Serialized = string.Empty;
            string ENT_User_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_User item in items)
                {
                    ENT_User dbItem = model.DBSet_ENT_User.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_User_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Encrypt =item.Encrypt;
								dbItem.Full_Name =item.Full_Name;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Password =item.Password;
					                        

                        ENT_User_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_User_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_User_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_User_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_User_Update: {1} - {2}", ModifiedBy, ENT_User_List, ENT_User_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_User_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_User_List = string.Empty;
            string ENT_User_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_User> sendToTrashList = model.DBSet_ENT_User.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_User item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_User_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_User_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_User_Destroy: {1}", ModifiedBy, ENT_User_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

