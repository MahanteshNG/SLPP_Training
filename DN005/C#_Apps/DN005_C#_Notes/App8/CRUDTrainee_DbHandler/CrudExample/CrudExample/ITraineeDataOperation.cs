using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudExample
{
    public interface ITraineeDataOperation
    {
        bool AddRecord(TraineeDL dl);

        List<TraineeDL> DisplayAllTraineesInfo();
        TraineeDL SearchById(int searchId);
        List<TraineeDL> DisplayTraineeByDepartment(string searchBatch);
    }
}
