using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPO_LB2.Entities;

namespace TRPO_LB2.Data
{
    class Repository : IRepository
    {
        public IEnumerable<Doctor> GetDoctors()
        {
            return null;
        }

        public void AddDoctor(Doctor doctor)
        {

        }
        public void Remove(int id)
        {

        }

    }
}
