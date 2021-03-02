using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum CloneWorkerMethod
    {
        Superficial,    //поверхностное
        Complete        //полное
    }

    /*
     * унаследоваться от класса Employee
       реализовать интерфейс IWorker
    */
    class Worker : Employee, IWorker, ICloneable, IComparable
    {
        private bool _isWorking;
        private string _workDescription;
        public bool IsWorking
        {
            get
            {
                return _isWorking;
            }
        }  //поле интерфейса

        public string Work() //метод интерфейса
        {
            return _workDescription;
        }
        public void StopWorking()
        {
            _isWorking = false;
        }

        public void NextTask(string task)
        {
            if (_isWorking == false)
            {
                if (task.Length > 0)
                {
                    _workDescription = task;
                    _isWorking = true;
                }
                else
                {
                    throw new InvalidOperationException("Не понял задачу");
                }
            }
            else
            {
                throw new Exception("Я уже занят, я работаю");
            }
        }
        public Worker() : base()
        {
            _isWorking = true;
            _workDescription = "Ведутся работы по организации самой работы";
        }

        public Worker(string name, string surname, string patronimic, DateTime birthDate, Genre genre, Nationality nationality, EducationLevel education, float salary, string workDescription)
            : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {
            _isWorking = false;
            this.NextTask(workDescription);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n\tStatus Working: {IsWorking};" +
                $"\n\tCurrent Work: {_workDescription}";
        }

        public object Clone()
        {
            Console.WriteLine("Задействую клонирование обьекта");

            //поверхностного копирования - использовать только если нету ссылочных полей

            //полного копирования
            /*Worker worker = new Worker();
            
            worker.Name = this.Name;


            return worker;*/

            return this.MemberwiseClone(); //поверхностное копирование
        }
        public object Clone(CloneWorkerMethod method)
        {
            switch (method)
            {
                case CloneWorkerMethod.Superficial:
                    return this.Clone();
                case CloneWorkerMethod.Complete:
                    return new Worker (
                            this.Name, 
                            this.Surname, 
                            this.Patronimic, 
                            this.BirthDate, 
                            this.genre, 
                            this.nationality,
                            this.educationLevel, 
                            this.Salary, 
                            this.Work()
                   );
            }
            throw new ArgumentException("Clone Worker Method incorrect");
        }

        public int CompareTo(object obj)
        {
            //дефолтная сортировка: по имени - по ниспаданию

            Worker worker = obj as Worker;

            if(worker != null)
            {
                return worker.Name.CompareTo(this.Name); //воспользовался стандартным стринговым компарером
            }
            else
            {
                throw new Exception("Incorrect compare two walues");
            }
        }
    }
}
