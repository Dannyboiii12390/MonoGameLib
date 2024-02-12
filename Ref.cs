using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameLib
{
    public class Ref<T> where T : struct
    {
        public T Value { get; set; }

    }
}
