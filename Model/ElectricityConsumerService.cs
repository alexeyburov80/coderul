using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderUL.Model
{
    public class ElectricityConsumerService
    {
        public List<ElectricityConsumer> GetBatchRuns(IDBContextElectricityConsumer db)
        {
            try
            {
                return db.ElectricityConsumers.OrderByDescending(p => p.Id).ToList<ElectricityConsumer>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string Save(ElectricityConsumer obj, IDBContextElectricityConsumer db)
        {
            db.ElectricityConsumers.Add(obj);
            db.SaveChanges();
            return "Saved successfully";
        }

        public ElectricityConsumer GetBatchRunsById(int id, IDBContextElectricityConsumer db)
        {
            return db.ElectricityConsumers.FirstOrDefault(s => s.Id == id);
        }

        public string Update(ElectricityConsumer obj, IDBContextElectricityConsumer db)
        {
            db.ElectricityConsumers.Update(obj);
            db.SaveChanges();
            return "Updated successfully";
        }

        public string Delete(ElectricityConsumer obj, IDBContextElectricityConsumer db)
        {
            db.ElectricityConsumers.Remove(obj);
            db.SaveChanges();
            return "Deleted successfully";
        }

        public List<ElectricityConsumer> FindBatchRuns(string strFind, IDBContextElectricityConsumer db)
        {
            var batchRuns = from b in db.ElectricityConsumers
                            where (b.User.Contains(strFind) || b.Address.ToString().Contains(strFind))
                            select b;

            return batchRuns.Cast<ElectricityConsumer>().ToList();
        }
    }
}
