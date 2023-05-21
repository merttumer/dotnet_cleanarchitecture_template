namespace Hello.Domain
{
    public class User
    {
        public int Id { get; }
        public string Name { get; } = null!;

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}