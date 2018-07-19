// file info -------------------------------------------------------------------
//
//    Copyright         : 3P Solutions
//    Website           : 3PS.VN
//
//    Namespace         : WMS.Models
//
//------------------------------------------------------------------------------

#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
#endregion

namespace WMS.Models
{
    public class DBContext: DbContext
    {
        //[begin coding block]//[end coding block]
                public DbSet<ENT_BOM> DBSet_ENT_BOM { get; set; }        public DbSet<ENT_Carrier> DBSet_ENT_Carrier { get; set; }        public DbSet<ENT_Cartonization> DBSet_ENT_Cartonization { get; set; }        public DbSet<ENT_Customer> DBSet_ENT_Customer { get; set; }        public DbSet<ENT_CycleClass> DBSet_ENT_CycleClass { get; set; }        public DbSet<ENT_CycleCountValidation> DBSet_ENT_CycleCountValidation { get; set; }        public DbSet<ENT_CycleCountValidationDetail> DBSet_ENT_CycleCountValidationDetail { get; set; }        public DbSet<ENT_Delivery_Note> DBSet_ENT_Delivery_Note { get; set; }        public DbSet<ENT_Item> DBSet_ENT_Item { get; set; }        public DbSet<ENT_LottableValidation> DBSet_ENT_LottableValidation { get; set; }        public DbSet<ENT_LottableValidationDetail> DBSet_ENT_LottableValidationDetail { get; set; }        public DbSet<ENT_LottableValidationDetailDetail> DBSet_ENT_LottableValidationDetailDetail { get; set; }        public DbSet<ENT_OutboundValidation> DBSet_ENT_OutboundValidation { get; set; }        public DbSet<ENT_OutboundValidationDetail> DBSet_ENT_OutboundValidationDetail { get; set; }        public DbSet<ENT_Owner> DBSet_ENT_Owner { get; set; }        public DbSet<ENT_Pack> DBSet_ENT_Pack { get; set; }        public DbSet<ENT_ReceiptValidation> DBSet_ENT_ReceiptValidation { get; set; }        public DbSet<ENT_ReceiptValidationDetail> DBSet_ENT_ReceiptValidationDetail { get; set; }        public DbSet<ENT_Supplier> DBSet_ENT_Supplier { get; set; }        public DbSet<ENT_User> DBSet_ENT_User { get; set; }        public DbSet<ENT_V_DateFormat> DBSet_ENT_V_DateFormat { get; set; }        public DbSet<ENT_V_DateFormatDetail> DBSet_ENT_V_DateFormatDetail { get; set; }        public DbSet<ENT_Warehouse> DBSet_ENT_Warehouse { get; set; }        public DbSet<ENT_Wave> DBSet_ENT_Wave { get; set; }        public DbSet<LIST_Code> DBSet_LIST_Code { get; set; }        public DbSet<WHS_Adjustment> DBSet_WHS_Adjustment { get; set; }        public DbSet<WHS_Adjustment_Detail> DBSet_WHS_Adjustment_Detail { get; set; }        public DbSet<WHS_ASN> DBSet_WHS_ASN { get; set; }        public DbSet<WHS_ASNDetail> DBSet_WHS_ASNDetail { get; set; }        public DbSet<WHS_Consolidate> DBSet_WHS_Consolidate { get; set; }        public DbSet<WHS_GoodReceiptNote> DBSet_WHS_GoodReceiptNote { get; set; }        public DbSet<WHS_Location> DBSet_WHS_Location { get; set; }        public DbSet<WHS_Lot_Attribute> DBSet_WHS_Lot_Attribute { get; set; }        public DbSet<WHS_Maintain_Hold> DBSet_WHS_Maintain_Hold { get; set; }        public DbSet<WHS_Move> DBSet_WHS_Move { get; set; }        public DbSet<WHS_Owner_Label> DBSet_WHS_Owner_Label { get; set; }        public DbSet<WHS_Packing_List> DBSet_WHS_Packing_List { get; set; }        public DbSet<WHS_Pick_Detail> DBSet_WHS_Pick_Detail { get; set; }        public DbSet<WHS_Picking_List> DBSet_WHS_Picking_List { get; set; }        public DbSet<WHS_PO> DBSet_WHS_PO { get; set; }        public DbSet<WHS_PODetail> DBSet_WHS_PODetail { get; set; }        public DbSet<WHS_ReceiptReversal> DBSet_WHS_ReceiptReversal { get; set; }        public DbSet<WHS_ReceiptReversalDetail> DBSet_WHS_ReceiptReversalDetail { get; set; }        public DbSet<WHS_Replenishment> DBSet_WHS_Replenishment { get; set; }        public DbSet<WHS_SO> DBSet_WHS_SO { get; set; }        public DbSet<WHS_SO_Detail> DBSet_WHS_SO_Detail { get; set; }        public DbSet<WHS_Strategy_Putaway> DBSet_WHS_Strategy_Putaway { get; set; }        public DbSet<WHS_Strategy_Putaway_Step> DBSet_WHS_Strategy_Putaway_Step { get; set; }        public DbSet<WHS_Transaction> DBSet_WHS_Transaction { get; set; }        public DbSet<WHS_Zone> DBSet_WHS_Zone { get; set; }		
		public DBContext()
        : base("DBConnectionString")
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

		}
    }
}
