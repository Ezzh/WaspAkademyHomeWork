interface IStoreItem
{
    double Price{get; set;}

    void DiscountPrice(int percenet)
    {
        this.Price = this.Price - (this.Price * (percenet / 100.0));
    }
}