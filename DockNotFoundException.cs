using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-ошибка "Если не найден корабль по определенному месту"
    /// </summary>
    class DockNotFoundException : Exception
    {
        public DockNotFoundException(int i) : base("Не найден корабль по месту " + i)
        { }
    }
}
