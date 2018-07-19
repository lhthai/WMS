// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Owner_Label
//    File Name         : WHS_Owner_Label.cs
//    Properties        : Case_Label_Type; CreatedBy; CreatedDate; ID; IsDeleted; LPN_Barcode_Format; LPN_Length; LPN_Next_Number; LPN_Start_Number; ModifiedBy; ModifiedDate; Owner_ID; Roll_Back_Number;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Case_Label_Type; CreatedBy; CreatedDate; ID; IsDeleted; LPN_Barcode_Format; LPN_Length; LPN_Next_Number; LPN_Start_Number; ModifiedBy; ModifiedDate; Owner_ID; Roll_Back_Number; ENT_Owner_Owner_ID;
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
	[Table("tbl_WHS_Owner_Label")]
    [Serializable]
	[DataContract]
    public partial class WHS_Owner_Label
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





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Owner_Label> WHS_Owner_Label_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Owner_Label.AsEnumerable().Select(s => new WHS_Owner_Label()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Case_Label_Type =s.Case_Label_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_Barcode_Format =s.LPN_Barcode_Format,
										LPN_Length =s.LPN_Length,
										LPN_Next_Number =s.LPN_Next_Number,
										LPN_Start_Number =s.LPN_Start_Number,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										Roll_Back_Number =s.Roll_Back_Number,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Owner_Label>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Owner_Label> WHS_Owner_Label_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Owner_Label_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Owner_Label.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Case_Label_Type =s.Case_Label_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_Barcode_Format =s.LPN_Barcode_Format,
										LPN_Length =s.LPN_Length,
										LPN_Next_Number =s.LPN_Next_Number,
										LPN_Start_Number =s.LPN_Start_Number,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										Roll_Back_Number =s.Roll_Back_Number,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Owner_Label_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Owner_Label WHS_Owner_Label_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Owner_Label.Where(d => d.ID == ID).FirstOrDefault<WHS_Owner_Label>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Owner_Label_Create(IEnumerable<WHS_Owner_Label> items, string CreatedBy)
        {
            string WHS_Owner_Label_List = string.Empty;
            string WHS_Owner_Label_List_Serialized = string.Empty;
            string WHS_Owner_Label_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Owner_Label> result = new List<WHS_Owner_Label>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Owner_Label item in items)
                {
                    WHS_Owner_Label dbItem = new WHS_Owner_Label();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Case_Label_Type =item.Case_Label_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LPN_Barcode_Format =item.LPN_Barcode_Format;
								dbItem.LPN_Length =item.LPN_Length;
								dbItem.LPN_Next_Number =item.LPN_Next_Number;
								dbItem.LPN_Start_Number =item.LPN_Start_Number;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Roll_Back_Number =item.Roll_Back_Number;
					                   
                    WHS_Owner_Label_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Owner_Label.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Owner_Label_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Owner_Label_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Owner_Label_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Owner_Label_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Owner_Label_Create: {1} - {2}", CreatedBy, WHS_Owner_Label_List, WHS_Owner_Label_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Owner_Label_Create(WHS_Owner_Label item, string CreatedBy)
        {
            string WHS_Owner_Label_List = string.Empty;
            string WHS_Owner_Label_List_Serialized = string.Empty;
            string WHS_Owner_Label_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Owner_Label> result = new List<WHS_Owner_Label>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Owner_Label dbItem = new WHS_Owner_Label();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Case_Label_Type =item.Case_Label_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LPN_Barcode_Format =item.LPN_Barcode_Format;
								dbItem.LPN_Length =item.LPN_Length;
								dbItem.LPN_Next_Number =item.LPN_Next_Number;
								dbItem.LPN_Start_Number =item.LPN_Start_Number;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Roll_Back_Number =item.Roll_Back_Number;
					                    WHS_Owner_Label_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Owner_Label.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Owner_Label_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Owner_Label_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Owner_Label_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Owner_Label_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Owner_Label_Create: {1} - {2}", CreatedBy, WHS_Owner_Label_List, WHS_Owner_Label_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Owner_Label_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Owner_Label.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Case_Label_Type =s.Case_Label_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_Barcode_Format =s.LPN_Barcode_Format,
										LPN_Length =s.LPN_Length,
										LPN_Next_Number =s.LPN_Next_Number,
										LPN_Start_Number =s.LPN_Start_Number,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
										Roll_Back_Number =s.Roll_Back_Number,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Owner_Label_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Owner_Label_Update(IEnumerable<WHS_Owner_Label> items, string ModifiedBy)
        {
            string WHS_Owner_Label_List = string.Empty;
            string WHS_Owner_Label_List_Serialized = string.Empty;
            string WHS_Owner_Label_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Owner_Label item in items)
                {
                    WHS_Owner_Label dbItem = model.DBSet_WHS_Owner_Label.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Owner_Label_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Case_Label_Type =item.Case_Label_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LPN_Barcode_Format =item.LPN_Barcode_Format;
								dbItem.LPN_Length =item.LPN_Length;
								dbItem.LPN_Next_Number =item.LPN_Next_Number;
								dbItem.LPN_Start_Number =item.LPN_Start_Number;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Roll_Back_Number =item.Roll_Back_Number;
					                        

                        WHS_Owner_Label_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Owner_Label_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Owner_Label_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Owner_Label_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Owner_Label_Update: {1} - {2}", ModifiedBy, WHS_Owner_Label_List, WHS_Owner_Label_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Owner_Label_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Owner_Label_List = string.Empty;
            string WHS_Owner_Label_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Owner_Label> sendToTrashList = model.DBSet_WHS_Owner_Label.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Owner_Label item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Owner_Label_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Owner_Label_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Owner_Label_Destroy: {1}", ModifiedBy, WHS_Owner_Label_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				
