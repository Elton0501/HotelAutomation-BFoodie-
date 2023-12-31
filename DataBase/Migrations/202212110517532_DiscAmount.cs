﻿namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DiscAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DiscountAmount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "DiscountAmount");
        }
    }
}
