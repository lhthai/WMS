// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Owner
//    File Name         : ENT_Owner.cs
//    Properties        : Address; Allocation_Strategy_ID; Billing_Address; Billing_City; Billing_District; Billing_Email1; Billing_Email2; Billing_Fax1; Billing_Fax2; Billing_Phone1; Billing_Phone2; Carrier_ID; Cartonization_ID; City; Company; CreatedBy; CreatedDate; Customer_ID; Cycle_Class_ID; District; Email1; Email2; Fax1; Fax2; ID; IsDeleted; ModifiedBy; ModifiedDate; Notes; Owner_Code; Phone1; Phone2; Putaway_Strategy_ID; Receipt_Validation_Detail_ID; Rotation_Detail_By; Rotation_Detail_ID; Supplier_ID; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; V_Cycle_Count_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Address; Allocation_Strategy_ID; Billing_Address; Billing_City; Billing_District; Billing_Email1; Billing_Email2; Billing_Fax1; Billing_Fax2; Billing_Phone1; Billing_Phone2; Carrier_ID; Cartonization_ID; City; Company; CreatedBy; CreatedDate; Customer_ID; Cycle_Class_ID; District; Email1; Email2; Fax1; Fax2; ID; IsDeleted; ModifiedBy; ModifiedDate; Notes; Owner_Code; Phone1; Phone2; Putaway_Strategy_ID; Receipt_Validation_Detail_ID; Rotation_Detail_By; Rotation_Detail_ID; Supplier_ID; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; V_Cycle_Count_ID; WHS_SOs_Owner_ID;
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
	[Table("tbl_ENT_Owner")]
    [Serializable]
	[DataContract]
    public partial class ENT_Owner
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





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Owner> ENT_Owner_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Owner.AsEnumerable().Select(s => new ENT_Owner()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Allocation_Strategy_ID =s.Allocation_Strategy_ID,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										Carrier_ID =s.Carrier_ID,
										Cartonization_ID =s.Cartonization_ID,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Cycle_Class_ID =s.Cycle_Class_ID,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Putaway_Strategy_ID =s.Putaway_Strategy_ID,
										Receipt_Validation_Detail_ID =s.Receipt_Validation_Detail_ID,
										Rotation_Detail_By =s.Rotation_Detail_By,
										Rotation_Detail_ID =s.Rotation_Detail_ID,
										Supplier_ID =s.Supplier_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_Cycle_Count_ID =s.V_Cycle_Count_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Owner>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Owner> ENT_Owner_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Owner_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Owner.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Allocation_Strategy_ID =s.Allocation_Strategy_ID,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										Carrier_ID =s.Carrier_ID,
										Cartonization_ID =s.Cartonization_ID,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Cycle_Class_ID =s.Cycle_Class_ID,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Putaway_Strategy_ID =s.Putaway_Strategy_ID,
										Receipt_Validation_Detail_ID =s.Receipt_Validation_Detail_ID,
										Rotation_Detail_By =s.Rotation_Detail_By,
										Rotation_Detail_ID =s.Rotation_Detail_ID,
										Supplier_ID =s.Supplier_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_Cycle_Count_ID =s.V_Cycle_Count_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Owner_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Owner ENT_Owner_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Owner.Where(d => d.ID == ID).FirstOrDefault<ENT_Owner>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Owner_Create(IEnumerable<ENT_Owner> items, string CreatedBy)
        {
            string ENT_Owner_List = string.Empty;
            string ENT_Owner_List_Serialized = string.Empty;
            string ENT_Owner_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Owner> result = new List<ENT_Owner>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Owner item in items)
                {
                    ENT_Owner dbItem = new ENT_Owner();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Address =item.Address;
								dbItem.Allocation_Strategy_ID =item.Allocation_Strategy_ID;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.Cartonization_ID =item.Cartonization_ID;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Cycle_Class_ID =item.Cycle_Class_ID;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Putaway_Strategy_ID =item.Putaway_Strategy_ID;
								dbItem.Receipt_Validation_Detail_ID =item.Receipt_Validation_Detail_ID;
								dbItem.Rotation_Detail_By =item.Rotation_Detail_By;
								dbItem.Rotation_Detail_ID =item.Rotation_Detail_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_Cycle_Count_ID =item.V_Cycle_Count_ID;
					                   
                    ENT_Owner_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Owner.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Owner_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Owner_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Owner_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Owner_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Owner_Create: {1} - {2}", CreatedBy, ENT_Owner_List, ENT_Owner_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Owner_Create(ENT_Owner item, string CreatedBy)
        {
            string ENT_Owner_List = string.Empty;
            string ENT_Owner_List_Serialized = string.Empty;
            string ENT_Owner_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Owner> result = new List<ENT_Owner>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Owner dbItem = new ENT_Owner();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Address =item.Address;
								dbItem.Allocation_Strategy_ID =item.Allocation_Strategy_ID;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.Cartonization_ID =item.Cartonization_ID;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Cycle_Class_ID =item.Cycle_Class_ID;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Putaway_Strategy_ID =item.Putaway_Strategy_ID;
								dbItem.Receipt_Validation_Detail_ID =item.Receipt_Validation_Detail_ID;
								dbItem.Rotation_Detail_By =item.Rotation_Detail_By;
								dbItem.Rotation_Detail_ID =item.Rotation_Detail_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_Cycle_Count_ID =item.V_Cycle_Count_ID;
					                    ENT_Owner_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Owner.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Owner_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Owner_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Owner_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Owner_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Owner_Create: {1} - {2}", CreatedBy, ENT_Owner_List, ENT_Owner_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Owner_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Owner.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Address =s.Address,
										Allocation_Strategy_ID =s.Allocation_Strategy_ID,
										Billing_Address =s.Billing_Address,
										Billing_City =s.Billing_City,
										Billing_District =s.Billing_District,
										Billing_Email1 =s.Billing_Email1,
										Billing_Email2 =s.Billing_Email2,
										Billing_Fax1 =s.Billing_Fax1,
										Billing_Fax2 =s.Billing_Fax2,
										Billing_Phone1 =s.Billing_Phone1,
										Billing_Phone2 =s.Billing_Phone2,
										Carrier_ID =s.Carrier_ID,
										Cartonization_ID =s.Cartonization_ID,
										City =s.City,
										Company =s.Company,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Customer_ID =s.Customer_ID,
										Cycle_Class_ID =s.Cycle_Class_ID,
										District =s.District,
										Email1 =s.Email1,
										Email2 =s.Email2,
										Fax1 =s.Fax1,
										Fax2 =s.Fax2,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Notes =s.Notes,
										Owner_Code =s.Owner_Code,
										Phone1 =s.Phone1,
										Phone2 =s.Phone2,
										Putaway_Strategy_ID =s.Putaway_Strategy_ID,
										Receipt_Validation_Detail_ID =s.Receipt_Validation_Detail_ID,
										Rotation_Detail_By =s.Rotation_Detail_By,
										Rotation_Detail_ID =s.Rotation_Detail_ID,
										Supplier_ID =s.Supplier_ID,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_Cycle_Count_ID =s.V_Cycle_Count_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Owner_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Owner_Update(IEnumerable<ENT_Owner> items, string ModifiedBy)
        {
            string ENT_Owner_List = string.Empty;
            string ENT_Owner_List_Serialized = string.Empty;
            string ENT_Owner_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Owner item in items)
                {
                    ENT_Owner dbItem = model.DBSet_ENT_Owner.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Owner_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Address =item.Address;
								dbItem.Allocation_Strategy_ID =item.Allocation_Strategy_ID;
								dbItem.Billing_Address =item.Billing_Address;
								dbItem.Billing_City =item.Billing_City;
								dbItem.Billing_District =item.Billing_District;
								dbItem.Billing_Email1 =item.Billing_Email1;
								dbItem.Billing_Email2 =item.Billing_Email2;
								dbItem.Billing_Fax1 =item.Billing_Fax1;
								dbItem.Billing_Fax2 =item.Billing_Fax2;
								dbItem.Billing_Phone1 =item.Billing_Phone1;
								dbItem.Billing_Phone2 =item.Billing_Phone2;
								dbItem.Carrier_ID =item.Carrier_ID;
								dbItem.Cartonization_ID =item.Cartonization_ID;
								dbItem.City =item.City;
								dbItem.Company =item.Company;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Customer_ID =item.Customer_ID;
								dbItem.Cycle_Class_ID =item.Cycle_Class_ID;
								dbItem.District =item.District;
								dbItem.Email1 =item.Email1;
								dbItem.Email2 =item.Email2;
								dbItem.Fax1 =item.Fax1;
								dbItem.Fax2 =item.Fax2;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Code =item.Owner_Code;
								dbItem.Phone1 =item.Phone1;
								dbItem.Phone2 =item.Phone2;
								dbItem.Putaway_Strategy_ID =item.Putaway_Strategy_ID;
								dbItem.Receipt_Validation_Detail_ID =item.Receipt_Validation_Detail_ID;
								dbItem.Rotation_Detail_By =item.Rotation_Detail_By;
								dbItem.Rotation_Detail_ID =item.Rotation_Detail_ID;
								dbItem.Supplier_ID =item.Supplier_ID;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_Cycle_Count_ID =item.V_Cycle_Count_ID;
					                        

                        ENT_Owner_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Owner_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Owner_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Owner_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Owner_Update: {1} - {2}", ModifiedBy, ENT_Owner_List, ENT_Owner_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Owner_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Owner_List = string.Empty;
            string ENT_Owner_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Owner> sendToTrashList = model.DBSet_ENT_Owner.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Owner item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Owner_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Owner_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Owner_Destroy: {1}", ModifiedBy, ENT_Owner_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				
