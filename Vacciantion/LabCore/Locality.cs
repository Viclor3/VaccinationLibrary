namespace PRITT
{
    public class Locality
    {
        public int Id { get; }
        public string Title { get; }
        public int Cost { get; }

        public Locality(int id, string title, int cost)
        {
            Id = id;
            Title = title;
            Cost = cost;
        }
    }
}