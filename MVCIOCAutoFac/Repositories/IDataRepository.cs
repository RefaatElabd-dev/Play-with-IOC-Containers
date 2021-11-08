namespace MVCIOCAutoFac.Repositories
{
    public interface IDataRepository
    {
        string GetData();
        int Count { get; set; }
    }
}