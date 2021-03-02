using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{


    class GenericWorkerNameAscComparer : IComparer<Worker>
    {       
        public int Compare(Worker worker1, Worker worker2)
        {
            return worker1.Name.CompareTo(worker2.Name);
        }
    }



    class WorkerNameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {           
            if (x is Worker && y is Worker)
            {               
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return worker1.Name.CompareTo(worker2.Name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerNameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return - (worker1.Name.CompareTo(worker2.Name)); // -(-1) = 1;  
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSurnameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return worker1.Surname.CompareTo(worker2.Surname);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSurnameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return -1 * (worker1.Surname.CompareTo(worker2.Surname));
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerPatronimicAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return worker1.Patronimic.CompareTo(worker2.Patronimic);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerPatronimicDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return -(worker1.Patronimic.CompareTo(worker2.Patronimic));
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSalaryAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return -worker2.Salary.CompareTo(worker1.Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerSalaryDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                return ((Worker)y).Salary.CompareTo(((Worker)x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerBirthDateAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return worker1.BirthDate.CompareTo(worker2.BirthDate);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class WorkerBirthDateDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Worker && y is Worker)
            {
                Worker worker1 = (Worker)x; //  (Worker)x -- cast
                Worker worker2 = (Worker)y;
                return -worker1.BirthDate.CompareTo(worker2.BirthDate);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
