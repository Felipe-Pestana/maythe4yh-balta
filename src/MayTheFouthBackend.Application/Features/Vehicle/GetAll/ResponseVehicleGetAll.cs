using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public class ResponseVehicleGetAll : Response
    {
        public ResponseVehicleGetAll() { }

        public ResponseVehicleGetAll(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponseVehicleGetAll(string message, PaginatedListResponse<VehicleDto> datas)
        {
            Message = message;
            Datas = datas;
            StatusCode = 200;
        }

        public PaginatedListResponse<VehicleDto>? Datas { get; set; }
    }
}
