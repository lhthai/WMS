// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : PODetail
//    File Name         : WHS_PODetail.cs
//    Properties        : C_System_POStatus_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Oder_Line_No; Order_Line_No; PO_ID; ReceiptStatus_ID; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; C_System_POStatus_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Oder_Line_No; Order_Line_No; PO_ID; ReceiptStatus_ID; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; WHS_PO_PO_ID;
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
	[Table("tbl_WHS_PODetail")]
    [Serializable]
	[DataContract]
    public partial class WHS_PODetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("C_System_POStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> C_System_POStatus_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "PODetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "PODetail_Item_ID_Required")]        public int Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Oder_Line_No")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Oder_Line_No { get; set; }
			        [Column("Order_Line_No")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "PODetail_Order_Line_No_Required")]        public int Order_Line_No { get; set; }
			        [Column("PO_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "PODetail_PO_ID_Required")]        public int PO_ID { get; set; }
			        [Column("ReceiptStatus_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ReceiptStatus_ID { get; set; }
			        [Column("UDF_1")]        [DataMember]        public string UDF_1 { get; set; }
			        [Column("UDF_2")]        [DataMember]        public string UDF_2 { get; set; }
			        [Column("UDF_3")]        [DataMember]        public string UDF_3 { get; set; }
			        [Column("UDF_4")]        [DataMember]        public string UDF_4 { get; set; }
			        [Column("UDF_5")]        [DataMember]        public string UDF_5 { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("C_System_POStatus_ID")]        public virtual LIST_Code LIST_Code_C_System_POStatus_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("PO_ID")]        public virtual WHS_PO WHS_PO_PO_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_PODetail> WHS_PODetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_PODetail.AsEnumerable().Select(s => new WHS_PODetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Oder_Line_No =s.Oder_Line_No,
										Order_Line_No =s.Order_Line_No,
										PO_ID =s.PO_ID,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_PODetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_PODetail> WHS_PODetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_PODetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_PODetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Oder_Line_No =s.Oder_Line_No,
										Order_Line_No =s.Order_Line_No,
										PO_ID =s.PO_ID,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_PODetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_PODetail WHS_PODetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_PODetail.Where(d => d.ID == ID).FirstOrDefault<WHS_PODetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_PODetail_Create(IEnumerable<WHS_PODetail> items, string CreatedBy)
        {
            string WHS_PODetail_List = string.Empty;
            string WHS_PODetail_List_Serialized = string.Empty;
            string WHS_PODetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_PODetail> result = new List<WHS_PODetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_PODetail item in items)
                {
                    WHS_PODetail dbItem = new WHS_PODetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Oder_Line_No =item.Oder_Line_No;
								dbItem.Order_Line_No =item.Order_Line_No;
								dbItem.PO_ID =item.PO_ID;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                   
                    WHS_PODetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_PODetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_PODetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_PODetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_PODetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_PODetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_PODetail_Create: {1} - {2}", CreatedBy, WHS_PODetail_List, WHS_PODetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_PODetail_Create(WHS_PODetail item, string CreatedBy)
        {
            string WHS_PODetail_List = string.Empty;
            string WHS_PODetail_List_Serialized = string.Empty;
            string WHS_PODetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_PODetail> result = new List<WHS_PODetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_PODetail dbItem = new WHS_PODetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Oder_Line_No =item.Oder_Line_No;
								dbItem.Order_Line_No =item.Order_Line_No;
								dbItem.PO_ID =item.PO_ID;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                    WHS_PODetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_PODetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_PODetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_PODetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_PODetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_PODetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PODetail_Create: {1} - {2}", CreatedBy, WHS_PODetail_List, WHS_PODetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_PODetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_PODetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										C_System_POStatus_ID =s.C_System_POStatus_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Oder_Line_No =s.Oder_Line_No,
										Order_Line_No =s.Order_Line_No,
										PO_ID =s.PO_ID,
										ReceiptStatus_ID =s.ReceiptStatus_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_PODetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_PODetail_Update(IEnumerable<WHS_PODetail> items, string ModifiedBy)
        {
            string WHS_PODetail_List = string.Empty;
            string WHS_PODetail_List_Serialized = string.Empty;
            string WHS_PODetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_PODetail item in items)
                {
                    WHS_PODetail dbItem = model.DBSet_WHS_PODetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_PODetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.C_System_POStatus_ID =item.C_System_POStatus_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Oder_Line_No =item.Oder_Line_No;
								dbItem.Order_Line_No =item.Order_Line_No;
								dbItem.PO_ID =item.PO_ID;
								dbItem.ReceiptStatus_ID =item.ReceiptStatus_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                        

                        WHS_PODetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_PODetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_PODetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_PODetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PODetail_Update: {1} - {2}", ModifiedBy, WHS_PODetail_List, WHS_PODetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_PODetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_PODetail_List = string.Empty;
            string WHS_PODetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_PODetail> sendToTrashList = model.DBSet_WHS_PODetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_PODetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_PODetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_PODetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_PODetail_Destroy: {1}", ModifiedBy, WHS_PODetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

