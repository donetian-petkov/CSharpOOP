namespace PersonInfo
{
    public interface IPerson
    {
        public string Name
        {
            get => Name;
            set => Name = value;
        }

        public int Age
        {
            get => Age;
            set => Age = value;
        }
    }
}