using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ProjectCanine.AdminPortal_OLD.Data;
using ProjectCanine.AdminPortal_OLD.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace ProjectCanine.AdminPortal_OLD
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			// Create the container as usual.
			var container = new Container();
			container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

			// Register types
			// Because of how the Reverse POCO Generator generates the actual 
			// DbContext class (with FIVE constructors!), we have to spin up a basic
			// instance here and set it as the instance that will be injected into
			// any/all controllers or services that ask for an ICanineProjDbContext.
			// See: ExportToPdfController
			container.Register<ICanineProjDbContext>(() => new CanineProjDbContext(), Lifestyle.Scoped);

			container.Register<ICertificationTypeServices, CertificationTypeServices>(Lifestyle.Scoped);
			container.Register<IExaminerServices, ExaminerServices>(Lifestyle.Scoped);
			container.Register<IExportToPdfServices, ExportToPdfServices>(Lifestyle.Scoped);
			container.Register<IEquipmentRestrictionServices, EquipmentRestrictionServices>(Lifestyle.Scoped);
			container.Register<ITestResultServices, TestResultServices>(Lifestyle.Scoped);
			container.Register<ITestServices, TestServices>(Lifestyle.Scoped);

			// This is an extension method from the integration package.
			container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

			container.Verify();

			DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

			// "normal" stuff
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
