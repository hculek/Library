﻿using System;

namespace Library_Domain.dbInterfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        IGenreRepository Genres { get; }
        int Save();
    }
}