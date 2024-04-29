using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetById
{
    public class ResponseVehicleGetById : Response
    {
        public ResponseVehicleGetById() { }

        public ResponseVehicleGetById(string message, int status) 
        { 
            Message = message;
            StatusCode = status;
        }

        public ResponseVehicleGetById(string message, VehicleDto data)
        {
            Message = message;
            Data = data;
            StatusCode = 200;
        }

        public VehicleDto? Data {  get; set; }
    }
}
