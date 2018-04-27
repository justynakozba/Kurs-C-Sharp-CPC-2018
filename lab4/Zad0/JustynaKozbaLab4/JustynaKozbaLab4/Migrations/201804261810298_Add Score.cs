namespace JustynaKozbaLab4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Score");
        }
    }
}
