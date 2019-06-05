using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Linq;
using System.Reflection;

namespace DITest
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造函数注入
            //Order orderByAccess = new Order(new AccessDal());
            //orderByAccess.Add();

            ////属性注入
            //Order orderBySql = new Order();
            //orderBySql.Ida = new SqlServerDal();
            //orderBySql.Add();

            //////接口注入
            //Order orderByOracle = new Order();
            //orderByOracle.SetDependence(new OracleDal());
            //orderByOracle.Add();

            //IOC容器注入
            //var container = new WindsorContainer();
            //1.常规注册
            //container.Register(
            //        Component.For<IDataAccess>().Named("AccessDal").ImplementedBy<AccessDal>(),
            //        Component.For<IDataAccess>().Named("SqlServerDal").ImplementedBy<SqlServerDal>()

            //    );
            //var dataAccessa = container.Resolve<IDataAccess>("AccessDal");
            //var dataAccessb = container.Resolve<IDataAccess>("SqlServerDal");
            //dataAccessa.Add();
            //dataAccessb.Add();
            //2.程序集注册
            //var controllerTypes =
            //       from t in Assembly.GetExecutingAssembly().GetTypes()
            //       where typeof(IDataAccess).IsAssignableFrom(t)
            //       select t;

            //foreach (var t in controllerTypes)
            //{
            //    //container.Register(Component.For(t).LifeStyle.Transient);
            //    container.Register(Component.For<IDataAccess>().Named(t.Name).ImplementedBy(t));

            //}

            //3.配置文件注册
            var container = new WindsorContainer("castle.config");
            var dataAccessc = container.Resolve<IDataAccess>("DITest.OracleDal");
            var dataAccessd = container.Resolve<IDataAccess>("DITest.SqlServerDal");

            dataAccessc.Add();
            dataAccessd.Add();

            Console.Read();
        }
    }
}
