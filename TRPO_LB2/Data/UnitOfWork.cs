using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_LB2.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new MockRepository();


        public void SaveChanges()
        {

            var doctors = Repository.GetDoctors();

            var json = JsonConvert.SerializeObject(doctors, Formatting.Indented,
                        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("data.json"))
            {
                f.Write(json);
            }
        }
    }
}
