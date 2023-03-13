using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    class OperationRepository : IOperationRepository
    {

        private List<OperationClass> operations;

        public OperationRepository()
        {
            operations = new List<OperationClass>();
            
        }

        public void Add(OperationClass op)
        {
            op.operationID = operations.Count() + 1;
            operations.Add(op);
        }

        public IEnumerable<OperationClass> GetAll()
        {
            return operations;
        }

        public OperationClass GetOperationByID(int id)
        {
            return operations.FirstOrDefault(x => x.operationID == id);
        }

        public void Remove(OperationClass op)
        {
            var existingOperation = operations.FirstOrDefault(x => x.operationID == op.operationID);
            if (existingOperation != null)
                operations.Remove(existingOperation);
        }

        public void Update(OperationClass op)
        {
            var existingOperation = operations.FirstOrDefault(x => x.operationID == op.operationID);
            if (existingOperation != null)
                existingOperation.operationName = op.operationName;
        }
    }
}
