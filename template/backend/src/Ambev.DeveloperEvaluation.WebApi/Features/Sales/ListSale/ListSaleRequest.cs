namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSale
{
    public class ListSaleRequest
    {
        public string? CustomerName { get; set; }
        public int Page { get; set; } = 1;
        public int Size { get; set; } = 10;
    }
}
