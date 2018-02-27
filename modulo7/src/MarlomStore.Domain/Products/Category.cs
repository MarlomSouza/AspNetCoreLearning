namespace MarlomStore.Domain.Products
{
    public class Category : Entity
    {
        public Category() { }

        public Category(string name) => ValidadeAndSetName(name);

        public void Update(string name) => ValidadeAndSetName(name);

        public void ValidadeAndSetName(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");

            this.Name = name;
        }

    }
}
