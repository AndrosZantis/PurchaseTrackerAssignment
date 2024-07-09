public interface IPurchaseRepository
{
    IEnumerable<Purchase> GetPurchases();
    Purchase? GetPurchase(long id);
}
