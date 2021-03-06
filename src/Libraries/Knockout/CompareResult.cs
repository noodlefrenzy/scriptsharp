// CompareResult.cs
// Script#/Libraries/Knockout
//

using System;
using System.Runtime.CompilerServices;

namespace KnockoutApi {

    [Imported]
    [IgnoreNamespace]
    public class CompareResult<T> {

        [IntrinsicProperty]
        public string Status {
            get;
            set;
        }

        [IntrinsicProperty]
        public T Value {
            get;
            set;
        }
    }
}
