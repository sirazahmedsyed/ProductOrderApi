﻿namespace ProductOrderApi.Entities
{
    public class OrderDetailDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity
        {
            get; set;
        }
        public decimal UnitPrice { get; set; }
    }
}
