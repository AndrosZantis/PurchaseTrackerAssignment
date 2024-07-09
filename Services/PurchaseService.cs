public class PurchaseService
{
    private readonly IPurchaseRepository _repository;

    public PurchaseService(IPurchaseRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Purchase> GetPurchases()
    {
        return _repository.GetPurchases();
    }

    public Purchase? GetPurchase(long id)
    {
        return _repository.GetPurchase(id);
    }
}
