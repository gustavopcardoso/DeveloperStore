﻿using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public class ListSaleResult
    {
        public Guid Id { get; set; }
        public int SaleNumber { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalSaleAmount { get; set; }
        public string BranchName { get; set; } = string.Empty;
        public List<ListSaleItemResult> SaleItems { get; set; } = new List<ListSaleItemResult>();
        public SaleStatus SaleStatus { get; set; }
    }

    public class ListSaleItemResult
    {
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discounts { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
