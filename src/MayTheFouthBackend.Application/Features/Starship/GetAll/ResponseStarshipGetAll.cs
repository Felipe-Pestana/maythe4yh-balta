using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public class ResponseStarshipGetAll : Response
    {
        public ResponseStarshipGetAll() { }

        public ResponseStarshipGetAll(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponseStarshipGetAll(string message, paginatedListResponse<StarshipDto> datas)
        {
            Message = message;
            Datas = datas;
            StatusCode = 200;
        }

        public paginatedListResponse<StarshipDto>? Datas { get; set; }
    }
}
