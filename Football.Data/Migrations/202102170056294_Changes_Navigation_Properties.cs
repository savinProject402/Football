namespace Football.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes_Navigation_Properties : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.PlayersCards", newName: "CardsPlayers");
            DropPrimaryKey("dbo.CardsPlayers");
            AlterColumn("dbo.Players", "NamePlayer", c => c.String(maxLength: 100));
            AddPrimaryKey("dbo.CardsPlayers", new[] { "Cards_Id", "Players_Id" });
            CreateIndex("dbo.Players", "NamePlayer", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Players", new[] { "NamePlayer" });
            DropPrimaryKey("dbo.CardsPlayers");
            AlterColumn("dbo.Players", "NamePlayer", c => c.String());
            AddPrimaryKey("dbo.CardsPlayers", new[] { "Players_Id", "Cards_Id" });
            RenameTable(name: "dbo.CardsPlayers", newName: "PlayersCards");
        }
    }
}
