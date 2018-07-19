// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Packing_List
//    File Name         : WHS_Packing_List.cs
//    Properties        : Batch_Note; CreatedBy; CreatedDate; ID; IsDeleted; Kg_Note; Lot_No_Note; M3_Note; ModifiedBy; ModifiedDate; Pack_Note; Packing_List_Note_No; Qty_Note; SO_Detail_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Batch_Note; CreatedBy; CreatedDate; ID; IsDeleted; Kg_Note; Lot_No_Note; M3_Note; ModifiedBy; ModifiedDate; Pack_Note; Packing_List_Note_No; Qty_Note; SO_Detail_ID; WHS_SO_Detail_SO_Detail_ID;
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
	[Table("tbl_WHS_Packing_List")]
    [Serializable]
	[DataContract]
    public partial class WHS_Packing_List
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Batch_Note")]        [DataMember]        public string Batch_Note { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Packing_List_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Kg_Note")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Kg_Note { get; set; }
			        [Column("Lot_No_Note")]        [DataMember]        public string Lot_No_Note { get; set; }
			        [Column("M3_Note")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> M3_Note { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Pack_Note")]        [DataMember]        public string Pack_Note { get; set; }
			        [Column("Packing_List_Note_No")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Packing_List_Note_No { get; set; }
			        [Column("Qty_Note")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Qty_Note { get; set; }
			        [Column("SO_Detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> SO_Detail_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("SO_Detail_ID")]        public virtual WHS_SO_Detail WHS_SO_Detail_SO_Detail_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Packing_List> WHS_Packing_List_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Packing_List.AsEnumerable().Select(s => new WHS_Packing_List()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Batch_Note =s.Batch_Note,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Kg_Note =s.Kg_Note,
										Lot_No_Note =s.Lot_No_Note,
										M3_Note =s.M3_Note,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_Note =s.Pack_Note,
										Packing_List_Note_No =s.Packing_List_Note_No,
										Qty_Note =s.Qty_Note,
										SO_Detail_ID =s.SO_Detail_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Packing_List>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Packing_List> WHS_Packing_List_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Packing_List_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Packing_List.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Batch_Note =s.Batch_Note,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Kg_Note =s.Kg_Note,
										Lot_No_Note =s.Lot_No_Note,
										M3_Note =s.M3_Note,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_Note =s.Pack_Note,
										Packing_List_Note_No =s.Packing_List_Note_No,
										Qty_Note =s.Qty_Note,
										SO_Detail_ID =s.SO_Detail_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Packing_List_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Packing_List WHS_Packing_List_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Packing_List.Where(d => d.ID == ID).FirstOrDefault<WHS_Packing_List>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Packing_List_Create(IEnumerable<WHS_Packing_List> items, string CreatedBy)
        {
            string WHS_Packing_List_List = string.Empty;
            string WHS_Packing_List_List_Serialized = string.Empty;
            string WHS_Packing_List_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Packing_List> result = new List<WHS_Packing_List>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Packing_List item in items)
                {
                    WHS_Packing_List dbItem = new WHS_Packing_List();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Batch_Note =item.Batch_Note;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Kg_Note =item.Kg_Note;
								dbItem.Lot_No_Note =item.Lot_No_Note;
								dbItem.M3_Note =item.M3_Note;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_Note =item.Pack_Note;
								dbItem.Packing_List_Note_No =item.Packing_List_Note_No;
								dbItem.Qty_Note =item.Qty_Note;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                   
                    WHS_Packing_List_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Packing_List.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Packing_List_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Packing_List_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Packing_List_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Packing_List_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Packing_List_Create: {1} - {2}", CreatedBy, WHS_Packing_List_List, WHS_Packing_List_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Packing_List_Create(WHS_Packing_List item, string CreatedBy)
        {
            string WHS_Packing_List_List = string.Empty;
            string WHS_Packing_List_List_Serialized = string.Empty;
            string WHS_Packing_List_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Packing_List> result = new List<WHS_Packing_List>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Packing_List dbItem = new WHS_Packing_List();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Batch_Note =item.Batch_Note;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Kg_Note =item.Kg_Note;
								dbItem.Lot_No_Note =item.Lot_No_Note;
								dbItem.M3_Note =item.M3_Note;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_Note =item.Pack_Note;
								dbItem.Packing_List_Note_No =item.Packing_List_Note_No;
								dbItem.Qty_Note =item.Qty_Note;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                    WHS_Packing_List_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Packing_List.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Packing_List_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Packing_List_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Packing_List_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Packing_List_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Packing_List_Create: {1} - {2}", CreatedBy, WHS_Packing_List_List, WHS_Packing_List_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Packing_List_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Packing_List.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Batch_Note =s.Batch_Note,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Kg_Note =s.Kg_Note,
										Lot_No_Note =s.Lot_No_Note,
										M3_Note =s.M3_Note,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Pack_Note =s.Pack_Note,
										Packing_List_Note_No =s.Packing_List_Note_No,
										Qty_Note =s.Qty_Note,
										SO_Detail_ID =s.SO_Detail_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Packing_List_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Packing_List_Update(IEnumerable<WHS_Packing_List> items, string ModifiedBy)
        {
            string WHS_Packing_List_List = string.Empty;
            string WHS_Packing_List_List_Serialized = string.Empty;
            string WHS_Packing_List_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Packing_List item in items)
                {
                    WHS_Packing_List dbItem = model.DBSet_WHS_Packing_List.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Packing_List_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Batch_Note =item.Batch_Note;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Kg_Note =item.Kg_Note;
								dbItem.Lot_No_Note =item.Lot_No_Note;
								dbItem.M3_Note =item.M3_Note;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Pack_Note =item.Pack_Note;
								dbItem.Packing_List_Note_No =item.Packing_List_Note_No;
								dbItem.Qty_Note =item.Qty_Note;
								dbItem.SO_Detail_ID =item.SO_Detail_ID;
					                        

                        WHS_Packing_List_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Packing_List_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Packing_List_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Packing_List_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Packing_List_Update: {1} - {2}", ModifiedBy, WHS_Packing_List_List, WHS_Packing_List_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Packing_List_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Packing_List_List = string.Empty;
            string WHS_Packing_List_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Packing_List> sendToTrashList = model.DBSet_WHS_Packing_List.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Packing_List item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Packing_List_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Packing_List_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Packing_List_Destroy: {1}", ModifiedBy, WHS_Packing_List_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

