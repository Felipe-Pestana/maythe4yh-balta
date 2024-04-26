using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public sealed class StarshipGetAllQuery : IRequest<ResponseStarshipGetAll>
    {
        public int CurrentPage {  get; set; }
        public int PageSize { get; set; }
    }
}
