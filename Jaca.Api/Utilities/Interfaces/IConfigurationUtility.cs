using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jaca.Api.Utilities.Interfaces
{
    public interface IConfigurationUtility
    {
        string DatabaseConnectionHost { get; }

        string DatabaseConnectionPort { get; }

        string DatabaseConnectionUsername { get; }

        string DatabaseConnectionPassword { get; }

        string ConnectionStringMongoDb { get; }

        string DatabaseName { get; }
    }
}
