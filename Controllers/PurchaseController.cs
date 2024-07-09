using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly PurchaseService _service;

    //Constructor
    public PurchaseController(PurchaseService service)
    {
        _service = service;
    }

    //Endpoint to get all purchases
    [HttpGet]
    public ActionResult<IEnumerable<Purchase>> GetPurchases()
    {
        //Retrieve all purchases
        var purchases = _service.GetPurchases();
        return Ok(purchases.Select(p => new 
        {
            p.Id,
            p.Name,
            p.PurchasedAt,
            TotalCost = p.Quantity * p.UnitPrice,
        }));
    }

    //Retrieve purchase by ID
    [HttpGet("{id}")]
    public ActionResult<Purchase> GetPurchase(long id)
    {
        var purchase = _service.GetPurchase(id);
        if (purchase == null)
        {
            return NotFound(); //Error out 404 if not found
        }
        return Ok(purchase); //Return HTTP 200 OK status if ok
    }

}
