namespace AssignmentDay8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var employees = Repository.Employees;

            

            #region Filtration Without Delegates
            var filteredByDeptId = Filtration1.FilterByDeptId(employees, 20);
            Console.WriteLine("\nEmployees in DeptId 20:");
            foreach (var employee in filteredByDeptId)
            {
                Console.WriteLine(employee);
            }

            var filteredBySalary = Filtration1.FilterBySalary(employees, 8000);
            Console.WriteLine("\nEmployees with Salary >= 8000:");
            foreach (var employee in filteredBySalary)
            {
                Console.WriteLine(employee);
            }

            var filteredByAge = Filtration1.FilterByAge(employees, 25);
            Console.WriteLine("\nEmployees with Age >= 25:");
            foreach (var employee in filteredByAge)
            {
                Console.WriteLine(employee);
            }
            #endregion

            #region Filtration With Delegate
            MyDelegate del1 = Filtration2.PerDeptId;
            
            del1 = www => www.Name.Contains("a") && www.DeptId == 20;
            var filteredEmps = Filtration2.FilterPerDelegate(employees, del1);

            filteredEmps = Filtration2.FilterPerDelegate
                (employees, RD => RD.DeptId == 20);

            Console.WriteLine("\nEmployees DeptId is 20:");
            foreach (var employee in filteredEmps)
            {
                Console.WriteLine(employee);
            }
            #endregion

        }
    }
}
