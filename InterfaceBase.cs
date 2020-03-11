using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_BridgeFactory.Entity;

namespace DA_BridgeFactory
{
    namespace Interface
    {
        /// <summary>
        /// 连接基类
        /// </summary>
        public abstract class InterfaceBase
        {
            List<EntityBase> connectdItems;
        }
        /// <summary>
        /// 焊接基类
        /// </summary>
        public class WeldInterface:InterfaceBase
        {

        }
        /// <summary>
        /// 对接焊缝
        /// </summary>
        public class ButtWeld:WeldInterface
        {

        }
        /// <summary>
        /// 角焊缝
        /// </summary>
        public class FilletWeld:WeldInterface
        {

        }
        /// <summary>
        /// 螺栓连接
        /// </summary>
        public class BoltInterface:InterfaceBase
        {

        }
    }
}
