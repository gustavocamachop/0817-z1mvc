using System.Data.Entity;

namespace MVCproduct.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}