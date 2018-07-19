// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//    Citem Name        : Location
//    File Name         : WHS_Location.cs
//    Properties        : C_System_MovingspeedDetail_ID; Category_ID; Comingleitems; Cominglelots; CreatedBy; CreatedDate; Cubic_Capacity; Flag_ID; Foot_Print; Height; ID; IsDeleted; Length; Level; Location_Code; Location_StatusDetail_ID; Location_Type_ID; LocationhandlingDetail_ID; ModifiedBy; ModifiedDate; Movingspeed_ID; Orientation; Stack_Limit; Status; Weight_Capacity; Width; X_coordinate; Y_coordinate; Z_coordinate; Zone_ID;
//    Not Change        :
//    Old Properties    : IsSelected; TagStr; C_System_MovingspeedDetail_ID; Category_ID; Comingleitems; Cominglelots; CreatedBy; CreatedDate; Cubic_Capacity; Flag_ID; Foot_Print; Height; ID; IsDeleted; Length; Level; Location_Code; Location_StatusDetail_ID; Location_Type_ID; LocationhandlingDetail_ID; ModifiedBy; ModifiedDate; Movingspeed_ID; Orientation; Stack_Limit; Status; Weight_Capacity; Width; X_coordinate; Y_coordinate; Z_coordinate; Zone_ID; WHS_Zones_Location_ID;
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
	[Table("tbl_WHS_Location")]
    [Serializable]
	[DataContract]
    public partial class WHS_Location
    {
        //[begin coding block]//[end coding block]

        #region properties
		[NotMapped]
		[DataMember]
        public bool IsSelected { get; set; }
		[NotMapped]
		[DataMember]
        public string TagStr { get; set; }
                [Column("C_System_MovingspeedDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> C_System_MovingspeedDetail_ID { get; set; }
			        [Column("Category_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Category_ID { get; set; }
			        [Column("Comingleitems")]        [DataMember]        public Nullable<bool> Comingleitems { get; set; }
			        [Column("Cominglelots")]        [DataMember]        public Nullable<bool> Cominglelots { get; set; }
			        [Column("CreatedBy")]        [DataMember]        public string CreatedBy { get; set; }
			        [Column("CreatedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> CreatedDate { get; set; }
			        [Column("Cubic_Capacity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Cubic_Capacity { get; set; }
			        [Column("Flag_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Flag_ID { get; set; }
			        [Column("Foot_Print")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Foot_Print { get; set; }
			        [Column("Height")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Height { get; set; }
			        [Column("ID")]        [DataMember]        [Key]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Location_ID_Required")]        public int ID { get; set; }
			        [Column("IsDeleted")]        [DataMember]        public Nullable<bool> IsDeleted { get; set; }
			        [Column("Length")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Length { get; set; }
			        [Column("Level")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Level { get; set; }
			        [Column("Location_Code")]        [DataMember]        public string Location_Code { get; set; }
			        [Column("Location_StatusDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Location_StatusDetail_ID { get; set; }
			        [Column("Location_Type_ID")]        [DataMember]        [UIHint("Integer")]        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.lang_WHS), ErrorMessageResourceName = "Location_Location_Type_ID_Required")]        public int Location_Type_ID { get; set; }
			        [Column("LocationhandlingDetail_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> LocationhandlingDetail_ID { get; set; }
			        [Column("ModifiedBy")]        [DataMember]        public string ModifiedBy { get; set; }
			        [Column("ModifiedDate")]        [DataMember]        [DataType(DataType.Date)]        public Nullable<DateTime> ModifiedDate { get; set; }
			        [Column("Movingspeed_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Movingspeed_ID { get; set; }
			        [Column("Orientation")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Orientation { get; set; }
			        [Column("Stack_Limit")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Stack_Limit { get; set; }
			        [Column("Status")]        [DataMember]        public string Status { get; set; }
			        [Column("Weight_Capacity")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Weight_Capacity { get; set; }
			        [Column("Width")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Width { get; set; }
			        [Column("X_coordinate")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> X_coordinate { get; set; }
			        [Column("Y_coordinate")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Y_coordinate { get; set; }
			        [Column("Z_coordinate")]        [DataMember]        [UIHint("Decimal")]        public Nullable<decimal> Z_coordinate { get; set; }
			        [Column("Zone_ID")]        [DataMember]        [UIHint("Integer")]        public Nullable<int> Zone_ID { get; set; }
					
		#region Navigation properties for creating ForeignKey
		        [ForeignKey("C_System_MovingspeedDetail_ID")]        public virtual LIST_Code LIST_Code_C_System_MovingspeedDetail_ID { get; set; }        [ForeignKey("Category_ID")]        public virtual LIST_Code LIST_Code_Category_ID { get; set; }        [ForeignKey("Flag_ID")]        public virtual LIST_Code LIST_Code_Flag_ID { get; set; }        [ForeignKey("Location_StatusDetail_ID")]        public virtual LIST_Code LIST_Code_Location_StatusDetail_ID { get; set; }        [ForeignKey("Location_Type_ID")]        public virtual LIST_Code LIST_Code_Location_Type_ID { get; set; }        [ForeignKey("LocationhandlingDetail_ID")]        public virtual LIST_Code LIST_Code_LocationhandlingDetail_ID { get; set; }        [ForeignKey("Movingspeed_ID")]        public virtual LIST_Code LIST_Code_Movingspeed_ID { get; set; }        [ForeignKey("Zone_ID")]        public virtual WHS_Zone WHS_Zone_Zone_ID { get; set; }		        public virtual ICollection<ENT_Item> ENT_Items_Location_ID { get; set; }        public virtual ICollection<WHS_ASNDetail> WHS_ASNDetails_Location_ID { get; set; }        public virtual ICollection<WHS_Maintain_Hold> WHS_Maintain_Holds_Location_ID { get; set; }        public virtual ICollection<WHS_Move> WHS_Moves_Location_ID { get; set; }        public virtual ICollection<WHS_Pick_Detail> WHS_Pick_Details_Location_ID { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_from_location { get; set; }        public virtual ICollection<WHS_Strategy_Putaway_Step> WHS_Strategy_Putaway_Steps_to_location { get; set; }        public virtual ICollection<WHS_Zone> WHS_Zones_Location_ID { get; set; }

		#endregion
		
        #endregion
    }





	public partial class WHS
    {	
		//[begin coding function block]//[end coding function block]
			        #region QueryFunctions
        public IEnumerable<WHS_Location> WHS_Location_Query(Kendo.Mvc.UI.DataSourceRequest request, out int Total)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Location.AsEnumerable().Select(s => new WHS_Location()
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_MovingspeedDetail_ID =s.C_System_MovingspeedDetail_ID,
										Category_ID =s.Category_ID,
										Comingleitems =s.Comingleitems,
										Cominglelots =s.Cominglelots,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cubic_Capacity =s.Cubic_Capacity,
										Flag_ID =s.Flag_ID,
										Foot_Print =s.Foot_Print,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Level =s.Level,
										Location_Code =s.Location_Code,
										Location_StatusDetail_ID =s.Location_StatusDetail_ID,
										Location_Type_ID =s.Location_Type_ID,
										LocationhandlingDetail_ID =s.LocationhandlingDetail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Movingspeed_ID =s.Movingspeed_ID,
										Orientation =s.Orientation,
										Stack_Limit =s.Stack_Limit,
										Status =s.Status,
										Weight_Capacity =s.Weight_Capacity,
										Width =s.Width,
										X_coordinate =s.X_coordinate,
										Y_coordinate =s.Y_coordinate,
										Z_coordinate =s.Z_coordinate,
										Zone_ID =s.Zone_ID,
					               
                })                
                .ToDataSourceResult(request);
                Total = result.Total;
                return result.Data as IEnumerable<WHS_Location>;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "IEnumerable<WHS_Location> WHS_Location_Query", ex.Message));
                Total = 0;
                return null;
            }
            
        }


		public DataSourceResult WHS_Location_Query(Kendo.Mvc.UI.DataSourceRequest request)
        {
			try
            {
                WMS.Models.DBContext model = new DBContext();
                var result = model.DBSet_WHS_Location.AsEnumerable().Select(s => new 
                {
					IsSelected = false,
					TagStr = s.TagStr,
										C_System_MovingspeedDetail_ID =s.C_System_MovingspeedDetail_ID,
										Category_ID =s.Category_ID,
										Comingleitems =s.Comingleitems,
										Cominglelots =s.Cominglelots,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cubic_Capacity =s.Cubic_Capacity,
										Flag_ID =s.Flag_ID,
										Foot_Print =s.Foot_Print,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Level =s.Level,
										Location_Code =s.Location_Code,
										Location_StatusDetail_ID =s.Location_StatusDetail_ID,
										Location_Type_ID =s.Location_Type_ID,
										LocationhandlingDetail_ID =s.LocationhandlingDetail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Movingspeed_ID =s.Movingspeed_ID,
										Orientation =s.Orientation,
										Stack_Limit =s.Stack_Limit,
										Status =s.Status,
										Weight_Capacity =s.Weight_Capacity,
										Width =s.Width,
										X_coordinate =s.X_coordinate,
										Y_coordinate =s.Y_coordinate,
										Z_coordinate =s.Z_coordinate,
										Zone_ID =s.Zone_ID,
					               
                })                
                .ToDataSourceResult(request);
                
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "DataSourceResult WHS_Location_Query", ex.Message));
              
                return null;
            }
            
        }
	

		 public WHS_Location WHS_Location_GetByID(int ID)
        {
            WMS.Models.DBContext model = new DBContext();
            return model.DBSet_WHS_Location.Where(d => d.ID == ID).FirstOrDefault<WHS_Location>();
        }
       
        #endregion
		#region CRUD
		#region Create
        public DataSourceResult WHS_Location_Create(IEnumerable<WHS_Location> items, string CreatedBy)
        {
            string WHS_Location_List = string.Empty;
            string WHS_Location_List_Serialized = string.Empty;
            string WHS_Location_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Location> result = new List<WHS_Location>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Location item in items)
                {
                    WHS_Location dbItem = new WHS_Location();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_MovingspeedDetail_ID =item.C_System_MovingspeedDetail_ID;
								dbItem.Category_ID =item.Category_ID;
								dbItem.Comingleitems =item.Comingleitems;
								dbItem.Cominglelots =item.Cominglelots;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cubic_Capacity =item.Cubic_Capacity;
								dbItem.Flag_ID =item.Flag_ID;
								dbItem.Foot_Print =item.Foot_Print;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Level =item.Level;
								dbItem.Location_Code =item.Location_Code;
								dbItem.Location_StatusDetail_ID =item.Location_StatusDetail_ID;
								dbItem.Location_Type_ID =item.Location_Type_ID;
								dbItem.LocationhandlingDetail_ID =item.LocationhandlingDetail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Movingspeed_ID =item.Movingspeed_ID;
								dbItem.Orientation =item.Orientation;
								dbItem.Stack_Limit =item.Stack_Limit;
								dbItem.Status =item.Status;
								dbItem.Weight_Capacity =item.Weight_Capacity;
								dbItem.Width =item.Width;
								dbItem.X_coordinate =item.X_coordinate;
								dbItem.Y_coordinate =item.Y_coordinate;
								dbItem.Z_coordinate =item.Z_coordinate;
								dbItem.Zone_ID =item.Zone_ID;
					                   
                    WHS_Location_Items_Serialized += Common.SerializeObject(item);  
                    model.DBSet_WHS_Location.Add(dbItem);
                     Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Location_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Location_List_Serialized += Common.SerializeObject(item);
                }
				
            }
            catch (Exception ex)
            {
                message = ex.Message;
                 Common.log.Error(WHS_Location_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                     Common.log.Warn(CreatedBy + " => " + WHS_Location_Items_Serialized, new Exception(message));
                }
                 Common.log.Info(string.Format("User: {0} - [end] - WHS_Location_Create: {1} - {2}", CreatedBy, WHS_Location_List, WHS_Location_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		 public DataSourceResult WHS_Location_Create(WHS_Location item, string CreatedBy)
        {
            string WHS_Location_List = string.Empty;
            string WHS_Location_List_Serialized = string.Empty;
            string WHS_Location_Items_Serialized = string.Empty;

            string message = string.Empty;
            List<WHS_Location> result = new List<WHS_Location>();
            try
            {
                WMS.Models.DBContext model = new DBContext();
                
                    WHS_Location dbItem = new WHS_Location();

                    item.CreatedBy = item.ModifiedBy = CreatedBy;
                    item.CreatedDate = item.ModifiedDate = Common.getUTCDate();
					dbItem.IsSelected = item.IsSelected;
					dbItem.TagStr = item.TagStr;
								dbItem.C_System_MovingspeedDetail_ID =item.C_System_MovingspeedDetail_ID;
								dbItem.Category_ID =item.Category_ID;
								dbItem.Comingleitems =item.Comingleitems;
								dbItem.Cominglelots =item.Cominglelots;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cubic_Capacity =item.Cubic_Capacity;
								dbItem.Flag_ID =item.Flag_ID;
								dbItem.Foot_Print =item.Foot_Print;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Level =item.Level;
								dbItem.Location_Code =item.Location_Code;
								dbItem.Location_StatusDetail_ID =item.Location_StatusDetail_ID;
								dbItem.Location_Type_ID =item.Location_Type_ID;
								dbItem.LocationhandlingDetail_ID =item.LocationhandlingDetail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Movingspeed_ID =item.Movingspeed_ID;
								dbItem.Orientation =item.Orientation;
								dbItem.Stack_Limit =item.Stack_Limit;
								dbItem.Status =item.Status;
								dbItem.Weight_Capacity =item.Weight_Capacity;
								dbItem.Width =item.Width;
								dbItem.X_coordinate =item.X_coordinate;
								dbItem.Y_coordinate =item.Y_coordinate;
								dbItem.Z_coordinate =item.Z_coordinate;
								dbItem.Zone_ID =item.Zone_ID;
					                    WHS_Location_Items_Serialized += Common.SerializeObject(item);
                    model.DBSet_WHS_Location.Add(dbItem);
                    Common.SaveChanges(model);

                    item.ID = dbItem.ID;
                    WHS_Location_List += "[" + item.ID + "] ";

                    result.Add(item);
                    WHS_Location_List_Serialized += Common.SerializeObject(item);
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                Common.log.Error(WHS_Location_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Common.log.Warn(CreatedBy + " => " + WHS_Location_Items_Serialized, new Exception(message));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Location_Create: {1} - {2}", CreatedBy, WHS_Location_List, WHS_Location_List_Serialized));
            }
            return result.ToDataSourceResult(new DataSourceRequest ());
        }
		#endregion
		 #region Read
        public DataSourceResult WHS_Location_Read(Kendo.Mvc.UI.DataSourceRequest request)
        {
            try
            {
                WMS.Models.DBContext model = new DBContext();
                var  result = model.DBSet_WHS_Location.AsEnumerable().Select(s => new 
                {
                   IsSelected = false,
					TagStr = s.TagStr,
										C_System_MovingspeedDetail_ID =s.C_System_MovingspeedDetail_ID,
										Category_ID =s.Category_ID,
										Comingleitems =s.Comingleitems,
										Cominglelots =s.Cominglelots,
										CreatedBy =s.CreatedBy,
										CreatedDate =s.CreatedDate,
										Cubic_Capacity =s.Cubic_Capacity,
										Flag_ID =s.Flag_ID,
										Foot_Print =s.Foot_Print,
										Height =s.Height,
										ID =s.ID,
										IsDeleted =s.IsDeleted,
										Length =s.Length,
										Level =s.Level,
										Location_Code =s.Location_Code,
										Location_StatusDetail_ID =s.Location_StatusDetail_ID,
										Location_Type_ID =s.Location_Type_ID,
										LocationhandlingDetail_ID =s.LocationhandlingDetail_ID,
										ModifiedBy =s.ModifiedBy,
										ModifiedDate =s.ModifiedDate,
										Movingspeed_ID =s.Movingspeed_ID,
										Orientation =s.Orientation,
										Stack_Limit =s.Stack_Limit,
										Status =s.Status,
										Weight_Capacity =s.Weight_Capacity,
										Width =s.Width,
										X_coordinate =s.X_coordinate,
										Y_coordinate =s.Y_coordinate,
										Z_coordinate =s.Z_coordinate,
										Zone_ID =s.Zone_ID,
					                })               
                .ToDataSourceResult(request);
                return result;
            }
            catch (Exception ex)
            {
                Common.log.Error(ex.Message, ex);
                Common.log.Info(string.Format("Function: {0} - [error message]: {1}", "MyDataSourceResult WHS_Location_Read", ex.Message));
                return null;
            }
        }
        #endregion
		 #region Update
        public bool WHS_Location_Update(IEnumerable<WHS_Location> items, string ModifiedBy)
        {
            string WHS_Location_List = string.Empty;
            string WHS_Location_List_Serialized = string.Empty;
            string WHS_Location_Items_Serialized = string.Empty;

            string result = string.Empty;
			bool flag = true;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                foreach (WHS_Location item in items)
                {
                    WHS_Location dbItem = model.DBSet_WHS_Location.Where(d => d.ID == item.ID).FirstOrDefault();
                    if (dbItem != null)
                    {
                        WHS_Location_List += "[" + item.ID + "] ";
                        item.ModifiedBy = ModifiedBy;
                        item.ModifiedDate = Common.getUTCDate();
                        if (item.CreatedDate == DateTime.MinValue)
                            item.CreatedDate = dbItem.CreatedDate;
							dbItem.IsSelected = item.IsSelected;
							dbItem.TagStr = item.TagStr;
                        				dbItem.C_System_MovingspeedDetail_ID =item.C_System_MovingspeedDetail_ID;
								dbItem.Category_ID =item.Category_ID;
								dbItem.Comingleitems =item.Comingleitems;
								dbItem.Cominglelots =item.Cominglelots;
								dbItem.CreatedBy =item.CreatedBy;
								dbItem.CreatedDate =item.CreatedDate;
								dbItem.Cubic_Capacity =item.Cubic_Capacity;
								dbItem.Flag_ID =item.Flag_ID;
								dbItem.Foot_Print =item.Foot_Print;
								dbItem.Height =item.Height;
								dbItem.ID =item.ID;
								dbItem.IsDeleted =item.IsDeleted;
								dbItem.Length =item.Length;
								dbItem.Level =item.Level;
								dbItem.Location_Code =item.Location_Code;
								dbItem.Location_StatusDetail_ID =item.Location_StatusDetail_ID;
								dbItem.Location_Type_ID =item.Location_Type_ID;
								dbItem.LocationhandlingDetail_ID =item.LocationhandlingDetail_ID;
								dbItem.ModifiedBy =item.ModifiedBy;
								dbItem.ModifiedDate =item.ModifiedDate;
								dbItem.Movingspeed_ID =item.Movingspeed_ID;
								dbItem.Orientation =item.Orientation;
								dbItem.Stack_Limit =item.Stack_Limit;
								dbItem.Status =item.Status;
								dbItem.Weight_Capacity =item.Weight_Capacity;
								dbItem.Width =item.Width;
								dbItem.X_coordinate =item.X_coordinate;
								dbItem.Y_coordinate =item.Y_coordinate;
								dbItem.Z_coordinate =item.Z_coordinate;
								dbItem.Zone_ID =item.Zone_ID;
					                        

                        WHS_Location_Items_Serialized += Common.SerializeObject(item);
                        Common.SaveChanges(model);
                        WHS_Location_List_Serialized += Common.SerializeObject(item);
                    }
                }
            }
            catch (Exception ex)
            {
				flag = false;
                result = ex.Message;
                Common.log.Error(WHS_Location_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Location_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Location_Update: {1} - {2}", ModifiedBy, WHS_Location_List, WHS_Location_List_Serialized));
            }
            return flag;
        }
        #endregion
        #region Destroy
        public string WHS_Location_Delete(IEnumerable<int> itemsID, string ModifiedBy)
        {
            string result = string.Empty;
            string WHS_Location_List = string.Empty;
            string WHS_Location_Items_Serialized = string.Empty;
            try
            {
                WMS.Models.DBContext model = new DBContext();
                List<WHS_Location> sendToTrashList = model.DBSet_WHS_Location.Where(d => itemsID.Contains(d.ID)).ToList();
                foreach (WHS_Location item in sendToTrashList)
                {
                    model.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                }
                Common.SaveChanges(model);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                Common.log.Error(WHS_Location_Items_Serialized, ex);
            }
            finally
            {
                if (!string.IsNullOrEmpty(result))
                {
                    Common.log.Warn(ModifiedBy + " => " + WHS_Location_Items_Serialized, new Exception(result));
                }
                Common.log.Info(string.Format("User: {0} - [end] - WHS_Location_Destroy: {1}", ModifiedBy, WHS_Location_List));
            }
            return result;
        }
        #endregion
		#endregion
           }
	
}
	
					
				

