using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay4
{
    public class Student
    {
        #region Data Filed
        int id;
        string name;
        int age;
        float grade;
        #endregion

        #region setter & getter
        public void setId(int _id) {  id = _id; }
        public void setName(string _name) { name = _name; }
        public void setAge(int _age) { age = _age; }
        public void setGrade( float _grade) { grade = _grade; }
        public int getId() { return id; }
        public string getName() { return name; }
        public int getAge() { return age; }
        public float getGrade() { return grade; }

        #endregion
        
        #region Prop
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public float Grade { get; set; }

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public float Grade
        {
            set
            {
                grade = value;
            }
            get
            {
                return grade;
            }
        }
        #endregion

        #region ctor
        public Student()
        {
            id = 1;
            name = "ahmed";
            age = 20;
            grade = 3.5F;
        }

        public Student(int _id, string _name, int _age, float _grade)
        {
            id = _id;
            name = _name;
            age = _age;
            grade = _grade;
           
        }


        #endregion

        #region print
        public string print()
        {
            return $"{id} : {name} : {age} : {grade}";
        }

        #endregion

    }
}
