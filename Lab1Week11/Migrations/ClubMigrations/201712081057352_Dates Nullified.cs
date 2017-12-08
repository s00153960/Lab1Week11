namespace Lab1Week11.Migrations.ClubMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatesNullified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClubEvent", "CreationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClubEvent", "CreationDate");
        }
    }
}
