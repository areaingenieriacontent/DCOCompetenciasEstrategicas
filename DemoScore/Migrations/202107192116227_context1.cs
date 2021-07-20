namespace DemoScore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class context1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context");
            DropIndex("dbo.MG_MultipleChoice", new[] { "Contex_Id" });
            AlterColumn("dbo.MG_MultipleChoice", "Contex_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MG_MultipleChoice", "Contex_Id");
            AddForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context", "Contex_Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context");
            DropIndex("dbo.MG_MultipleChoice", new[] { "Contex_Id" });
            AlterColumn("dbo.MG_MultipleChoice", "Contex_Id", c => c.Int());
            CreateIndex("dbo.MG_MultipleChoice", "Contex_Id");
            AddForeignKey("dbo.MG_MultipleChoice", "Contex_Id", "dbo.MG_Context", "Contex_Id");
        }
    }
}
