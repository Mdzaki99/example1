using example1.Models;
using Microsoft.EntityFrameworkCore;

namespace example1.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext>options) : base(options){
 }
    
    public DbSet<Value> Values {get;set;} //the variable name will be used for time table in DB  
}
}