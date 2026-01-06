using System;

namespace Strategy
{
    //Interfaz 
    public interface IDescuentoStrategy 
    {
        decimal CalcularPrecioFinal(decimal precioBase);
    }

    public class SinDescuento : IDescuentoStrategy 
    {
        public decimal CalcularPrecioFinal(decimal precioBase) 
        {
            return precioBase;
        }
    }

    public class Descuento10PorCiento : IDescuentoStrategy 
    {
        public decimal CalcularPrecioFinal(decimal precioBase) 
        {
            return precioBase * 0.9m;
        }
    }

    public class Descuento20Porciento : IDescuentoStrategy 
    {
        public decimal CalcularPrecioFinal(decimal precioBase) 
        {
            return precioBase * 0.8m;
        }
    }

    public class CarritoCompra 
    {
        private IDescuentoStrategy _descuentoStrategy;

        public void SetDescuentoStrategy(IDescuentoStrategy strategy) 
        {
            _descuentoStrategy = strategy;
        }

        public void MostrarPrecioFinal(decimal precioBase) 
        {
            if (_descuentoStrategy == null) 
            {
                Console.WriteLine("No se configuro una estrategia de descuento");
                return;
            }
            decimal precioFinal = _descuentoStrategy.CalcularPrecioFinal(precioBase);
            Console.WriteLine($"Precio final: ${precioFinal}");
        }
    }

    class Program 
    {
        static void Main(string[] args)
        { 
            CarritoCompra carrito = new CarritoCompra();
            decimal precioBase = 1000;

            Console.WriteLine("Cliente: compra sin descuento");
            carrito.SetDescuentoStrategy(new SinDescuento());
            carrito.MostrarPrecioFinal(precioBase);

            Console.WriteLine();

            Console.WriteLine("Cliente: Compra con 10% de descuento");
            carrito.SetDescuentoStrategy(new Descuento10PorCiento());
            carrito.MostrarPrecioFinal(precioBase);

            Console.WriteLine();

            Console.WriteLine("Cliente: compra con 20% de descuento");
            carrito.SetDescuentoStrategy(new Descuento20Porciento());
            carrito.MostrarPrecioFinal(precioBase);

            Console.ReadKey();
        }
    }
}
