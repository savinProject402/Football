namespace Football.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamePlayer = c.String(),
                        MatchesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchesId, cascadeDelete: true)
                .Index(t => t.MatchesId);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameMatches = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayersCards",
                c => new
                    {
                        Players_Id = c.Int(nullable: false),
                        Cards_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Players_Id, t.Cards_Id })
                .ForeignKey("dbo.Players", t => t.Players_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cards", t => t.Cards_Id, cascadeDelete: true)
                .Index(t => t.Players_Id)
                .Index(t => t.Cards_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "MatchesId", "dbo.Matches");
            DropForeignKey("dbo.PlayersCards", "Cards_Id", "dbo.Cards");
            DropForeignKey("dbo.PlayersCards", "Players_Id", "dbo.Players");
            DropIndex("dbo.PlayersCards", new[] { "Cards_Id" });
            DropIndex("dbo.PlayersCards", new[] { "Players_Id" });
            DropIndex("dbo.Players", new[] { "MatchesId" });
            DropTable("dbo.PlayersCards");
            DropTable("dbo.Matches");
            DropTable("dbo.Players");
            DropTable("dbo.Cards");
        }
    }
}
