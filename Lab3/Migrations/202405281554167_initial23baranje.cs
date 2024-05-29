namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial23baranje : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PatientName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "PatientName", c => c.String());
        }
    }
}
