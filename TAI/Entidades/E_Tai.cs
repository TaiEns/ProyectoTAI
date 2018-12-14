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
        private string _ApellidoUsuario;
        private string _EmailUsuario;
        private string _PasswordUsuario;
        private string _EstatusUsuario;
        private string _Usuario;

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
            _ApellidoUsuario = string.Empty;
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
        public string ApellidoUsuario { get => _ApellidoUsuario; set => _ApellidoUsuario = value; }
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
        private int _CantidadProducto;
        private string _EstadoProducto;
        private string _MedidaProducto;
        private string _CategoriaProducto;
        #endregion

        #region Constructor
        public E_Producto()
        {
            _Accion = string.Empty;
            _IdProducto = 0;
            _NombreProducto = string.Empty;
            _Marca = string.Empty;
            _CantidadProducto = 0;
            _MedidaProducto = string.Empty;
            _CategoriaProducto = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public int CantidadProducto { get => _CantidadProducto; set => _CantidadProducto = value; }
        public string EstadoProducto { get => _EstadoProducto; set => _EstadoProducto = value; }
        public string MedidaProducto { get => _MedidaProducto; set => _MedidaProducto = value; }
        public string CategoriaProducto { get => _CategoriaProducto; set => _CategoriaProducto = value; }
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
        private string _EstadoNegocio;
        private string _RFC;
        private string _CalleNegocio;
        private int _NumeroCalle;
        private string _ColoniaNegocio;
        private int _CodigoPostal;
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
            _RFC = string.Empty;
            _CalleNegocio = string.Empty;
            _NumeroCalle = 0;
            _ColoniaNegocio = string.Empty;
            _CodigoPostal = 0;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdNegocios { get => _IdNegocios; set => _IdNegocios = value; }
        public string DiasLaborales { get => _DiasLaborales; set => _DiasLaborales = value; }
        public string TipoNegocio { get => _TipoNegocio; set => _TipoNegocio = value; }
        public string TelefonoNegocio { get => _TelefonoNegocio; set => _TelefonoNegocio = value; }
        public string NombreNegocio { get => _NombreNegocio; set => _NombreNegocio = value; }
        public string EstadoNegocio { get => _EstadoNegocio; set => _EstadoNegocio = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public string CalleNegocio { get => _CalleNegocio; set => _CalleNegocio = value; }
        public int NumeroCalle { get => _NumeroCalle; set => _NumeroCalle = value; }
        public string ColoniaNegocio { get => _ColoniaNegocio; set => _ColoniaNegocio = value; }
        public int CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
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

    public class E_HorarioNegocios
    {
        #region Atributos
        private string _Accion;
        private int _IdNegocios;
        private int _LE;
        private int _LS;
        private int _ME;
        private int _MS;
        private int _MIE;
        private int _MIS;
        private int _JE;
        private int _JS;
        private int _VE;
        private int _VS;
        private int _SE;
        private int _SS;
        private int _DE;
        private int _DS;
        #endregion

        #region Contructor
        public E_HorarioNegocios()
        {
            _IdNegocios = 0;
            _LE = 0;
            _LS = 0;
            _ME = 0;
            _MS = 0;
            _MIE = 0;
            _MIS = 0;
            _JE = 0;
            _JS = 0;
            _VE = 0;
            _VS = 0;
            _SE = 0;
            _SS = 0;
            _DE = 0;
            _DS = 0;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int LE { get => _LE; set => _LE = value; }
        public int LS { get => _LS; set => _LS = value; }
        public int ME { get => _ME; set => _ME = value; }
        public int MS { get => _MS; set => _MS = value; }
        public int MIE { get => _MIE; set => _MIE = value; }
        public int MIS { get => _MIS; set => _MIS = value; }
        public int JE { get => _JE; set => _JE = value; }
        public int JS { get => _JS; set => _JS = value; }
        public int VE { get => _VE; set => _VE = value; }
        public int VS { get => _VS; set => _VS = value; }
        public int SE { get => _SE; set => _SE = value; }
        public int SS { get => _SS; set => _SS = value; }
        public int DE { get => _DE; set => _DE = value; }
        public int DS { get => _DS; set => _DS = value; }
        public int IdNegocios { get => _IdNegocios; set => _IdNegocios = value; }
        #endregion
    }

    public class E_ProductoNegocios
    {
        #region Atributos
        private string _Accion;
        private int _IdProducto;
        private int _IdNegocios;
        private int _Precios;
        private int _IdProductoNegocio;
        #endregion

        #region Contructor
        public E_ProductoNegocios()
        {
            _IdNegocios = 0;
            _IdProducto = 0;
            _Precios = 0;
            _IdProductoNegocio = 0;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int IdNegocios { get => _IdNegocios; set => _IdNegocios = value; }
        public int Precios { get => _Precios; set => _Precios = value; }
        public int IdProductoNegocio { get => _IdProductoNegocio; set => _IdProductoNegocio = value; }
        #endregion
    }

    public class E_Email
    {
        #region Atributos
        private string _From;
        private string _Password;
        private string _To;
        private string _Msn;
        #endregion

        #region Constructor
        public E_Email()
        {
            _From = string.Empty;
            _Password = string.Empty;
            _To = string.Empty;
            _Msn = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string From
        {
            get { return _From; }
            set { _From = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string To
        {
            get { return _To; }
            set { _To = value; }
        }
        public string Msn
        {
            get { return _Msn; }
            set { _Msn = value; }
        }
        #endregion

    }

    public class E_ListaUsuario
    {
        #region Atributos
        private string _Accion;
        private int _IdUsuario;
        private int _IdLista;
        private string _NombreLista;
        #endregion

        #region Contructor
        public E_ListaUsuario()
        {
            _Accion = string.Empty;
            _IdLista = 0;
            _IdUsuario = 0;
            _NombreLista = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdLista { get => _IdLista; set => _IdLista = value; }
        public string NombreLista { get => _NombreLista; set => _NombreLista = value; }
        #endregion
    }

    public class E_ListaProducto
    {
        #region Atributos
        private string _Accion;
        private int _IdListaProducto;
        private int _IdProducto;
        private int _IdLista;
        #endregion

        #region Contructor
        public E_ListaProducto()
        {
            _IdListaProducto = 0;
            _IdLista = 0;
            _IdProducto = 0;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public int IdListaProducto { get => _IdListaProducto; set => _IdListaProducto = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int IdLista { get => _IdLista; set => _IdLista = value; }
        #endregion
    }

    public class E_Criticas
    {
        #region Atributos
        private string _Accion;
        private int _IdCritica;
        private int _IdUsuario;
        private int _ValorCritica;
        private string _Comentario;
        #endregion

        #region Contructor
        public E_Criticas()
        {
            _IdCritica = 0;
            _IdUsuario = 0;
            _ValorCritica = 0;
            _Comentario = string.Empty;
            _Accion = string.Empty;
        }
        #endregion

        #region Encapsulamiento
        public string Accion { get => _Accion; set => _Accion = value; }
        public string Comentario { get => _Comentario; set => _Comentario = value; }
        public int IdCritica { get => _IdCritica; set => _IdCritica = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int ValorCritica { get => _ValorCritica; set => _ValorCritica = value; }
        #endregion
    }

}
