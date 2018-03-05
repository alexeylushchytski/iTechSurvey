namespace Application.DependencyResolution {
    using Models;
    using Repositories;
    using StructureMap;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using System.Data.Entity;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });

            For<UserRepository>().Use<UserRepository>();
            For<DbConnection>().Singleton().Use<DbConnection>();
            For<EmailService.EmailSender>().Use<EmailService.EmailSender>();
        }

        #endregion
    }
}