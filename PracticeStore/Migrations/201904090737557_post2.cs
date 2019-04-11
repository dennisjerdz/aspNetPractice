namespace PracticeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class post2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "DateTimeCreated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DateTimeCreated", c => c.DateTime(nullable: false));
        }
    }
}
