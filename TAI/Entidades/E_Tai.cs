using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuarios;
        private string _NombreUsuario;
        private string _EmailUsuario;
        private string _PasswordUsuario;
        private string _EstatusUsuario;
        private string _Usuario;
        private string _NombreNegocio;
        private string _DireccionNegocio;
        #endregion

        #region Contructor
        public E_Usuario()
        {
            _Accion = string.Empty;
            _IdUsuarios = 0;
            _NombreUsuario = string.Empty;
            _EmailUsuario = string.Empty;
            _PasswordUsuario = string.Empty;
            _EstatusUsuario = string.Empty;
            _NombreNegocio = string.Empty;
            _DireccionNegocio = string.Empty;
            _Usuario = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuarios { get => _IdUsuarios; set => _IdUsuarios = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string EmailUsuario { get => _EmailUsuario; set => _EmailUsuario = value; }
        public string PasswordUsuario { get => _PasswordUsuario; set => _PasswordUsuario = value; }
        public string EstatusUsuario { get => _EstatusUsuario; set => _EstatusUsuario = value; }
        public string NombreNegocio { get => _NombreNegocio; set => _NombreNegocio = value; }
        public string DireccionNegocio { get => _DireccionNegocio; set => _DireccionNegocio = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        #endregion

    }

    public class E_Rol
    {
        #region Atributos
        private string _Accion;
        private int _IdRol;
        private string _NombreRol;
        private string _Descripcion;
        #endregion

        #region Contructor
        public E_Rol()
        {
            _Accion = string.Empty;
            _IdRol = 0;
            _NombreRol = string.Empty;
            _Descripcion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        #endregion
    }

    public class E_Producto
    {
        #region Atributos
        private string _Accion;
        private int _IdProducto;
        private string _NombreProducto;
        private string _Marca;
        private string _Descripcion;
        private int _CostoProducto;
        private int _CantidadProducto;
        private string _EstadoProducto;
        #endregion

        #region Constructor
        public E_Producto()
        {
            _Accion = string.Empty;
            _IdProducto = 0;
            _NombreProducto = string.Empty;
            _Marca = string.Empty;
            _Descripcion = string.Empty;
            _CostoProducto = 0;
            _CantidadProducto = 0;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int CostoProducto { get => _CostoProducto; set => _CostoProducto = value; }
        public int CantidadProducto { get => _CantidadProducto; set => _CantidadProducto = value; }
        public string EstadoProducto { get => _EstadoProducto; set => _EstadoProducto = value; }
        #endregion
    }

    public class E_UsuarioRol
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private int _IdRol;
        #endregion

        #region Contructor
        public E_UsuarioRol()
        {
            _IdRol = 0;
            _IdUsuario = 0;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        #endregion
    }

    public class E_Negocios
    {
        #region Atributos
        private string _Accion;
        private int _IdNegocios;
        private string _DiasLaborales;
        private string _TipoNegocio;
        private string _TelefonoNegocio;
        private string _NombreNegocio;
        private string _DireccionNegocio;
        private string _EstadoNegocio;
        #endregion

        #region Contructor
        public E_Negocios()
        {
            _Accion = string.Empty;
            _IdNegocios = 0;
            _DiasLaborales = string.Empty;
            _TipoNegocio = string.Empty;
            _TelefonoNegocio = string.Empty;
            _NombreNegocio = string.Empty;
            _DireccionNegocio = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdNegocios { get => _IdNegocios; set => _IdNegocios = value; }
        public string EDiasLaborales { get => _DiasLaborales; set => _DiasLaborales = value; }
        public string TipoNegocio { get => _TipoNegocio; set => _TipoNegocio = value; }
        public string TelefonoNegocio { get => _TelefonoNegocio; set => _TelefonoNegocio = value; }
        public string NombreNegocio { get => _NombreNegocio; set => _NombreNegocio = value; }
        public string DireccionNegocio { get => _DireccionNegocio; set => _DireccionNegocio = value; }
        public string EstadoNegocio { get => _EstadoNegocio; set => _EstadoNegocio = value; }
        #endregion

    }
    public class E_UsuarioNegocios
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private int _IdNegocios;
        #endregion

        #region Contructor
        public E_UsuarioNegocios()
        {
            _IdNegocios = 0;
            _IdUsuario = 0;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdNegocios { get => _IdNegocios; set => _IdNegocios = value; }
        #endregion
    }
}
