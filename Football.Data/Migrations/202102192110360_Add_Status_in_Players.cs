namespace Football.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Status_in_Players : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Status", c => c.Int(nullable: false));
        }
    }
}
