namespace ConsoleApp7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Timings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "Timings", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Batches", "Timings");
        }
    }
}
