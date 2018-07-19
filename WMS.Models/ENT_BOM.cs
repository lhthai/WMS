// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : BOM
//    File Name         : ENT_BOM.cs
//    Properties        : Component_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Owner_Code; Quantity; Sequence;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Component_ID; CreatedBy; CreatedDate; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Owner_Code; Quantity; Sequence; ENT_Item_Item_ID;
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
	[Table("tbl_ENT_BOM")]
    [Serializable]
	[DataContract]
    public partial class ENT_BOM
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Component_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "BOM_Component_ID_Required")]        public int Component_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "BOM_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "BOM_Item_ID_Required")]        public int Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Owner_Code")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "BOM_Owner_Code_Required")]        public string Owner_Code { get; set; }
			        [Column("Quantity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Quantity { get; set; }
			        [Column("Sequence")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Sequence { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Component_ID")]        public virtual ENT_Item ENT_Item_Component_ID { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_BOM> ENT_BOM_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_BOM.AsEnumerable().Select(s => new ENT_BOM()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Component_ID =s.Component_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Quantity =s.Quantity,
										Sequence =s.Sequence,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_BOM>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_BOM> ENT_BOM_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_BOM_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_BOM.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Component_ID =s.Component_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Quantity =s.Quantity,
										Sequence =s.Sequence,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_BOM_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_BOM ENT_BOM_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_BOM.Where(d => d.ID == ID).FirstOrDefault<ENT_BOM>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_BOM_Create(IEnumerable<ENT_BOM> items, string CreatedBy)
        {
            string ENT_BOM_List = string.Empty;
            string ENT_BOM_List_Serialized = string.Empty;
            string ENT_BOM_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_BOM> result = new List<ENT_BOM>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_BOM item in items)
                {
                    ENT_BOM dbItem = new ENT_BOM();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Component_ID =item.Component_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Quantity =item.Quantity;
								dbItem.Sequence =item.Sequence;
					                   
                    ENT_BOM_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_BOM.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_BOM_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_BOM_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_BOM_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_BOM_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_BOM_Create: {1} - {2}", CreatedBy, ENT_BOM_List, ENT_BOM_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_BOM_Create(ENT_BOM item, string CreatedBy)
        {
            string ENT_BOM_List = string.Empty;
            string ENT_BOM_List_Serialized = string.Empty;
            string ENT_BOM_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_BOM> result = new List<ENT_BOM>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_BOM dbItem = new ENT_BOM();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Component_ID =item.Component_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Quantity =item.Quantity;
								dbItem.Sequence =item.Sequence;
					                    ENT_BOM_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_BOM.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_BOM_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_BOM_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_BOM_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_BOM_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_BOM_Create: {1} - {2}", CreatedBy, ENT_BOM_List, ENT_BOM_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_BOM_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_BOM.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Component_ID =s.Component_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Quantity =s.Quantity,
										Sequence =s.Sequence,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_BOM_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_BOM_Update(IEnumerable<ENT_BOM> items, string ModifiedBy)
        {
            string ENT_BOM_List = string.Empty;
            string ENT_BOM_List_Serialized = string.Empty;
            string ENT_BOM_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_BOM item in items)
                {
                    ENT_BOM dbItem = model.DBSet_ENT_BOM.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_BOM_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Component_ID =item.Component_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Quantity =item.Quantity;
								dbItem.Sequence =item.Sequence;
					                        

                        ENT_BOM_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_BOM_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_BOM_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_BOM_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_BOM_Update: {1} - {2}", ModifiedBy, ENT_BOM_List, ENT_BOM_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_BOM_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_BOM_List = string.Empty;
            string ENT_BOM_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_BOM> sendToTrashList = model.DBSet_ENT_BOM.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_BOM item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_BOM_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_BOM_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_BOM_Destroy: {1}", ModifiedBy, ENT_BOM_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

