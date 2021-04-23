using GraphQL.Types;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(sm => sm.Id);
            Field(sm => sm.Name);
            Field(sm => sm.Description);
            Field(sm => sm.ImageUrl);
            Field(sm => sm.Price);
            Field(sm => sm.MenuId);
        }
    }
}
