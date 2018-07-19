// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : OutboundValidationDetail
//    File Name         : ENT_OutboundValidationDetail.cs
//    Properties        : Code_Validation_routine_ID; CreatedBy; CreatedDate; Enable; ID; IsDeleted; Minimum_shelf_life; ModifiedBy; ModifiedDate; Outbound_validation_ID; RF_assisted_picking; RF_directed_picking; Sequence; Validation_routine;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Code_Validation_routine_ID; CreatedBy; CreatedDate; Enable; ID; IsDeleted; Minimum_shelf_life; ModifiedBy; ModifiedDate; Outbound_validation_ID; RF_assisted_picking; RF_directed_picking; Sequence; Validation_routine; ENT_OutboundValidation_Outbound_validation_ID;
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
	[Table("tbl_ENT_OutboundValidationDetail")]
    [Serializable]
	[DataContract]
    public partial class ENT_OutboundValidationDetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Code_Validation_routine_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_Validation_routine_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Enable")]        [DataMember]        public Nullable<bool> Enable { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "OutboundValidationDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Minimum_shelf_life")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Minimum_shelf_life { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Outbound_validation_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Outbound_validation_ID { get; set; }
			        [Column("RF_assisted_picking")]        [DataMember]        public Nullable<bool> RF_assisted_picking { get; set; }
			        [Column("RF_directed_picking")]        [DataMember]        public Nullable<bool> RF_directed_picking { get; set; }
			        [Column("Sequence")]        [DataMember]        public string Sequence { get; set; }
			        [Column("Validation_routine")]        [DataMember]        public string Validation_routine { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Code_Validation_routine_ID")]        public virtual LIST_Code LIST_Code_Code_Validation_routine_ID { get; set; }        [ForeignKey("Outbound_validation_ID")]        public virtual ENT_OutboundValidation ENT_OutboundValidation_Outbound_validation_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_OutboundValidationDetail> ENT_OutboundValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_OutboundValidationDetail.AsEnumerable().Select(s => new ENT_OutboundValidationDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Code_Validation_routine_ID =s.Code_Validation_routine_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Enable =s.Enable,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Minimum_shelf_life =s.Minimum_shelf_life,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_ID =s.Outbound_validation_ID,
										RF_assisted_picking =s.RF_assisted_picking,
										RF_directed_picking =s.RF_directed_picking,
										Sequence =s.Sequence,
										Validation_routine =s.Validation_routine,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_OutboundValidationDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_OutboundValidationDetail> ENT_OutboundValidationDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_OutboundValidationDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_OutboundValidationDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Code_Validation_routine_ID =s.Code_Validation_routine_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Enable =s.Enable,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Minimum_shelf_life =s.Minimum_shelf_life,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_ID =s.Outbound_validation_ID,
										RF_assisted_picking =s.RF_assisted_picking,
										RF_directed_picking =s.RF_directed_picking,
										Sequence =s.Sequence,
										Validation_routine =s.Validation_routine,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_OutboundValidationDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_OutboundValidationDetail ENT_OutboundValidationDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_OutboundValidationDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_OutboundValidationDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_OutboundValidationDetail_Create(IEnumerable<ENT_OutboundValidationDetail> items, string CreatedBy)
        {
            string ENT_OutboundValidationDetail_List = string.Empty;
            string ENT_OutboundValidationDetail_List_Serialized = string.Empty;
            string ENT_OutboundValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_OutboundValidationDetail> result = new List<ENT_OutboundValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_OutboundValidationDetail item in items)
                {
                    ENT_OutboundValidationDetail dbItem = new ENT_OutboundValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Code_Validation_routine_ID =item.Code_Validation_routine_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Enable =item.Enable;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Minimum_shelf_life =item.Minimum_shelf_life;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_ID =item.Outbound_validation_ID;
								dbItem.RF_assisted_picking =item.RF_assisted_picking;
								dbItem.RF_directed_picking =item.RF_directed_picking;
								dbItem.Sequence =item.Sequence;
								dbItem.Validation_routine =item.Validation_routine;
					                   
                    ENT_OutboundValidationDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_OutboundValidationDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_OutboundValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_OutboundValidationDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_OutboundValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_OutboundValidationDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidationDetail_Create: {1} - {2}", CreatedBy, ENT_OutboundValidationDetail_List, ENT_OutboundValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_OutboundValidationDetail_Create(ENT_OutboundValidationDetail item, string CreatedBy)
        {
            string ENT_OutboundValidationDetail_List = string.Empty;
            string ENT_OutboundValidationDetail_List_Serialized = string.Empty;
            string ENT_OutboundValidationDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_OutboundValidationDetail> result = new List<ENT_OutboundValidationDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_OutboundValidationDetail dbItem = new ENT_OutboundValidationDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Code_Validation_routine_ID =item.Code_Validation_routine_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Enable =item.Enable;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Minimum_shelf_life =item.Minimum_shelf_life;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_ID =item.Outbound_validation_ID;
								dbItem.RF_assisted_picking =item.RF_assisted_picking;
								dbItem.RF_directed_picking =item.RF_directed_picking;
								dbItem.Sequence =item.Sequence;
								dbItem.Validation_routine =item.Validation_routine;
					                    ENT_OutboundValidationDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_OutboundValidationDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_OutboundValidationDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_OutboundValidationDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_OutboundValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_OutboundValidationDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidationDetail_Create: {1} - {2}", CreatedBy, ENT_OutboundValidationDetail_List, ENT_OutboundValidationDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_OutboundValidationDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_OutboundValidationDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Code_Validation_routine_ID =s.Code_Validation_routine_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Enable =s.Enable,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Minimum_shelf_life =s.Minimum_shelf_life,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Outbound_validation_ID =s.Outbound_validation_ID,
										RF_assisted_picking =s.RF_assisted_picking,
										RF_directed_picking =s.RF_directed_picking,
										Sequence =s.Sequence,
										Validation_routine =s.Validation_routine,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_OutboundValidationDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_OutboundValidationDetail_Update(IEnumerable<ENT_OutboundValidationDetail> items, string ModifiedBy)
        {
            string ENT_OutboundValidationDetail_List = string.Empty;
            string ENT_OutboundValidationDetail_List_Serialized = string.Empty;
            string ENT_OutboundValidationDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_OutboundValidationDetail item in items)
                {
                    ENT_OutboundValidationDetail dbItem = model.DBSet_ENT_OutboundValidationDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_OutboundValidationDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Code_Validation_routine_ID =item.Code_Validation_routine_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Enable =item.Enable;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Minimum_shelf_life =item.Minimum_shelf_life;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Outbound_validation_ID =item.Outbound_validation_ID;
								dbItem.RF_assisted_picking =item.RF_assisted_picking;
								dbItem.RF_directed_picking =item.RF_directed_picking;
								dbItem.Sequence =item.Sequence;
								dbItem.Validation_routine =item.Validation_routine;
					                        

                        ENT_OutboundValidationDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_OutboundValidationDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_OutboundValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_OutboundValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidationDetail_Update: {1} - {2}", ModifiedBy, ENT_OutboundValidationDetail_List, ENT_OutboundValidationDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_OutboundValidationDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_OutboundValidationDetail_List = string.Empty;
            string ENT_OutboundValidationDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_OutboundValidationDetail> sendToTrashList = model.DBSet_ENT_OutboundValidationDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_OutboundValidationDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_OutboundValidationDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_OutboundValidationDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_OutboundValidationDetail_Destroy: {1}", ModifiedBy, ENT_OutboundValidationDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

