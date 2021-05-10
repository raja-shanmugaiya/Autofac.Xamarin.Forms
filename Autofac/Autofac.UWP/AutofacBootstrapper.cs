namespace Autofac.UWP
{
    public class AutofacBootstrapper : Autofac.Core.Bootstrapper.AutofacBootstrapper
    {
        public static void Init()
        {
            var instance = new AutofacBootstrapper();
        }
    }
}
