﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Dtos
{
    public class VehicleDto
    {
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public float CostInCredits { get; set; }
        public float Length { get; set; }
        public int Maxspeed { get; set; }
        public int Crew { get; set; }
        public int Passengers { get; set; }
        public float Cargocapacity { get; set; }
        public string Consumables { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public IEnumerable<ListInfoDto> Movies { get; set; } = Enumerable.Empty<ListInfoDto>();
    }
}
