using BookStoreAPI.Models;
using BookStoreAPI.Repository;

namespace BookStoreAPI.UnitOfWork
{
    public class UnitOfWork
    {
        BookStoreContext db;
        GenericRepository<Book> BookRepository;
        GenericRepository<Order> OrderRepository;
        GenericRepository<OrderItems> OrderItemsRepository;
        GenericRepository<Author> AuthorRepository;
        GenericRepository<Catalog> CatalogRepository;

        public UnitOfWork(BookStoreContext context)
        {
            this.db = context;
        }

        public GenericRepository<Book> bookRepository
        {
            get
            {
                if (bookRepository == null)
                {
                    BookRepository = new GenericRepository<Book>(db);
                }
                return bookRepository;
            }
        }    

        public GenericRepository<Order> orderRepository
        {
            get
            {
                if (orderRepository == null)
                    OrderRepository = new GenericRepository<Order>(db);
                return orderRepository;
            }
        }

        public GenericRepository<OrderItems> orderItemsRepository
        {
            get
            {
                if(orderItemsRepository == null)
                {
                    OrderItemsRepository = new GenericRepository<OrderItems>(db);
                }
                return orderItemsRepository;
            }
        }

        public GenericRepository<Author> authorRepository
        {
            get
            {
                if (authorRepository == null)
                    AuthorRepository = new GenericRepository<Author>(db);
                return authorRepository;
            }
        }

        public GenericRepository<Catalog> catalogRepository
        {
            get
            {
                if (catalogRepository == null)
                    CatalogRepository = new GenericRepository<Catalog>(db);
                return catalogRepository;
            }
        }


    }
}
