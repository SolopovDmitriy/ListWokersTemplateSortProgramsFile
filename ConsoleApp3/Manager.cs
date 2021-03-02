using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee, IManage
    {
        private ListOfWorkers _workers; //список рабочих текущего экземпляра менеджера
        public ListOfWorkers Workers { //поле получения доступа к рабочим текущего менеджера
            get
            {
                return _workers;
            }
        }
        
        public IWorker GetWorker(int index)
        {
            throw new NotImplementedException(); //заглушка
        }
        public IWorker GetWorker(string workDescription)
        {
            throw new NotImplementedException(); //заглушка
        }
        public void PushWork(string task, IWorker[] workers)
        {

        }
        public Manager()
        {
            _workers = new ListOfWorkers();
        }
















        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
