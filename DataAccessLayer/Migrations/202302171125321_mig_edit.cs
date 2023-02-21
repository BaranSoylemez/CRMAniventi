namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_edit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Quotes", "ProjectID", "dbo.Projects");
            DropIndex("dbo.Comments", new[] { "ProjectID" });
            DropIndex("dbo.Quotes", new[] { "ProjectID" });
            AddColumn("dbo.Projects", "QuoteID", c => c.Int(nullable: false));
            AddColumn("dbo.Projects", "CommentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "QuoteID");
            CreateIndex("dbo.Projects", "CommentID");
            AddForeignKey("dbo.Projects", "CommentID", "dbo.Comments", "CommentID", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "QuoteID", "dbo.Quotes", "QuoteID", cascadeDelete: true);
            DropColumn("dbo.Comments", "ProjectID");
            DropColumn("dbo.Quotes", "ProjectID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotes", "ProjectID", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "ProjectID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Projects", "QuoteID", "dbo.Quotes");
            DropForeignKey("dbo.Projects", "CommentID", "dbo.Comments");
            DropIndex("dbo.Projects", new[] { "CommentID" });
            DropIndex("dbo.Projects", new[] { "QuoteID" });
            DropColumn("dbo.Projects", "CommentID");
            DropColumn("dbo.Projects", "QuoteID");
            CreateIndex("dbo.Quotes", "ProjectID");
            CreateIndex("dbo.Comments", "ProjectID");
            AddForeignKey("dbo.Quotes", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
        }
    }
}
