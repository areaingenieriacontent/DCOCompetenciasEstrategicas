namespace DemoScore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class context : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MG_Context",
                c => new
                    {
                        Contex_Id = c.Int(nullable: false, identity: true),
                        Contex_Desc = c.String(),
                    })
                .PrimaryKey(t => t.Contex_Id);
            
            AddColumn("dbo.MG_MultipleChoice", "Contex_Id", c => c.Int());
            CreateIndex("dbo.MG_MultipleChoice", "Contex_Id");
            AddForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context", "Contex_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context");
            DropIndex("dbo.MG_MultipleChoice", new[] { "Contex_Id" });
            DropColumn("dbo.MG_MultipleChoice", "Contex_Id");
            DropTable("dbo.MG_Context");
        }
    }
}
