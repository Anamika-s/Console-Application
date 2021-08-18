namespace ConsoleApp7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "Fees", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Batches", "Fees");
        }
    }
}
