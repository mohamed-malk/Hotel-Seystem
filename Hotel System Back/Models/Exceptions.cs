namespace Hotel_System_Back.Models
{
    public static class Exceptions
    {
        public static Exception NotFoundException(string entityName)
            => new NullReferenceException
                ($"This {entityName} not Found in DataBase");

        public static Exception AlreadyExistException(string entityName)
            => new($"This {entityName} is already exist in DataBase");
        public static Exception NotFoundProperty(string propertyName)
            => new ArgumentException($"This {propertyName} is not found in the object");
    }
}
