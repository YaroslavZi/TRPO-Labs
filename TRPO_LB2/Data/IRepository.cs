using System.Collections.Generic;
using TRPO_LB2.Entities;

namespace TRPO_LB2.Data
{
    interface IRepository
    {
        
        IEnumerable<Doctor> GetDoctors();
        void AddDoctor(Doctor doctor);
        void Remove(int id);
    }
}