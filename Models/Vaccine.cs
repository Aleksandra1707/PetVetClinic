using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetsClinic.Models
{
    public class Vaccine
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PetVaccine> PetVaccines { get; set; }

        public Vaccine()
        {
        }
    }
}

