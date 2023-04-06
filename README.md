# FrikiPop

-Descripcion:
Se va a desarrollar una web de compra-venta de articulos relacionados con el mundo de los videojuegos, donde 
los usuarios pueden comprar y vender artículos y ponerle el precio que deseen.

-Parte pública:
Desde la parte pública se podrá ver el logo de la web. Además, se podrá acceder a una sección para hacer log in o crear un usuario.
Se visualizará tambien a una columna con un menú donde poder aplicar filtros a los productos mostrados.
Por último, en la zona principal de la pantalla se mostrará un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podrá comprar.

-Listado EN publica:
	+ENUsuarios: Servirá para iniciar sesión.
	+ENArticulos: Servirá para poder ver los artículos de otras personas.

-Parte privada:
	+Usuario normal: Se visualizará lo mismo que en la parte pública, con la diferencia de que se mostrará el username y accediendo
	a este se puede modificar la información del usuario. Además, se mostrará una opción "vender" para añadir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte pública a diferencia que en vez de hacer log in aparecerá un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde hay (usuarios, productos, ver estado de pedidos, etc).

-Listado EN privada:
	+ENUsuario: Servirá para configurar el perfil de usuario.
	+ENLocalidad: Servirá para seleccionar una localidad de las almacenadas a la hora de crear gestionar el usuario.
	+ENTarjetaCredito: Servirá para acceder a la tarjeta de credito que tenga el usuario guardado.
	+ENArticulos: Servirá para poder acceder a los articulos propios que vendes o a los de otros usuarios que se pueden comprar.
	+ENCarrito: Servirá para almacenar varios articulos y hacer una compra conjunta.
	+ENLinCarrito: Servirá para ver cada articulo dentro del carrito.
	+ENPedido: Se podrá ver el pedido del usuario y el estado del mismo.
	+ENLinPedido: Servirá para acceder a cada articulo del pedido.

-Posibles mejoras:
	+Estadísticas: Funcionalidad donde se mostrarán algunos tops de mas vendidos, mejor valorados, etc
	+Filtros: Filtrar los articulos que se ven por usuario, precio, categoría, etc