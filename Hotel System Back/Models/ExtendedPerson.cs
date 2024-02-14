namespace Hotel_System_Back.Models
{
    public abstract partial class Person
    {
        protected void Update(string userName, string email, string password,
            string nId, string name, int age, bool gender, string address)
        {
            Email = email;
            UserName = userName;
            Password = password;

            NId = nId;
            Name = name;
            Gender = gender;
            Address = address;
            Age = age;
        }
    }
}
