using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosSQL;
using Entidades;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace Negocios
{
    public class N_Usuario
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_Usuario";

        //Acciones de insertar, Borrar y Modificar los datos del usuario
        public string InsertarUsuario(E_Usuario pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, pEntidad);
        }

        public string BorraUsuario(int pIdUsuarios)
        {
            E_Usuario Entidad = new E_Usuario
            {
                Accion = "BORRAR",
                IdUsuarios = pIdUsuarios
            };
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, Entidad);
        }

        public string ModoficaUsuario(E_Usuario pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Usuario>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_Usuarios()
        {
            return ObjLst.DT_ListadoGeneral("[tbUsuarios]", "NombreUsuario");
        }

        public List<E_Usuario> LstUsuarios()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Usuario>(GetDT_Usuarios());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_Usuario BuscarUsuarioPorId(int pIdUsuario)
        {
            return (from User in LstUsuarios() where User.IdUsuarios == pIdUsuario select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorEmail(string pEmail)
        {
            return (from User in LstUsuarios() where User.EmailUsuario == pEmail select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorNombre(string pNombre)
        {
            return (from User in LstUsuarios() where User.NombreUsuario == pNombre select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorUsuario(string pUsuario)
        {
            return (from User in LstUsuarios() where User.Usuario == pUsuario select User).FirstOrDefault();
        }

        public E_Usuario ValidaLogin(string NombreUsuario, string Password)
        {
            return (from User in LstUsuarios() where User.NombreUsuario == NombreUsuario && User.PasswordUsuario == Password select User).FirstOrDefault();
        }

        public E_Usuario BuscarUsuarioPorNombreNegocio(string NombreNegocio, int IdUsuario)
        {
            return (from User in LstUsuarios() where User.NombreNegocio == NombreNegocio && User.IdUsuarios == IdUsuario select User).FirstOrDefault();
        }

    }

    public class N_Rol
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_Rol";

        //Acciones de insertar, Borrar y Modificar los datos del Rol
        public string InsertarRol(E_Rol pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, pEntidad);
        }

        public string BorraRol(int pIdRol)
        {
            E_Rol Entidad = new E_Rol
            {
                Accion = "BORRAR",
                IdRol = pIdRol
            };
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, Entidad);
        }

        public string ModoficaRol(E_Rol pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Rol>(Sp, pEntidad);
        }

        //listado general de Rol en formato DataTable y list <E_Sistema>
        public DataTable GetDT_Roles()
        {
            return ObjLst.DT_ListadoGeneral("[tbRoles]", "NombreRol");
        }

        public List<E_Rol> LstRoles()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Rol>(GetDT_Roles());
        }

        // Busqueda de Roles por diferente creiterio

        public E_Rol BuscarRolPorId(int pIdRol)
        {
            return (from User in LstRoles() where User.IdRol == pIdRol select User).FirstOrDefault();
        }

    }

    public class N_Producto
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_Producto";

        //Acciones de insertar, Borrar y Modificar los datos del Producto
        public string InsertarProducto(E_Producto pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Producto>(Sp, pEntidad);
        }

        public string BorraProducto(int pIdProducto)
        {
            E_Producto Entidad = new E_Producto
            {
                Accion = "BORRAR",
                IdProducto = pIdProducto
            };
            return ObjIBM.IBM_Entidad<E_Producto>(Sp, Entidad);
        }

        public string ModoficaProducto(E_Producto pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Producto>(Sp, pEntidad);
        }

        //listado general de Producto en formato DataTable y list <E_Sistema>
        public DataTable GetDT_Productos()
        {
            return ObjLst.DT_ListadoGeneral("[tbProductos]", "Marca, NombreProducto");
        }

        public List<E_Producto> LstProductos()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Producto>(GetDT_Productos());
        }

        // Busqueda de Productos por diferente creiterio

        public E_Producto BuscarProductoPorId(int pIdProducto)
        {
            return (from User in LstProductos() where User.IdProducto == pIdProducto select User).FirstOrDefault();
        }

        public E_Producto BuscarProductoPorMarca(string pMarca)
        {
            return (from User in LstProductos() where User.Marca == pMarca select User).FirstOrDefault();
        }

        public E_Producto BuscarProductoPorNombre(String pNombreProducto)
        {
            return (from User in LstProductos() where User.NombreProducto == pNombreProducto select User).FirstOrDefault();
        }


    }

    public class N_UsuarioRol
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_UsuarioRol";

        public string InsertarUsuarioRol(E_UsuarioRol pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, pEntidad);
        }

        public string BorraUsuarioRol(int pIdUsuario)
        {
            E_UsuarioRol Entidad = new E_UsuarioRol
            {
                Accion = "BORRAR",
                IdUsuario = pIdUsuario
            };
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, Entidad);
        }

        public string ModoficaUsuarioRol(E_UsuarioRol pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_UsuarioRol>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_UsuarioRol()
        {
            return ObjLst.DT_ListadoGeneral("[tbUsuarioRol]", "IdUsuario");
        }

        public List<E_UsuarioRol> LstUsuarios()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_UsuarioRol>(GetDT_UsuarioRol());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_UsuarioRol BuscarUsuarioRolPorId(int pIdUsuario)
        {
            return (from User in LstUsuarios() where User.IdUsuario == pIdUsuario select User).FirstOrDefault();
        }

        public E_UsuarioRol BuscarUsuarioRolPorRol(int pIdRol)
        {
            return (from User in LstUsuarios() where User.IdRol == pIdRol select User).FirstOrDefault();
        }
    }

    public class N_UsuarioNegocios
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_UsuarioNegocios";

        public string InsertarUsuarioNegocios(E_UsuarioNegocios pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_UsuarioNegocios>(Sp, pEntidad);
        }

        public string BorraUsuarioNegocio(int pIdUsuario)
        {
            E_UsuarioNegocios Entidad = new E_UsuarioNegocios
            {
                Accion = "BORRAR",
                IdUsuario = pIdUsuario
            };
            return ObjIBM.IBM_Entidad<E_UsuarioNegocios>(Sp, Entidad);
        }

        public string ModoficaUsuarioNegocio(E_UsuarioNegocios pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_UsuarioNegocios>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_UsuarioNegocio()
        {
            return ObjLst.DT_ListadoGeneral("[tbUsuarioNegocios]", "IdUsuario");
        }

        public List<E_UsuarioNegocios> LstUsuarioNegocio()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_UsuarioNegocios>(GetDT_UsuarioNegocio());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_UsuarioNegocios BuscarUsuarioNegocioPorId(int pIdUsuario)
        {
            return (from User in LstUsuarioNegocio() where User.IdUsuario == pIdUsuario select User).FirstOrDefault();
        }

        public E_UsuarioNegocios BuscarUsuarioNegocioPorNegocio(int pIdNegocios)
        {
            return (from User in LstUsuarioNegocio() where User.IdNegocios == pIdNegocios select User).FirstOrDefault();
        }
    }

    public class N_Negocio
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_Negocios";

        //Acciones de insertar, Borrar y Modificar los datos del usuario
        public string InsertarNegocio(E_Negocios pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Negocios>(Sp, pEntidad);
        }

        public string BorraNegocio(int pIdNegocios)
        {
            E_Negocios Entidad = new E_Negocios
            {
                Accion = "BORRAR",
                IdNegocios = pIdNegocios
            };
            return ObjIBM.IBM_Entidad<E_Negocios>(Sp, Entidad);
        }

        public string ModoficaNegocio(E_Negocios pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_Negocios>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_Negocios()
        {
            return ObjLst.DT_ListadoGeneral("[tbNegocios]", "NombreNegocio");
        }

        public List<E_Negocios> LstNegocios()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_Negocios>(GetDT_Negocios());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_Negocios BuscarNegocioPorId(int pIdNegocios)
        {
            return (from User in LstNegocios() where User.IdNegocios == pIdNegocios select User).FirstOrDefault();
        }

        public E_Negocios BuscarUsuarioPorNombre(string pNombreNegocio)
        {
            return (from User in LstNegocios() where User.NombreNegocio == pNombreNegocio select User).FirstOrDefault();
        }

 
        public E_Negocios BuscarUsuarioPorTipoNegocio(string TipoNegocio, int IdNegocios)
        {
            return (from User in LstNegocios() where User.TipoNegocio == TipoNegocio && User.IdNegocios == IdNegocios select User).FirstOrDefault();
        }

    }

    public class N_ProductoNegocios
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_ProductoNegocios";

        //Acciones de insertar, Borrar y Modificar los datos del usuario
        public string InsertarProductoNegocios(E_ProductoNegocios pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_Negocios>(Sp, pEntidad);
        }

        public string BorraProductoNegocios(int pIdProducto)
        {
            E_ProductoNegocios Entidad = new E_ProductoNegocios
            {
                Accion = "BORRAR",
                IdProducto = pIdProducto
            };
            return ObjIBM.IBM_Entidad<E_ProductoNegocios>(Sp, Entidad);
        }

        public string ModoficaProductoNegocios(E_ProductoNegocios pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_ProductoNegocios>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_ProductoNegocios()
        {
            return ObjLst.DT_ListadoGeneral("[tbProductoNegocios]", "IdProducto");
        }

        public List<E_ProductoNegocios> LstNegocios()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_ProductoNegocios>(GetDT_ProductoNegocios());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_ProductoNegocios BuscarProductoNegociosPorIdProducto(int pIdNegocios)
        {
            return (from User in LstNegocios() where User.IdNegocios == pIdNegocios select User).FirstOrDefault();
        }

        public E_ProductoNegocios BuscarProductoNegociosPorIdNegocio(int pIdProducto)
        {
            return (from User in LstNegocios() where User.IdProducto == pIdProducto select User).FirstOrDefault();
        }


    }

    public class N_HorarioNegocios
    {
        D_IBM_Datos ObjIBM = new D_IBM_Datos();
        D_Listados ObjLst = new D_Listados();
        private string Sp = "IBM_HorarioNegocios";

        //Acciones de insertar, Borrar y Modificar los datos del usuario
        public string InsertarProductoNegocios(E_HorarioNegocios pEntidad)
        {
            pEntidad.Accion = "INSERTAR";
            return ObjIBM.IBM_Entidad<E_HorarioNegocios>(Sp, pEntidad);
        }

        public string BorraHorarioNegocios(int pIdNegocios)
        {
            E_HorarioNegocios Entidad = new E_HorarioNegocios
            {
                Accion = "BORRAR",
                IdNegocios = pIdNegocios
            };
            return ObjIBM.IBM_Entidad<E_HorarioNegocios>(Sp, Entidad);
        }

        public string ModoficaHorarioNegocios(E_HorarioNegocios pEntidad)
        {
            pEntidad.Accion = "MODIFICAR";
            return ObjIBM.IBM_Entidad<E_HorarioNegocios>(Sp, pEntidad);
        }

        //listado general de usuario en formato DataTable y list <E_Sistema>
        public DataTable GetDT_HorarioNegocios()
        {
            return ObjLst.DT_ListadoGeneral("[tbHorarioNegocios]", "IdNegocios");
        }

        public List<E_HorarioNegocios> LstNegocios()
        {
            return D_ConvierteDatos.ConvertirDTALista<E_HorarioNegocios>(GetDT_HorarioNegocios());
        }

        // Busqueda de usuarios por diferente creiterio

        public E_HorarioNegocios BuscarHorarioNegociosPorIdNegocio(int pIdNegocios)
        {
            return (from User in LstNegocios() where User.IdNegocios == pIdNegocios select User).FirstOrDefault();
        }

    }

}
