**-Sistema de Control de Inventario - TecnoPunto-**

	• Datos del Autor

**Nombre:** Set Daniel Sanchez Javier.
**Matrícula:** (2026-1598).

	• Descripción del Programa

Aplicación de consola desarrollada en C# (.NET) bajo el paradigma de 
Programación Orientada a Objetos (POO). El sistema permite gestionar
el inventario de la tienda TecnoPunto registrando 3 productos con sus
atributos principales, encapsulando y validando sus datos, y emitiendo
un reporte con el cálculo del valor total acumulado en existencia.

	• Datos de Entrada

El sistema solicita por teclado los siguientes datos para cada uno de los 3 productos:
1. **Código:** Cadena de texto (string) que identifica al producto por ejemplo: "P001".
2. **Nombre:** Cadena de texto (string) que no puede estar vacía o contener solo espacios, validado mediante el buble 'do-while' y el metodo '.IsNullOrWhiteSpace'.
3. **Precio:** Número decimal (double) que debe ser estrictamente mayor a 0, validado mediante bucle 'while' y el metodo'.TryParse'.
4. **Cantidad:** Número entero (int) que debe ser mayor o igual a 0, validado mediante bucle 'while' y el metodo'.TryParse'.

	• Datos que Procesa

1. **Encapsulamiento y Validaciones:** Protege los atributos mediante propiedades 'get' y 'set' evaluando que no se ingresen nombres vacíos, precios menores o iguales a cero, ni cantidades negativas. 
2. **Control de Repetición por Consola:** Empleo de bucles 'do-while' y 'while' para pausar y reintentar la captura de datos hasta recibir entradas válidas.
3. **Valor Total por Producto (ValorTotal):** Propiedad calculada de solo lectura que evalúa (Precio * Cantidad).
4. **Valor Total del Inventario (valorTotalInventario):** Suma acumulada del valor total de los 3 productos (p1.ValorTotal + p2.ValorTotal + p3.ValorTotal).

	• Datos de Salida

1. **Ficha individual por producto:** Muestra en pantalla el Código, Nombre, Precio (formateado a 2 decimales $N2), Cantidad y Valor Total individual. 
2. **Reporte Consolidado:** Imprime la suma del "Valor Total del Inventario" acumulado.

	• Capturas de la Ejecución

1. **Datos Válidos y el resultado:** (imagenes/valido.png) (imagenes/resultado.png).
2. **Validación de Precio Negativo:** (imagenes/precio_negativo.png).
3. **Validación de Nombre Vacío:** (imagenes/nombre_vacio.png).
4. **Ingreso de Cantidad Cero:** (imagenes/cantidad_cero.png) en este caso el programa acepta el dato y continua con el siguiente producto.