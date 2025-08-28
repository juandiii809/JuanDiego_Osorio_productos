// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
Empleados empleados1 = new Empleados() {id_empleado = 1, nombre = "jaime", apellidos = "garcia", telefono = 1234567891 };
Cliente clientes = new Cliente() {id_cliente = 1, nombre = "julio", apellidos = "alvarez", telefono = 123987456 };
Productos productos1 = new Productos() {id_producto = 1, nombre = "balon de basketball", precio = 120000 };
Productos productos2 = new Productos() {id_producto = 2, nombre = "buso nike", precio = 2000000 };
Productos productos3 = new Productos() {id_producto = 3, nombre = "computador lenovo", precio = 2800000 };
Productos productos4 = new Productos() {id_producto = 4, nombre = "mouse gamer", precio = 250000 };
List<Productos> productos = new List<Productos>();
productos.Add(productos1);
productos.Add(productos2);
productos.Add(productos3);
productos.Add(productos4);
List<Empleados> empleados = new List<Empleados>();
empleados.Add(empleados1);
int tot = 0;
foreach (var p in productos)
{
    Console.WriteLine(p.nombre);
    tot = p.precio+ tot; 
}
;
Console.WriteLine(tot);
Facturas facturas = new Facturas() {id_factura=1,total_pagar= tot};

public class Empleados
{
    public int id_empleado;
    public string? nombre;
    public string? apellidos;
    public int telefono;
}

public class Cliente
{
    public int id_cliente;
    public string? nombre;
    public string? apellidos;
    public int telefono;
    public List<Empleados>? Empleados;
}

public class Productos
{
    public int id_producto;
    public string? nombre;
    public int precio;
}

public class Facturas
{
    public int id_factura;
    public int total_pagar;
    public List<Productos>? Productos;
}
