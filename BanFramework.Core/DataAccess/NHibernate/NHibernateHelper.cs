﻿//using NHibernate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BanFramework.Core.DataAccess.NHibernate
//{
//    public abstract class NHibernateHelper : IDisposable
//    {
//        private static ISessionFactory _sessionFactory; //factory desing pattern db türüne göre implemetasyon yapacak

//        public virtual ISessionFactory SessionFactory
//        {
//            get { return _sessionFactory ?? (_sessionFactory = InitializeFactory()); }
//        }

//        protected abstract ISessionFactory InitializeFactory();

//        //private ISessionFactory InitializeFactory()//implemetasyon yapılan yer
//        //{
//        //    throw new NotImplementedException();
//        //}

//        public virtual ISession OpenSession()
//        {
//            return SessionFactory.OpenSession();
//        }

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
