using PetVetClinic.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetsClinic.Models
{
    public class PetVaccine
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int VaccineId { get; set; }
        public Vaccine Vaccine { get; set; }

        public PetVaccine()
        {
        }
    }
}

