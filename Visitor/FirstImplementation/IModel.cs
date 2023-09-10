using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.FirstImplementation
{
    internal interface IModel
    {
        void Accept(IVistor vistor);
    }
}
