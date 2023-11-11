using System;

namespace ExerciseWorkerContract.Entities
{
    internal class Department
    {
        public string Name { get; private set; }

        //Construtor
        public Department()
        {
        }

        public Department (string name)
        {
            Name = name;
        }
    }
}
