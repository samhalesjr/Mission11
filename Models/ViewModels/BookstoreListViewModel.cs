﻿namespace Mission11.Models.ViewModels
{
    public class BookstoreListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
