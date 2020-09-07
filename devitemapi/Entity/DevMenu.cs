namespace devitemapi.Entity
{
    public class DevMenu : BaseEntity
    {
        public string MenuCode { get; set; }
        public string MenuName { get; set; }

        public int ParentId { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }
    }
}