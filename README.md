# FrikiPop

-Descripcion:
Se va a desarrollar una web de compra-venta de articulos relacionados con el mundo de los videojuegos, donde 
los usuarios pueden comprar y vender art�culos y ponerle el precio que deseen.

-Parte p�blica:
Desde la parte p�blica se podr� ver el logo de la web. Adem�s, se podr� acceder a una secci�n para hacer log in o crear un usuario.
Se visualizar� tambien a una columna con un men� donde poder aplicar filtros a los productos mostrados.
Por �ltimo, en la zona principal de la pantalla se mostrar� un listado de articulos en venta por usuarios, pero que hasta no estar identificado
no se podr� comprar.

-Listado EN publica:
	+ENUsuarios: Servir� para iniciar sesi�n.
	+ENArticulos: Servir� para poder ver los art�culos de otras personas.

-Parte privada:
	+Usuario normal: Se visualizar� lo mismo que en la parte p�blica, con la diferencia de que se mostrar� el username y accediendo
	a este se puede modificar la informaci�n del usuario. Adem�s, se mostrar� una opci�n "vender" para a�adir articulos en venta a tu perfil.

	+Administrador: Muestra lo mismo que en la parte p�blica a diferencia que en vez de hacer log in aparecer� un boton para administrar la informacion de
	la web. Todo lo que hay en la web se puede administrar desde hay (usuarios, productos, ver estado de pedidos, etc).

-Listado EN privada:
	+ENUsuario: Servir� para configurar el perfil de usuario.
	+ENLocalidad: Servir� para seleccionar una localidad de las almacenadas a la hora de crear gestionar el usuario.
	+ENTarjetaCredito: Servir� para acceder a la tarjeta de credito que tenga el usuario guardado.
	+ENArticulos: Servir� para poder acceder a los articulos propios que vendes o a los de otros usuarios que se pueden comprar.
	+ENCarrito: Servir� para almacenar varios articulos y hacer una compra conjunta.
	+ENLinCarrito: Servir� para ver cada articulo dentro del carrito.
	+ENPedido: Se podr� ver el pedido del usuario y el estado del mismo.
	+ENLinPedido: Servir� para acceder a cada articulo del pedido.

-Posibles mejoras:
	+Estad�sticas: Funcionalidad donde se mostrar�n algunos tops de mas vendidos, mejor valorados, etc
	+Filtros: Filtrar los articulos que se ven por usuario, precio, categor�a, etc