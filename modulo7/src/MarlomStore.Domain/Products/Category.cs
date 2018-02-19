namespace MarlomStore.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");

            this.Name = name;

        }

    }
}