using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.FirstImplementation
{
    internal interface IVistor
    {
        void VisitModelA(IModel model);
        void VisitModelB(IModel model);
    }
}
