using System;
namespace properties
{
   class student
    {
        private int _id;

        private string _name;
        
        private int _passMark;

        public void setId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("student id can not be less than zero");
            }
            this._id = id;
        }
        public int getId()
        {
            return this._id;
        }

        public void setName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not be null");
            }
            this._name = name;
        }

        public string getName()
        {
            return this._name;
        }

         public void setPassMark(int passMark)
        {
            if(passMark > 100)
            {
                throw new Exception("PassMark can not be more than 100");
            }
            this._passMark = passMark;
        }

        public int getPassMark()
        {
            return this._passMark;
        }
    }
}