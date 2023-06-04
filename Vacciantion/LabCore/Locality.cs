namespace PRITT
{
    public class Locality
    {
        private string Title { get; }
        private int Cost { get; }

        public Locality(string title, int cost)
        {
            Title = title;
            Cost = cost;
            
            //TODO: Создание населенного пункта в бд
        }
    }
}