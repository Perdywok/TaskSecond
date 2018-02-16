namespace TaskSecond.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Publisher", c => c.String());
            DropColumn("dbo.Books", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Content", c => c.String());
            DropColumn("dbo.Books", "Publisher");
        }
    }
}
