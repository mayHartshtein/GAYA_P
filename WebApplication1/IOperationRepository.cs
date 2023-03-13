using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    interface IOperationRepository
    {
        IEnumerable<OperationClass> GetAll();

        OperationClass GetOperationByID(int id);
        void Add(OperationClass op);
        void Remove(OperationClass op);
        void Update(OperationClass op);


    }
}
