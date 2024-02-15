namespace Hotel_System_Back.Services
{
    public abstract class PersonRepo
    {
        private readonly HotelDbContext _dbContext = new();
        
        /// <summary>
        /// Login to System
        /// </summary>
        /// <returns>Login Successfully Person or Null </returns>
        public Person? Login(string userName, string password) 
            => _dbContext.People.SingleOrDefault(p =>
            p.UserName == userName && p.Password == password);
        
        public virtual void Add(Person person)
        {
            _dbContext.People.Add(person);
            _dbContext.SaveChanges();
        }
        public abstract void Delete(int id);
        public abstract void Delete(string nId);

        public virtual Person? GetById(int id) => _dbContext.People.Find(id);
        public PersonView? GetByIdShow(int id)
        {
            Person? person = GetById(id);
            return new PersonView(person!.Id, person.Name,
                person.UserName, person.Email, person.Password,
                person.NId, person.Age, person.Gender,
                person.Address);
        }
        public virtual Person Update(int id, Dictionary<Properties, object> newValues)
        {
            Person? person = GetById(id);
            if (person != null)
            {
                foreach (var item in newValues)
                {
                    switch (item.Key)
                    {
                        case Properties.UserName:
                            person.UserName = (string)item.Value;
                            break;
                        case Properties.Email:
                            person.Email = (string)item.Value;
                            break;
                        case Properties.Password:
                            person.Password = (string)item.Value;
                            break;
                        case Properties.Name:
                            person.Name = (string)item.Value;
                            break;
                        case Properties.Age:
                            person.Age = (int)item.Value;
                            break;
                        case Properties.Gender:
                            person.Gender = (bool)item.Value;
                            break;
                        case Properties.Address:
                            person.Address = (string)item.Value;
                            break;
                        //default:
                        //    throw Exceptions.NotFoundProperty(item.Key.ToString());
                    }
                }

                _dbContext.People.Update(person);
                _dbContext.SaveChanges();

                return person;
            }
            throw Exceptions.NotFoundException("Person");
        }
    }
}
