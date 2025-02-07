﻿namespace API_Assignment.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            VehicleModels = new HashSet<VehicleModel>();
            Dealerships = new HashSet<Dealership>();
        }

        public int ID { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
        public virtual ICollection<Dealership> Dealerships{ get; set; }

    }
}
