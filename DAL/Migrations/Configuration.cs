using System.Data.Entity.Migrations;

namespace iTechart.Survey.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<iTechart.Survey.DAL.Context.SurveyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(iTechart.Survey.DAL.Context.SurveyContext context)
        {
        }
    }
}