namespace MarlomStore.Domain.Products
{
    public class Category : Entity
    {
        public Category() { }

        public Category(string name) => ValidadeAndSetName(name);

        public void Update(string name) => ValidadeAndSetName(name);

        public void ValidadeAndSetName(string name)
        {
            ValidadeName(name);

            this.Name = name;
        }
    }
}
