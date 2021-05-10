namespace Autofac.Droid
{
    public class AutofacBootstrapper : Core.Bootstrapper.AutofacBootstrapper
    {
        public static void Init()
        {
            AutofacBootstrapper instance = new AutofacBootstrapper();
        }
    }
}