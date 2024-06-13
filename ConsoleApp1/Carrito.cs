using TareaMati;
/*A partir del proyecto "Producto y Carrito" crear en carrito un vector de 10 productos 
  * en los cuales luego se recorra en un método retornando que hay en ese carrito y cuanta cantidad de ese producto
  * (mostrar información de los productos)
  */

Producto producto = new Producto();

producto.productos[0] = "pelota";
producto.productos[1] = "papitas";
producto.productos[2] = "auriculares";
producto.productos[3] = "lapiz";
producto.productos[4] = "plato";
producto.productos[5] = "tenedor";
producto.productos[6] = "cuaderno";
producto.productos[7] = "goma";
producto.productos[8] = "droga";
producto.productos[9] = "merca";

producto.precio[0] = 45;
producto.precio[1] = 20;
producto.precio[2] = 60;
producto.precio[3] = 5;
producto.precio[4] = 30;
producto.precio[5] = 12;
producto.precio[6] = 18;
producto.precio[7] = 3;
producto.precio[8] = 35;
producto.precio[9] = 36;


producto.Mostrar();