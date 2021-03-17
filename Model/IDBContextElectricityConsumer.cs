using Microsoft.EntityFrameworkCore;

namespace CoderUL.Model
{
    public interface IDBContextElectricityConsumer
    {
        DbSet<ElectricityConsumer> ElectricityConsumers { get; set; }

        void SaveChanges();
    }
}