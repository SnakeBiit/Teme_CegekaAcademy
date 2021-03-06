class Order
{
    public orderId: number;
    public customer: Customer;
    public orderedItems: OrderItem[] = [];
    public date = new Date().toLocaleDateString();
    public totalPrice: number = 0;

    constructor(orderId: number, customer: Customer)
    {
        this.orderId = orderId;
        this.customer = customer;
    }

    addOrders(orderItem:OrderItem)
    {
        orderItem.item.addDiscountToProduct();
        orderItem.item.addDiscountLikeability();
        this.orderedItems.push(orderItem);
    }

    CalculatePrice()
    {
        this.orderedItems.forEach(element => {
            this.totalPrice += element.item.price;
        });
    }

    CheckStock()
    {
        this.orderedItems.forEach((element, index) => {
            this.checkQuantity(element);
            this.updateStock(element);
        });
    }

    checkQuantity(orderedItem: OrderItem)
    {
        if(orderedItem.item.stockQuantity < orderedItem.quantity){
                    console.log("Product " + orderedItem.item.name + " is out of stock!");
                    this.orderedItems.splice(this.orderedItems.indexOf(orderedItem),1);
                }
    }

    updateStock(orderedItem: OrderItem)
    {
        if(orderedItem.item.stockQuantity >= orderedItem.quantity) orderedItem.item.stockQuantity -= orderedItem.quantity;
    }
    
    Order()
    {
        this.CheckStock();
        this.CalculatePrice();
        console.log("Command number " + this.orderId + " has been placed!");
        console.log("Dear " + this.customer.name + " your command has been placed at adress " + this.customer.adress + " today " + this.date);
        console.log("Comand details:\nProducts: " +  JSON.stringify(this.orderedItems) + "\nPrice: " + this.totalPrice);
    }
}