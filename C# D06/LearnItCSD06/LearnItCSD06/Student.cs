using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD06
{
    public class Student
    {
        #region Data Fields
        int id;
        string name;
        int age;
        float grade;

        static int counter;
        #endregion

        #region Setters & Getters
        public void SetId(int _id) {  id = _id; }
        public void SetName(string _name) {  this.name = _name; }
        public void SetAge(int _age) { age = _age; }
        public void SetGrade(float _grade) {  grade = _grade; }
        public int GetId() { return id; }
        public string GetName() { return name; }
        public int GetAge() { return age; }
        public float GetGrade() { return grade; }
        #endregion

        #region Static Counter Properties
        public static int Counter
        {
            get { return counter; }
        }
        #endregion


        #region Properties MCU
        //alternitave way for setters and getters
        //fst ltr is upper case
        public int Id
        {
            set     //function  void Set(int value){}
            {
                //if(value>1)
                    //Id = value;  //stack overflow
                    id= value;
            }
            get    //Function  int Get(){}
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
            set { age = value; }
            get { return age; }
        }

        public float Grade
        {
            set { grade = value; }
            get { return grade; }
        }
        #endregion

        #region ctor
        public Student()
        {
            counter++;
            id = 1;
            name = "Habeba";
            age = 20;
            grade = 3.5F;
        }
        public Student(int _id, string _name,int _age,float _grade)
        {
            counter++;
            id = _id;
            name = _name;
            age = _age;
            grade = _grade;
        }
        #endregion

        #region Static ctor
        static Student()
        {
            counter = 0;
        }
        #endregion

        #region Print
        public override string ToString()
        {
            return $"{id}:{name}:{age}:{grade}";
            //return string.Format($"");
        }
        #endregion
    }
}
