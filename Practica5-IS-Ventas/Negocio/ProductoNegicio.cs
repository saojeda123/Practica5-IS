using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegicio
    {
        ProductoDatos productoDatos;

        public ProductoNegicio()
        {
            productoDatos = new ProductoDatos();
        }

        public List<Producto> All()
        {
            return productoDatos.lista();
        }
        public Producto ById(int id)
        {
            return productoDatos.lista().Where(p =>p.idProducto==id).SingleOrDefault();
        }
        public bool insertarProducto(Producto productoNuevo)
        {
            return productoDatos.insertarProducto(productoNuevo);
        }

    }
}
