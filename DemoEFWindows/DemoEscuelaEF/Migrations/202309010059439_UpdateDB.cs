namespace DemoEscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
        }
    }
}
