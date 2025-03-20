using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Core.Constants
{
    public class ReplyMessage
    {
        public const string MESSAGE_QUERY = "Consulta realizada.";
        public const string MESSAGE_QUERY_EMPTY = "Sin registros.";
        public const string MESSAGE_SAVE = "Registro exitoso.";
        public const string MESSAGE_UPDATE = "Actualización exitosa.";
        public const string MESSAGE_DELETE = "Eliminado correctamente.";
        public const string MESSAGE_CANCEL = "Anulado correctamente.";
        public const string MESSAGE_EXISTS = "El registro ya existe.";
        public const string MESSAGE_ACTIVATE = "Activado correctamente.";
        public const string MESSAGE_TOKEN = "Token generado.";
        public const string MESSAGE_TOKEN_ERROR = "Usuario o contraseña incorrectos.";
        public const string MESSAGE_TOKEN_ERROR_REFRESH = "Token inválido.";
        public const string MESSAGE_VALIDATE = "Errores de validación.";
        public const string MESSAGE_FAILED = "Operación fallida.";
        public const string MESSAGE_EXCEPTION = "Error inesperado.";
        public const string MESSAGE_AUTH_TYPE = "Ingrese con email y contraseña.";

        public const string MESSAGE_USEREMPRESA_EMPTY = "Usuario sin empresa.";
        public const string MESSAGE_USEREMPRESA_SUCESS = "Consulta exitosa.";
        public const string MESSAGE_USEREMPRESA_ERROR = "Error inesperado.";

    }
}
