using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(sm => sm.Id);
            Field(sm => sm.Name);
            Field(sm => sm.Phone);
            Field(sm => sm.TotalPeople);
            Field(sm => sm.Email);
            Field(sm => sm.Date);
            Field(sm => sm.Time);
        }
    }
}
