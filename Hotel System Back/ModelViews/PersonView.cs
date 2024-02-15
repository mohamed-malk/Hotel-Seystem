namespace Hotel_System_Back.ModelViews;

public readonly struct ClientView(int id, string name, 
    string userName, string email, string password,
    string nId, int age, bool gender, string address, 
    string nationality,
    int points, int? memberShipId,  string memberShipName)
{
    public int Id => id;
    public string UserName => userName;
    public string Email => email;
    public string Password => password;
    public string NId => nId;
    public string Name => name;
    public int Age => age;
    public bool Gender => gender;
    public string Address => address;
    public string Nationality => nationality;
    public int Points => points;
    public int? MemberShipId => memberShipId;
    public string MemberShipName => memberShipName;
}
public readonly struct EmployeeView(int id, string name,
    string userName, string email, string password,
    string nId, int age, bool gender, string address,
    float salary, int attend)
{
    public int Id => id;
    public string UserName => userName;
    public string Email => email;
    public string Password => password;
    public string NId => nId;
    public string Name => name;
    public int Age => age;
    public bool Gender => gender;
    public string Address => address;
    public int Attend => attend;
    public float Salary => salary;
}
public readonly struct PersonView(int id, string name,
    string userName, string email, string password,
    string nId, int age, bool gender, string address)
{
    public int Id => id;
    public string UserName => userName;
    public string Email => email;
    public string Password => password;
    public string NId => nId;
    public string Name => name;
    public int Age => age;
    public bool Gender => gender;
    public string Address => address;
}