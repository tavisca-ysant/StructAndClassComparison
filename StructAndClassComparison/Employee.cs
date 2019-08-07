namespace StructAndClassComparison
{
    internal class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public string Designation { get; }

        public Employee(int id, string name, string designation)
        {
            Id = id;
            Name = name;
            Designation = designation;
        }
    }
}