using Autofac;
using SkateshopApi.Interfaces;
using SkateshopApi.Services;

namespace SkateshopApi.App_Start
{
    public class AutofacBuilder
    {
        private ContainerBuilder builder;

        private AutofacBuilder(ContainerBuilder _builder)
        {
            this.builder = _builder;
        }
        public static AutofacBuilder CreateBuilder()
        {
            var builder = new ContainerBuilder();
            return new AutofacBuilder(builder);
        }

        public AutofacBuilder AndRegisterComponents() 
        {
            this.builder.RegisterType<LogInOutService>().As<ILogInOutService>().AsSelf().SingleInstance();
            return this; // return AutofacBuilder      
        }

        public ContainerBuilder AndGet()
        {
            return this.builder;
        }
    }    
}