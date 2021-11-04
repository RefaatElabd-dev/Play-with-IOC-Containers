namespace SharedServices
{
    public interface IFirstService
    {
        public int Count { get; set; }
        int increamentAndReturnCount();
    }
}