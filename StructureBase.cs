using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_BridgeFactory.Entity;
using DA_BridgeFactory.Feature;
using DA_BridgeFactory.Material;
using DA_BridgeFactory.Interface;
using DA_BridgeFactory.Geometry;

namespace DA_BridgeFactory
{
    namespace structure
    {
        public abstract class StructureBase
        {
            /// <summary>
            /// 基本几何体信息，字典形式，键为几何体名称，值为几何体对象
            /// </summary>
            public Dictionary<string, EntityBase> entityInfo;
            /// <summary>
            /// 基本几何体位置信息，键为几何体名称，值为位置信息
            /// </summary>
            public Dictionary<string, GeometryBase> entityPosition;
            /// <summary>
            /// 特征信息，字典形式，键为几何体名称，值为该几何体所拥有特征做成的列表
            /// </summary>
            public Dictionary<string, List<FeatureBase>> featureInfo;
            /// <summary>
            /// 材料信息，字典形式，键为几何体名称，值为该几何体的材料对象
            /// </summary>
            public Dictionary<string, MaterialBase> materialInfo;
            /// <summary>
            /// 子结构信息，字典形式，键为子结构名称，值为子结构
            /// </summary>
            public Dictionary<string, StructureBase> subStructureInfo;
            /// <summary>
            /// 子结构位置信息，字典形式，键为子结构名称，值为位置
            /// </summary>
            public Dictionary<string, GeometryBase> subStructurePosition;
            /// <summary>
            /// 连接信息，结构中各部件连接信息汇总
            /// </summary>           
            public List<InterfaceBase> interfaceInfo;
            /// <summary>
            /// 结构体定位原点
            /// </summary>
            public Point3d Origin;
        }
    }
}
