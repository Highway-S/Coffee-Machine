VendingMachine
//Menu
BlackCoffee : int
Mocca : int
Late : int
HotChocolate : int

//Ingredient
Water : int
Chocolate : int
Coffee : int
Milk : int
BlackCoffee(Water : int, Coffee : int)
Mocca(Water : int, Coffee : int, Chocolate : int)
Late(Water : int, Coffee : int, Milk : int)
HotChocolate(Water : int, Chocolate : int)

VendingMachine(BlackCoffee : int, Mocca : int, Late : int, HotChocolate : int)

buyBlackCoffee(amount : int) : void
buyMocca(amount : int) : void
buyLate(amount : int) : void
buyHotChocolate(amount : int) : void

showStock():void
increaseStock(BlackCoffee : int, Mocca : int, Late : int, HotChocolate : int):void

