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
                        employeeId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        age = c.Int(nullable: false),
                        mobileNumber = c.String(),
                        email = c.String(),
                        gender = c.String(),
                        employeeType = c.Int(nullable: false),
                        joiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.employeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
