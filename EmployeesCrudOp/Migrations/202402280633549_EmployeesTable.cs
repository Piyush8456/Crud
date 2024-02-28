namespace EmployeesCrudOp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        Age = c.Int(nullable: false),
                        MobileNumber = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        EmployeeType = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
