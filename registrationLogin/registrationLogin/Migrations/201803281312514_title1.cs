namespace registrationLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class title1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "title", c => c.String());
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            AlterColumn("dbo.AspNetUsers", "phoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "Code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Code", c => c.String());
            AlterColumn("dbo.AspNetUsers", "phoneNumber", c => c.String());
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "title");
        }
    }
}
