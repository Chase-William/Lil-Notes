using System;
using System.Collections.Generic;
using System.Text;

namespace Lil_Notes
{
    /// <summary>
    ///     Collection of txt used for NameErrorAlerts when creating or modifing an existing "Note" instance.
    /// </summary>
    public struct NameErrorAlert
    {
        public const string TITLE = "Error";
        public const string MSG = "The note's name cannot be empty or just spaces.";
        public const string CANCEL = "OK";
    }
}
