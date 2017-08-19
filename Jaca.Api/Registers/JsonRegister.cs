using System.Collections.Generic;
using Nancy.Bootstrapper;
using Newtonsoft.Json;

namespace Jaca.Api.Registers
{
    public class JsonRegister : IRegistrations
    {
        public IEnumerable<TypeRegistration> TypeRegistrations
        {
            get
            {
                yield return new TypeRegistration(typeof(JsonSerializer), typeof(JsonSerializer));
            }
        }

        public IEnumerable<CollectionTypeRegistration> CollectionTypeRegistrations { get; protected set; }
        public IEnumerable<InstanceRegistration> InstanceRegistrations { get; protected set; }
    }
}
