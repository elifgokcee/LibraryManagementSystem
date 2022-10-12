namespace LibraryManagamentSystem.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dd1 : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.BookRezervations", "RezervePersonId", "dbo.Members", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
