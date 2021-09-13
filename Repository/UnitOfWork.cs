using book_store.Data;
using book_store.Data.DTOs;
using book_store.IRepository;

namespace book_store.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IGenericRepository<Book> _bookRepo;
        public IGenericRepository<BookCategory> _bookCategoryRepo;
    }
}