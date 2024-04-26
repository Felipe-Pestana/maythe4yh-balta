using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetById
{
    public class StarshipGetByIdQuery : IRequest<ResponseStarshipGetById>
    {
        public int Id { get; set; }
    }
}
