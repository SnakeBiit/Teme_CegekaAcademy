"use strict";
class Customer {
    constructor(customerId, name, adress) {
        this.customerId = customerId;
        this.name = name;
        this.adress = adress;
        this.products = [];
    }
    seeStock(product) {
        console.log("The stock for product " + product.name + " is " + product.stockQuantity);
    }
    addToFavorites(product) {
        this.products.push(product);
        product.likeability += 1;
        if (product.price > 1000)
            console.log("Hello! Product " + product.name + " has a 10% discount if you buy it right now!");
    }
}
class Order {
    constructor(orderId, customer) {
        this.orderedItems = [];
        this.date = new Date().toLocaleDateString();
        this.totalPrice = 0;
        this.orderId = orderId;
        this.customer = customer;
    }
    addOrders(orderItem) {
        orderItem.item.addDiscount();
        orderItem.item.addDiscountLikeability();
        this.orderedItems.push(orderItem);
    }
    CalculatePrice() {
        this.orderedItems.forEach(element => {
            this.totalPrice += element.item.price;
        });
    }
    CheckStock() {
        this.orderedItems.forEach((element, index) => {
            if (element.item.stockQuantity < element.quantity) {
                console.log("Product " + element.item.name + " is out of stock!");
                this.orderedItems.splice(index, 1);
            }
            if (element.item.stockQuantity >= element.quantity)
                element.item.stockQuantity -= element.quantity;
        });
    }
    Order() {
        this.CheckStock();
        this.CalculatePrice();
        console.log("Command number " + this.orderId + " has been placed!");
        console.log("Dear " + this.customer.name + " your command has been placed at adress " + this.customer.adress + " today " + this.date);
        console.log("Comand details:\nProducts: " + JSON.stringify(this.orderedItems) + "\nPrice: " + this.totalPrice);
    }
}
class OrderItem {
    constructor(item, quantity) {
        this.item = item;
        this.quantity = quantity;
    }
}
class Product {
    constructor(productId, name, price, likeability) {
        this.stockQuantity = 0;
        this.productId = productId;
        this.name = name;
        this.price = price;
        this.likeability = likeability;
    }
    fillStock(num) {
        if (this.stockQuantity == 0)
            this.stockQuantity = num;
    }
    addToStock() {
        this.stockQuantity++;
    }
    addDiscount() {
        if (this.price > 1000) {
            console.log("Hello! Product " + this.name + " has a 10% discount!");
            this.price = this.price - this.price * 10 / 100;
        }
    }
    addDiscountLikeability() {
        if (this.likeability > 20)
            this.price -= this.price * 5 / 100;
    }
}
//Customers:
let customer1 = new Customer(43242, "Sarpe Radu-Stefan", "str. Temisana 2,bl 14,sc 32, sector 3, Bucuresti");
let customer2 = new Customer(67443, "Tacu Victor", "str. Crisana,bl 1,sc 3, sector 1, Bucuresti");
//Products:
let tshirt = new Product(32, "tricou alb XL", 50, 20);
let phone = new Product(11, "Iphone 11", 4000, 15);
let laptop = new Product(200, "Dell XPS 13", 8000, 10);
//Filling stocks
tshirt.fillStock(20);
phone.fillStock(10);
laptop.fillStock(2);
//Adding to favorites and modifing likeability
customer1.addToFavorites(tshirt);
customer1.seeStock(phone);
//Orders
let orderTshirt = new OrderItem(tshirt, 2);
let orderPhone = new OrderItem(phone, 1);
let orderLaptop = new OrderItem(laptop, 3);
let orderLaptop2 = new OrderItem(laptop, 1);
//Order items
let order1 = new Order(1, customer1);
let order2 = new Order(2, customer2);
order1.addOrders(orderTshirt);
order1.addOrders(orderPhone);
order1.addOrders(orderLaptop2);
order2.addOrders(orderPhone);
order2.addOrders(orderLaptop);
order1.addOrders(orderLaptop2);
order1.Order();
order2.Order();
//Checking stock
console.log("Tshirt stock is: " + tshirt.stockQuantity);
console.log("Phone stock is: " + phone.stockQuantity);
console.log("Laptop stock is: " + laptop.stockQuantity);
//# sourceMappingURL=app.js.map