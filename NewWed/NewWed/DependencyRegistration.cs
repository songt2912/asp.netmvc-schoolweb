using Autofac;
using Autofac.Integration.Mvc;
using NewWed.Data;
using NewWed.Service.Implement;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace NewWed
{
    public static class DependencyRegistration
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            builder.RegisterType<ClassRoomService>().As<IClassRoomService>().InstancePerLifetimeScope();
            builder.RegisterType<SubjectService>().As<ISubjectService>().InstancePerLifetimeScope();
            builder.RegisterType<SubjectScoreService>().As<ISubjectScoreService>().InstancePerLifetimeScope();
            builder.RegisterType<AllTable>().As<IAllTable>().InstancePerLifetimeScope();
            builder.RegisterType<SubjectScoreService>().As<ISubjectScoreService>().InstancePerLifetimeScope();
            var connectionString = ConfigurationManager.ConnectionStrings["SchoolWedEntities"].ConnectionString;
            builder.Register<ISchoolEntitiesData>(c => new SchoolWedEntities(connectionString)).InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}