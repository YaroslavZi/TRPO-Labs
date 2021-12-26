using System;
using System.Collections.Generic;
using TRPO_LB2.Entities;

namespace TRPO_LB2.Data
{
    class MockRepository : IRepository
    {
        private readonly List<Doctor> _doctors = new List<Doctor>()
        {
            new Doctor
                {
                    Id=1,
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Doljnost = "Dantist",
                    Bolnici = new Bolnici
                    {
                        Id=1,
                        Otdelenie="Morg",
                        Palati=6,
                        Pacienti="A123",
                    }

                },
            new Doctor
                {
                    Id=2,
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Doljnost = "Travmotolog",
                    Bolnici = new Bolnici
                    {
                        Id=2,
                        Otdelenie="Travmpunkt",
                        Palati=28,
                        Pacienti="B433",
                    }

                },
            new Doctor
                {
                    Id=3,
                    FirstName = "Sasha",
                    LastName = "Sashkov",
                    Doljnost = "Ginekolog",
                    Bolnici = new Bolnici
                    {
                        Id=3,
                        Otdelenie="Ginekologicheskoe",
                        Palati=64,
                        Pacienti="F345",
                    }

                }
        };

                
        public IEnumerable<Doctor> GetDoctors()
        {
            return _doctors;
        }
        public void AddDoctor(Doctor doctor)
        {
            _doctors.Add(doctor);
        }

        public void Remove(int id)
        {
           // throw new NotImplementedException();
        }
    }

}
