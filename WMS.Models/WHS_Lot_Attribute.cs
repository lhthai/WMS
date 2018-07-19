// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Lot_Attribute
//    File Name         : WHS_Lot_Attribute.cs
//    Properties        : ASN_Detail_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Lottable_1; Lottable_10; Lottable_11; Lottable_12; Lottable_2; Lottable_3; Lottable_4; Lottable_5; Lottable_6; Lottable_7; Lottable_8; Lottable_9; ModifiedBy; ModifiedDate; Owner_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; ASN_Detail_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; Lottable_1; Lottable_10; Lottable_11; Lottable_12; Lottable_2; Lottable_3; Lottable_4; Lottable_5; Lottable_6; Lottable_7; Lottable_8; Lottable_9; ModifiedBy; ModifiedDate; Owner_ID; WHS_Pick_Details_Lot_Attribute_ID;
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
	[Table("tbl_WHS_Lot_Attribute")]
    [Serializable]
	[DataContract]
    public partial class WHS_Lot_Attribute
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("ASN_Detail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ASN_Detail_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Lot_Attribute_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("Lottable_1")]        [DataMember]        public string Lottable_1 { get; set; }
			        [Column("Lottable_10")]        [DataMember]        public string Lottable_10 { get; set; }
			        [Column("Lottable_11")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lottable_11 { get; set; }
			        [Column("Lottable_12")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lottable_12 { get; set; }
			        [Column("Lottable_2")]        [DataMember]        public string Lottable_2 { get; set; }
			        [Column("Lottable_3")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lottable_3 { get; set; }
			        [Column("Lottable_4")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Lottable_4 { get; set; }
			        [Column("Lottable_5")]        [DataMember]        public string Lottable_5 { get; set; }
			        [Column("Lottable_6")]        [DataMember]        public string Lottable_6 { get; set; }
			        [Column("Lottable_7")]        [DataMember]        public string Lottable_7 { get; set; }
			        [Column("Lottable_8")]        [DataMember]        public string Lottable_8 { get; set; }
			        [Column("Lottable_9")]        [DataMember]        public string Lottable_9 { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("ASN_Detail_ID")]        public virtual WHS_ASNDetail WHS_ASNDetail_ASN_Detail_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }		        public virtual ICollection<WHS_Maintain_Hold> WHS_Maintain_Holds_Lot_ID { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_Lot_Attribute_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Lot_Attribute> WHS_Lot_Attribute_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Lot_Attribute.AsEnumerable().Select(s => new WHS_Lot_Attribute()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Lottable_1 =s.Lottable_1,
										Lottable_10 =s.Lottable_10,
										Lottable_11 =s.Lottable_11,
										Lottable_12 =s.Lottable_12,
										Lottable_2 =s.Lottable_2,
										Lottable_3 =s.Lottable_3,
										Lottable_4 =s.Lottable_4,
										Lottable_5 =s.Lottable_5,
										Lottable_6 =s.Lottable_6,
										Lottable_7 =s.Lottable_7,
										Lottable_8 =s.Lottable_8,
										Lottable_9 =s.Lottable_9,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Lot_Attribute>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Lot_Attribute> WHS_Lot_Attribute_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Lot_Attribute_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Lot_Attribute.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Lottable_1 =s.Lottable_1,
										Lottable_10 =s.Lottable_10,
										Lottable_11 =s.Lottable_11,
										Lottable_12 =s.Lottable_12,
										Lottable_2 =s.Lottable_2,
										Lottable_3 =s.Lottable_3,
										Lottable_4 =s.Lottable_4,
										Lottable_5 =s.Lottable_5,
										Lottable_6 =s.Lottable_6,
										Lottable_7 =s.Lottable_7,
										Lottable_8 =s.Lottable_8,
										Lottable_9 =s.Lottable_9,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Lot_Attribute_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Lot_Attribute WHS_Lot_Attribute_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Lot_Attribute.Where(d => d.ID == ID).FirstOrDefault<WHS_Lot_Attribute>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Lot_Attribute_Create(IEnumerable<WHS_Lot_Attribute> items, string CreatedBy)
        {
            string WHS_Lot_Attribute_List = string.Empty;
            string WHS_Lot_Attribute_List_Serialized = string.Empty;
            string WHS_Lot_Attribute_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Lot_Attribute> result = new List<WHS_Lot_Attribute>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Lot_Attribute item in items)
                {
                    WHS_Lot_Attribute dbItem = new WHS_Lot_Attribute();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Lottable_1 =item.Lottable_1;
								dbItem.Lottable_10 =item.Lottable_10;
								dbItem.Lottable_11 =item.Lottable_11;
								dbItem.Lottable_12 =item.Lottable_12;
								dbItem.Lottable_2 =item.Lottable_2;
								dbItem.Lottable_3 =item.Lottable_3;
								dbItem.Lottable_4 =item.Lottable_4;
								dbItem.Lottable_5 =item.Lottable_5;
								dbItem.Lottable_6 =item.Lottable_6;
								dbItem.Lottable_7 =item.Lottable_7;
								dbItem.Lottable_8 =item.Lottable_8;
								dbItem.Lottable_9 =item.Lottable_9;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
					                   
                    WHS_Lot_Attribute_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Lot_Attribute.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Lot_Attribute_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Lot_Attribute_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Lot_Attribute_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Lot_Attribute_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Lot_Attribute_Create: {1} - {2}", CreatedBy, WHS_Lot_Attribute_List, WHS_Lot_Attribute_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Lot_Attribute_Create(WHS_Lot_Attribute item, string CreatedBy)
        {
            string WHS_Lot_Attribute_List = string.Empty;
            string WHS_Lot_Attribute_List_Serialized = string.Empty;
            string WHS_Lot_Attribute_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Lot_Attribute> result = new List<WHS_Lot_Attribute>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Lot_Attribute dbItem = new WHS_Lot_Attribute();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Lottable_1 =item.Lottable_1;
								dbItem.Lottable_10 =item.Lottable_10;
								dbItem.Lottable_11 =item.Lottable_11;
								dbItem.Lottable_12 =item.Lottable_12;
								dbItem.Lottable_2 =item.Lottable_2;
								dbItem.Lottable_3 =item.Lottable_3;
								dbItem.Lottable_4 =item.Lottable_4;
								dbItem.Lottable_5 =item.Lottable_5;
								dbItem.Lottable_6 =item.Lottable_6;
								dbItem.Lottable_7 =item.Lottable_7;
								dbItem.Lottable_8 =item.Lottable_8;
								dbItem.Lottable_9 =item.Lottable_9;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
					                    WHS_Lot_Attribute_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Lot_Attribute.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Lot_Attribute_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Lot_Attribute_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Lot_Attribute_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Lot_Attribute_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Lot_Attribute_Create: {1} - {2}", CreatedBy, WHS_Lot_Attribute_List, WHS_Lot_Attribute_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Lot_Attribute_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Lot_Attribute.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										Lottable_1 =s.Lottable_1,
										Lottable_10 =s.Lottable_10,
										Lottable_11 =s.Lottable_11,
										Lottable_12 =s.Lottable_12,
										Lottable_2 =s.Lottable_2,
										Lottable_3 =s.Lottable_3,
										Lottable_4 =s.Lottable_4,
										Lottable_5 =s.Lottable_5,
										Lottable_6 =s.Lottable_6,
										Lottable_7 =s.Lottable_7,
										Lottable_8 =s.Lottable_8,
										Lottable_9 =s.Lottable_9,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Owner_ID =s.Owner_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Lot_Attribute_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Lot_Attribute_Update(IEnumerable<WHS_Lot_Attribute> items, string ModifiedBy)
        {
            string WHS_Lot_Attribute_List = string.Empty;
            string WHS_Lot_Attribute_List_Serialized = string.Empty;
            string WHS_Lot_Attribute_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Lot_Attribute item in items)
                {
                    WHS_Lot_Attribute dbItem = model.DBSet_WHS_Lot_Attribute.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Lot_Attribute_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.Lottable_1 =item.Lottable_1;
								dbItem.Lottable_10 =item.Lottable_10;
								dbItem.Lottable_11 =item.Lottable_11;
								dbItem.Lottable_12 =item.Lottable_12;
								dbItem.Lottable_2 =item.Lottable_2;
								dbItem.Lottable_3 =item.Lottable_3;
								dbItem.Lottable_4 =item.Lottable_4;
								dbItem.Lottable_5 =item.Lottable_5;
								dbItem.Lottable_6 =item.Lottable_6;
								dbItem.Lottable_7 =item.Lottable_7;
								dbItem.Lottable_8 =item.Lottable_8;
								dbItem.Lottable_9 =item.Lottable_9;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Owner_ID =item.Owner_ID;
					                        

                        WHS_Lot_Attribute_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Lot_Attribute_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Lot_Attribute_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Lot_Attribute_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Lot_Attribute_Update: {1} - {2}", ModifiedBy, WHS_Lot_Attribute_List, WHS_Lot_Attribute_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Lot_Attribute_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Lot_Attribute_List = string.Empty;
            string WHS_Lot_Attribute_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Lot_Attribute> sendToTrashList = model.DBSet_WHS_Lot_Attribute.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Lot_Attribute item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Lot_Attribute_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Lot_Attribute_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Lot_Attribute_Destroy: {1}", ModifiedBy, WHS_Lot_Attribute_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

