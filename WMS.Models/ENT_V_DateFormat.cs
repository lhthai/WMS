// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : V_DateFormat
//    File Name         : ENT_V_DateFormat.cs
//    Properties        : Converts_to; CreatedBy; CreatedDate; Description; Example; ID; IsDeleted; ModifiedBy; ModifiedDate; V_Date_format_code;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Converts_to; CreatedBy; CreatedDate; Description; Example; ID; IsDeleted; ModifiedBy; ModifiedDate; V_Date_format_code; ENT_V_DateFormatDetails_V_date_format_ID;
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
	[Table("tbl_ENT_V_DateFormat")]
    [Serializable]
	[DataContract]
    public partial class ENT_V_DateFormat
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Converts_to")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Converts_to { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("Example")]        [DataMember]        public string Example { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "V_DateFormat_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("V_Date_format_code")]        [DataMember]        public string V_Date_format_code { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_LottableValidationDetailDetail> ENT_LottableValidationDetailDetails_V_Date_fortmat_ID { get; set; }        public virtual ICollection<ENT_V_DateFormatDetail> ENT_V_DateFormatDetails_V_date_format_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_V_DateFormat> ENT_V_DateFormat_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_V_DateFormat.AsEnumerable().Select(s => new ENT_V_DateFormat()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Converts_to =s.Converts_to,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										Example =s.Example,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Date_format_code =s.V_Date_format_code,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_V_DateFormat>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_V_DateFormat> ENT_V_DateFormat_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_V_DateFormat_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_V_DateFormat.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Converts_to =s.Converts_to,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										Example =s.Example,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Date_format_code =s.V_Date_format_code,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_V_DateFormat_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_V_DateFormat ENT_V_DateFormat_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_V_DateFormat.Where(d => d.ID == ID).FirstOrDefault<ENT_V_DateFormat>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_V_DateFormat_Create(IEnumerable<ENT_V_DateFormat> items, string CreatedBy)
        {
            string ENT_V_DateFormat_List = string.Empty;
            string ENT_V_DateFormat_List_Serialized = string.Empty;
            string ENT_V_DateFormat_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_V_DateFormat> result = new List<ENT_V_DateFormat>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_V_DateFormat item in items)
                {
                    ENT_V_DateFormat dbItem = new ENT_V_DateFormat();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Converts_to =item.Converts_to;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.Example =item.Example;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Date_format_code =item.V_Date_format_code;
					                   
                    ENT_V_DateFormat_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_V_DateFormat.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_V_DateFormat_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_V_DateFormat_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_V_DateFormat_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_V_DateFormat_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormat_Create: {1} - {2}", CreatedBy, ENT_V_DateFormat_List, ENT_V_DateFormat_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_V_DateFormat_Create(ENT_V_DateFormat item, string CreatedBy)
        {
            string ENT_V_DateFormat_List = string.Empty;
            string ENT_V_DateFormat_List_Serialized = string.Empty;
            string ENT_V_DateFormat_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_V_DateFormat> result = new List<ENT_V_DateFormat>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_V_DateFormat dbItem = new ENT_V_DateFormat();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Converts_to =item.Converts_to;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.Example =item.Example;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Date_format_code =item.V_Date_format_code;
					                    ENT_V_DateFormat_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_V_DateFormat.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_V_DateFormat_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_V_DateFormat_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_V_DateFormat_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_V_DateFormat_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormat_Create: {1} - {2}", CreatedBy, ENT_V_DateFormat_List, ENT_V_DateFormat_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_V_DateFormat_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_V_DateFormat.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Converts_to =s.Converts_to,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										Example =s.Example,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										V_Date_format_code =s.V_Date_format_code,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_V_DateFormat_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_V_DateFormat_Update(IEnumerable<ENT_V_DateFormat> items, string ModifiedBy)
        {
            string ENT_V_DateFormat_List = string.Empty;
            string ENT_V_DateFormat_List_Serialized = string.Empty;
            string ENT_V_DateFormat_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_V_DateFormat item in items)
                {
                    ENT_V_DateFormat dbItem = model.DBSet_ENT_V_DateFormat.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_V_DateFormat_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Converts_to =item.Converts_to;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.Example =item.Example;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.V_Date_format_code =item.V_Date_format_code;
					                        

                        ENT_V_DateFormat_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_V_DateFormat_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_V_DateFormat_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_V_DateFormat_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormat_Update: {1} - {2}", ModifiedBy, ENT_V_DateFormat_List, ENT_V_DateFormat_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_V_DateFormat_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_V_DateFormat_List = string.Empty;
            string ENT_V_DateFormat_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_V_DateFormat> sendToTrashList = model.DBSet_ENT_V_DateFormat.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_V_DateFormat item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_V_DateFormat_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_V_DateFormat_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_V_DateFormat_Destroy: {1}", ModifiedBy, ENT_V_DateFormat_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

