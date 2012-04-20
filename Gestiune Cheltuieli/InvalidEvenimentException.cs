using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestiune_Cheltuieli {
    class InvalidEvenimentException : Exception {
        public InvalidEvenimentException() : base() { }

        public InvalidEvenimentException(String message) : base(message) { }

        public InvalidEvenimentException(String message, Exception innerException) : base(message, innerException) { }
    }
}
