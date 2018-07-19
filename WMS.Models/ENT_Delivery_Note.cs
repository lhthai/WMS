// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Delivery_Note
//    File Name         : ENT_Delivery_Note.cs
//    Properties        : CreatedBy; CreatedDate; ID; IsDeleted; ModifiedBy; ModifiedDate; Note; Printed_Date; SO_Detail_ID; Warehouse_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; CreatedBy; CreatedDate; ID; IsDeleted; ModifiedBy; ModifiedDate; Note; Printed_Date; SO_Detail_ID; Warehouse_ID; ENT_Warehouse_Warehouse_ID;
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
	[Table("tbl_ENT_Delivery_Note")]
    [Serializable]
	[DataContract]
    public partial class ENT_Delivery_Note
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





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Delivery_Note> ENT_Delivery_Note_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Delivery_Note.AsEnumerable().Select(s => new ENT_Delivery_Note()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Printed_Date =s.Printed_Date,
										SO_Detail_ID =s.SO_Detail_ID,
										Warehouse_ID =s.Warehouse_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Delivery_Note>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Delivery_Note> ENT_Delivery_Note_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Delivery_Note_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Delivery_Note.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Printed_Date =s.Printed_Date,
										SO_Detail_ID =s.SO_Detail_ID,
										Warehouse_ID =s.Warehouse_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Delivery_Note_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Delivery_Note ENT_Delivery_Note_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Delivery_Note.Where(d => d.ID == ID).FirstOrDefault<ENT_Delivery_Note>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Delivery_Note_Create(IEnumerable<ENT_Delivery_Note> items, string CreatedBy)
        {
            string ENT_Delivery_Note_List = string.Empty;
            string ENT_Delivery_Note_List_Serialized = string.Empty;
            string ENT_Delivery_Note_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Delivery_Note> result = new List<ENT_Delivery_Note>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Delivery_Note item in items)
                {
                    ENT_Delivery_Note dbItem = new ENT_Delivery_Note();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Printed_Date =item.Printed_Date;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                   
                    ENT_Delivery_Note_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Delivery_Note.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Delivery_Note_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Delivery_Note_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Delivery_Note_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Delivery_Note_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Delivery_Note_Create: {1} - {2}", CreatedBy, ENT_Delivery_Note_List, ENT_Delivery_Note_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Delivery_Note_Create(ENT_Delivery_Note item, string CreatedBy)
        {
            string ENT_Delivery_Note_List = string.Empty;
            string ENT_Delivery_Note_List_Serialized = string.Empty;
            string ENT_Delivery_Note_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Delivery_Note> result = new List<ENT_Delivery_Note>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Delivery_Note dbItem = new ENT_Delivery_Note();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Printed_Date =item.Printed_Date;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                    ENT_Delivery_Note_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Delivery_Note.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Delivery_Note_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Delivery_Note_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Delivery_Note_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Delivery_Note_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Delivery_Note_Create: {1} - {2}", CreatedBy, ENT_Delivery_Note_List, ENT_Delivery_Note_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Delivery_Note_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Delivery_Note.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Printed_Date =s.Printed_Date,
										SO_Detail_ID =s.SO_Detail_ID,
										Warehouse_ID =s.Warehouse_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Delivery_Note_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Delivery_Note_Update(IEnumerable<ENT_Delivery_Note> items, string ModifiedBy)
        {
            string ENT_Delivery_Note_List = string.Empty;
            string ENT_Delivery_Note_List_Serialized = string.Empty;
            string ENT_Delivery_Note_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Delivery_Note item in items)
                {
                    ENT_Delivery_Note dbItem = model.DBSet_ENT_Delivery_Note.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Delivery_Note_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Printed_Date =item.Printed_Date;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                        

                        ENT_Delivery_Note_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Delivery_Note_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Delivery_Note_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Delivery_Note_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Delivery_Note_Update: {1} - {2}", ModifiedBy, ENT_Delivery_Note_List, ENT_Delivery_Note_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Delivery_Note_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Delivery_Note_List = string.Empty;
            string ENT_Delivery_Note_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Delivery_Note> sendToTrashList = model.DBSet_ENT_Delivery_Note.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Delivery_Note item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Delivery_Note_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Delivery_Note_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Delivery_Note_Destroy: {1}", ModifiedBy, ENT_Delivery_Note_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				
