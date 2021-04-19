class Product
{
    public productId: number;
    public name: string ;
    public price:number ;
    public likeability: number ;
    public stockQuantity = 0;
    
    constructor(productId: number , name: string, price: number, likeability: number)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
        this.likeability = likeability;
        
    }

    fillStock(num:number){
        if(this.stockQuantity == 0) this.stockQuantity = num;
    }

    addToStock(){
        this.stockQuantity++;
    }
   
    addDiscount(this: Product)
    {
        if(this.price > 1000)
        {
            console.log("Hello! Product "+ this.name + " has a 10% discount!");
            this.price = this.price - this.price*10/100;
        } 
    }
    addDiscountLikeability(this: Product)
    {
        if(this.likeability > 20) this.price -= this.price*5/100;
    }
}