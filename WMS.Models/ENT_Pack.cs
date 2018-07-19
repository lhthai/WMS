// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Pack
//    File Name         : ENT_Pack.cs
//    Properties        : Carton_ID; Cartonize_Case; Cartonize_innerPack; Cartonize_Layer; Cartonize_MasterUnit; Cartonize_Pallet; Case_Height; Case_Length; Case_Width; CreatedBy; CreatedDate; Description; ID; Innerpack_Height; Innerpack_Length; Innerpack_Width; IsDeleted; Layer_Height; Layer_Lenght; Layer_Width; Master_Unit_Height; Master_Unit_Length; Master_Unit_Width; ModifiedBy; ModifiedDate; Number_of_cases_per_tier; Number_of_tiers_high_per_pallet; Pack_Code; Pallet_Height; Pallet_Length; Pallet_Width; Pallet_Wood_Height; Pallet_Wood_Length; Pallet_Wood_Width; Unit_Per_Mesure_1; Unit_Per_Mesure_2; Unit_Per_Mesure_3; Unit_Per_Mesure_4; UOM_CubeDetail_ID; UOM_PackageDetail_ID; UOM_QuantityDetail_ID; UOM_WeightDetail_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Carton_ID; Cartonize_Case; Cartonize_innerPack; Cartonize_Layer; Cartonize_MasterUnit; Cartonize_Pallet; Case_Height; Case_Length; Case_Width; CreatedBy; CreatedDate; Description; ID; Innerpack_Height; Innerpack_Length; Innerpack_Width; IsDeleted; Layer_Height; Layer_Lenght; Layer_Width; Master_Unit_Height; Master_Unit_Length; Master_Unit_Width; ModifiedBy; ModifiedDate; Number_of_cases_per_tier; Number_of_tiers_high_per_pallet; Pack_Code; Pallet_Height; Pallet_Length; Pallet_Width; Pallet_Wood_Height; Pallet_Wood_Length; Pallet_Wood_Width; Unit_Per_Mesure_1; Unit_Per_Mesure_2; Unit_Per_Mesure_3; Unit_Per_Mesure_4; UOM_CubeDetail_ID; UOM_PackageDetail_ID; UOM_QuantityDetail_ID; UOM_WeightDetail_ID; WHS_SO_Details_Pack_ID;
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
	[Table("tbl_ENT_Pack")]
    [Serializable]
	[DataContract]
    public partial class ENT_Pack
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Carton_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Carton_ID { get; set; }
			        [Column("Cartonize_Case")]        [DataMember]        public Nullable<bool> Cartonize_Case { get; set; }
			        [Column("Cartonize_innerPack")]        [DataMember]        public Nullable<bool> Cartonize_innerPack { get; set; }
			        [Column("Cartonize_Layer")]        [DataMember]        public Nullable<bool> Cartonize_Layer { get; set; }
			        [Column("Cartonize_MasterUnit")]        [DataMember]        public Nullable<bool> Cartonize_MasterUnit { get; set; }
			        [Column("Cartonize_Pallet")]        [DataMember]        public Nullable<bool> Cartonize_Pallet { get; set; }
			        [Column("Case_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Case_Height { get; set; }
			        [Column("Case_Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Case_Length { get; set; }
			        [Column("Case_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Case_Width { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Description")]        [DataMember]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Pack_Description_Required")]        public string Description { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Pack_ID_Required")]        public int ID { get; set; }
			        [Column("Innerpack_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Innerpack_Height { get; set; }
			        [Column("Innerpack_Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Innerpack_Length { get; set; }
			        [Column("Innerpack_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Innerpack_Width { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Layer_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Layer_Height { get; set; }
			        [Column("Layer_Lenght")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Layer_Lenght { get; set; }
			        [Column("Layer_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Layer_Width { get; set; }
			        [Column("Master_Unit_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Master_Unit_Height { get; set; }
			        [Column("Master_Unit_Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Master_Unit_Length { get; set; }
			        [Column("Master_Unit_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Master_Unit_Width { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Number_of_cases_per_tier")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Number_of_cases_per_tier { get; set; }
			        [Column("Number_of_tiers_high_per_pallet")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Number_of_tiers_high_per_pallet { get; set; }
			        [Column("Pack_Code")]        [DataMember]        public string Pack_Code { get; set; }
			        [Column("Pallet_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Height { get; set; }
			        [Column("Pallet_Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Length { get; set; }
			        [Column("Pallet_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Width { get; set; }
			        [Column("Pallet_Wood_Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Wood_Height { get; set; }
			        [Column("Pallet_Wood_Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Wood_Length { get; set; }
			        [Column("Pallet_Wood_Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Pallet_Wood_Width { get; set; }
			        [Column("Unit_Per_Mesure_1")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Unit_Per_Mesure_1 { get; set; }
			        [Column("Unit_Per_Mesure_2")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Unit_Per_Mesure_2 { get; set; }
			        [Column("Unit_Per_Mesure_3")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Unit_Per_Mesure_3 { get; set; }
			        [Column("Unit_Per_Mesure_4")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Unit_Per_Mesure_4 { get; set; }
			        [Column("UOM_CubeDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_CubeDetail_ID { get; set; }
			        [Column("UOM_PackageDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_PackageDetail_ID { get; set; }
			        [Column("UOM_QuantityDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_QuantityDetail_ID { get; set; }
			        [Column("UOM_WeightDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> UOM_WeightDetail_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("Carton_ID")]        public virtual ENT_Cartonization ENT_Cartonization_Carton_ID { get; set; }        [ForeignKey("UOM_CubeDetail_ID")]        public virtual LIST_Code LIST_Code_UOM_CubeDetail_ID { get; set; }        [ForeignKey("UOM_PackageDetail_ID")]        public virtual LIST_Code LIST_Code_UOM_PackageDetail_ID { get; set; }        [ForeignKey("UOM_QuantityDetail_ID")]        public virtual LIST_Code LIST_Code_UOM_QuantityDetail_ID { get; set; }        [ForeignKey("UOM_WeightDetail_ID")]        public virtual LIST_Code LIST_Code_UOM_WeightDetail_ID { get; set; }		        public virtual ICollection<ENT_Item> ENT_Items_Pack_Id { get; set; }        public virtual ICollection<WHS_Adjustment_Detail> WHS_Adjustment_Details_Pack_ID { get; set; }        public virtual ICollection<WHS_ASNDetail> WHS_ASNDetails_Pack_ID { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_Pack_ID { get; set; }        public virtual ICollection<WHS_SO_Detail> WHS_SO_Details_Pack_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Pack> ENT_Pack_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Pack.AsEnumerable().Select(s => new ENT_Pack()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Carton_ID =s.Carton_ID,
										Cartonize_Case =s.Cartonize_Case,
										Cartonize_innerPack =s.Cartonize_innerPack,
										Cartonize_Layer =s.Cartonize_Layer,
										Cartonize_MasterUnit =s.Cartonize_MasterUnit,
										Cartonize_Pallet =s.Cartonize_Pallet,
										Case_Height =s.Case_Height,
										Case_Length =s.Case_Length,
										Case_Width =s.Case_Width,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										Innerpack_Height =s.Innerpack_Height,
										Innerpack_Length =s.Innerpack_Length,
										Innerpack_Width =s.Innerpack_Width,
										IsDeleted =s.IsDeleted,
										Layer_Height =s.Layer_Height,
										Layer_Lenght =s.Layer_Lenght,
										Layer_Width =s.Layer_Width,
										Master_Unit_Height =s.Master_Unit_Height,
										Master_Unit_Length =s.Master_Unit_Length,
										Master_Unit_Width =s.Master_Unit_Width,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Number_of_cases_per_tier =s.Number_of_cases_per_tier,
										Number_of_tiers_high_per_pallet =s.Number_of_tiers_high_per_pallet,
										Pack_Code =s.Pack_Code,
										Pallet_Height =s.Pallet_Height,
										Pallet_Length =s.Pallet_Length,
										Pallet_Width =s.Pallet_Width,
										Pallet_Wood_Height =s.Pallet_Wood_Height,
										Pallet_Wood_Length =s.Pallet_Wood_Length,
										Pallet_Wood_Width =s.Pallet_Wood_Width,
										Unit_Per_Mesure_1 =s.Unit_Per_Mesure_1,
										Unit_Per_Mesure_2 =s.Unit_Per_Mesure_2,
										Unit_Per_Mesure_3 =s.Unit_Per_Mesure_3,
										Unit_Per_Mesure_4 =s.Unit_Per_Mesure_4,
										UOM_CubeDetail_ID =s.UOM_CubeDetail_ID,
										UOM_PackageDetail_ID =s.UOM_PackageDetail_ID,
										UOM_QuantityDetail_ID =s.UOM_QuantityDetail_ID,
										UOM_WeightDetail_ID =s.UOM_WeightDetail_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Pack>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Pack> ENT_Pack_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Pack_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Pack.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Carton_ID =s.Carton_ID,
										Cartonize_Case =s.Cartonize_Case,
										Cartonize_innerPack =s.Cartonize_innerPack,
										Cartonize_Layer =s.Cartonize_Layer,
										Cartonize_MasterUnit =s.Cartonize_MasterUnit,
										Cartonize_Pallet =s.Cartonize_Pallet,
										Case_Height =s.Case_Height,
										Case_Length =s.Case_Length,
										Case_Width =s.Case_Width,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										Innerpack_Height =s.Innerpack_Height,
										Innerpack_Length =s.Innerpack_Length,
										Innerpack_Width =s.Innerpack_Width,
										IsDeleted =s.IsDeleted,
										Layer_Height =s.Layer_Height,
										Layer_Lenght =s.Layer_Lenght,
										Layer_Width =s.Layer_Width,
										Master_Unit_Height =s.Master_Unit_Height,
										Master_Unit_Length =s.Master_Unit_Length,
										Master_Unit_Width =s.Master_Unit_Width,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Number_of_cases_per_tier =s.Number_of_cases_per_tier,
										Number_of_tiers_high_per_pallet =s.Number_of_tiers_high_per_pallet,
										Pack_Code =s.Pack_Code,
										Pallet_Height =s.Pallet_Height,
										Pallet_Length =s.Pallet_Length,
										Pallet_Width =s.Pallet_Width,
										Pallet_Wood_Height =s.Pallet_Wood_Height,
										Pallet_Wood_Length =s.Pallet_Wood_Length,
										Pallet_Wood_Width =s.Pallet_Wood_Width,
										Unit_Per_Mesure_1 =s.Unit_Per_Mesure_1,
										Unit_Per_Mesure_2 =s.Unit_Per_Mesure_2,
										Unit_Per_Mesure_3 =s.Unit_Per_Mesure_3,
										Unit_Per_Mesure_4 =s.Unit_Per_Mesure_4,
										UOM_CubeDetail_ID =s.UOM_CubeDetail_ID,
										UOM_PackageDetail_ID =s.UOM_PackageDetail_ID,
										UOM_QuantityDetail_ID =s.UOM_QuantityDetail_ID,
										UOM_WeightDetail_ID =s.UOM_WeightDetail_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Pack_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Pack ENT_Pack_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Pack.Where(d => d.ID == ID).FirstOrDefault<ENT_Pack>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Pack_Create(IEnumerable<ENT_Pack> items, string CreatedBy)
        {
            string ENT_Pack_List = string.Empty;
            string ENT_Pack_List_Serialized = string.Empty;
            string ENT_Pack_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Pack> result = new List<ENT_Pack>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Pack item in items)
                {
                    ENT_Pack dbItem = new ENT_Pack();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Carton_ID =item.Carton_ID;
								dbItem.Cartonize_Case =item.Cartonize_Case;
								dbItem.Cartonize_innerPack =item.Cartonize_innerPack;
								dbItem.Cartonize_Layer =item.Cartonize_Layer;
								dbItem.Cartonize_MasterUnit =item.Cartonize_MasterUnit;
								dbItem.Cartonize_Pallet =item.Cartonize_Pallet;
								dbItem.Case_Height =item.Case_Height;
								dbItem.Case_Length =item.Case_Length;
								dbItem.Case_Width =item.Case_Width;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.Innerpack_Height =item.Innerpack_Height;
								dbItem.Innerpack_Length =item.Innerpack_Length;
								dbItem.Innerpack_Width =item.Innerpack_Width;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Layer_Height =item.Layer_Height;
								dbItem.Layer_Lenght =item.Layer_Lenght;
								dbItem.Layer_Width =item.Layer_Width;
								dbItem.Master_Unit_Height =item.Master_Unit_Height;
								dbItem.Master_Unit_Length =item.Master_Unit_Length;
								dbItem.Master_Unit_Width =item.Master_Unit_Width;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Number_of_cases_per_tier =item.Number_of_cases_per_tier;
								dbItem.Number_of_tiers_high_per_pallet =item.Number_of_tiers_high_per_pallet;
								dbItem.Pack_Code =item.Pack_Code;
								dbItem.Pallet_Height =item.Pallet_Height;
								dbItem.Pallet_Length =item.Pallet_Length;
								dbItem.Pallet_Width =item.Pallet_Width;
								dbItem.Pallet_Wood_Height =item.Pallet_Wood_Height;
								dbItem.Pallet_Wood_Length =item.Pallet_Wood_Length;
								dbItem.Pallet_Wood_Width =item.Pallet_Wood_Width;
								dbItem.Unit_Per_Mesure_1 =item.Unit_Per_Mesure_1;
								dbItem.Unit_Per_Mesure_2 =item.Unit_Per_Mesure_2;
								dbItem.Unit_Per_Mesure_3 =item.Unit_Per_Mesure_3;
								dbItem.Unit_Per_Mesure_4 =item.Unit_Per_Mesure_4;
								dbItem.UOM_CubeDetail_ID =item.UOM_CubeDetail_ID;
								dbItem.UOM_PackageDetail_ID =item.UOM_PackageDetail_ID;
								dbItem.UOM_QuantityDetail_ID =item.UOM_QuantityDetail_ID;
								dbItem.UOM_WeightDetail_ID =item.UOM_WeightDetail_ID;
					                   
                    ENT_Pack_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Pack.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Pack_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Pack_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Pack_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Pack_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Pack_Create: {1} - {2}", CreatedBy, ENT_Pack_List, ENT_Pack_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Pack_Create(ENT_Pack item, string CreatedBy)
        {
            string ENT_Pack_List = string.Empty;
            string ENT_Pack_List_Serialized = string.Empty;
            string ENT_Pack_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Pack> result = new List<ENT_Pack>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Pack dbItem = new ENT_Pack();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Carton_ID =item.Carton_ID;
								dbItem.Cartonize_Case =item.Cartonize_Case;
								dbItem.Cartonize_innerPack =item.Cartonize_innerPack;
								dbItem.Cartonize_Layer =item.Cartonize_Layer;
								dbItem.Cartonize_MasterUnit =item.Cartonize_MasterUnit;
								dbItem.Cartonize_Pallet =item.Cartonize_Pallet;
								dbItem.Case_Height =item.Case_Height;
								dbItem.Case_Length =item.Case_Length;
								dbItem.Case_Width =item.Case_Width;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.Innerpack_Height =item.Innerpack_Height;
								dbItem.Innerpack_Length =item.Innerpack_Length;
								dbItem.Innerpack_Width =item.Innerpack_Width;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Layer_Height =item.Layer_Height;
								dbItem.Layer_Lenght =item.Layer_Lenght;
								dbItem.Layer_Width =item.Layer_Width;
								dbItem.Master_Unit_Height =item.Master_Unit_Height;
								dbItem.Master_Unit_Length =item.Master_Unit_Length;
								dbItem.Master_Unit_Width =item.Master_Unit_Width;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Number_of_cases_per_tier =item.Number_of_cases_per_tier;
								dbItem.Number_of_tiers_high_per_pallet =item.Number_of_tiers_high_per_pallet;
								dbItem.Pack_Code =item.Pack_Code;
								dbItem.Pallet_Height =item.Pallet_Height;
								dbItem.Pallet_Length =item.Pallet_Length;
								dbItem.Pallet_Width =item.Pallet_Width;
								dbItem.Pallet_Wood_Height =item.Pallet_Wood_Height;
								dbItem.Pallet_Wood_Length =item.Pallet_Wood_Length;
								dbItem.Pallet_Wood_Width =item.Pallet_Wood_Width;
								dbItem.Unit_Per_Mesure_1 =item.Unit_Per_Mesure_1;
								dbItem.Unit_Per_Mesure_2 =item.Unit_Per_Mesure_2;
								dbItem.Unit_Per_Mesure_3 =item.Unit_Per_Mesure_3;
								dbItem.Unit_Per_Mesure_4 =item.Unit_Per_Mesure_4;
								dbItem.UOM_CubeDetail_ID =item.UOM_CubeDetail_ID;
								dbItem.UOM_PackageDetail_ID =item.UOM_PackageDetail_ID;
								dbItem.UOM_QuantityDetail_ID =item.UOM_QuantityDetail_ID;
								dbItem.UOM_WeightDetail_ID =item.UOM_WeightDetail_ID;
					                    ENT_Pack_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Pack.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Pack_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Pack_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Pack_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Pack_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Pack_Create: {1} - {2}", CreatedBy, ENT_Pack_List, ENT_Pack_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Pack_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Pack.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Carton_ID =s.Carton_ID,
										Cartonize_Case =s.Cartonize_Case,
										Cartonize_innerPack =s.Cartonize_innerPack,
										Cartonize_Layer =s.Cartonize_Layer,
										Cartonize_MasterUnit =s.Cartonize_MasterUnit,
										Cartonize_Pallet =s.Cartonize_Pallet,
										Case_Height =s.Case_Height,
										Case_Length =s.Case_Length,
										Case_Width =s.Case_Width,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Description =s.Description,
										ID =s.ID,
										Innerpack_Height =s.Innerpack_Height,
										Innerpack_Length =s.Innerpack_Length,
										Innerpack_Width =s.Innerpack_Width,
										IsDeleted =s.IsDeleted,
										Layer_Height =s.Layer_Height,
										Layer_Lenght =s.Layer_Lenght,
										Layer_Width =s.Layer_Width,
										Master_Unit_Height =s.Master_Unit_Height,
										Master_Unit_Length =s.Master_Unit_Length,
										Master_Unit_Width =s.Master_Unit_Width,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Number_of_cases_per_tier =s.Number_of_cases_per_tier,
										Number_of_tiers_high_per_pallet =s.Number_of_tiers_high_per_pallet,
										Pack_Code =s.Pack_Code,
										Pallet_Height =s.Pallet_Height,
										Pallet_Length =s.Pallet_Length,
										Pallet_Width =s.Pallet_Width,
										Pallet_Wood_Height =s.Pallet_Wood_Height,
										Pallet_Wood_Length =s.Pallet_Wood_Length,
										Pallet_Wood_Width =s.Pallet_Wood_Width,
										Unit_Per_Mesure_1 =s.Unit_Per_Mesure_1,
										Unit_Per_Mesure_2 =s.Unit_Per_Mesure_2,
										Unit_Per_Mesure_3 =s.Unit_Per_Mesure_3,
										Unit_Per_Mesure_4 =s.Unit_Per_Mesure_4,
										UOM_CubeDetail_ID =s.UOM_CubeDetail_ID,
										UOM_PackageDetail_ID =s.UOM_PackageDetail_ID,
										UOM_QuantityDetail_ID =s.UOM_QuantityDetail_ID,
										UOM_WeightDetail_ID =s.UOM_WeightDetail_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Pack_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Pack_Update(IEnumerable<ENT_Pack> items, string ModifiedBy)
        {
            string ENT_Pack_List = string.Empty;
            string ENT_Pack_List_Serialized = string.Empty;
            string ENT_Pack_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Pack item in items)
                {
                    ENT_Pack dbItem = model.DBSet_ENT_Pack.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Pack_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Carton_ID =item.Carton_ID;
								dbItem.Cartonize_Case =item.Cartonize_Case;
								dbItem.Cartonize_innerPack =item.Cartonize_innerPack;
								dbItem.Cartonize_Layer =item.Cartonize_Layer;
								dbItem.Cartonize_MasterUnit =item.Cartonize_MasterUnit;
								dbItem.Cartonize_Pallet =item.Cartonize_Pallet;
								dbItem.Case_Height =item.Case_Height;
								dbItem.Case_Length =item.Case_Length;
								dbItem.Case_Width =item.Case_Width;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Description =item.Description;
								dbItem.ID =item.ID;
								dbItem.Innerpack_Height =item.Innerpack_Height;
								dbItem.Innerpack_Length =item.Innerpack_Length;
								dbItem.Innerpack_Width =item.Innerpack_Width;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Layer_Height =item.Layer_Height;
								dbItem.Layer_Lenght =item.Layer_Lenght;
								dbItem.Layer_Width =item.Layer_Width;
								dbItem.Master_Unit_Height =item.Master_Unit_Height;
								dbItem.Master_Unit_Length =item.Master_Unit_Length;
								dbItem.Master_Unit_Width =item.Master_Unit_Width;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Number_of_cases_per_tier =item.Number_of_cases_per_tier;
								dbItem.Number_of_tiers_high_per_pallet =item.Number_of_tiers_high_per_pallet;
								dbItem.Pack_Code =item.Pack_Code;
								dbItem.Pallet_Height =item.Pallet_Height;
								dbItem.Pallet_Length =item.Pallet_Length;
								dbItem.Pallet_Width =item.Pallet_Width;
								dbItem.Pallet_Wood_Height =item.Pallet_Wood_Height;
								dbItem.Pallet_Wood_Length =item.Pallet_Wood_Length;
								dbItem.Pallet_Wood_Width =item.Pallet_Wood_Width;
								dbItem.Unit_Per_Mesure_1 =item.Unit_Per_Mesure_1;
								dbItem.Unit_Per_Mesure_2 =item.Unit_Per_Mesure_2;
								dbItem.Unit_Per_Mesure_3 =item.Unit_Per_Mesure_3;
								dbItem.Unit_Per_Mesure_4 =item.Unit_Per_Mesure_4;
								dbItem.UOM_CubeDetail_ID =item.UOM_CubeDetail_ID;
								dbItem.UOM_PackageDetail_ID =item.UOM_PackageDetail_ID;
								dbItem.UOM_QuantityDetail_ID =item.UOM_QuantityDetail_ID;
								dbItem.UOM_WeightDetail_ID =item.UOM_WeightDetail_ID;
					                        

                        ENT_Pack_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Pack_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Pack_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Pack_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Pack_Update: {1} - {2}", ModifiedBy, ENT_Pack_List, ENT_Pack_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Pack_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Pack_List = string.Empty;
            string ENT_Pack_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Pack> sendToTrashList = model.DBSet_ENT_Pack.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Pack item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Pack_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Pack_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Pack_Destroy: {1}", ModifiedBy, ENT_Pack_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

