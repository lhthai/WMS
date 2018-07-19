// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Supplier
//    File Name         : ENT_Supplier.cs
//    Properties        : Address; Billing_Address; Billing_City; Billing_District; Billing_Email1; Billing_Email2; Billing_Fax1; Billing_Fax2; Billing_Phone1; Billing_Phone2; City; Company; CreatedBy; CreatedDate; District; Email1; Email2; Fax1; Fax2; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Owner_ID; Phone1; Phone2; Supplier_Code; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Address; Billing_Address; Billing_City; Billing_District; Billing_Email1; Billing_Email2; Billing_Fax1; Billing_Fax2; Billing_Phone1; Billing_Phone2; City; Company; CreatedBy; CreatedDate; District; Email1; Email2; Fax1; Fax2; ID; IsDeleted; Item_ID; ModifiedBy; ModifiedDate; Notes; Owner_ID; Phone1; Phone2; Supplier_Code; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; WHS_POs_Supplier_ID;
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
	[Table("tbl_ENT_Supplier")]
    [Serializable]
	[DataContract]
    public partial class ENT_Supplier
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Address")]        [DataMember]        public string Address { get; set; }
			        [Column("Billing_Address")]        [DataMember]        public string Billing_Address { get; set; }
			        [Column("Billing_City")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Billing_City { get; set; }
			        [Column("Billing_District")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Billing_District { get; set; }
			        [Column("Billing_Email1")]        [DataMember]        public string Billing_Email1 { get; set; }
			        [Column("Billing_Email2")]        [DataMember]        public string Billing_Email2 { get; set; }
			        [Column("Billing_Fax1")]        [DataMember]        public string Billing_Fax1 { get; set; }
			        [Column("Billing_Fax2")]        [DataMember]        public string Billing_Fax2 { get; set; }
			        [Column("Billing_Phone1")]        [DataMember]        public string Billing_Phone1 { get; set; }
			        [Column("Billing_Phone2")]        [DataMember]        public string Billing_Phone2 { get; set; }
			        [Column("City")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> City { get; set; }
			        [Column("Company")]        [DataMember]        public string Company { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("District")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> District { get; set; }
			        [Column("Email1")]        [DataMember]        public string Email1 { get; set; }
			        [Column("Email2")]        [DataMember]        public string Email2 { get; set; }
			        [Column("Fax1")]        [DataMember]        public string Fax1 { get; set; }
			        [Column("Fax2")]        [DataMember]        public string Fax2 { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Supplier_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Item_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Owner_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_ID { get; set; }
			        [Column("Phone1")]        [DataMember]        public string Phone1 { get; set; }
			        [Column("Phone2")]        [DataMember]        public string Phone2 { get; set; }
			        [Column("Supplier_Code")]        [DataMember]        public string Supplier_Code { get; set; }
			        [Column("UDF_1")]        [DataMember]        public string UDF_1 { get; set; }
			        [Column("UDF_2")]        [DataMember]        public string UDF_2 { get; set; }
			        [Column("UDF_3")]        [DataMember]        public string UDF_3 { get; set; }
			        [Column("UDF_4")]        [DataMember]        public string UDF_4 { get; set; }
			        [Column("UDF_5")]        [DataMember]        public string UDF_5 { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Billing_City")]        public virtual LIST_Code LIST_Code_Billing_City { get; set; }        [ForeignKey("Billing_District")]        public virtual LIST_Code LIST_Code_Billing_District { get; set; }        [ForeignKey("City")]        public virtual LIST_Code LIST_Code_City { get; set; }        [ForeignKey("District")]        public virtual LIST_Code LIST_Code_District { get; set; }        [ForeignKey("Item_ID")]        public virtual ENT_Item ENT_Item_Item_ID { get; set; }        [ForeignKey("Owner_ID")]        public virtual ENT_Owner ENT_Owner_Owner_ID { get; set; }		        public virtual ICollection<ENT_Owner> ENT_Owners_Supplier_ID { get; set; }        public virtual ICollection<WHS_ASN> WHS_ASNs_Supplier_ID { get; set; }        public virtual ICollection<WHS_PO> WHS_POs_Supplier_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Supplier> ENT_Supplier_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Supplier.AsEnumerable().Select(s => new ENT_Supplier()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Supplier_Code =s.Supplier_Code,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Supplier>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Supplier> ENT_Supplier_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Supplier_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Supplier.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Supplier_Code =s.Supplier_Code,
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
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Supplier_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Supplier ENT_Supplier_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Supplier.Where(d => d.ID == ID).FirstOrDefault<ENT_Supplier>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Supplier_Create(IEnumerable<ENT_Supplier> items, string CreatedBy)
        {
            string ENT_Supplier_List = string.Empty;
            string ENT_Supplier_List_Serialized = string.Empty;
            string ENT_Supplier_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Supplier> result = new List<ENT_Supplier>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Supplier item in items)
                {
                    ENT_Supplier dbItem = new ENT_Supplier();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Address =item.Address;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Supplier_Code =item.Supplier_Code;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                   
                    ENT_Supplier_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Supplier.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Supplier_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Supplier_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Supplier_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Supplier_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Supplier_Create: {1} - {2}", CreatedBy, ENT_Supplier_List, ENT_Supplier_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Supplier_Create(ENT_Supplier item, string CreatedBy)
        {
            string ENT_Supplier_List = string.Empty;
            string ENT_Supplier_List_Serialized = string.Empty;
            string ENT_Supplier_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Supplier> result = new List<ENT_Supplier>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Supplier dbItem = new ENT_Supplier();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Address =item.Address;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Supplier_Code =item.Supplier_Code;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                    ENT_Supplier_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Supplier.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Supplier_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Supplier_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Supplier_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Supplier_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Supplier_Create: {1} - {2}", CreatedBy, ENT_Supplier_List, ENT_Supplier_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Supplier_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Supplier.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_ID =s.Item_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_ID =s.Owner_ID,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Supplier_Code =s.Supplier_Code,
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
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Supplier_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Supplier_Update(IEnumerable<ENT_Supplier> items, string ModifiedBy)
        {
            string ENT_Supplier_List = string.Empty;
            string ENT_Supplier_List_Serialized = string.Empty;
            string ENT_Supplier_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Supplier item in items)
                {
                    ENT_Supplier dbItem = model.DBSet_ENT_Supplier.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Supplier_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Address =item.Address;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_ID =item.Item_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_ID =item.Owner_ID;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Supplier_Code =item.Supplier_Code;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
					                        

                        ENT_Supplier_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Supplier_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Supplier_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Supplier_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Supplier_Update: {1} - {2}", ModifiedBy, ENT_Supplier_List, ENT_Supplier_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Supplier_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Supplier_List = string.Empty;
            string ENT_Supplier_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Supplier> sendToTrashList = model.DBSet_ENT_Supplier.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Supplier item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Supplier_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Supplier_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Supplier_Destroy: {1}", ModifiedBy, ENT_Supplier_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

