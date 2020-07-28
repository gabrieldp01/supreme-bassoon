namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CashFlows", "Box_Id", c => c.Int());
            AddColumn("dbo.Devolutions", "SaleDetail_Id", c => c.Int());
            AddColumn("dbo.Logs", "User_ID", c => c.Int());
            AddColumn("dbo.Products", "Category_Id", c => c.Int());
            AddColumn("dbo.PurchaseDetails", "Product_Id", c => c.Int());
            AddColumn("dbo.PurchaseDetails", "Purchase_Id", c => c.Int());
            AddColumn("dbo.Purchases", "CashFlow_Id", c => c.Int());
            AddColumn("dbo.SaleDetails", "Product_Id", c => c.Int());
            AddColumn("dbo.SaleDetails", "Sale_Id", c => c.Int());
            AddColumn("dbo.Sales", "CashFlow_Id", c => c.Int());
            AddColumn("dbo.Sales", "User_ID", c => c.Int());
            AddColumn("dbo.Users", "Rol_Id", c => c.Int());
            CreateIndex("dbo.CashFlows", "Box_Id");
            CreateIndex("dbo.Devolutions", "SaleDetail_Id");
            CreateIndex("dbo.SaleDetails", "Product_Id");
            CreateIndex("dbo.SaleDetails", "Sale_Id");
            CreateIndex("dbo.Products", "Category_Id");
            CreateIndex("dbo.Sales", "CashFlow_Id");
            CreateIndex("dbo.Sales", "User_ID");
            CreateIndex("dbo.Users", "Rol_Id");
            CreateIndex("dbo.Logs", "User_ID");
            CreateIndex("dbo.PurchaseDetails", "Product_Id");
            CreateIndex("dbo.PurchaseDetails", "Purchase_Id");
            CreateIndex("dbo.Purchases", "CashFlow_Id");
            AddForeignKey("dbo.CashFlows", "Box_Id", "dbo.Boxes", "Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.SaleDetails", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Sales", "CashFlow_Id", "dbo.CashFlows", "Id");
            AddForeignKey("dbo.Users", "Rol_Id", "dbo.Rols", "Id");
            AddForeignKey("dbo.Sales", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.SaleDetails", "Sale_Id", "dbo.Sales", "Id");
            AddForeignKey("dbo.Devolutions", "SaleDetail_Id", "dbo.SaleDetails", "Id");
            AddForeignKey("dbo.Logs", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.PurchaseDetails", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Purchases", "CashFlow_Id", "dbo.CashFlows", "Id");
            AddForeignKey("dbo.PurchaseDetails", "Purchase_Id", "dbo.Purchases", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseDetails", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "CashFlow_Id", "dbo.CashFlows");
            DropForeignKey("dbo.PurchaseDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Logs", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Devolutions", "SaleDetail_Id", "dbo.SaleDetails");
            DropForeignKey("dbo.SaleDetails", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.Sales", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Users", "Rol_Id", "dbo.Rols");
            DropForeignKey("dbo.Sales", "CashFlow_Id", "dbo.CashFlows");
            DropForeignKey("dbo.SaleDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.CashFlows", "Box_Id", "dbo.Boxes");
            DropIndex("dbo.Purchases", new[] { "CashFlow_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Purchase_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Product_Id" });
            DropIndex("dbo.Logs", new[] { "User_ID" });
            DropIndex("dbo.Users", new[] { "Rol_Id" });
            DropIndex("dbo.Sales", new[] { "User_ID" });
            DropIndex("dbo.Sales", new[] { "CashFlow_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.SaleDetails", new[] { "Sale_Id" });
            DropIndex("dbo.SaleDetails", new[] { "Product_Id" });
            DropIndex("dbo.Devolutions", new[] { "SaleDetail_Id" });
            DropIndex("dbo.CashFlows", new[] { "Box_Id" });
            DropColumn("dbo.Users", "Rol_Id");
            DropColumn("dbo.Sales", "User_ID");
            DropColumn("dbo.Sales", "CashFlow_Id");
            DropColumn("dbo.SaleDetails", "Sale_Id");
            DropColumn("dbo.SaleDetails", "Product_Id");
            DropColumn("dbo.Purchases", "CashFlow_Id");
            DropColumn("dbo.PurchaseDetails", "Purchase_Id");
            DropColumn("dbo.PurchaseDetails", "Product_Id");
            DropColumn("dbo.Products", "Category_Id");
            DropColumn("dbo.Logs", "User_ID");
            DropColumn("dbo.Devolutions", "SaleDetail_Id");
            DropColumn("dbo.CashFlows", "Box_Id");
        }
    }
}
