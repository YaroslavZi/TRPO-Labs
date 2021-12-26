namespace TRPO_LB2.Entities
{
    class Doctor : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Doljnost { get; set; }
        public Bolnici Bolnici { get; set; }
    }

}
