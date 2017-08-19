using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jaca.Api.Utilities.Interfaces
{
    public interface IEnumUtility
    {
        T Convert<T>(object enumToConvert);
    }
}
