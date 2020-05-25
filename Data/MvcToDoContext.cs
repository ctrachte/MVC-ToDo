using Microsoft.EntityFrameworkCore;
using MvcToDo.Models;

namespace MvcToDo.Data
{
    public class MvcToDoContext : DbContext
    {
        public MvcToDoContext (DbContextOptions<MvcToDoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}