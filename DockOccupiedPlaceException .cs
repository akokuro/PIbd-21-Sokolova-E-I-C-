using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить корабль, уже занято"
    /// </summary>
    class DockOccupiedPlaceException : Exception
    {
        public DockOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит корабль")
        { }
    }
}
