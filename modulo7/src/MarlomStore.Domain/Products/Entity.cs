namespace MarlomStore.Domain.Products
{
    public class Entity
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public void ValidadeName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(name.Length < 3, "Name at least 3 caracteres");
        }
    }
}