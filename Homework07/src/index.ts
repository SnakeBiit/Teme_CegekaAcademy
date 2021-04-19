//Customers:
let customer1= new Customer(43242,"Sarpe Radu-Stefan","str. Temisana 2,bl 14,sc 32, sector 3, Bucuresti");
let customer2= new Customer(67443,"Tacu Victor","str. Crisana,bl 1,sc 3, sector 1, Bucuresti");
//Products:
let tshirt = new Product(32,"tricou alb XL",50,20);
let phone = new Product(11,"Iphone 11",4000,15);
let laptop = new Product(200,"Dell XPS 13",8000,10);
//Filling stocks
tshirt.fillStock(20);
phone.fillStock(10);
laptop.fillStock(2);
//Adding to favorites and modifing likeability
customer1.addToFavorites(tshirt);
customer1.seeStock(phone);
//Orders
let orderTshirt = new OrderItem(tshirt, 2);
let orderPhone = new OrderItem(phone,1);
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