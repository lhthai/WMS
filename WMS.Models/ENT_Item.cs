// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Item
//    File Name         : ENT_Item.cs
//    Properties        : Allocation_Strategy_Id; Batch_No; C_System_Itemtype; Carton_ID; Code_UOM_ID; CreatedBy; CreatedDate; Cube; CycleClass_ID; Gross_weight; ID; IsDeleted; Item_Code; Item_Description; ItemtypeDetail_ID; Last_cycle_count; Location_ID; Lot_No; ModifiedBy; ModifiedDate; Net_weight; Notes; Owner_Id; Pack_Id; Putaway_Strategy_Id; RotatebyDetail_ID; RotationDetail_ID; Tare_weight; To_Best_By_Day; To_Deliver_By_Days; To_Expire_Days; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; V_CycleCount_ID; V_Lot_ID; V_Receipt_ID; Zone_Id;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Allocation_Strategy_Id; Batch_No; C_System_Itemtype; Carton_ID; Code_UOM_ID; CreatedBy; CreatedDate; Cube; CycleClass_ID; Gross_weight; ID; IsDeleted; Item_Code; Item_Description; ItemtypeDetail_ID; Last_cycle_count; Location_ID; Lot_No; ModifiedBy; ModifiedDate; Net_weight; Notes; Owner_Id; Pack_Id; Putaway_Strategy_Id; RotatebyDetail_ID; RotationDetail_ID; Tare_weight; To_Best_By_Day; To_Deliver_By_Days; To_Expire_Days; UDF_1; UDF_2; UDF_3; UDF_4; UDF_5; V_CycleCount_ID; V_Lot_ID; V_Receipt_ID; Zone_Id; WHS_Transactions_Item_ID;
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
	[Table("tbl_ENT_Item")]
    [Serializable]
	[DataContract]
    public partial class ENT_Item
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Allocation_Strategy_Id")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Allocation_Strategy_Id { get; set; }
			        [Column("Batch_No")]        [DataMember]        public string Batch_No { get; set; }
			        [Column("C_System_Itemtype")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> C_System_Itemtype { get; set; }
			        [Column("Carton_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Carton_ID { get; set; }
			        [Column("Code_UOM_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Code_UOM_ID { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Cube")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Cube { get; set; }
			        [Column("CycleClass_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> CycleClass_ID { get; set; }
			        [Column("Gross_weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Gross_weight { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Item_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Item_Code")]        [DataMember]        public string Item_Code { get; set; }
			        [Column("Item_Description")]        [DataMember]        public string Item_Description { get; set; }
			        [Column("ItemtypeDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> ItemtypeDetail_ID { get; set; }
			        [Column("Last_cycle_count")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> Last_cycle_count { get; set; }
			        [Column("Location_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_ID { get; set; }
			        [Column("Lot_No")]        [DataMember]        public string Lot_No { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Net_weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Net_weight { get; set; }
			        [Column("Notes")]        [DataMember]        public string Notes { get; set; }
			        [Column("Owner_Id")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Owner_Id { get; set; }
			        [Column("Pack_Id")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Pack_Id { get; set; }
			        [Column("Putaway_Strategy_Id")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Putaway_Strategy_Id { get; set; }
			        [Column("RotatebyDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> RotatebyDetail_ID { get; set; }
			        [Column("RotationDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> RotationDetail_ID { get; set; }
			        [Column("Tare_weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Tare_weight { get; set; }
			        [Column("To_Best_By_Day")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> To_Best_By_Day { get; set; }
			        [Column("To_Deliver_By_Days")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> To_Deliver_By_Days { get; set; }
			        [Column("To_Expire_Days")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> To_Expire_Days { get; set; }
			        [Column("UDF_1")]        [DataMember]        public string UDF_1 { get; set; }
			        [Column("UDF_2")]        [DataMember]        public string UDF_2 { get; set; }
			        [Column("UDF_3")]        [DataMember]        public string UDF_3 { get; set; }
			        [Column("UDF_4")]        [DataMember]        public string UDF_4 { get; set; }
			        [Column("UDF_5")]        [DataMember]        public string UDF_5 { get; set; }
			        [Column("V_CycleCount_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_CycleCount_ID { get; set; }
			        [Column("V_Lot_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_Lot_ID { get; set; }
			        [Column("V_Receipt_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> V_Receipt_ID { get; set; }
			        [Column("Zone_Id")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Zone_Id { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("C_System_Itemtype")]        public virtual LIST_Code LIST_Code_C_System_Itemtype { get; set; }        [ForeignKey("Carton_ID")]        public virtual ENT_Cartonization ENT_Cartonization_Carton_ID { get; set; }        [ForeignKey("Code_UOM_ID")]        public virtual LIST_Code LIST_Code_Code_UOM_ID { get; set; }        [ForeignKey("CycleClass_ID")]        public virtual ENT_CycleClass ENT_CycleClass_CycleClass_ID { get; set; }        [ForeignKey("ItemtypeDetail_ID")]        public virtual LIST_Code LIST_Code_ItemtypeDetail_ID { get; set; }        [ForeignKey("Location_ID")]        public virtual WHS_Location WHS_Location_Location_ID { get; set; }        [ForeignKey("Owner_Id")]        public virtual ENT_Owner ENT_Owner_Owner_Id { get; set; }        [ForeignKey("Pack_Id")]        public virtual ENT_Pack ENT_Pack_Pack_Id { get; set; }        [ForeignKey("Putaway_Strategy_Id")]        public virtual WHS_Strategy_Putaway WHS_Strategy_Putaway_Putaway_Strategy_Id { get; set; }        [ForeignKey("RotatebyDetail_ID")]        public virtual LIST_Code LIST_Code_RotatebyDetail_ID { get; set; }        [ForeignKey("RotationDetail_ID")]        public virtual LIST_Code LIST_Code_RotationDetail_ID { get; set; }        [ForeignKey("V_CycleCount_ID")]        public virtual ENT_CycleCountValidation ENT_CycleCountValidation_V_CycleCount_ID { get; set; }        [ForeignKey("V_Lot_ID")]        public virtual ENT_LottableValidation ENT_LottableValidation_V_Lot_ID { get; set; }        [ForeignKey("V_Receipt_ID")]        public virtual ENT_ReceiptValidation ENT_ReceiptValidation_V_Receipt_ID { get; set; }        [ForeignKey("Zone_Id")]        public virtual WHS_Zone WHS_Zone_Zone_Id { get; set; }		        public virtual ICollection<ENT_BOM> ENT_BOMs_Component_ID { get; set; }        public virtual ICollection<ENT_BOM> ENT_BOMs_Item_ID { get; set; }        public virtual ICollection<ENT_OutboundValidation> ENT_OutboundValidations_Item_ID { get; set; }        public virtual ICollection<ENT_Supplier> ENT_Suppliers_Item_ID { get; set; }        public virtual ICollection<WHS_ASNDetail> WHS_ASNDetails_Item_ID { get; set; }        public virtual ICollection<WHS_ASNDetail> WHS_ASNDetails_UOM_ID { get; set; }        public virtual ICollection<WHS_Lot_Attribute> WHS_Lot_Attributes_Item_ID { get; set; }        public virtual ICollection<WHS_Maintain_Hold> WHS_Maintain_Holds_Item_ID { get; set; }        public virtual ICollection<WHS_Move> WHS_Moves_Item_ID { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_Item_ID { get; set; }        public virtual ICollection<WHS_PODetail> WHS_PODetails_Item_ID { get; set; }        public virtual ICollection<WHS_Replenishment> WHS_Replenishments_Item_ID { get; set; }        public virtual ICollection<WHS_SO_Detail> WHS_SO_Details_Item_ID { get; set; }        public virtual ICollection<WHS_Transaction> WHS_Transactions_Item_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Item> ENT_Item_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Item.AsEnumerable().Select(s => new ENT_Item()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allocation_Strategy_Id =s.Allocation_Strategy_Id,
										Batch_No =s.Batch_No,
										C_System_Itemtype =s.C_System_Itemtype,
										Carton_ID =s.Carton_ID,
										Code_UOM_ID =s.Code_UOM_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										CycleClass_ID =s.CycleClass_ID,
										Gross_weight =s.Gross_weight,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Code =s.Item_Code,
										Item_Description =s.Item_Description,
										ItemtypeDetail_ID =s.ItemtypeDetail_ID,
										Last_cycle_count =s.Last_cycle_count,
										Location_ID =s.Location_ID,
										Lot_No =s.Lot_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Net_weight =s.Net_weight,
										Notes =s.Notes,
										Owner_Id =s.Owner_Id,
										Pack_Id =s.Pack_Id,
										Putaway_Strategy_Id =s.Putaway_Strategy_Id,
										RotatebyDetail_ID =s.RotatebyDetail_ID,
										RotationDetail_ID =s.RotationDetail_ID,
										Tare_weight =s.Tare_weight,
										To_Best_By_Day =s.To_Best_By_Day,
										To_Deliver_By_Days =s.To_Deliver_By_Days,
										To_Expire_Days =s.To_Expire_Days,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_CycleCount_ID =s.V_CycleCount_ID,
										V_Lot_ID =s.V_Lot_ID,
										V_Receipt_ID =s.V_Receipt_ID,
										Zone_Id =s.Zone_Id,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Item>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Item> ENT_Item_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Item_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Item.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Allocation_Strategy_Id =s.Allocation_Strategy_Id,
										Batch_No =s.Batch_No,
										C_System_Itemtype =s.C_System_Itemtype,
										Carton_ID =s.Carton_ID,
										Code_UOM_ID =s.Code_UOM_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										CycleClass_ID =s.CycleClass_ID,
										Gross_weight =s.Gross_weight,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Code =s.Item_Code,
										Item_Description =s.Item_Description,
										ItemtypeDetail_ID =s.ItemtypeDetail_ID,
										Last_cycle_count =s.Last_cycle_count,
										Location_ID =s.Location_ID,
										Lot_No =s.Lot_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Net_weight =s.Net_weight,
										Notes =s.Notes,
										Owner_Id =s.Owner_Id,
										Pack_Id =s.Pack_Id,
										Putaway_Strategy_Id =s.Putaway_Strategy_Id,
										RotatebyDetail_ID =s.RotatebyDetail_ID,
										RotationDetail_ID =s.RotationDetail_ID,
										Tare_weight =s.Tare_weight,
										To_Best_By_Day =s.To_Best_By_Day,
										To_Deliver_By_Days =s.To_Deliver_By_Days,
										To_Expire_Days =s.To_Expire_Days,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_CycleCount_ID =s.V_CycleCount_ID,
										V_Lot_ID =s.V_Lot_ID,
										V_Receipt_ID =s.V_Receipt_ID,
										Zone_Id =s.Zone_Id,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Item_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Item ENT_Item_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Item.Where(d => d.ID == ID).FirstOrDefault<ENT_Item>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Item_Create(IEnumerable<ENT_Item> items, string CreatedBy)
        {
            string ENT_Item_List = string.Empty;
            string ENT_Item_List_Serialized = string.Empty;
            string ENT_Item_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Item> result = new List<ENT_Item>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Item item in items)
                {
                    ENT_Item dbItem = new ENT_Item();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allocation_Strategy_Id =item.Allocation_Strategy_Id;
								dbItem.Batch_No =item.Batch_No;
								dbItem.C_System_Itemtype =item.C_System_Itemtype;
								dbItem.Carton_ID =item.Carton_ID;
								dbItem.Code_UOM_ID =item.Code_UOM_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.CycleClass_ID =item.CycleClass_ID;
								dbItem.Gross_weight =item.Gross_weight;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Code =item.Item_Code;
								dbItem.Item_Description =item.Item_Description;
								dbItem.ItemtypeDetail_ID =item.ItemtypeDetail_ID;
								dbItem.Last_cycle_count =item.Last_cycle_count;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_No =item.Lot_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Net_weight =item.Net_weight;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Id =item.Owner_Id;
								dbItem.Pack_Id =item.Pack_Id;
								dbItem.Putaway_Strategy_Id =item.Putaway_Strategy_Id;
								dbItem.RotatebyDetail_ID =item.RotatebyDetail_ID;
								dbItem.RotationDetail_ID =item.RotationDetail_ID;
								dbItem.Tare_weight =item.Tare_weight;
								dbItem.To_Best_By_Day =item.To_Best_By_Day;
								dbItem.To_Deliver_By_Days =item.To_Deliver_By_Days;
								dbItem.To_Expire_Days =item.To_Expire_Days;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.V_Receipt_ID =item.V_Receipt_ID;
								dbItem.Zone_Id =item.Zone_Id;
					                   
                    ENT_Item_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Item.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Item_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Item_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Item_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Item_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Item_Create: {1} - {2}", CreatedBy, ENT_Item_List, ENT_Item_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Item_Create(ENT_Item item, string CreatedBy)
        {
            string ENT_Item_List = string.Empty;
            string ENT_Item_List_Serialized = string.Empty;
            string ENT_Item_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Item> result = new List<ENT_Item>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Item dbItem = new ENT_Item();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Allocation_Strategy_Id =item.Allocation_Strategy_Id;
								dbItem.Batch_No =item.Batch_No;
								dbItem.C_System_Itemtype =item.C_System_Itemtype;
								dbItem.Carton_ID =item.Carton_ID;
								dbItem.Code_UOM_ID =item.Code_UOM_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.CycleClass_ID =item.CycleClass_ID;
								dbItem.Gross_weight =item.Gross_weight;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Code =item.Item_Code;
								dbItem.Item_Description =item.Item_Description;
								dbItem.ItemtypeDetail_ID =item.ItemtypeDetail_ID;
								dbItem.Last_cycle_count =item.Last_cycle_count;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_No =item.Lot_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Net_weight =item.Net_weight;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Id =item.Owner_Id;
								dbItem.Pack_Id =item.Pack_Id;
								dbItem.Putaway_Strategy_Id =item.Putaway_Strategy_Id;
								dbItem.RotatebyDetail_ID =item.RotatebyDetail_ID;
								dbItem.RotationDetail_ID =item.RotationDetail_ID;
								dbItem.Tare_weight =item.Tare_weight;
								dbItem.To_Best_By_Day =item.To_Best_By_Day;
								dbItem.To_Deliver_By_Days =item.To_Deliver_By_Days;
								dbItem.To_Expire_Days =item.To_Expire_Days;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.V_Receipt_ID =item.V_Receipt_ID;
								dbItem.Zone_Id =item.Zone_Id;
					                    ENT_Item_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Item.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Item_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Item_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Item_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Item_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Item_Create: {1} - {2}", CreatedBy, ENT_Item_List, ENT_Item_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Item_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Item.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Allocation_Strategy_Id =s.Allocation_Strategy_Id,
										Batch_No =s.Batch_No,
										C_System_Itemtype =s.C_System_Itemtype,
										Carton_ID =s.Carton_ID,
										Code_UOM_ID =s.Code_UOM_ID,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										CycleClass_ID =s.CycleClass_ID,
										Gross_weight =s.Gross_weight,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Item_Code =s.Item_Code,
										Item_Description =s.Item_Description,
										ItemtypeDetail_ID =s.ItemtypeDetail_ID,
										Last_cycle_count =s.Last_cycle_count,
										Location_ID =s.Location_ID,
										Lot_No =s.Lot_No,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Net_weight =s.Net_weight,
										Notes =s.Notes,
										Owner_Id =s.Owner_Id,
										Pack_Id =s.Pack_Id,
										Putaway_Strategy_Id =s.Putaway_Strategy_Id,
										RotatebyDetail_ID =s.RotatebyDetail_ID,
										RotationDetail_ID =s.RotationDetail_ID,
										Tare_weight =s.Tare_weight,
										To_Best_By_Day =s.To_Best_By_Day,
										To_Deliver_By_Days =s.To_Deliver_By_Days,
										To_Expire_Days =s.To_Expire_Days,
										UDF_1 =s.UDF_1,
										UDF_2 =s.UDF_2,
										UDF_3 =s.UDF_3,
										UDF_4 =s.UDF_4,
										UDF_5 =s.UDF_5,
										V_CycleCount_ID =s.V_CycleCount_ID,
										V_Lot_ID =s.V_Lot_ID,
										V_Receipt_ID =s.V_Receipt_ID,
										Zone_Id =s.Zone_Id,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Item_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Item_Update(IEnumerable<ENT_Item> items, string ModifiedBy)
        {
            string ENT_Item_List = string.Empty;
            string ENT_Item_List_Serialized = string.Empty;
            string ENT_Item_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Item item in items)
                {
                    ENT_Item dbItem = model.DBSet_ENT_Item.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Item_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Allocation_Strategy_Id =item.Allocation_Strategy_Id;
								dbItem.Batch_No =item.Batch_No;
								dbItem.C_System_Itemtype =item.C_System_Itemtype;
								dbItem.Carton_ID =item.Carton_ID;
								dbItem.Code_UOM_ID =item.Code_UOM_ID;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.CycleClass_ID =item.CycleClass_ID;
								dbItem.Gross_weight =item.Gross_weight;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Item_Code =item.Item_Code;
								dbItem.Item_Description =item.Item_Description;
								dbItem.ItemtypeDetail_ID =item.ItemtypeDetail_ID;
								dbItem.Last_cycle_count =item.Last_cycle_count;
								dbItem.Location_ID =item.Location_ID;
								dbItem.Lot_No =item.Lot_No;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Net_weight =item.Net_weight;
								dbItem.Notes =item.Notes;
								dbItem.Owner_Id =item.Owner_Id;
								dbItem.Pack_Id =item.Pack_Id;
								dbItem.Putaway_Strategy_Id =item.Putaway_Strategy_Id;
								dbItem.RotatebyDetail_ID =item.RotatebyDetail_ID;
								dbItem.RotationDetail_ID =item.RotationDetail_ID;
								dbItem.Tare_weight =item.Tare_weight;
								dbItem.To_Best_By_Day =item.To_Best_By_Day;
								dbItem.To_Deliver_By_Days =item.To_Deliver_By_Days;
								dbItem.To_Expire_Days =item.To_Expire_Days;
								dbItem.UDF_1 =item.UDF_1;
								dbItem.UDF_2 =item.UDF_2;
								dbItem.UDF_3 =item.UDF_3;
								dbItem.UDF_4 =item.UDF_4;
								dbItem.UDF_5 =item.UDF_5;
								dbItem.V_CycleCount_ID =item.V_CycleCount_ID;
								dbItem.V_Lot_ID =item.V_Lot_ID;
								dbItem.V_Receipt_ID =item.V_Receipt_ID;
								dbItem.Zone_Id =item.Zone_Id;
					                        

                        ENT_Item_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Item_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Item_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Item_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Item_Update: {1} - {2}", ModifiedBy, ENT_Item_List, ENT_Item_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Item_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Item_List = string.Empty;
            string ENT_Item_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Item> sendToTrashList = model.DBSet_ENT_Item.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Item item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Item_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Item_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Item_Destroy: {1}", ModifiedBy, ENT_Item_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

