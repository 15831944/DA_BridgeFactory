using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_BridgeFactory
{
    namespace Material
    {
        /// <summary>
        /// 材料基类
        /// </summary>
        public abstract class MaterialBase
        {
            public double Density { get; set; }
            public string Name { get; set; }
        }
        public class Steel:MaterialBase 
        {

        }
    }

}
