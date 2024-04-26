using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetById
{
    public class ResponseStarshipGetById : Response
    {
        public ResponseStarshipGetById() { }

        public ResponseStarshipGetById(string message, int status) 
        { 
            Message = message;
            StatusCode = status;
        }

        public ResponseStarshipGetById(string message, StarshipDto data)
        {
            Message = message;
            Data = data;
            StatusCode = 200;
        }

        public StarshipDto? Data {  get; set; }
    }
}
