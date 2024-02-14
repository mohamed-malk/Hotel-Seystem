using Hotel_System.Models;

namespace Hotel_System.Services;
public class EmployeeRepo : PersonRepo
{
    private readonly HotelDbContext _dbContext = new();

    #region Manger

    /// <summary>
    /// Add Manager
    /// </summary>
    /// <returns><see cref="Employee"/> Manger</returns>
    /// <exception cref="Exceptions.AlreadyExistException"></exception>
    public Employee CreateManager(string userName, string email, string password,
        string nId, string name, int age, bool gender, string address,
        int attend, float salary)
    {
        if (_dbContext.Employees.Find(Employee.ManagerId) == null)
        {
            _dbContext.SaveChanges(); // Add Manger To DB

            return new()
            {
                Id = Employee.ManagerId,
                UserName = userName,
                Password = password,
                Address = address,
                Age = age,
                Attend = attend,
                Email = email,
                Gender = gender,
                Name = name,
                NId = nId,
                Salary = salary
            };
        }
        throw Exceptions.AlreadyExistException("Manager");
    }

    /// <summary>
    /// Make the Employee is a Manager, in case No Manger is existed
    /// </summary>
    /// <param name="manger">The Employee that will be a Manger</param>
    /// <returns><see cref="Employee"/>Manger</returns>
    /// <exception cref="Exceptions.AlreadyExistException"></exception>
    public Employee CreateManager(Employee manger)
    {
        if (_dbContext.Employees.Find(Employee.ManagerId) == null)
        {
            //----------- Repeated -----------//
            // First Remove Person as Employee
            _dbContext.Employees.Remove(manger);
            // Second Add Person as Manger
            _dbContext.Employees.Add(new(manger)
            {
                Id = Employee.ManagerId
            });

            _dbContext.SaveChanges(); // Add Manger To DB

            return manger;
        }
        throw Exceptions.AlreadyExistException("Manager");
    }

    /// <summary>
    /// Change Manger with other Employee
    /// </summary>
    /// <param name="employee">Employee that will be a Manager</param>
    /// <param name="removeMan">Remove a Manger from System or Make it as Employee</param>
    public void ChangeManager(Employee employee, bool removeMan = false)
    {
        // Get the Manger 
        Employee? oldManger = _dbContext.Employees.Find(Employee.ManagerId);

        if (oldManger != null) // The Manger is existed
        {
            // Remove Manager From System
            _dbContext.Employees.Remove(oldManger);

            if (!removeMan)
            {
                // Add Manager as new Employee with new ID
                Employee newEmployee = new(oldManger);
                _dbContext.Employees.Add(newEmployee); // Add him as Employee
            }

            //----------- Repeated -----------//
            // First Remove Person as Employee
            _dbContext.Employees.Remove(employee);
            // Second Add Person as Manger
            _dbContext.Employees.Add(new(employee)
            {
                Id = Employee.ManagerId
            });

            _dbContext.SaveChanges();  // Save Changes To DB
        }
        else throw Exceptions.NotFoundException("Manger");
    }

    #endregion

    #region Employee
    public void Add(Employee employee)
    {
        _dbContext.Employees.Add(employee);
        _dbContext.SaveChanges();
    }

    public override void Delete(int id)
    {
        Employee? emp = GetById(id);
        if (emp != null)
            Delete(emp);
    }
    public override void Delete(string nId)
    {
        Employee? emp = _dbContext.Employees
            .SingleOrDefault(e => e.NId == nId);
        if (emp != null)
            Delete(emp);
    }
    public void Delete(Employee employee)
    {
        if (employee.Id != Employee.ManagerId)
        {
            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();
        }
        else throw new Exception("Can't Delete Employee");
    }

    public List<Employee> GetAll() => _dbContext.Employees.ToList();
    public override Employee? GetById(int id) => _dbContext.Employees.Find(id);
    public List<Employee> GetByName(string name)
        => _dbContext.Employees.Filter(e =>
            e.Name.ToLower() == name.ToLower()).ToList();
    public List<Employee> GetByNamePattern(string pattern)
        => _dbContext.Employees.Filter(e =>
            e.Name.ToLower().Contains(pattern.ToLower())).ToList();
    public List<Employee> GetByAddress(string address)
        => _dbContext.Employees.Filter(e =>
            e.Address.ToLower() == address.ToLower()).ToList();

    public void Update(Employee employee)
    {
        _dbContext.Employees.Update(employee);
        _dbContext.SaveChanges();
    }
    public override Employee Update(int id, 
        Dictionary<Properties, object> newValues)
    {
       
        Dictionary<Properties, object> perValues = newValues;
        perValues.Remove(Properties.Salary);
        perValues.Remove(Properties.Attend);
        Employee employee = (Employee)base.Update(id, perValues);

        foreach (var item in newValues)
        {
            switch (item.Key)
            {
                case Properties.Salary:
                    employee.Salary = (float)item.Value;
                    break;
                case Properties.Attend:
                    employee.Attend = (int)item.Value;
                    break;
                default:
                    throw Exceptions.NotFoundProperty(item.Key.ToString());
            }
        }
        _dbContext.Employees.Update(employee);
        _dbContext.SaveChanges();
        return employee;
    }

    #endregion
}
