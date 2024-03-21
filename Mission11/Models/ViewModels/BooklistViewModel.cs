﻿namespace Mission11.Models.ViewModels
{
    public class BooklistViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();

    }
}
