namespace FuelingsWebApi.Core
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToVehicle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "UserId");
        }
    }
}
