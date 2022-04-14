using System;

namespace MyApp
{
    // declaring Delegates 
    public delegate string MyDel(string str);
    public class Employee
    {
        //declaring event
        event MyDel MyEvent;
        //Declaring three private properties called Id, Name, DepartmentName
        private int Id { get; set; }
        private string Name { get; set; }
        private string DepartmentName { get; set; }

        //The constructor which accept all of these three properties while creating an object.
        public Employee(int id, string name, string departmentName)
        {
            Id = id;
            Name = name;
            DepartmentName = departmentName;
        }
        
        //first method of three methods
        public int GetId()
        {
            return Id;
        }

        //second method of three methods
        public string GetName()
        {
            return Name;
        }

        //third method of three methods
        public string GetDepartmentName()
        {
            return DepartmentName;
        }

        //Created first overloaded method of 3 overloaded methods 
        public int GetId(int id)
        {
            // Console.WriteLine("Please Enter Updated Employee Id : ");
            //id = Convert.ToInt32(Console.ReadLine());
            return this.Id = id;
        }

        //Created second overloaded method of 3 overloaded methods 
        public string GetName(string name)
        {
            //Console.WriteLine("Please Enter Updated Employee Name: ");
            // name = Console.ReadLine();
            return this.Name = name;
        }

        //Created third overloaded method of 3 overloaded methods 
        public string GetDepartmentName(string department)
        {
            Console.WriteLine("Please Enter Your Updated Department Name: ");
            department = Console.ReadLine();
            return this.DepartmentName = department;
        }

        //event in Employee Class which is fired
        public Employee()
        {
            this.MyEvent += new MyDel(this.eventExample);
        }
        public string eventExample(string username)
        {
            return username;
        }





        static void Main(string[] args)
        {
            //asking the user for Id, Name, DepartmentName
            Console.WriteLine("Please Enter Employee Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Department Name: ");
            string departmentName = Console.ReadLine();

            //After getting details from the user creating an object of Employee class with provided details.
            Employee obj = new Employee(id, name, departmentName);


            //called method and outputs message
            Employee obj1 = new Employee();
            string result = obj1.MyEvent("GetId() method called");
            Console.WriteLine(result);

            //After creating an object printing all three properties one by one using above created methods.
            Console.WriteLine($"Employee Id : {obj.GetId()}");

            //called method and outputs message
            Employee obj2 = new Employee();
            string result2 = obj2.MyEvent("GetName() method called");
            Console.WriteLine(result2);

            Console.WriteLine($"Employee Name : {obj.GetName()}");

            //called method and outputs message
            Employee obj3= new Employee();
            string result3 = obj3.MyEvent("GetDepartmentName() method called");
            Console.WriteLine(result3);

            Console.WriteLine($"Department Name : {obj.GetDepartmentName()}");


            int updatedId = obj.GetId(id);
            string updatedName = obj.GetName(name);
            string updatedDepartment = obj.GetDepartmentName(departmentName);
            Console.WriteLine($"Your Updated Employee Id : {updatedId}");
            Console.WriteLine($"Your Updated Employee Name : {updatedName}");
            Console.WriteLine($"Your Updated Department Name : {updatedDepartment}");

        }

    }
}