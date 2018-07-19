// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Code
//    File Name         : LIST_Code.cs
//    Properties        : CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Type;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; Description; ID; IsDeleted; ModifiedBy; ModifiedDate; Name; Type; WHS_Zones_ReplenishmentlevelDetail_ID;
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
	[Table("tbl_LIST_Code")]
    [Serializable]
	[DataContract]
    public partial class LIST_Code
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
        
			
			
			
			
			
			
			
			
					
		#region Navigation properties for creating ForeignKey
		

		#endregion
		
        #endregion
    }





	public partial class LIST
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<LIST_Code> LIST_Code_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new LIST_Code()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<LIST_Code>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<LIST_Code> LIST_Code_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult LIST_Code_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult LIST_Code_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public LIST_Code LIST_Code_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_LIST_Code.Where(d => d.ID == ID).FirstOrDefault<LIST_Code>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult LIST_Code_Create(IEnumerable<LIST_Code> items, string CreatedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<LIST_Code> result = new List<LIST_Code>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (LIST_Code item in items)
                {
                    LIST_Code dbItem = new LIST_Code();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                   
                    LIST_Code_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_LIST_Code.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    LIST_Code_List += "[" + item.ID + "] ";

                    result.Add(item);
                    LIST_Code_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + LIST_Code_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Create: {1} - {2}", CreatedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult LIST_Code_Create(LIST_Code item, string CreatedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<LIST_Code> result = new List<LIST_Code>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    LIST_Code dbItem = new LIST_Code();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                    LIST_Code_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_LIST_Code.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    LIST_Code_List += "[" + item.ID + "] ";

                    result.Add(item);
                    LIST_Code_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + LIST_Code_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Create: {1} - {2}", CreatedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult LIST_Code_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_LIST_Code.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Name =s.Name,
										Type =s.Type,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult LIST_Code_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool LIST_Code_Update(IEnumerable<LIST_Code> items, string ModifiedBy)
        {
            string LIST_Code_List = string.Empty;
            string LIST_Code_List_Serialized = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (LIST_Code item in items)
                {
                    LIST_Code dbItem = model.DBSet_LIST_Code.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        LIST_Code_List += "[" + item.ID + "] ";
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
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Name =item.Name;
								dbItem.Type =item.Type;
					                        

                        LIST_Code_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        LIST_Code_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + LIST_Code_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Update: {1} - {2}", ModifiedBy, LIST_Code_List, LIST_Code_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string LIST_Code_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string LIST_Code_List = string.Empty;
            string LIST_Code_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<LIST_Code> sendToTrashList = model.DBSet_LIST_Code.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (LIST_Code item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(LIST_Code_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + LIST_Code_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - LIST_Code_Destroy: {1}", ModifiedBy, LIST_Code_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				
