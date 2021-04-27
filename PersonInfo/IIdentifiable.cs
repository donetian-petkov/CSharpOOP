namespace PersonInfo
{
    public interface IIdentifiable
    {
        public string Id
        {
            get => Id;
            set => Id = value;
        }
    }
}