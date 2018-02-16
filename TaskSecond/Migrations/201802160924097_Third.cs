namespace TaskSecond.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "Book_BookId", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Book_BookId" });
            AddColumn("dbo.Authors", "BookId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Author_AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "Author_AuthorId");
            AddForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors", "AuthorId");
            DropColumn("dbo.Authors", "Book_BookId");
            DropColumn("dbo.Books", "AuthorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            AddColumn("dbo.Authors", "Book_BookId", c => c.Int());
            DropForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorId" });
            DropColumn("dbo.Books", "Author_AuthorId");
            DropColumn("dbo.Authors", "BookId");
            CreateIndex("dbo.Authors", "Book_BookId");
            AddForeignKey("dbo.Authors", "Book_BookId", "dbo.Books", "BookId");
        }
    }
}
