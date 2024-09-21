namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        // Constructor
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = string.IsNullOrWhiteSpace(firstName) ? "Unknown" : firstName;
            LastName = string.IsNullOrWhiteSpace(lastName) ? "Unknown" : lastName;
            MonthlySalary = monthlySalary < 0 ? 0.0 : monthlySalary;
        }

        // Public properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0)
                {
                    _monthlySalary = value;
                }
            }
        }

        // Method to raise the salary by a percentage
        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage <= 20 && raisePercentage > 0)
            {
                _monthlySalary += (_monthlySalary * raisePercentage / 100);
            }
        }

        // Method to get the yearly salary
        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
