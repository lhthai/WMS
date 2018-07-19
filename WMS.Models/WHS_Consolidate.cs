// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Consolidate
//    File Name         : WHS_Consolidate.cs
//    Properties        : ASN_Detail_ID; CreatedBy; CreatedDate; ID; IsDeleted; LPN_New; ModifiedBy; ModifiedDate;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; ASN_Detail_ID; CreatedBy; CreatedDate; ID; IsDeleted; LPN_New; ModifiedBy; ModifiedDate; WHS_Moves_To_LPN;
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
	[Table("tbl_WHS_Consolidate")]
    [Serializable]
	[DataContract]
    public partial class WHS_Consolidate
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
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Consolidate_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("LPN_New")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Consolidate_LPN_New_Required")]        public string LPN_New { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("ASN_Detail_ID")]        public virtual WHS_ASNDetail WHS_ASNDetail_ASN_Detail_ID { get; set; }		        public virtual ICollection<WHS_Move> WHS_Moves_To_LPN { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Consolidate> WHS_Consolidate_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Consolidate.AsEnumerable().Select(s => new WHS_Consolidate()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_New =s.LPN_New,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Consolidate>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Consolidate> WHS_Consolidate_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Consolidate_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Consolidate.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_New =s.LPN_New,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Consolidate_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Consolidate WHS_Consolidate_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Consolidate.Where(d => d.ID == ID).FirstOrDefault<WHS_Consolidate>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Consolidate_Create(IEnumerable<WHS_Consolidate> items, string CreatedBy)
        {
            string WHS_Consolidate_List = string.Empty;
            string WHS_Consolidate_List_Serialized = string.Empty;
            string WHS_Consolidate_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Consolidate> result = new List<WHS_Consolidate>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Consolidate item in items)
                {
                    WHS_Consolidate dbItem = new WHS_Consolidate();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LPN_New =item.LPN_New;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                   
                    WHS_Consolidate_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Consolidate.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Consolidate_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Consolidate_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Consolidate_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Consolidate_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Consolidate_Create: {1} - {2}", CreatedBy, WHS_Consolidate_List, WHS_Consolidate_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Consolidate_Create(WHS_Consolidate item, string CreatedBy)
        {
            string WHS_Consolidate_List = string.Empty;
            string WHS_Consolidate_List_Serialized = string.Empty;
            string WHS_Consolidate_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Consolidate> result = new List<WHS_Consolidate>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Consolidate dbItem = new WHS_Consolidate();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.ASN_Detail_ID =item.ASN_Detail_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.LPN_New =item.LPN_New;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                    WHS_Consolidate_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Consolidate.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Consolidate_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Consolidate_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Consolidate_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Consolidate_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Consolidate_Create: {1} - {2}", CreatedBy, WHS_Consolidate_List, WHS_Consolidate_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Consolidate_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Consolidate.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										ASN_Detail_ID =s.ASN_Detail_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										LPN_New =s.LPN_New,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Consolidate_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Consolidate_Update(IEnumerable<WHS_Consolidate> items, string ModifiedBy)
        {
            string WHS_Consolidate_List = string.Empty;
            string WHS_Consolidate_List_Serialized = string.Empty;
            string WHS_Consolidate_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Consolidate item in items)
                {
                    WHS_Consolidate dbItem = model.DBSet_WHS_Consolidate.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Consolidate_List += "[" + item.ID + "] ";
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
								dbItem.LPN_New =item.LPN_New;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
					                        

                        WHS_Consolidate_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Consolidate_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Consolidate_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Consolidate_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Consolidate_Update: {1} - {2}", ModifiedBy, WHS_Consolidate_List, WHS_Consolidate_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Consolidate_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Consolidate_List = string.Empty;
            string WHS_Consolidate_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Consolidate> sendToTrashList = model.DBSet_WHS_Consolidate.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Consolidate item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Consolidate_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Consolidate_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Consolidate_Destroy: {1}", ModifiedBy, WHS_Consolidate_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

