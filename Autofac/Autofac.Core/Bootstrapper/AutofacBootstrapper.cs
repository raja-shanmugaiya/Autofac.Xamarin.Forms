using System.Reflection;

namespace Autofac.Core.Bootstrapper
{
    public abstract class AutofacBootstrapper
    {
        protected ContainerBuilder ContainerBuilder { get; private set; }

        public AutofacBootstrapper()
        {
            Initialize();
            FinishInitialization();
        }

        protected virtual void Initialize()
        {

            ContainerBuilder = new ContainerBuilder();
            var currentAssembly = Assembly.GetExecutingAssembly();

            ContainerBuilder.RegisterAssemblyTypes(currentAssembly).Where(t => t.Name.EndsWith("View")).SingleInstance();

            ContainerBuilder.RegisterAssemblyTypes(currentAssembly).Where(t => t.Name.EndsWith("ViewModel")).SingleInstance();

            //ContainerBuilder.RegisterType<TodoItemRepository>().SingleInstance();
        }

        private void FinishInitialization()
        {
            var container = ContainerBuilder.Build();
            Resolver.Initialize(container);
        }
    }
}
