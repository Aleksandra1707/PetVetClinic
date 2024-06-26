﻿using PetVetClinic.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetsClinic.Models
{
    public class Pet
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public List<PetVaccine> PetVaccines { get; set; }

        public Pet()
        {
        }
    }
}

