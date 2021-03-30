namespace WebApiMedical.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        appointment_id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        note = c.String(),
                        patient_id = c.Int(),
                    })
                .PrimaryKey(t => t.appointment_id)
                .ForeignKey("dbo.Patients", t => t.patient_id)
                .Index(t => t.patient_id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        patient_id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.patient_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "patient_id", "dbo.Patients");
            DropIndex("dbo.Appointments", new[] { "patient_id" });
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
