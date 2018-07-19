// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : V_DateFormatDetail
//    File Name         : ENT_V_DateFormatDetail.cs
//    Properties        : Begin; Code_Date_element_ID; Code_date_field_ID; Code_Date_type_ID; Code_how_to_process_ID; CreatedBy; CreatedDate; Date_element; Date_type; End; Field_type; How_to_process; ID; IsDeleted; ModifiedBy; ModifiedDate; V_date_format_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Begin; Code_Date_element_ID; Code_date_field_ID; Code_Date_type_ID; Code_how_to_process_ID; CreatedBy; CreatedDate; Date_element; Date_type; End; Field_type; How_to_process; ID; IsDeleted; ModifiedBy; ModifiedDate; V_date_format_ID; ENT_V_DateFormat_V_date_format_ID;
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
	[Table("tbl_ENT_V_DateFormatDetail")]
    [Serializable]
	[DataContract]
    public partial class ENT_V_DateFormatDetail
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Begin")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Begin { get; set; }
			        [Column("Code_Date_element_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_Date_element_ID { get; set; }
			        [Column("Code_date_field_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_date_field_ID { get; set; }
			        [Column("Code_Date_type_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_Date_type_ID { get; set; }
			        [Column("Code_how_to_process_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_how_to_process_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Date_element")]        [DataMember]        public string Date_element { get; set; }
			        [Column("Date_type")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Date_type { get; set; }
			        [Column("End")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> End { get; set; }
			        [Column("Field_type")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Field_type { get; set; }
			        [Column("How_to_process")]        [DataMember]        public string How_to_process { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "V_DateFormatDetail_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("V_date_format_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_date_format_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Code_Date_element_ID")]        public virtual LIST_Code LIST_Code_Code_Date_element_ID { get; set; }        [ForeignKey("Code_date_field_ID")]        public virtual LIST_Code LIST_Code_Code_date_field_ID { get; set; }        [ForeignKey("Code_Date_type_ID")]        public virtual LIST_Code LIST_Code_Code_Date_type_ID { get; set; }        [ForeignKey("Code_how_to_process_ID")]        public virtual LIST_Code LIST_Code_Code_how_to_process_ID { get; set; }        [ForeignKey("Date_type")]        public virtual LIST_Code LIST_Code_Date_type { get; set; }        [ForeignKey("Field_type")]        public virtual LIST_Code LIST_Code_Field_type { get; set; }        [ForeignKey("V_date_format_ID")]        public virtual ENT_V_DateFormat ENT_V_DateFormat_V_date_format_ID { get; set; }		

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_V_DateFormatDetail> ENT_V_DateFormatDetail_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_V_DateFormatDetail.AsEnumerable().Select(s => new ENT_V_DateFormatDetail()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Begin =s.Begin,
										Code_Date_element_ID =s.Code_Date_element_ID,
										Code_date_field_ID =s.Code_date_field_ID,
										Code_Date_type_ID =s.Code_Date_type_ID,
										Code_how_to_process_ID =s.Code_how_to_process_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_element =s.Date_element,
										Date_type =s.Date_type,
										End =s.End,
										Field_type =s.Field_type,
										How_to_process =s.How_to_process,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_date_format_ID =s.V_date_format_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_V_DateFormatDetail>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_V_DateFormatDetail> ENT_V_DateFormatDetail_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_V_DateFormatDetail_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_V_DateFormatDetail.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Begin =s.Begin,
										Code_Date_element_ID =s.Code_Date_element_ID,
										Code_date_field_ID =s.Code_date_field_ID,
										Code_Date_type_ID =s.Code_Date_type_ID,
										Code_how_to_process_ID =s.Code_how_to_process_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_element =s.Date_element,
										Date_type =s.Date_type,
										End =s.End,
										Field_type =s.Field_type,
										How_to_process =s.How_to_process,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_date_format_ID =s.V_date_format_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_V_DateFormatDetail_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_V_DateFormatDetail ENT_V_DateFormatDetail_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_V_DateFormatDetail.Where(d => d.ID == ID).FirstOrDefault<ENT_V_DateFormatDetail>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_V_DateFormatDetail_Create(IEnumerable<ENT_V_DateFormatDetail> items, string CreatedBy)
        {
            string ENT_V_DateFormatDetail_List = string.Empty;
            string ENT_V_DateFormatDetail_List_Serialized = string.Empty;
            string ENT_V_DateFormatDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_V_DateFormatDetail> result = new List<ENT_V_DateFormatDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_V_DateFormatDetail item in items)
                {
                    ENT_V_DateFormatDetail dbItem = new ENT_V_DateFormatDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Begin =item.Begin;
								dbItem.Code_Date_element_ID =item.Code_Date_element_ID;
								dbItem.Code_date_field_ID =item.Code_date_field_ID;
								dbItem.Code_Date_type_ID =item.Code_Date_type_ID;
								dbItem.Code_how_to_process_ID =item.Code_how_to_process_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_element =item.Date_element;
								dbItem.Date_type =item.Date_type;
								dbItem.End =item.End;
								dbItem.Field_type =item.Field_type;
								dbItem.How_to_process =item.How_to_process;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_date_format_ID =item.V_date_format_ID;
					                   
                    ENT_V_DateFormatDetail_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_V_DateFormatDetail.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_V_DateFormatDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_V_DateFormatDetail_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_V_DateFormatDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_V_DateFormatDetail_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormatDetail_Create: {1} - {2}", CreatedBy, ENT_V_DateFormatDetail_List, ENT_V_DateFormatDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_V_DateFormatDetail_Create(ENT_V_DateFormatDetail item, string CreatedBy)
        {
            string ENT_V_DateFormatDetail_List = string.Empty;
            string ENT_V_DateFormatDetail_List_Serialized = string.Empty;
            string ENT_V_DateFormatDetail_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_V_DateFormatDetail> result = new List<ENT_V_DateFormatDetail>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_V_DateFormatDetail dbItem = new ENT_V_DateFormatDetail();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Begin =item.Begin;
								dbItem.Code_Date_element_ID =item.Code_Date_element_ID;
								dbItem.Code_date_field_ID =item.Code_date_field_ID;
								dbItem.Code_Date_type_ID =item.Code_Date_type_ID;
								dbItem.Code_how_to_process_ID =item.Code_how_to_process_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_element =item.Date_element;
								dbItem.Date_type =item.Date_type;
								dbItem.End =item.End;
								dbItem.Field_type =item.Field_type;
								dbItem.How_to_process =item.How_to_process;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_date_format_ID =item.V_date_format_ID;
					                    ENT_V_DateFormatDetail_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_V_DateFormatDetail.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_V_DateFormatDetail_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_V_DateFormatDetail_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_V_DateFormatDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_V_DateFormatDetail_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormatDetail_Create: {1} - {2}", CreatedBy, ENT_V_DateFormatDetail_List, ENT_V_DateFormatDetail_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_V_DateFormatDetail_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_V_DateFormatDetail.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Begin =s.Begin,
										Code_Date_element_ID =s.Code_Date_element_ID,
										Code_date_field_ID =s.Code_date_field_ID,
										Code_Date_type_ID =s.Code_Date_type_ID,
										Code_how_to_process_ID =s.Code_how_to_process_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Date_element =s.Date_element,
										Date_type =s.Date_type,
										End =s.End,
										Field_type =s.Field_type,
										How_to_process =s.How_to_process,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_date_format_ID =s.V_date_format_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_V_DateFormatDetail_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_V_DateFormatDetail_Update(IEnumerable<ENT_V_DateFormatDetail> items, string ModifiedBy)
        {
            string ENT_V_DateFormatDetail_List = string.Empty;
            string ENT_V_DateFormatDetail_List_Serialized = string.Empty;
            string ENT_V_DateFormatDetail_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_V_DateFormatDetail item in items)
                {
                    ENT_V_DateFormatDetail dbItem = model.DBSet_ENT_V_DateFormatDetail.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_V_DateFormatDetail_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Begin =item.Begin;
								dbItem.Code_Date_element_ID =item.Code_Date_element_ID;
								dbItem.Code_date_field_ID =item.Code_date_field_ID;
								dbItem.Code_Date_type_ID =item.Code_Date_type_ID;
								dbItem.Code_how_to_process_ID =item.Code_how_to_process_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Date_element =item.Date_element;
								dbItem.Date_type =item.Date_type;
								dbItem.End =item.End;
								dbItem.Field_type =item.Field_type;
								dbItem.How_to_process =item.How_to_process;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_date_format_ID =item.V_date_format_ID;
					                        

                        ENT_V_DateFormatDetail_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_V_DateFormatDetail_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_V_DateFormatDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_V_DateFormatDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormatDetail_Update: {1} - {2}", ModifiedBy, ENT_V_DateFormatDetail_List, ENT_V_DateFormatDetail_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_V_DateFormatDetail_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_V_DateFormatDetail_List = string.Empty;
            string ENT_V_DateFormatDetail_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_V_DateFormatDetail> sendToTrashList = model.DBSet_ENT_V_DateFormatDetail.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_V_DateFormatDetail item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_V_DateFormatDetail_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_V_DateFormatDetail_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormatDetail_Destroy: {1}", ModifiedBy, ENT_V_DateFormatDetail_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

