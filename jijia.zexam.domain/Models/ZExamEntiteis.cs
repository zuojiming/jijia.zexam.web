namespace jijia.zexam.domain.models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZExamEntiteis : DbContext
    {
        public ZExamEntiteis()
            : base("name=ZExamEntiteis")
        {
        }

        public virtual DbSet<C_TestQuestionStatis> C_TestQuestionStatis { get; set; }
        public virtual DbSet<C_TestScore> C_TestScore { get; set; }
        public virtual DbSet<C_TestStatis> C_TestStatis { get; set; }
        public virtual DbSet<E_ActionUser> E_ActionUser { get; set; }
        public virtual DbSet<E_OrgExam> E_OrgExam { get; set; }
        public virtual DbSet<E_Questions> E_Questions { get; set; }
        public virtual DbSet<E_UserAnwser> E_UserAnwser { get; set; }
        public virtual DbSet<Q_CharpterQuestion> Q_CharpterQuestion { get; set; }
        public virtual DbSet<Q_CharpterQuestionHistory> Q_CharpterQuestionHistory { get; set; }
        public virtual DbSet<Q_QuestionAnwser> Q_QuestionAnwser { get; set; }
        public virtual DbSet<Q_QusAnwserGroup> Q_QusAnwserGroup { get; set; }
        public virtual DbSet<S_Charpter> S_Charpter { get; set; }
        public virtual DbSet<S_Classes> S_Classes { get; set; }
        public virtual DbSet<S_Dic> S_Dic { get; set; }
        public virtual DbSet<S_Dic_Item> S_Dic_Item { get; set; }
        public virtual DbSet<S_User> S_User { get; set; }
        public virtual DbSet<S_User_Bak> S_User_Bak { get; set; }
        public virtual DbSet<T_CharpterQuestion> T_CharpterQuestion { get; set; }
        public virtual DbSet<T_QuestionAnwser> T_QuestionAnwser { get; set; }
        public virtual DbSet<T_QusAnwserGroup> T_QusAnwserGroup { get; set; }
        public virtual DbSet<T_TestPaper> T_TestPaper { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<E_OrgExam>()
                .Property(e => e.TestPagerId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Q_QuestionAnwser>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Q_QuestionAnwser>()
                .Property(e => e.Anwser)
                .IsUnicode(false);

            modelBuilder.Entity<Q_QusAnwserGroup>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<S_User>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<S_User_Bak>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_CharpterQuestion>()
                .Property(e => e.TestPagerId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<T_QuestionAnwser>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<T_QuestionAnwser>()
                .Property(e => e.Anwser)
                .IsUnicode(false);

            modelBuilder.Entity<T_QusAnwserGroup>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}
