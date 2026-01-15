# Patrón Strategy en C#

Este repositorio contiene un ejemplo simple y claro del **patrón de diseño Strategy**, implementado en **C#** mediante una aplicación de consola.

El objetivo del patrón Strategy es **definir una familia de algoritmos, encapsularlos y hacerlos intercambiables**, permitiendo cambiar el comportamiento de un objeto en tiempo de ejecución sin modificar su código.

---

## 🧠 ¿Qué problema resuelve?

Evita el uso de múltiples condicionales (`if` / `switch`) para aplicar distintas lógicas de negocio.  
En este caso, se evita decidir el descuento mediante condiciones y se delega esa responsabilidad a distintas estrategias.

---

## 🧩 Estructura del ejemplo

- **IDescuentoStrategy**  
  Interfaz que define el método común para calcular el precio final.

- **SinDescuento / Descuento10PorCiento / Descuento20Porciento**  
  Estrategias concretas que implementan distintos tipos de descuentos.

- **CarritoCompra**  
  Clase contexto que utiliza una estrategia de descuento configurable en tiempo de ejecución.

- **Program**  
  Demuestra cómo cambiar dinámicamente la estrategia aplicada.

---

## ▶️ Ejemplo de ejecución

- Cliente sin descuento  
- Cliente con 10% de descuento  
- Cliente con 20% de descuento  

Cada uno utiliza una estrategia distinta sin modificar el código del carrito.

---

## 🚀 Beneficios del patrón Strategy

- Código más limpio y mantenible
- Principio **Open/Closed** (abierto para extensión, cerrado para modificación)
- Facilita la incorporación de nuevas estrategias
- Bajo acoplamiento entre clases

---

## 🛠️ Tecnologías utilizadas

- Lenguaje: **C#**
- Tipo de proyecto: **Aplicación de consola**
- Paradigma: **Programación Orientada a Objetos**

---

## 📚 Uso educativo

Este proyecto fue creado con fines **educativos**, ideal para:
- Aprender patrones de diseño
- Practicar interfaces y polimorfismo
- Aplicar buenas prácticas de diseño de software

