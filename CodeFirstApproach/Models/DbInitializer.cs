using System.Data.Entity;

namespace CodeFirstApproach.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<CodeFirstApproachContext>
    {
        protected override void Seed(CodeFirstApproachContext context)
        {
            base.Seed(context);
        }
    }
}