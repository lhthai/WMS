// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Cartonization
//    File Name         : ENT_Cartonization.cs
//    Properties        : Carton_Group; Carton_Type; Cartonization_Code; Container_Type; CreatedBy; CreatedDate; Cube; Description; Height; ID; IsDeleted; Length; Maximum_Unit; Maximum_Weight; ModifiedBy; ModifiedDate; Sequence; Tare_Weight; Width;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; Carton_Group; Carton_Type; Cartonization_Code; Container_Type; CreatedBy; CreatedDate; Cube; Description; Height; ID; IsDeleted; Length; Maximum_Unit; Maximum_Weight; ModifiedBy; ModifiedDate; Sequence; Tare_Weight; Width; ENT_Packs_Carton_ID;
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
	[Table("tbl_ENT_Cartonization")]
    [Serializable]
	[DataContract]
    public partial class ENT_Cartonization
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("Carton_Group")]        [DataMember]        public string Carton_Group { get; set; }
			        [Column("Carton_Type")]        [DataMember]        public string Carton_Type { get; set; }
			        [Column("Cartonization_Code")]        [DataMember]        public string Cartonization_Code { get; set; }
			        [Column("Container_Type")]        [DataMember]        public string Container_Type { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Cube")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Cube { get; set; }
			        [Column("Description")]        [DataMember]        public string Description { get; set; }
			        [Column("Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Height { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_ENT), ErrorMessageResourceName = "Cartonization_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Length { get; set; }
			        [Column("Maximum_Unit")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Maximum_Unit { get; set; }
			        [Column("Maximum_Weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Maximum_Weight { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Sequence")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Sequence { get; set; }
			        [Column("Tare_Weight")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Tare_Weight { get; set; }
			        [Column("Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Width { get; set; }
					
		#region Navigation properties for creating ForeignKey
				        public virtual ICollection<ENT_Item> ENT_Items_Carton_ID { get; set; }        public virtual ICollection<ENT_Owner> ENT_Owners_Cartonization_ID { get; set; }        public virtual ICollection<ENT_Pack> ENT_Packs_Carton_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class ENT
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<ENT_Cartonization> ENT_Cartonization_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Cartonization.AsEnumerable().Select(s => new ENT_Cartonization()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Carton_Group =s.Carton_Group,
										Carton_Type =s.Carton_Type,
										Cartonization_Code =s.Cartonization_Code,
										Container_Type =s.Container_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										Description =s.Description,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Maximum_Unit =s.Maximum_Unit,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										Tare_Weight =s.Tare_Weight,
										Width =s.Width,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<ENT_Cartonization>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<ENT_Cartonization> ENT_Cartonization_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult ENT_Cartonization_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_ENT_Cartonization.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										Carton_Group =s.Carton_Group,
										Carton_Type =s.Carton_Type,
										Cartonization_Code =s.Cartonization_Code,
										Container_Type =s.Container_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										Description =s.Description,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Maximum_Unit =s.Maximum_Unit,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										Tare_Weight =s.Tare_Weight,
										Width =s.Width,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult ENT_Cartonization_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public ENT_Cartonization ENT_Cartonization_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_ENT_Cartonization.Where(d => d.ID == ID).FirstOrDefault<ENT_Cartonization>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult ENT_Cartonization_Create(IEnumerable<ENT_Cartonization> items, string CreatedBy)
        {
            string ENT_Cartonization_List = string.Empty;
            string ENT_Cartonization_List_Serialized = string.Empty;
            string ENT_Cartonization_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Cartonization> result = new List<ENT_Cartonization>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Cartonization item in items)
                {
                    ENT_Cartonization dbItem = new ENT_Cartonization();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Carton_Group =item.Carton_Group;
								dbItem.Carton_Type =item.Carton_Type;
								dbItem.Cartonization_Code =item.Cartonization_Code;
								dbItem.Container_Type =item.Container_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.Description =item.Description;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Maximum_Unit =item.Maximum_Unit;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.Tare_Weight =item.Tare_Weight;
								dbItem.Width =item.Width;
					                   
                    ENT_Cartonization_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_ENT_Cartonization.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Cartonization_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Cartonization_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(ENT_Cartonization_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + ENT_Cartonization_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - ENT_Cartonization_Create: {1} - {2}", CreatedBy, ENT_Cartonization_List, ENT_Cartonization_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult ENT_Cartonization_Create(ENT_Cartonization item, string CreatedBy)
        {
            string ENT_Cartonization_List = string.Empty;
            string ENT_Cartonization_List_Serialized = string.Empty;
            string ENT_Cartonization_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<ENT_Cartonization> result = new List<ENT_Cartonization>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    ENT_Cartonization dbItem = new ENT_Cartonization();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.Carton_Group =item.Carton_Group;
								dbItem.Carton_Type =item.Carton_Type;
								dbItem.Cartonization_Code =item.Cartonization_Code;
								dbItem.Container_Type =item.Container_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.Description =item.Description;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Maximum_Unit =item.Maximum_Unit;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.Tare_Weight =item.Tare_Weight;
								dbItem.Width =item.Width;
					                    ENT_Cartonization_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_ENT_Cartonization.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    ENT_Cartonization_List += "[" + item.ID + "] ";

                    result.Add(item);
                    ENT_Cartonization_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(ENT_Cartonization_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + ENT_Cartonization_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Cartonization_Create: {1} - {2}", CreatedBy, ENT_Cartonization_List, ENT_Cartonization_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult ENT_Cartonization_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_ENT_Cartonization.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										Carton_Group =s.Carton_Group,
										Carton_Type =s.Carton_Type,
										Cartonization_Code =s.Cartonization_Code,
										Container_Type =s.Container_Type,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cube =s.Cube,
										Description =s.Description,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Maximum_Unit =s.Maximum_Unit,
										Maximum_Weight =s.Maximum_Weight,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Sequence =s.Sequence,
										Tare_Weight =s.Tare_Weight,
										Width =s.Width,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult ENT_Cartonization_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool ENT_Cartonization_Update(IEnumerable<ENT_Cartonization> items, string ModifiedBy)
        {
            string ENT_Cartonization_List = string.Empty;
            string ENT_Cartonization_List_Serialized = string.Empty;
            string ENT_Cartonization_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (ENT_Cartonization item in items)
                {
                    ENT_Cartonization dbItem = model.DBSet_ENT_Cartonization.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        ENT_Cartonization_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.Carton_Group =item.Carton_Group;
								dbItem.Carton_Type =item.Carton_Type;
								dbItem.Cartonization_Code =item.Cartonization_Code;
								dbItem.Container_Type =item.Container_Type;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cube =item.Cube;
								dbItem.Description =item.Description;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Maximum_Unit =item.Maximum_Unit;
								dbItem.Maximum_Weight =item.Maximum_Weight;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Sequence =item.Sequence;
								dbItem.Tare_Weight =item.Tare_Weight;
								dbItem.Width =item.Width;
					                        

                        ENT_Cartonization_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        ENT_Cartonization_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(ENT_Cartonization_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Cartonization_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Cartonization_Update: {1} - {2}", ModifiedBy, ENT_Cartonization_List, ENT_Cartonization_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string ENT_Cartonization_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string ENT_Cartonization_List = string.Empty;
            string ENT_Cartonization_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<ENT_Cartonization> sendToTrashList = model.DBSet_ENT_Cartonization.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (ENT_Cartonization item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(ENT_Cartonization_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + ENT_Cartonization_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - ENT_Cartonization_Destroy: {1}", ModifiedBy, ENT_Cartonization_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

