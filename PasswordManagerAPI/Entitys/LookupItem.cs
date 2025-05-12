namespace PasswordManagerAPI.Entitys
{
    public class LookupItem:ParentEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LookupTypeID { get; set; }

    }
}
