namespace WMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_ENT_BOM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Component_ID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_Code = c.String(nullable: false),
                        Quantity = c.Decimal(precision: 18, scale: 2),
                        Sequence = c.Int(),
                        ENT_Item_ID = c.Int(),
                        ENT_Item_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.ENT_Item_ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.ENT_Item_ID1)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Component_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID, cascadeDelete: true)
                .Index(t => t.Component_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.ENT_Item_ID)
                .Index(t => t.ENT_Item_ID1);
            
            CreateTable(
                "dbo.tbl_ENT_Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Allocation_Strategy_Id = c.Int(),
                        Batch_No = c.String(),
                        C_System_Itemtype = c.Int(),
                        Carton_ID = c.Int(),
                        Code_UOM_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Cube = c.Decimal(precision: 18, scale: 2),
                        CycleClass_ID = c.Int(),
                        Gross_weight = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Item_Code = c.String(),
                        Item_Description = c.String(),
                        ItemtypeDetail_ID = c.Int(),
                        Last_cycle_count = c.DateTime(),
                        Location_ID = c.Int(),
                        Lot_No = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Net_weight = c.Decimal(precision: 18, scale: 2),
                        Notes = c.String(),
                        Owner_Id = c.Int(),
                        Pack_Id = c.Int(),
                        Putaway_Strategy_Id = c.Int(),
                        RotatebyDetail_ID = c.Int(),
                        RotationDetail_ID = c.Int(),
                        Tare_weight = c.Decimal(precision: 18, scale: 2),
                        To_Best_By_Day = c.DateTime(),
                        To_Deliver_By_Days = c.DateTime(),
                        To_Expire_Days = c.Int(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        V_CycleCount_ID = c.Int(),
                        V_Lot_ID = c.Int(),
                        V_Receipt_ID = c.Int(),
                        Zone_Id = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        LIST_Code_ID4 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Cartonization", t => t.Carton_ID)
                .ForeignKey("dbo.tbl_ENT_Pack", t => t.Pack_Id)
                .ForeignKey("dbo.tbl_WHS_Zone", t => t.Zone_Id)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .ForeignKey("dbo.tbl_WHS_Strategy_Putaway", t => t.Putaway_Strategy_Id)
                .ForeignKey("dbo.tbl_ENT_CycleCountValidation", t => t.V_CycleCount_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID4)
                .ForeignKey("dbo.tbl_ENT_LottableValidation", t => t.V_Lot_ID)
                .ForeignKey("dbo.tbl_ENT_CycleClass", t => t.CycleClass_ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_Id)
                .ForeignKey("dbo.tbl_ENT_ReceiptValidation", t => t.V_Receipt_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.C_System_Itemtype)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_UOM_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.ItemtypeDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.RotatebyDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.RotationDetail_ID)
                .Index(t => t.C_System_Itemtype)
                .Index(t => t.Carton_ID)
                .Index(t => t.Code_UOM_ID)
                .Index(t => t.CycleClass_ID)
                .Index(t => t.ItemtypeDetail_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.Owner_Id)
                .Index(t => t.Pack_Id)
                .Index(t => t.Putaway_Strategy_Id)
                .Index(t => t.RotatebyDetail_ID)
                .Index(t => t.RotationDetail_ID)
                .Index(t => t.V_CycleCount_ID)
                .Index(t => t.V_Lot_ID)
                .Index(t => t.V_Receipt_ID)
                .Index(t => t.Zone_Id)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.LIST_Code_ID4);
            
            CreateTable(
                "dbo.tbl_ENT_Cartonization",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Carton_Group = c.String(),
                        Carton_Type = c.String(),
                        Cartonization_Code = c.String(),
                        Container_Type = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Cube = c.Decimal(precision: 18, scale: 2),
                        Description = c.String(),
                        Height = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Length = c.Decimal(precision: 18, scale: 2),
                        Maximum_Unit = c.Decimal(precision: 18, scale: 2),
                        Maximum_Weight = c.Decimal(precision: 18, scale: 2),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Sequence = c.Decimal(precision: 18, scale: 2),
                        Tare_Weight = c.Decimal(precision: 18, scale: 2),
                        Width = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_ENT_Owner",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Allocation_Strategy_ID = c.Int(),
                        Billing_Address = c.String(),
                        Billing_City = c.Int(),
                        Billing_District = c.Int(),
                        Billing_Email1 = c.String(),
                        Billing_Email2 = c.String(),
                        Billing_Fax1 = c.String(),
                        Billing_Fax2 = c.String(),
                        Billing_Phone1 = c.String(),
                        Billing_Phone2 = c.String(),
                        Carrier_ID = c.Int(),
                        Cartonization_ID = c.Int(),
                        City = c.Int(),
                        Company = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Customer_ID = c.Int(),
                        Cycle_Class_ID = c.Int(),
                        District = c.String(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        Fax1 = c.String(),
                        Fax2 = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_Code = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Putaway_Strategy_ID = c.Int(),
                        Receipt_Validation_Detail_ID = c.Int(),
                        Rotation_Detail_By = c.Int(),
                        Rotation_Detail_ID = c.Int(),
                        Supplier_ID = c.Int(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        V_Cycle_Count_ID = c.Int(),
                        ENT_Carrier_ID = c.Int(),
                        ENT_Customer_ID = c.Int(),
                        ENT_Supplier_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        LIST_Code_ID4 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Carrier", t => t.ENT_Carrier_ID)
                .ForeignKey("dbo.tbl_ENT_Customer", t => t.ENT_Customer_ID)
                .ForeignKey("dbo.tbl_ENT_Supplier", t => t.ENT_Supplier_ID)
                .ForeignKey("dbo.tbl_WHS_Strategy_Putaway", t => t.Putaway_Strategy_ID)
                .ForeignKey("dbo.tbl_ENT_CycleCountValidation", t => t.V_Cycle_Count_ID)
                .ForeignKey("dbo.tbl_ENT_ReceiptValidationDetail", t => t.Receipt_Validation_Detail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID4)
                .ForeignKey("dbo.tbl_ENT_Carrier", t => t.Carrier_ID)
                .ForeignKey("dbo.tbl_ENT_Cartonization", t => t.Cartonization_ID)
                .ForeignKey("dbo.tbl_ENT_Customer", t => t.Customer_ID)
                .ForeignKey("dbo.tbl_ENT_CycleClass", t => t.Cycle_Class_ID)
                .ForeignKey("dbo.tbl_ENT_Supplier", t => t.Supplier_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_District)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Rotation_Detail_By)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Rotation_Detail_ID)
                .Index(t => t.Billing_City)
                .Index(t => t.Billing_District)
                .Index(t => t.Carrier_ID)
                .Index(t => t.Cartonization_ID)
                .Index(t => t.City)
                .Index(t => t.Customer_ID)
                .Index(t => t.Cycle_Class_ID)
                .Index(t => t.Putaway_Strategy_ID)
                .Index(t => t.Receipt_Validation_Detail_ID)
                .Index(t => t.Rotation_Detail_By)
                .Index(t => t.Rotation_Detail_ID)
                .Index(t => t.Supplier_ID)
                .Index(t => t.V_Cycle_Count_ID)
                .Index(t => t.ENT_Carrier_ID)
                .Index(t => t.ENT_Customer_ID)
                .Index(t => t.ENT_Supplier_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.LIST_Code_ID4);
            
            CreateTable(
                "dbo.tbl_ENT_Carrier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Billing_Address = c.String(),
                        Billing_City = c.Int(),
                        Billing_District = c.Int(),
                        Billing_Email1 = c.String(),
                        Billing_Email2 = c.String(),
                        Billing_Fax1 = c.String(),
                        Billing_Fax2 = c.String(),
                        Billing_Phone1 = c.String(),
                        Billing_Phone2 = c.String(),
                        Carrier_Code = c.Int(nullable: false),
                        City = c.Int(),
                        Company = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        District = c.Int(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        Fax1 = c.String(),
                        Fax2 = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_ID = c.Int(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        ENT_Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_District)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.District)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.ENT_Owner_ID)
                .Index(t => t.Billing_City)
                .Index(t => t.Billing_District)
                .Index(t => t.City)
                .Index(t => t.District)
                .Index(t => t.Owner_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.ENT_Owner_ID);
            
            CreateTable(
                "dbo.tbl_LIST_Code",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Name = c.String(nullable: false),
                        Type = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Type)
                .Index(t => t.Type);
            
            CreateTable(
                "dbo.tbl_ENT_Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Billing_Address = c.String(),
                        Billing_City = c.String(),
                        Billing_District = c.String(),
                        Billing_Email1 = c.String(),
                        Billing_Email2 = c.String(),
                        Billing_Fax1 = c.String(),
                        Billing_Fax2 = c.String(),
                        Billing_Phone1 = c.String(),
                        Billing_Phone2 = c.String(),
                        City = c.Int(),
                        Company = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Customer_Code = c.String(),
                        District = c.Int(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        Fax1 = c.String(),
                        Fax2 = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_ID = c.Int(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        ENT_Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.District)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.ENT_Owner_ID)
                .Index(t => t.City)
                .Index(t => t.District)
                .Index(t => t.Owner_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.ENT_Owner_ID);
            
            CreateTable(
                "dbo.tbl_ENT_OutboundValidation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Conditional_Validation_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Customer_ID = c.Int(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Outbound_validation_code = c.String(),
                        Owner_ID = c.Int(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Customer", t => t.Customer_ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_OutboundValidation", t => t.Conditional_Validation_ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .Index(t => t.Conditional_Validation_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Owner_ID);
            
            CreateTable(
                "dbo.tbl_ENT_OutboundValidationDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code_Validation_routine_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Enable = c.Boolean(),
                        IsDeleted = c.Boolean(),
                        Minimum_shelf_life = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Outbound_validation_ID = c.Int(),
                        RF_assisted_picking = c.Boolean(),
                        RF_directed_picking = c.Boolean(),
                        Sequence = c.String(),
                        Validation_routine = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_OutboundValidation", t => t.Outbound_validation_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_Validation_routine_ID)
                .Index(t => t.Code_Validation_routine_ID)
                .Index(t => t.Outbound_validation_ID);
            
            CreateTable(
                "dbo.tbl_WHS_SO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Actual_Ship_Date = c.DateTime(),
                        Carrier_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Customer_ID = c.Int(),
                        Driver_Name = c.String(),
                        IsDelete = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Order_Date = c.DateTime(),
                        OutboundstatusID = c.Int(),
                        Owner_ID = c.Int(nullable: false),
                        Priority_ID = c.Int(),
                        Remark = c.String(),
                        Requested_Ship_Date = c.DateTime(),
                        SO_Code = c.String(),
                        Total_Quantity = c.Decimal(precision: 18, scale: 2),
                        Truck_Number = c.String(),
                        Type_ID = c.Int(nullable: false),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Carrier", t => t.Carrier_ID)
                .ForeignKey("dbo.tbl_ENT_Customer", t => t.Customer_ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.OutboundstatusID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Priority_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Type_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .Index(t => t.Carrier_ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.OutboundstatusID)
                .Index(t => t.Owner_ID)
                .Index(t => t.Priority_ID)
                .Index(t => t.Type_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2);
            
            CreateTable(
                "dbo.tbl_ENT_Wave",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Create_On = c.DateTime(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        IsDelete = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        SO_ID = c.Int(),
                        User_ID = c.Int(),
                        Wave_Code = c.String(),
                        Wave_Status_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_User", t => t.User_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Wave_Status_ID)
                .ForeignKey("dbo.tbl_WHS_SO", t => t.SO_ID)
                .Index(t => t.SO_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Wave_Status_ID);
            
            CreateTable(
                "dbo.tbl_ENT_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Encrypt = c.String(nullable: false),
                        Full_Name = c.String(nullable: false),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_WHS_Adjustment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adjustment_Date = c.DateTime(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Owner_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_ENT_User", t => t.User_ID)
                .Index(t => t.Owner_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Adjustment_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adjustment_ID = c.Int(),
                        Adjustment_Quantity = c.Decimal(precision: 18, scale: 2),
                        AdjustmentReasonID = c.Int(),
                        ASN_Detail_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Current_Quantity = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Line = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Pack_ID = c.Int(),
                        Target_Quantity = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Pack", t => t.Pack_ID)
                .ForeignKey("dbo.tbl_WHS_ASNDetail", t => t.ASN_Detail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.AdjustmentReasonID)
                .ForeignKey("dbo.tbl_WHS_Adjustment", t => t.Adjustment_ID)
                .Index(t => t.Adjustment_ID)
                .Index(t => t.AdjustmentReasonID)
                .Index(t => t.ASN_Detail_ID)
                .Index(t => t.Pack_ID);
            
            CreateTable(
                "dbo.tbl_ENT_Pack",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Carton_ID = c.Int(),
                        Cartonize_Case = c.Boolean(),
                        Cartonize_innerPack = c.Boolean(),
                        Cartonize_Layer = c.Boolean(),
                        Cartonize_MasterUnit = c.Boolean(),
                        Cartonize_Pallet = c.Boolean(),
                        Case_Height = c.Decimal(precision: 18, scale: 2),
                        Case_Length = c.Decimal(precision: 18, scale: 2),
                        Case_Width = c.Decimal(precision: 18, scale: 2),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(nullable: false),
                        Innerpack_Height = c.Decimal(precision: 18, scale: 2),
                        Innerpack_Length = c.Decimal(precision: 18, scale: 2),
                        Innerpack_Width = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Layer_Height = c.Decimal(precision: 18, scale: 2),
                        Layer_Lenght = c.Decimal(precision: 18, scale: 2),
                        Layer_Width = c.Decimal(precision: 18, scale: 2),
                        Master_Unit_Height = c.Decimal(precision: 18, scale: 2),
                        Master_Unit_Length = c.Decimal(precision: 18, scale: 2),
                        Master_Unit_Width = c.Decimal(precision: 18, scale: 2),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Number_of_cases_per_tier = c.Decimal(precision: 18, scale: 2),
                        Number_of_tiers_high_per_pallet = c.Decimal(precision: 18, scale: 2),
                        Pack_Code = c.String(),
                        Pallet_Height = c.Decimal(precision: 18, scale: 2),
                        Pallet_Length = c.Decimal(precision: 18, scale: 2),
                        Pallet_Width = c.Decimal(precision: 18, scale: 2),
                        Pallet_Wood_Height = c.Decimal(precision: 18, scale: 2),
                        Pallet_Wood_Length = c.Decimal(precision: 18, scale: 2),
                        Pallet_Wood_Width = c.Decimal(precision: 18, scale: 2),
                        Unit_Per_Mesure_1 = c.Decimal(precision: 18, scale: 2),
                        Unit_Per_Mesure_2 = c.Decimal(precision: 18, scale: 2),
                        Unit_Per_Mesure_3 = c.Decimal(precision: 18, scale: 2),
                        Unit_Per_Mesure_4 = c.Decimal(precision: 18, scale: 2),
                        UOM_CubeDetail_ID = c.Int(),
                        UOM_PackageDetail_ID = c.Int(),
                        UOM_QuantityDetail_ID = c.Int(),
                        UOM_WeightDetail_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Cartonization", t => t.Carton_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.UOM_CubeDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.UOM_PackageDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.UOM_QuantityDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.UOM_WeightDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .Index(t => t.Carton_ID)
                .Index(t => t.UOM_CubeDetail_ID)
                .Index(t => t.UOM_PackageDetail_ID)
                .Index(t => t.UOM_QuantityDetail_ID)
                .Index(t => t.UOM_WeightDetail_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3);
            
            CreateTable(
                "dbo.tbl_WHS_ASNDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ASN_ID = c.Int(),
                        C_System_HoldCode_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Discrepancy_Qty = c.Decimal(precision: 18, scale: 2),
                        Expected_Qty = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        Location_ID = c.Int(),
                        Lotable_1 = c.String(),
                        Lotable_10 = c.String(),
                        Lotable_11 = c.DateTime(),
                        Lotable_12 = c.DateTime(),
                        Lotable_2 = c.String(),
                        Lotable_3 = c.DateTime(),
                        Lotable_4 = c.DateTime(),
                        Lotable_5 = c.String(),
                        Lotable_6 = c.String(),
                        LPN = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Pack_ID = c.Int(),
                        Pallet_Label = c.String(),
                        Receipt_Line_No = c.Int(),
                        ReceiptStatus_ID = c.Int(),
                        Received_Qty = c.Decimal(precision: 18, scale: 2),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        UOM_ID = c.Int(),
                        ENT_Item_ID = c.Int(),
                        ENT_Item_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.UOM_ID)
                .ForeignKey("dbo.tbl_ENT_Pack", t => t.Pack_ID)
                .ForeignKey("dbo.tbl_WHS_ASN", t => t.ASN_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.ENT_Item_ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.ENT_Item_ID1)
                .Index(t => t.ASN_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.Pack_ID)
                .Index(t => t.UOM_ID)
                .Index(t => t.ENT_Item_ID)
                .Index(t => t.ENT_Item_ID1);
            
            CreateTable(
                "dbo.tbl_WHS_ASN",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Actual_receipt_date = c.DateTime(),
                        ASN_Code = c.String(),
                        Carrier_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Date_created = c.DateTime(),
                        Expected_cube = c.Decimal(precision: 18, scale: 2),
                        Expected_weight = c.DateTime(),
                        PO_ID = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Note = c.String(),
                        ReceiptStatus_ID = c.Int(),
                        Schedule_receipt_date = c.DateTime(),
                        Supplier_ID = c.Int(),
                        Total_Expected_Qty = c.Decimal(precision: 18, scale: 2),
                        Total_Receipted_Qty = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Carrier", t => t.Carrier_ID)
                .ForeignKey("dbo.tbl_ENT_Supplier", t => t.Supplier_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.ReceiptStatus_ID)
                .Index(t => t.Carrier_ID)
                .Index(t => t.ReceiptStatus_ID)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.tbl_ENT_Supplier",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Billing_Address = c.String(),
                        Billing_City = c.Int(),
                        Billing_District = c.Int(),
                        Billing_Email1 = c.String(),
                        Billing_Email2 = c.String(),
                        Billing_Fax1 = c.String(),
                        Billing_Fax2 = c.String(),
                        Billing_Phone1 = c.String(),
                        Billing_Phone2 = c.String(),
                        City = c.Int(),
                        Company = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        District = c.Int(),
                        Email1 = c.String(),
                        Email2 = c.String(),
                        Fax1 = c.String(),
                        Fax2 = c.String(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_ID = c.Int(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Supplier_Code = c.String(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        ENT_Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Billing_District)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.City)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.District)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.ENT_Owner_ID)
                .Index(t => t.Billing_City)
                .Index(t => t.Billing_District)
                .Index(t => t.City)
                .Index(t => t.District)
                .Index(t => t.Item_ID)
                .Index(t => t.Owner_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.ENT_Owner_ID);
            
            CreateTable(
                "dbo.tbl_WHS_PO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        C_System_POStatus_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Expected_receipt_date = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Owner_ID = c.Int(),
                        PO_Code = c.String(),
                        PO_date = c.DateTime(),
                        ReceiptStatus_ID = c.Int(),
                        Supplier_ID = c.Int(),
                        Total_Order_Qty = c.Decimal(precision: 18, scale: 2),
                        UOM_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_ENT_Supplier", t => t.Supplier_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.C_System_POStatus_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.UOM_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .Index(t => t.C_System_POStatus_ID)
                .Index(t => t.Owner_ID)
                .Index(t => t.Supplier_ID)
                .Index(t => t.UOM_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1);
            
            CreateTable(
                "dbo.tbl_WHS_PODetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        C_System_POStatus_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Notes = c.String(),
                        Oder_Line_No = c.Int(),
                        Order_Line_No = c.Int(nullable: false),
                        PO_ID = c.Int(nullable: false),
                        ReceiptStatus_ID = c.Int(),
                        UDF_1 = c.String(),
                        UDF_2 = c.String(),
                        UDF_3 = c.String(),
                        UDF_4 = c.String(),
                        UDF_5 = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.C_System_POStatus_ID)
                .ForeignKey("dbo.tbl_WHS_PO", t => t.PO_ID, cascadeDelete: true)
                .Index(t => t.C_System_POStatus_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.PO_ID);
            
            CreateTable(
                "dbo.tbl_WHS_ReceiptReversal",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adjustment_number_ID = c.String(),
                        ASN_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Effective_date = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_WHS_ASN", t => t.ASN_ID)
                .Index(t => t.ASN_ID);
            
            CreateTable(
                "dbo.tbl_WHS_ReceiptReversalDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adjustment_Qty = c.Decimal(precision: 18, scale: 2),
                        ASN_Detail_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Receipt_reversal_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_WHS_ASNDetail", t => t.ASN_Detail_ID)
                .ForeignKey("dbo.tbl_WHS_ReceiptReversal", t => t.Receipt_reversal_ID)
                .Index(t => t.ASN_Detail_ID)
                .Index(t => t.Receipt_reversal_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Replenishment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ASN_Receipt_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Input_Qty = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_WHS_ASN", t => t.ASN_Receipt_ID)
                .Index(t => t.ASN_Receipt_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Zone",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        Location_ID = c.Int(),
                        Max_Pallets_per_item = c.Int(),
                        Max_Pick_Container = c.Int(),
                        Max_Pick_Line = c.Int(),
                        Maximum_Case_Count = c.Int(),
                        Maximum_Cube = c.Decimal(precision: 18, scale: 2),
                        Maximum_Weight = c.Decimal(precision: 18, scale: 2),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        PositiveValidationMethod_ID = c.Int(),
                        Replenishment_MethodDetail_ID = c.Int(),
                        ReplenishmentlevelDetail_ID = c.Int(),
                        Zone_Code = c.String(),
                        WHS_Location_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.PositiveValidationMethod_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.ReplenishmentlevelDetail_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.WHS_Location_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .ForeignKey("dbo.tbl_WHS_Replenishment", t => t.Replenishment_MethodDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .Index(t => t.Location_ID)
                .Index(t => t.PositiveValidationMethod_ID)
                .Index(t => t.Replenishment_MethodDetail_ID)
                .Index(t => t.ReplenishmentlevelDetail_ID)
                .Index(t => t.WHS_Location_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1);
            
            CreateTable(
                "dbo.tbl_WHS_Location",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        C_System_MovingspeedDetail_ID = c.Int(),
                        Category_ID = c.Int(),
                        Comingleitems = c.Boolean(),
                        Cominglelots = c.Boolean(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Cubic_Capacity = c.Decimal(precision: 18, scale: 2),
                        Flag_ID = c.Int(),
                        Foot_Print = c.Int(),
                        Height = c.Decimal(precision: 18, scale: 2),
                        IsDeleted = c.Boolean(),
                        Length = c.Decimal(precision: 18, scale: 2),
                        Level = c.Int(),
                        Location_Code = c.String(),
                        Location_StatusDetail_ID = c.Int(),
                        Location_Type_ID = c.Int(nullable: false),
                        LocationhandlingDetail_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Movingspeed_ID = c.Int(),
                        Orientation = c.Decimal(precision: 18, scale: 2),
                        Stack_Limit = c.Int(),
                        Status = c.String(),
                        Weight_Capacity = c.Decimal(precision: 18, scale: 2),
                        Width = c.Decimal(precision: 18, scale: 2),
                        X_coordinate = c.Decimal(precision: 18, scale: 2),
                        Y_coordinate = c.Decimal(precision: 18, scale: 2),
                        Z_coordinate = c.Decimal(precision: 18, scale: 2),
                        Zone_ID = c.Int(),
                        WHS_Zone_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        LIST_Code_ID4 = c.Int(),
                        LIST_Code_ID5 = c.Int(),
                        LIST_Code_ID6 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.C_System_MovingspeedDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Category_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Flag_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Location_StatusDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Location_Type_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LocationhandlingDetail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Movingspeed_ID)
                .ForeignKey("dbo.tbl_WHS_Zone", t => t.Zone_ID)
                .ForeignKey("dbo.tbl_WHS_Zone", t => t.WHS_Zone_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID4)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID5)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID6)
                .Index(t => t.C_System_MovingspeedDetail_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.Flag_ID)
                .Index(t => t.Location_StatusDetail_ID)
                .Index(t => t.Location_Type_ID)
                .Index(t => t.LocationhandlingDetail_ID)
                .Index(t => t.Movingspeed_ID)
                .Index(t => t.Zone_ID)
                .Index(t => t.WHS_Zone_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.LIST_Code_ID4)
                .Index(t => t.LIST_Code_ID5)
                .Index(t => t.LIST_Code_ID6);
            
            CreateTable(
                "dbo.tbl_WHS_Maintain_Hold",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Date_Off = c.DateTime(),
                        Date_On = c.DateTime(),
                        Holdreason_ID = c.Int(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        Location_ID = c.Int(),
                        Lot_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_User", t => t.User_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Holdreason_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .ForeignKey("dbo.tbl_WHS_Lot_Attribute", t => t.Lot_ID)
                .Index(t => t.Holdreason_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.Lot_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Lot_Attribute",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ASN_Detail_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        Lottable_1 = c.String(),
                        Lottable_10 = c.String(),
                        Lottable_11 = c.DateTime(),
                        Lottable_12 = c.DateTime(),
                        Lottable_2 = c.String(),
                        Lottable_3 = c.DateTime(),
                        Lottable_4 = c.DateTime(),
                        Lottable_5 = c.String(),
                        Lottable_6 = c.String(),
                        Lottable_7 = c.String(),
                        Lottable_8 = c.String(),
                        Lottable_9 = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Owner_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_WHS_ASNDetail", t => t.ASN_Detail_ID)
                .Index(t => t.ASN_Detail_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Owner_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Pick_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        Location_ID = c.Int(),
                        Lot_Attribute_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Pack_ID = c.Int(),
                        Picking_Line_No = c.Int(),
                        PickStatus_ID = c.Int(),
                        Quantity = c.Decimal(precision: 18, scale: 2),
                        SO_Detail_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_ENT_Pack", t => t.Pack_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.PickStatus_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .ForeignKey("dbo.tbl_WHS_Lot_Attribute", t => t.Lot_Attribute_ID)
                .ForeignKey("dbo.tbl_WHS_SO_Detail", t => t.SO_Detail_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.Lot_Attribute_ID)
                .Index(t => t.Pack_ID)
                .Index(t => t.PickStatus_ID)
                .Index(t => t.SO_Detail_ID);
            
            CreateTable(
                "dbo.tbl_WHS_SO_Detail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Allocated_Quantity = c.Decimal(precision: 18, scale: 2),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDelete = c.Boolean(),
                        Item_ID = c.Int(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Order_Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pack_ID = c.Int(nullable: false),
                        Picked_Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Shipped_Quantity = c.Decimal(precision: 18, scale: 2),
                        SO_ID = c.Int(),
                        SO_Line_No = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_ENT_Pack", t => t.Pack_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_WHS_SO", t => t.SO_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Pack_ID)
                .Index(t => t.SO_ID);
            
            CreateTable(
                "dbo.tbl_ENT_Delivery_Note",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Note = c.String(),
                        Printed_Date = c.DateTime(),
                        SO_Detail_ID = c.Int(),
                        Warehouse_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Warehouse", t => t.Warehouse_ID)
                .ForeignKey("dbo.tbl_WHS_SO_Detail", t => t.SO_Detail_ID)
                .Index(t => t.SO_Detail_ID)
                .Index(t => t.Warehouse_ID);
            
            CreateTable(
                "dbo.tbl_ENT_Warehouse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Name = c.String(nullable: false),
                        Server = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_WHS_Picking_List",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Note = c.String(),
                        Printed_Date = c.DateTime(),
                        SO_Detail_ID = c.Int(),
                        Warehouse_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Warehouse", t => t.Warehouse_ID)
                .ForeignKey("dbo.tbl_WHS_SO_Detail", t => t.SO_Detail_ID)
                .Index(t => t.SO_Detail_ID)
                .Index(t => t.Warehouse_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Packing_List",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Batch_Note = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Kg_Note = c.Decimal(precision: 18, scale: 2),
                        Lot_No_Note = c.String(),
                        M3_Note = c.Decimal(precision: 18, scale: 2),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Pack_Note = c.String(),
                        Packing_List_Note_No = c.Int(),
                        Qty_Note = c.Decimal(precision: 18, scale: 2),
                        SO_Detail_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_WHS_SO_Detail", t => t.SO_Detail_ID)
                .Index(t => t.SO_Detail_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Move",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        Location_ID = c.Int(),
                        LPN = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Quantity = c.Decimal(precision: 18, scale: 2),
                        Quantity_Allocated = c.Decimal(precision: 18, scale: 2),
                        Quantity_Available = c.Decimal(precision: 18, scale: 2),
                        Quantity_To_Move = c.Decimal(precision: 18, scale: 2),
                        Status = c.Boolean(),
                        To_Location = c.String(),
                        To_LPN = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_WHS_Consolidate", t => t.To_LPN)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.Location_ID)
                .Index(t => t.Item_ID)
                .Index(t => t.Location_ID)
                .Index(t => t.To_LPN);
            
            CreateTable(
                "dbo.tbl_WHS_Consolidate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ASN_Detail_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        LPN_New = c.String(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_WHS_ASNDetail", t => t.ASN_Detail_ID)
                .Index(t => t.ASN_Detail_ID);
            
            CreateTable(
                "dbo.tbl_WHS_Strategy_Putaway_Step",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        area_restriction_1 = c.Int(),
                        area_restriction_2 = c.Int(),
                        area_restriction_3 = c.Int(),
                        check_restriction = c.Boolean(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Demention_Restriction_1 = c.Int(),
                        Demention_Restriction_2 = c.Int(),
                        Demention_Restriction_3 = c.Int(),
                        Demention_Restriction_4 = c.Int(),
                        Demention_Restriction_5 = c.Int(),
                        from_location = c.Int(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Multi_Pallet = c.Boolean(),
                        putaway_strategy_ID = c.Int(nullable: false),
                        Puttaway_Type_ID = c.Int(),
                        step = c.Int(nullable: false),
                        to_location = c.Int(),
                        zone_ID = c.Int(),
                        WHS_Location_ID = c.Int(),
                        WHS_Location_ID1 = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        LIST_Code_ID4 = c.Int(),
                        LIST_Code_ID5 = c.Int(),
                        LIST_Code_ID6 = c.Int(),
                        LIST_Code_ID7 = c.Int(),
                        LIST_Code_ID8 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.area_restriction_1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.area_restriction_2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.area_restriction_3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Demention_Restriction_1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Demention_Restriction_2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Demention_Restriction_3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Demention_Restriction_4)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Demention_Restriction_5)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Puttaway_Type_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.from_location)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.to_location)
                .ForeignKey("dbo.tbl_WHS_Strategy_Putaway", t => t.putaway_strategy_ID, cascadeDelete: true)
                .ForeignKey("dbo.tbl_WHS_Zone", t => t.zone_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.WHS_Location_ID)
                .ForeignKey("dbo.tbl_WHS_Location", t => t.WHS_Location_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID4)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID5)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID6)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID7)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID8)
                .Index(t => t.area_restriction_1)
                .Index(t => t.area_restriction_2)
                .Index(t => t.area_restriction_3)
                .Index(t => t.Demention_Restriction_1)
                .Index(t => t.Demention_Restriction_2)
                .Index(t => t.Demention_Restriction_3)
                .Index(t => t.Demention_Restriction_4)
                .Index(t => t.Demention_Restriction_5)
                .Index(t => t.from_location)
                .Index(t => t.putaway_strategy_ID)
                .Index(t => t.Puttaway_Type_ID)
                .Index(t => t.to_location)
                .Index(t => t.zone_ID)
                .Index(t => t.WHS_Location_ID)
                .Index(t => t.WHS_Location_ID1)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.LIST_Code_ID4)
                .Index(t => t.LIST_Code_ID5)
                .Index(t => t.LIST_Code_ID6)
                .Index(t => t.LIST_Code_ID7)
                .Index(t => t.LIST_Code_ID8);
            
            CreateTable(
                "dbo.tbl_WHS_Strategy_Putaway",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_WHS_GoodReceiptNote",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ASN_Detail_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Date_time_print_GRN = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Line_No = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Note = c.String(),
                        Total_quantity = c.Decimal(precision: 18, scale: 2),
                        User_ID = c.Int(),
                        Warehouse_ID = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_User", t => t.User_ID)
                .ForeignKey("dbo.tbl_WHS_ASNDetail", t => t.ASN_Detail_ID)
                .Index(t => t.ASN_Detail_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.tbl_ENT_CycleCountValidationDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        LottableAdjustmentRule_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Negative_adjustment_lot = c.String(),
                        Negative_adjustment_lottable3 = c.String(),
                        Negative_adjustment_lottable4 = c.String(),
                        Positive_adjustment_lot = c.String(),
                        Positive_adjustment_lottable3 = c.String(),
                        Positive_adjustment_lottable4 = c.String(),
                        V_CycleCount_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_CycleCountValidation", t => t.V_CycleCount_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LottableAdjustmentRule_ID)
                .Index(t => t.LottableAdjustmentRule_ID)
                .Index(t => t.V_CycleCount_ID);
            
            CreateTable(
                "dbo.tbl_ENT_CycleCountValidation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Cycle_Count_Discrepancy_Template = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_ENT_LottableValidationDetailD",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Conversion = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        DateCodeFormat = c.String(),
                        IsDeleted = c.Boolean(),
                        Lottable_conversion_ID = c.Int(),
                        Lottable_Validation_Detail_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Sequence = c.Int(),
                        ShelfLifeValidation = c.Boolean(),
                        V_Date_fortmat_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_LottableValidationDetail", t => t.Lottable_Validation_Detail_ID)
                .ForeignKey("dbo.tbl_ENT_V_DateFormat", t => t.V_Date_fortmat_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Lottable_conversion_ID)
                .Index(t => t.Lottable_conversion_ID)
                .Index(t => t.Lottable_Validation_Detail_ID)
                .Index(t => t.V_Date_fortmat_ID);
            
            CreateTable(
                "dbo.tbl_ENT_LottableValidationDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        GenerateMask = c.String(),
                        IsDeleted = c.Boolean(),
                        Lottable_name = c.String(),
                        MaximumLength = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Required = c.Boolean(),
                        V_Lot_ID = c.Int(),
                        Visible = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_LottableValidation", t => t.V_Lot_ID)
                .Index(t => t.V_Lot_ID);
            
            CreateTable(
                "dbo.tbl_ENT_LottableValidation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        Lottable_Validation_Key = c.String(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_ENT_ReceiptValidationDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Allow_error_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_Not_on_ASN = c.String(),
                        Item_not_on_PO = c.String(),
                        Lottable_Validation_detail_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Overage_Hard_Error = c.Decimal(precision: 18, scale: 2),
                        Overage_Message = c.Boolean(),
                        Overage_Override = c.Decimal(precision: 18, scale: 2),
                        Perform_Qty_Validation = c.Boolean(),
                        Receipt_Without_ASN = c.String(),
                        Receipt_without_LPN = c.String(),
                        Receipt_without_PO = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_LottableValidationDetail", t => t.Lottable_Validation_detail_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Allow_error_ID)
                .Index(t => t.Allow_error_ID)
                .Index(t => t.Lottable_Validation_detail_ID);
            
            CreateTable(
                "dbo.tbl_ENT_V_DateFormat",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Converts_to = c.DateTime(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Description = c.String(),
                        Example = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        V_Date_format_code = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_ENT_V_DateFormatDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Begin = c.Int(),
                        Code_Date_element_ID = c.Int(),
                        Code_date_field_ID = c.Int(),
                        Code_Date_type_ID = c.Int(),
                        Code_how_to_process_ID = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Date_element = c.String(),
                        Date_type = c.Int(),
                        End = c.Int(),
                        Field_type = c.Int(),
                        How_to_process = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        V_date_format_ID = c.Int(),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                        LIST_Code_ID2 = c.Int(),
                        LIST_Code_ID3 = c.Int(),
                        LIST_Code_ID4 = c.Int(),
                        LIST_Code_ID5 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_V_DateFormat", t => t.V_date_format_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_Date_element_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_date_field_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_Date_type_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Code_how_to_process_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Date_type)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Field_type)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID2)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID3)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID4)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID5)
                .Index(t => t.Code_Date_element_ID)
                .Index(t => t.Code_date_field_ID)
                .Index(t => t.Code_Date_type_ID)
                .Index(t => t.Code_how_to_process_ID)
                .Index(t => t.Date_type)
                .Index(t => t.Field_type)
                .Index(t => t.V_date_format_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1)
                .Index(t => t.LIST_Code_ID2)
                .Index(t => t.LIST_Code_ID3)
                .Index(t => t.LIST_Code_ID4)
                .Index(t => t.LIST_Code_ID5);
            
            CreateTable(
                "dbo.tbl_WHS_Owner_Label",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Case_Label_Type = c.Int(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        LPN_Barcode_Format = c.Int(nullable: false),
                        LPN_Length = c.Int(nullable: false),
                        LPN_Next_Number = c.Int(nullable: false),
                        LPN_Start_Number = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Owner_ID = c.Int(),
                        Roll_Back_Number = c.Int(nullable: false),
                        LIST_Code_ID = c.Int(),
                        LIST_Code_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Owner", t => t.Owner_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Case_Label_Type)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LPN_Barcode_Format, cascadeDelete: true)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.LIST_Code_ID1)
                .Index(t => t.Case_Label_Type)
                .Index(t => t.LPN_Barcode_Format)
                .Index(t => t.Owner_ID)
                .Index(t => t.LIST_Code_ID)
                .Index(t => t.LIST_Code_ID1);
            
            CreateTable(
                "dbo.tbl_WHS_Transaction",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Activity_ID = c.Int(),
                        Add_Date = c.DateTime(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Edit_Date = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        Item_ID = c.Int(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        User_Add = c.Int(),
                        User_Update = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.tbl_ENT_Item", t => t.Item_ID)
                .ForeignKey("dbo.tbl_LIST_Code", t => t.Activity_ID)
                .Index(t => t.Activity_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.tbl_ENT_CycleClass",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Cycle_Class_Code = c.String(),
                        Days = c.Decimal(precision: 18, scale: 2),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        Percent_Negative_Variance = c.Decimal(precision: 18, scale: 2),
                        Percent_Positive_Variance = c.Decimal(precision: 18, scale: 2),
                        Value_Negative_Variance = c.Decimal(precision: 18, scale: 2),
                        Value_Positive_Variance = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tbl_ENT_ReceiptValidation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(),
                        Default = c.Boolean(),
                        IsDeleted = c.Boolean(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        V_Receipt_code = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_ENT_BOM", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_ENT_BOM", "Component_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "ENT_Item_ID1", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "ENT_Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_ENT_Item", "RotationDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "RotatebyDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "ItemtypeDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "Code_UOM_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "C_System_Itemtype", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "V_Receipt_ID", "dbo.tbl_ENT_ReceiptValidation");
            DropForeignKey("dbo.tbl_ENT_Owner", "Rotation_Detail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "Rotation_Detail_By", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "Billing_District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "Billing_City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "ENT_Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Owner", "Supplier_ID", "dbo.tbl_ENT_Supplier");
            DropForeignKey("dbo.tbl_ENT_Item", "Owner_Id", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Owner", "Cycle_Class_ID", "dbo.tbl_ENT_CycleClass");
            DropForeignKey("dbo.tbl_ENT_Item", "CycleClass_ID", "dbo.tbl_ENT_CycleClass");
            DropForeignKey("dbo.tbl_ENT_Customer", "ENT_Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Owner", "Customer_ID", "dbo.tbl_ENT_Customer");
            DropForeignKey("dbo.tbl_ENT_Owner", "Cartonization_ID", "dbo.tbl_ENT_Cartonization");
            DropForeignKey("dbo.tbl_ENT_Carrier", "ENT_Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Owner", "Carrier_ID", "dbo.tbl_ENT_Carrier");
            DropForeignKey("dbo.tbl_ENT_Carrier", "District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "Billing_District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "Billing_City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Zone", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Zone", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Transaction", "Activity_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Transaction", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID8", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID7", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID6", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID5", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PO", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PO", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Owner_Label", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Owner_Label", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Owner_Label", "LPN_Barcode_Format", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Owner_Label", "Case_Label_Type", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Owner_Label", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID6", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID5", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_LIST_Code", "Type", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID5", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "LIST_Code_ID4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_LottableValidationDetailD", "Lottable_conversion_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Field_type", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Date_type", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Code_how_to_process_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Code_Date_type_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Code_date_field_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "Code_Date_element_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_V_DateFormatDetail", "V_date_format_ID", "dbo.tbl_ENT_V_DateFormat");
            DropForeignKey("dbo.tbl_ENT_LottableValidationDetailD", "V_Date_fortmat_ID", "dbo.tbl_ENT_V_DateFormat");
            DropForeignKey("dbo.tbl_ENT_ReceiptValidationDetail", "Allow_error_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "Receipt_Validation_Detail_ID", "dbo.tbl_ENT_ReceiptValidationDetail");
            DropForeignKey("dbo.tbl_ENT_ReceiptValidationDetail", "Lottable_Validation_detail_ID", "dbo.tbl_ENT_LottableValidationDetail");
            DropForeignKey("dbo.tbl_ENT_LottableValidationDetailD", "Lottable_Validation_Detail_ID", "dbo.tbl_ENT_LottableValidationDetail");
            DropForeignKey("dbo.tbl_ENT_LottableValidationDetail", "V_Lot_ID", "dbo.tbl_ENT_LottableValidation");
            DropForeignKey("dbo.tbl_ENT_Item", "V_Lot_ID", "dbo.tbl_ENT_LottableValidation");
            DropForeignKey("dbo.tbl_ENT_Item", "LIST_Code_ID4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_CycleCountValidationDetail", "LottableAdjustmentRule_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "V_Cycle_Count_ID", "dbo.tbl_ENT_CycleCountValidation");
            DropForeignKey("dbo.tbl_ENT_Item", "V_CycleCount_ID", "dbo.tbl_ENT_CycleCountValidation");
            DropForeignKey("dbo.tbl_ENT_CycleCountValidationDetail", "V_CycleCount_ID", "dbo.tbl_ENT_CycleCountValidation");
            DropForeignKey("dbo.tbl_ENT_Customer", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Customer", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "Type_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "Priority_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_SO", "OutboundstatusID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Wave", "SO_ID", "dbo.tbl_WHS_SO");
            DropForeignKey("dbo.tbl_ENT_Wave", "Wave_Status_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Adjustment_Detail", "Adjustment_ID", "dbo.tbl_WHS_Adjustment");
            DropForeignKey("dbo.tbl_WHS_Adjustment_Detail", "AdjustmentReasonID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_GoodReceiptNote", "ASN_Detail_ID", "dbo.tbl_WHS_ASNDetail");
            DropForeignKey("dbo.tbl_WHS_GoodReceiptNote", "User_ID", "dbo.tbl_ENT_User");
            DropForeignKey("dbo.tbl_WHS_Zone", "Replenishment_MethodDetail_ID", "dbo.tbl_WHS_Replenishment");
            DropForeignKey("dbo.tbl_WHS_Location", "WHS_Zone_ID", "dbo.tbl_WHS_Zone");
            DropForeignKey("dbo.tbl_WHS_Zone", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Zone", "WHS_Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Location", "Zone_ID", "dbo.tbl_WHS_Zone");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "WHS_Location_ID1", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "WHS_Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "zone_ID", "dbo.tbl_WHS_Zone");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "putaway_strategy_ID", "dbo.tbl_WHS_Strategy_Putaway");
            DropForeignKey("dbo.tbl_ENT_Owner", "Putaway_Strategy_ID", "dbo.tbl_WHS_Strategy_Putaway");
            DropForeignKey("dbo.tbl_ENT_Item", "Putaway_Strategy_Id", "dbo.tbl_WHS_Strategy_Putaway");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "to_location", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "from_location", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Puttaway_Type_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Demention_Restriction_5", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Demention_Restriction_4", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Demention_Restriction_3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Demention_Restriction_2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "Demention_Restriction_1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "area_restriction_3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "area_restriction_2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Strategy_Putaway_Step", "area_restriction_1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Move", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Move", "To_LPN", "dbo.tbl_WHS_Consolidate");
            DropForeignKey("dbo.tbl_WHS_Consolidate", "ASN_Detail_ID", "dbo.tbl_WHS_ASNDetail");
            DropForeignKey("dbo.tbl_WHS_Move", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_SO_Detail", "SO_ID", "dbo.tbl_WHS_SO");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "SO_Detail_ID", "dbo.tbl_WHS_SO_Detail");
            DropForeignKey("dbo.tbl_WHS_Packing_List", "SO_Detail_ID", "dbo.tbl_WHS_SO_Detail");
            DropForeignKey("dbo.tbl_WHS_SO_Detail", "Pack_ID", "dbo.tbl_ENT_Pack");
            DropForeignKey("dbo.tbl_WHS_SO_Detail", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_ENT_Delivery_Note", "SO_Detail_ID", "dbo.tbl_WHS_SO_Detail");
            DropForeignKey("dbo.tbl_WHS_Picking_List", "SO_Detail_ID", "dbo.tbl_WHS_SO_Detail");
            DropForeignKey("dbo.tbl_WHS_Picking_List", "Warehouse_ID", "dbo.tbl_ENT_Warehouse");
            DropForeignKey("dbo.tbl_ENT_Delivery_Note", "Warehouse_ID", "dbo.tbl_ENT_Warehouse");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "Lot_Attribute_ID", "dbo.tbl_WHS_Lot_Attribute");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "PickStatus_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "Pack_ID", "dbo.tbl_ENT_Pack");
            DropForeignKey("dbo.tbl_WHS_Pick_Detail", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_Maintain_Hold", "Lot_ID", "dbo.tbl_WHS_Lot_Attribute");
            DropForeignKey("dbo.tbl_WHS_Lot_Attribute", "ASN_Detail_ID", "dbo.tbl_WHS_ASNDetail");
            DropForeignKey("dbo.tbl_WHS_Lot_Attribute", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_WHS_Lot_Attribute", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_Maintain_Hold", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Maintain_Hold", "Holdreason_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Maintain_Hold", "User_ID", "dbo.tbl_ENT_User");
            DropForeignKey("dbo.tbl_WHS_Maintain_Hold", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Location", "Movingspeed_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "LocationhandlingDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "Location_Type_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "Location_StatusDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "Flag_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "Category_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Location", "C_System_MovingspeedDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "Location_ID", "dbo.tbl_WHS_Location");
            DropForeignKey("dbo.tbl_WHS_Zone", "ReplenishmentlevelDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_Zone", "PositiveValidationMethod_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "Zone_Id", "dbo.tbl_WHS_Zone");
            DropForeignKey("dbo.tbl_WHS_Replenishment", "ASN_Receipt_ID", "dbo.tbl_WHS_ASN");
            DropForeignKey("dbo.tbl_WHS_Replenishment", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ReceiptReversalDetail", "Receipt_reversal_ID", "dbo.tbl_WHS_ReceiptReversal");
            DropForeignKey("dbo.tbl_WHS_ReceiptReversalDetail", "ASN_Detail_ID", "dbo.tbl_WHS_ASNDetail");
            DropForeignKey("dbo.tbl_WHS_ReceiptReversal", "ASN_ID", "dbo.tbl_WHS_ASN");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "ASN_ID", "dbo.tbl_WHS_ASN");
            DropForeignKey("dbo.tbl_WHS_ASN", "ReceiptStatus_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PODetail", "PO_ID", "dbo.tbl_WHS_PO");
            DropForeignKey("dbo.tbl_WHS_PODetail", "C_System_POStatus_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PODetail", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_PO", "UOM_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PO", "C_System_POStatus_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_WHS_PO", "Supplier_ID", "dbo.tbl_ENT_Supplier");
            DropForeignKey("dbo.tbl_WHS_PO", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_WHS_ASN", "Supplier_ID", "dbo.tbl_ENT_Supplier");
            DropForeignKey("dbo.tbl_ENT_Supplier", "District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "Billing_District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Supplier", "Billing_City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "ENT_Supplier_ID", "dbo.tbl_ENT_Supplier");
            DropForeignKey("dbo.tbl_ENT_Supplier", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Supplier", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ASN", "Carrier_ID", "dbo.tbl_ENT_Carrier");
            DropForeignKey("dbo.tbl_WHS_Adjustment_Detail", "ASN_Detail_ID", "dbo.tbl_WHS_ASNDetail");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "Pack_ID", "dbo.tbl_ENT_Pack");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "UOM_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_ASNDetail", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_WHS_Adjustment_Detail", "Pack_ID", "dbo.tbl_ENT_Pack");
            DropForeignKey("dbo.tbl_ENT_Pack", "UOM_WeightDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "UOM_QuantityDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "UOM_PackageDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Pack", "UOM_CubeDetail_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Item", "Pack_Id", "dbo.tbl_ENT_Pack");
            DropForeignKey("dbo.tbl_ENT_Pack", "Carton_ID", "dbo.tbl_ENT_Cartonization");
            DropForeignKey("dbo.tbl_WHS_Adjustment", "User_ID", "dbo.tbl_ENT_User");
            DropForeignKey("dbo.tbl_WHS_Adjustment", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Wave", "User_ID", "dbo.tbl_ENT_User");
            DropForeignKey("dbo.tbl_WHS_SO", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_WHS_SO", "Customer_ID", "dbo.tbl_ENT_Customer");
            DropForeignKey("dbo.tbl_WHS_SO", "Carrier_ID", "dbo.tbl_ENT_Carrier");
            DropForeignKey("dbo.tbl_ENT_Customer", "District", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Customer", "City", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "ENT_Customer_ID", "dbo.tbl_ENT_Customer");
            DropForeignKey("dbo.tbl_ENT_Customer", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_OutboundValidation", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_OutboundValidation", "Conditional_Validation_ID", "dbo.tbl_ENT_OutboundValidation");
            DropForeignKey("dbo.tbl_ENT_OutboundValidationDetail", "Code_Validation_routine_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_OutboundValidationDetail", "Outbound_validation_ID", "dbo.tbl_ENT_OutboundValidation");
            DropForeignKey("dbo.tbl_ENT_OutboundValidation", "Item_ID", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_ENT_OutboundValidation", "Customer_ID", "dbo.tbl_ENT_Customer");
            DropForeignKey("dbo.tbl_ENT_Carrier", "LIST_Code_ID3", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "LIST_Code_ID2", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "LIST_Code_ID1", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Carrier", "LIST_Code_ID", "dbo.tbl_LIST_Code");
            DropForeignKey("dbo.tbl_ENT_Owner", "ENT_Carrier_ID", "dbo.tbl_ENT_Carrier");
            DropForeignKey("dbo.tbl_ENT_Carrier", "Owner_ID", "dbo.tbl_ENT_Owner");
            DropForeignKey("dbo.tbl_ENT_Item", "Carton_ID", "dbo.tbl_ENT_Cartonization");
            DropForeignKey("dbo.tbl_ENT_BOM", "ENT_Item_ID1", "dbo.tbl_ENT_Item");
            DropForeignKey("dbo.tbl_ENT_BOM", "ENT_Item_ID", "dbo.tbl_ENT_Item");
            DropIndex("dbo.tbl_WHS_Transaction", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Transaction", new[] { "Activity_ID" });
            DropIndex("dbo.tbl_WHS_Owner_Label", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_Owner_Label", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_Owner_Label", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_WHS_Owner_Label", new[] { "LPN_Barcode_Format" });
            DropIndex("dbo.tbl_WHS_Owner_Label", new[] { "Case_Label_Type" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID5" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID4" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "V_date_format_ID" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Field_type" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Date_type" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Code_how_to_process_ID" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Code_Date_type_ID" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Code_date_field_ID" });
            DropIndex("dbo.tbl_ENT_V_DateFormatDetail", new[] { "Code_Date_element_ID" });
            DropIndex("dbo.tbl_ENT_ReceiptValidationDetail", new[] { "Lottable_Validation_detail_ID" });
            DropIndex("dbo.tbl_ENT_ReceiptValidationDetail", new[] { "Allow_error_ID" });
            DropIndex("dbo.tbl_ENT_LottableValidationDetail", new[] { "V_Lot_ID" });
            DropIndex("dbo.tbl_ENT_LottableValidationDetailD", new[] { "V_Date_fortmat_ID" });
            DropIndex("dbo.tbl_ENT_LottableValidationDetailD", new[] { "Lottable_Validation_Detail_ID" });
            DropIndex("dbo.tbl_ENT_LottableValidationDetailD", new[] { "Lottable_conversion_ID" });
            DropIndex("dbo.tbl_ENT_CycleCountValidationDetail", new[] { "V_CycleCount_ID" });
            DropIndex("dbo.tbl_ENT_CycleCountValidationDetail", new[] { "LottableAdjustmentRule_ID" });
            DropIndex("dbo.tbl_WHS_GoodReceiptNote", new[] { "User_ID" });
            DropIndex("dbo.tbl_WHS_GoodReceiptNote", new[] { "ASN_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID8" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID7" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID6" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID5" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID4" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "WHS_Location_ID1" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "WHS_Location_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "zone_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "to_location" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Puttaway_Type_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "putaway_strategy_ID" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "from_location" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Demention_Restriction_5" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Demention_Restriction_4" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Demention_Restriction_3" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Demention_Restriction_2" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "Demention_Restriction_1" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "area_restriction_3" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "area_restriction_2" });
            DropIndex("dbo.tbl_WHS_Strategy_Putaway_Step", new[] { "area_restriction_1" });
            DropIndex("dbo.tbl_WHS_Consolidate", new[] { "ASN_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Move", new[] { "To_LPN" });
            DropIndex("dbo.tbl_WHS_Move", new[] { "Location_ID" });
            DropIndex("dbo.tbl_WHS_Move", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Packing_List", new[] { "SO_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Picking_List", new[] { "Warehouse_ID" });
            DropIndex("dbo.tbl_WHS_Picking_List", new[] { "SO_Detail_ID" });
            DropIndex("dbo.tbl_ENT_Delivery_Note", new[] { "Warehouse_ID" });
            DropIndex("dbo.tbl_ENT_Delivery_Note", new[] { "SO_Detail_ID" });
            DropIndex("dbo.tbl_WHS_SO_Detail", new[] { "SO_ID" });
            DropIndex("dbo.tbl_WHS_SO_Detail", new[] { "Pack_ID" });
            DropIndex("dbo.tbl_WHS_SO_Detail", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "SO_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "PickStatus_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "Pack_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "Lot_Attribute_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "Location_ID" });
            DropIndex("dbo.tbl_WHS_Pick_Detail", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Lot_Attribute", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_WHS_Lot_Attribute", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Lot_Attribute", new[] { "ASN_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Maintain_Hold", new[] { "User_ID" });
            DropIndex("dbo.tbl_WHS_Maintain_Hold", new[] { "Lot_ID" });
            DropIndex("dbo.tbl_WHS_Maintain_Hold", new[] { "Location_ID" });
            DropIndex("dbo.tbl_WHS_Maintain_Hold", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Maintain_Hold", new[] { "Holdreason_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID6" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID5" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID4" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "WHS_Zone_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Zone_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Movingspeed_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "LocationhandlingDetail_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Location_Type_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Location_StatusDetail_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Flag_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "Category_ID" });
            DropIndex("dbo.tbl_WHS_Location", new[] { "C_System_MovingspeedDetail_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "WHS_Location_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "ReplenishmentlevelDetail_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "Replenishment_MethodDetail_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "PositiveValidationMethod_ID" });
            DropIndex("dbo.tbl_WHS_Zone", new[] { "Location_ID" });
            DropIndex("dbo.tbl_WHS_Replenishment", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_Replenishment", new[] { "ASN_Receipt_ID" });
            DropIndex("dbo.tbl_WHS_ReceiptReversalDetail", new[] { "Receipt_reversal_ID" });
            DropIndex("dbo.tbl_WHS_ReceiptReversalDetail", new[] { "ASN_Detail_ID" });
            DropIndex("dbo.tbl_WHS_ReceiptReversal", new[] { "ASN_ID" });
            DropIndex("dbo.tbl_WHS_PODetail", new[] { "PO_ID" });
            DropIndex("dbo.tbl_WHS_PODetail", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_PODetail", new[] { "C_System_POStatus_ID" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "UOM_ID" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "Supplier_ID" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_WHS_PO", new[] { "C_System_POStatus_ID" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "ENT_Owner_ID" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "Item_ID" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "District" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "City" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "Billing_District" });
            DropIndex("dbo.tbl_ENT_Supplier", new[] { "Billing_City" });
            DropIndex("dbo.tbl_WHS_ASN", new[] { "Supplier_ID" });
            DropIndex("dbo.tbl_WHS_ASN", new[] { "ReceiptStatus_ID" });
            DropIndex("dbo.tbl_WHS_ASN", new[] { "Carrier_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "ENT_Item_ID1" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "ENT_Item_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "UOM_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "Pack_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "Location_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "Item_ID" });
            DropIndex("dbo.tbl_WHS_ASNDetail", new[] { "ASN_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "UOM_WeightDetail_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "UOM_QuantityDetail_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "UOM_PackageDetail_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "UOM_CubeDetail_ID" });
            DropIndex("dbo.tbl_ENT_Pack", new[] { "Carton_ID" });
            DropIndex("dbo.tbl_WHS_Adjustment_Detail", new[] { "Pack_ID" });
            DropIndex("dbo.tbl_WHS_Adjustment_Detail", new[] { "ASN_Detail_ID" });
            DropIndex("dbo.tbl_WHS_Adjustment_Detail", new[] { "AdjustmentReasonID" });
            DropIndex("dbo.tbl_WHS_Adjustment_Detail", new[] { "Adjustment_ID" });
            DropIndex("dbo.tbl_WHS_Adjustment", new[] { "User_ID" });
            DropIndex("dbo.tbl_WHS_Adjustment", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_ENT_Wave", new[] { "Wave_Status_ID" });
            DropIndex("dbo.tbl_ENT_Wave", new[] { "User_ID" });
            DropIndex("dbo.tbl_ENT_Wave", new[] { "SO_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "Type_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "Priority_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "OutboundstatusID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "Customer_ID" });
            DropIndex("dbo.tbl_WHS_SO", new[] { "Carrier_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidationDetail", new[] { "Outbound_validation_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidationDetail", new[] { "Code_Validation_routine_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidation", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidation", new[] { "Item_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidation", new[] { "Customer_ID" });
            DropIndex("dbo.tbl_ENT_OutboundValidation", new[] { "Conditional_Validation_ID" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "ENT_Owner_ID" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "District" });
            DropIndex("dbo.tbl_ENT_Customer", new[] { "City" });
            DropIndex("dbo.tbl_LIST_Code", new[] { "Type" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "ENT_Owner_ID" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "Owner_ID" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "District" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "City" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "Billing_District" });
            DropIndex("dbo.tbl_ENT_Carrier", new[] { "Billing_City" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "LIST_Code_ID4" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "ENT_Supplier_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "ENT_Customer_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "ENT_Carrier_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "V_Cycle_Count_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Supplier_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Rotation_Detail_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Rotation_Detail_By" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Receipt_Validation_Detail_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Putaway_Strategy_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Cycle_Class_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Customer_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "City" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Cartonization_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Carrier_ID" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Billing_District" });
            DropIndex("dbo.tbl_ENT_Owner", new[] { "Billing_City" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "LIST_Code_ID4" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "LIST_Code_ID3" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "LIST_Code_ID2" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "LIST_Code_ID1" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "LIST_Code_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Zone_Id" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "V_Receipt_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "V_Lot_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "V_CycleCount_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "RotationDetail_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "RotatebyDetail_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Putaway_Strategy_Id" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Pack_Id" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Owner_Id" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Location_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "ItemtypeDetail_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "CycleClass_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Code_UOM_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "Carton_ID" });
            DropIndex("dbo.tbl_ENT_Item", new[] { "C_System_Itemtype" });
            DropIndex("dbo.tbl_ENT_BOM", new[] { "ENT_Item_ID1" });
            DropIndex("dbo.tbl_ENT_BOM", new[] { "ENT_Item_ID" });
            DropIndex("dbo.tbl_ENT_BOM", new[] { "Item_ID" });
            DropIndex("dbo.tbl_ENT_BOM", new[] { "Component_ID" });
            DropTable("dbo.tbl_ENT_ReceiptValidation");
            DropTable("dbo.tbl_ENT_CycleClass");
            DropTable("dbo.tbl_WHS_Transaction");
            DropTable("dbo.tbl_WHS_Owner_Label");
            DropTable("dbo.tbl_ENT_V_DateFormatDetail");
            DropTable("dbo.tbl_ENT_V_DateFormat");
            DropTable("dbo.tbl_ENT_ReceiptValidationDetail");
            DropTable("dbo.tbl_ENT_LottableValidation");
            DropTable("dbo.tbl_ENT_LottableValidationDetail");
            DropTable("dbo.tbl_ENT_LottableValidationDetailD");
            DropTable("dbo.tbl_ENT_CycleCountValidation");
            DropTable("dbo.tbl_ENT_CycleCountValidationDetail");
            DropTable("dbo.tbl_WHS_GoodReceiptNote");
            DropTable("dbo.tbl_WHS_Strategy_Putaway");
            DropTable("dbo.tbl_WHS_Strategy_Putaway_Step");
            DropTable("dbo.tbl_WHS_Consolidate");
            DropTable("dbo.tbl_WHS_Move");
            DropTable("dbo.tbl_WHS_Packing_List");
            DropTable("dbo.tbl_WHS_Picking_List");
            DropTable("dbo.tbl_ENT_Warehouse");
            DropTable("dbo.tbl_ENT_Delivery_Note");
            DropTable("dbo.tbl_WHS_SO_Detail");
            DropTable("dbo.tbl_WHS_Pick_Detail");
            DropTable("dbo.tbl_WHS_Lot_Attribute");
            DropTable("dbo.tbl_WHS_Maintain_Hold");
            DropTable("dbo.tbl_WHS_Location");
            DropTable("dbo.tbl_WHS_Zone");
            DropTable("dbo.tbl_WHS_Replenishment");
            DropTable("dbo.tbl_WHS_ReceiptReversalDetail");
            DropTable("dbo.tbl_WHS_ReceiptReversal");
            DropTable("dbo.tbl_WHS_PODetail");
            DropTable("dbo.tbl_WHS_PO");
            DropTable("dbo.tbl_ENT_Supplier");
            DropTable("dbo.tbl_WHS_ASN");
            DropTable("dbo.tbl_WHS_ASNDetail");
            DropTable("dbo.tbl_ENT_Pack");
            DropTable("dbo.tbl_WHS_Adjustment_Detail");
            DropTable("dbo.tbl_WHS_Adjustment");
            DropTable("dbo.tbl_ENT_User");
            DropTable("dbo.tbl_ENT_Wave");
            DropTable("dbo.tbl_WHS_SO");
            DropTable("dbo.tbl_ENT_OutboundValidationDetail");
            DropTable("dbo.tbl_ENT_OutboundValidation");
            DropTable("dbo.tbl_ENT_Customer");
            DropTable("dbo.tbl_LIST_Code");
            DropTable("dbo.tbl_ENT_Carrier");
            DropTable("dbo.tbl_ENT_Owner");
            DropTable("dbo.tbl_ENT_Cartonization");
            DropTable("dbo.tbl_ENT_Item");
            DropTable("dbo.tbl_ENT_BOM");
        }
    }
}
