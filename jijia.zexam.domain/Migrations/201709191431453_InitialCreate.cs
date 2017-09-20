namespace jijia.zexam.domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.C_TestQuestionStatis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(),
                        QuestionId1 = c.Int(),
                        QuestionFailCount1 = c.Int(),
                        QuestionId3 = c.Int(),
                        QuestionFailCount3 = c.Int(),
                        QuestionId2 = c.Int(),
                        QuestionId10 = c.Int(),
                        QuestionFailCount10 = c.Int(),
                        QuestionId9 = c.Int(),
                        QuestionFailCount9 = c.Int(),
                        QuestionId8 = c.Int(),
                        QuestionFailCount8 = c.Int(),
                        QuestionId7 = c.Int(),
                        QuestionFailCount7 = c.Int(),
                        QuestionId6 = c.Int(),
                        QuestionFailCount6 = c.Int(),
                        QuestionId5 = c.Int(),
                        QuestionFailCount5 = c.Int(),
                        QuestionFailCount2 = c.Int(),
                        QuestionId4 = c.Int(),
                        QuestionFailCount4 = c.Int(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C_TestScore",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(),
                        UserId = c.Int(),
                        Score = c.Double(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.C_TestStatis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(),
                        MaxUserId = c.Int(),
                        MaxScore = c.Double(),
                        ClassId = c.Int(),
                        MinUserId = c.Int(),
                        MinScore = c.Double(),
                        AvgScore = c.Double(),
                        PassUserCount = c.Int(),
                        FailUserCount = c.Int(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.E_ActionUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(),
                        UserId = c.Int(),
                        ClassId = c.Int(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.E_OrgExam",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestPagerId = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        Title = c.String(maxLength: 200),
                        BeginDate = c.DateTime(),
                        TimeLength = c.Int(),
                        PassScore = c.Int(),
                        ExamType = c.Int(),
                        ExamStatue = c.Int(),
                        Year = c.Int(),
                        IsPublish = c.Boolean(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.E_Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(),
                        T_QuestionId = c.Int(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.E_UserAnwser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionGroupId = c.Int(),
                        AnwserId = c.Int(),
                        IsTrue = c.Boolean(),
                        Score = c.Double(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Q_CharpterQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QusName = c.String(maxLength: 4000),
                        QusType = c.String(maxLength: 200),
                        QusCategary = c.String(maxLength: 200),
                        QusSubject = c.String(maxLength: 200),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Q_CharpterQuestionHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QusName = c.String(maxLength: 4000),
                        QusType = c.String(maxLength: 200),
                        QusCategary = c.String(maxLength: 200),
                        QusSubject = c.String(maxLength: 200),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Q_QuestionAnwser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 1, unicode: false),
                        Anwser = c.String(maxLength: 1, unicode: false),
                        GroupId = c.Int(),
                        Score = c.Double(),
                        IsTrue = c.Boolean(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Q_QusAnwserGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(),
                        D_AnwserType = c.String(maxLength: 200),
                        ParentGroup = c.Int(),
                        Title = c.String(maxLength: 1, unicode: false),
                        Prompt = c.String(maxLength: 2000),
                        Score = c.Double(),
                        Desc = c.String(maxLength: 2000),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_Charpter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(),
                        CharpterName = c.String(maxLength: 50),
                        SortNo = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        StudyDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                        IsDelete = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(maxLength: 50),
                        ClassCode = c.String(maxLength: 50),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_Dic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Desc = c.String(maxLength: 200),
                        Code = c.String(maxLength: 50),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_Dic_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 200),
                        IsDefault = c.Boolean(),
                        DicId = c.Int(),
                        Value = c.String(maxLength: 200),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Categary = c.Int(nullable: false),
                        UserName = c.String(maxLength: 50),
                        RealName = c.String(maxLength: 50),
                        Pwd = c.String(maxLength: 50),
                        Sex = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Phone = c.String(maxLength: 50),
                        IsEnabled = c.String(maxLength: 50),
                        LoginBeginDate = c.DateTime(),
                        LoginEndDate = c.DateTime(),
                        ClassId = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        StudyDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                        IsDelete = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.S_User_Bak",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        RealName = c.String(maxLength: 50),
                        Sex = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Phone = c.String(maxLength: 50),
                        IsEnabled = c.String(maxLength: 50),
                        LoginBeginDate = c.DateTime(),
                        LoginEndDate = c.DateTime(),
                        ClassId = c.String(maxLength: 50),
                        StudyDate = c.DateTime(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_CharpterQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestPagerId = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        QusName = c.String(maxLength: 4000),
                        QusType = c.String(maxLength: 200),
                        QusCategary = c.String(maxLength: 200),
                        QusSubject = c.String(maxLength: 200),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.T_QuestionAnwser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 1, unicode: false),
                        Anwser = c.String(maxLength: 1, unicode: false),
                        GroupId = c.Int(),
                        Score = c.Double(),
                        IsTrue = c.Boolean(),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_QusAnwserGroup", t => t.GroupId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.T_QusAnwserGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(),
                        AnwserType = c.String(maxLength: 200),
                        TestId = c.Int(nullable: false),
                        ParentGroupId = c.Int(),
                        Title = c.String(maxLength: 1, unicode: false),
                        Prompt = c.String(maxLength: 2000),
                        Score = c.Double(),
                        Desc = c.String(maxLength: 2000),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.T_QusAnwserGroup", t => t.ParentGroupId)
                .ForeignKey("dbo.T_TestPaper", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId)
                .Index(t => t.ParentGroupId);
            
            CreateTable(
                "dbo.T_TestPaper",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalScore = c.Double(),
                        PassScore = c.Double(),
                        Title = c.String(maxLength: 200),
                        Name = c.String(),
                        Desc = c.String(maxLength: 200),
                        IsDelete = c.Int(),
                        UpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(),
                        CreateUser = c.Int(),
                        UpdateUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.T_QusAnwserGroup", "TestId", "dbo.T_TestPaper");
            DropForeignKey("dbo.T_QusAnwserGroup", "ParentGroupId", "dbo.T_QusAnwserGroup");
            DropForeignKey("dbo.T_QuestionAnwser", "GroupId", "dbo.T_QusAnwserGroup");
            DropIndex("dbo.T_QusAnwserGroup", new[] { "ParentGroupId" });
            DropIndex("dbo.T_QusAnwserGroup", new[] { "TestId" });
            DropIndex("dbo.T_QuestionAnwser", new[] { "GroupId" });
            DropTable("dbo.T_TestPaper");
            DropTable("dbo.T_QusAnwserGroup");
            DropTable("dbo.T_QuestionAnwser");
            DropTable("dbo.T_CharpterQuestion");
            DropTable("dbo.S_User_Bak");
            DropTable("dbo.S_User");
            DropTable("dbo.S_Dic_Item");
            DropTable("dbo.S_Dic");
            DropTable("dbo.S_Classes");
            DropTable("dbo.S_Charpter");
            DropTable("dbo.Q_QusAnwserGroup");
            DropTable("dbo.Q_QuestionAnwser");
            DropTable("dbo.Q_CharpterQuestionHistory");
            DropTable("dbo.Q_CharpterQuestion");
            DropTable("dbo.E_UserAnwser");
            DropTable("dbo.E_Questions");
            DropTable("dbo.E_OrgExam");
            DropTable("dbo.E_ActionUser");
            DropTable("dbo.C_TestStatis");
            DropTable("dbo.C_TestScore");
            DropTable("dbo.C_TestQuestionStatis");
        }
    }
}
