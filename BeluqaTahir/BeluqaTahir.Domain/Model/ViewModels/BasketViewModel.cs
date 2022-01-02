namespace BeluqaTahir.Domain.Model.ViewModels
{
    public class BasketViewModel
    {
        public int ProductId { get; set; }
        public string Count { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImagePati { get; set; }

        //public int Amount
        //{
        //    get
        //    {
        //        return Price * Count;

        //    }
        //}
    }
}
