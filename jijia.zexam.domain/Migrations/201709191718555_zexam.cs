namespace jijia.zexam.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zexam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.S_User", "ClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.S_User", "ClassId");
            AddForeignKey("dbo.S_User", "ClassId", "dbo.S_Classes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.S_User", "ClassId", "dbo.S_Classes");
            DropIndex("dbo.S_User", new[] { "ClassId" });
            AlterColumn("dbo.S_User", "ClassId", c => c.String(maxLength: 50));
        }
    }
}
