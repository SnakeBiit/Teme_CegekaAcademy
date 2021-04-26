class Customer
{
    public customerId: number;
    public name: string;
    public adress: string;
    public products: Product[] ;

    constructor(customerId:number, name:string, adress:string){
        this.customerId = customerId;
        this.name= name;
        this.adress = adress;
        this.products = [];
    }

    seeStock(product: Product)
    {
        console.log("The stock for product " + product.name + " is " + product.stockQuantity);
    }
    
    addToFavorites(product: Product)
    {
        this.products.push(product);
        this.increaseLikeability(product);
        this.calculatePrice(product);
    }
    increaseLikeability(product: Product){
        product.likeability+=1;
    }
    calculatePrice(product: Product){
         if(product.price > 1000) console.log("Hello! Product "+ product.name + " has a 10% discount if you buy it right now!");
    }
}