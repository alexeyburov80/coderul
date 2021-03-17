using Microsoft.EntityFrameworkCore;

namespace CoderUL.Model
{
    public partial class DBContextElectricityConsumer : DbContext, IDBContextElectricityConsumer
    {
        public DBContextElectricityConsumer(DbContextOptions<DBContextElectricityConsumer> options)
            : base(options)
        {    }

    
        public virtual DbSet<ElectricityConsumer> ElectricityConsumers { get; set; }

        void IDBContextElectricityConsumer.SaveChanges()
        {
            SaveChanges();
        }
    }
}