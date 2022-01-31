using System;
using Library_Persistence;
using Library_Persistence.UnitOfWork;

namespace Library_DTO
{
    public class UnitOfWorkFactory
    {
        public static UnitOfWork Create()
        {
            var context = new ApplicationContext();
            UnitOfWork uow = new UnitOfWork(context);
            return uow;
        }
    }
}