
namespace Mission11.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BookstoreContext _context;
        public EFBooksRepository(BookstoreContext temp) { 
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
