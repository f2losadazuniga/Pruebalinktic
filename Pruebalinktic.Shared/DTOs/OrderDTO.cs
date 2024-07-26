using Pruebalinktic.Shared.Enums;

namespace Pruebalinktic.Shared.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string Remarks { get; set; } = string.Empty;
    }
}