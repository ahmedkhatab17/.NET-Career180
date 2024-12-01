namespace ConsoleApp10
{
    class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public student(int  id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(1, "ali ahmed", 22);

            /*xml
             * <student>
             * <id>1</id>
             * <name>ali ahmed </name>
             * <age>22</age>
             * </student>
             */
            /* s={
             * "id":1,
             * "name":"ali ahmed",
             * "age:22,
             * "subjects":[
             * {
             * "id":1,
             * "name":"ali ahmed",
             * "age:22,
             * "intructor":["c#" ,"",""]
             * },
             * {
             * "id":1,
             * "name":"ali ahmed",
             * "age:22,
             * "intructor":["" ,"",""]
             * }
             * ]
             * 
             * }
             * 
             * arr=[
             * {
             * "id":1,
             * "name":"ali ahmed",
             * "age:22,
             * "subjects":["c#" ,"",""]
             * },
             * {
             * "id":1,
             * "name":"ali ahmed",
             * "age:22,
             * "subjects":["" ,"",""]
             * }
             * ]
             * 
             * 
             */
        }
    }
}
