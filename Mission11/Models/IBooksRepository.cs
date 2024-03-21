namespace Mission11.Models
{
    public interface IBooksRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
