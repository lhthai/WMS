// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : GoodReceiptNote
//    File Name         : WHS_GoodReceiptNote.cs
//    Properties        : ASN_Detail_ID; CreatedBy; CreatedDate; Date_time_print_GRN; ID; IsDeleted; Line_No; ModifiedBy; ModifiedDate; Note; Total_quantity; User_ID; Warehouse_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; ASN_Detail_ID; CreatedBy; CreatedDate; Date_time_print_GRN; ID; IsDeleted; Line_No; ModifiedBy; ModifiedDate; Note; Total_quantity; User_ID; Warehouse_ID; ENT_User_User_ID;
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
	[Table("tbl_WHS_GoodReceiptNote")]
    [Serializable]
	[DataContract]
    public partial class WHS_GoodReceiptNote
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
        public IEnumerable<WHS_GoodReceiptNote> WHS_GoodReceiptNote_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_GoodReceiptNote.AsEnumerable().Select(s => new WHS_GoodReceiptNote()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_time_print_GRN =s.Date_time_print_GRN,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line_No =s.Line_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Total_quantity =s.Total_quantity,
										User_ID =s.User_ID,
										Warehouse_ID =s.Warehouse_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_GoodReceiptNote>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_GoodReceiptNote> WHS_GoodReceiptNote_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_GoodReceiptNote_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_GoodReceiptNote.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_time_print_GRN =s.Date_time_print_GRN,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line_No =s.Line_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Total_quantity =s.Total_quantity,
										User_ID =s.User_ID,
										Warehouse_ID =s.Warehouse_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_GoodReceiptNote_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_GoodReceiptNote WHS_GoodReceiptNote_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_GoodReceiptNote.Where(d => d.ID == ID).FirstOrDefault<WHS_GoodReceiptNote>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_GoodReceiptNote_Create(IEnumerable<WHS_GoodReceiptNote> items, string CreatedBy)
        {
            string WHS_GoodReceiptNote_List = string.Empty;
            string WHS_GoodReceiptNote_List_Serialized = string.Empty;
            string WHS_GoodReceiptNote_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_GoodReceiptNote> result = new List<WHS_GoodReceiptNote>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_GoodReceiptNote item in items)
                {
                    WHS_GoodReceiptNote dbItem = new WHS_GoodReceiptNote();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_time_print_GRN =item.Date_time_print_GRN;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line_No =item.Line_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Total_quantity =item.Total_quantity;
								dbItem.User_ID =item.User_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                   
                    WHS_GoodReceiptNote_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_GoodReceiptNote.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_GoodReceiptNote_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_GoodReceiptNote_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_GoodReceiptNote_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_GoodReceiptNote_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_GoodReceiptNote_Create: {1} - {2}", CreatedBy, WHS_GoodReceiptNote_List, WHS_GoodReceiptNote_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_GoodReceiptNote_Create(WHS_GoodReceiptNote item, string CreatedBy)
        {
            string WHS_GoodReceiptNote_List = string.Empty;
            string WHS_GoodReceiptNote_List_Serialized = string.Empty;
            string WHS_GoodReceiptNote_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_GoodReceiptNote> result = new List<WHS_GoodReceiptNote>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_GoodReceiptNote dbItem = new WHS_GoodReceiptNote();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_time_print_GRN =item.Date_time_print_GRN;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line_No =item.Line_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Total_quantity =item.Total_quantity;
								dbItem.User_ID =item.User_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                    WHS_GoodReceiptNote_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_GoodReceiptNote.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_GoodReceiptNote_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_GoodReceiptNote_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_GoodReceiptNote_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_GoodReceiptNote_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_GoodReceiptNote_Create: {1} - {2}", CreatedBy, WHS_GoodReceiptNote_List, WHS_GoodReceiptNote_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_GoodReceiptNote_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_GoodReceiptNote.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_time_print_GRN =s.Date_time_print_GRN,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Line_No =s.Line_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Note =s.Note,
										Total_quantity =s.Total_quantity,
										User_ID =s.User_ID,
										Warehouse_ID =s.Warehouse_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_GoodReceiptNote_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_GoodReceiptNote_Update(IEnumerable<WHS_GoodReceiptNote> items, string ModifiedBy)
        {
            string WHS_GoodReceiptNote_List = string.Empty;
            string WHS_GoodReceiptNote_List_Serialized = string.Empty;
            string WHS_GoodReceiptNote_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_GoodReceiptNote item in items)
                {
                    WHS_GoodReceiptNote dbItem = model.DBSet_WHS_GoodReceiptNote.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_GoodReceiptNote_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_time_print_GRN =item.Date_time_print_GRN;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Line_No =item.Line_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Note =item.Note;
								dbItem.Total_quantity =item.Total_quantity;
								dbItem.User_ID =item.User_ID;
								dbItem.Warehouse_ID =item.Warehouse_ID;
					                        

                        WHS_GoodReceiptNote_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_GoodReceiptNote_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_GoodReceiptNote_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_GoodReceiptNote_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_GoodReceiptNote_Update: {1} - {2}", ModifiedBy, WHS_GoodReceiptNote_List, WHS_GoodReceiptNote_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_GoodReceiptNote_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_GoodReceiptNote_List = string.Empty;
            string WHS_GoodReceiptNote_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_GoodReceiptNote> sendToTrashList = model.DBSet_WHS_GoodReceiptNote.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_GoodReceiptNote item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_GoodReceiptNote_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_GoodReceiptNote_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_GoodReceiptNote_Destroy: {1}", ModifiedBy, WHS_GoodReceiptNote_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				
