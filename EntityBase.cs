using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_BridgeFactory.Geometry;

namespace DA_BridgeFactory
{
    namespace Entity
    {
        /// <summary>
        /// 构件几何形态基类
        /// </summary>
        public abstract class EntityBase
        {

        }
        #region Plate
        /// <summary>
        /// 平面板件
        /// </summary>
        public class Plate:EntityBase
        {
            public double Thickness { get; set; }
            public List<Point2d> Vertices { get; set; }
        }
        /// <summary>
        /// 矩形板件
        /// </summary>
        public class RectanglePlate : Plate
        {
            /// <summary>
            /// 两个角点
            /// </summary>
            private Point2d corner1;
            private Point2d corner2;
            /// <summary>
            /// 指定两个角点的构造函数
            /// </summary>
            /// <param name="pt1">第一个角点</param>
            /// <param name="pt2">第二个角点</param>
            public RectanglePlate(Point2d pt1, Point2d pt2)
            {
                corner1 = pt1;
                corner2 = pt2;
                this.Vertices.Add(pt1);
                this.Vertices.Add(new Point2d(pt1.X, pt2.Y));
                this.Vertices.Add(pt2);
                this.Vertices.Add(new Point2d(pt2.X, pt1.Y));
            }
        }
        /// <summary>
        /// 延伸型板件
        /// </summary>
        public class ExtrudedPlate:Plate
        {
            /// <summary>
            /// 基线
            /// </summary>
            public virtual Polyline2d BaseLine { get; set; }
            /// <summary>
            /// 延伸方向
            /// </summary>
            public Vector3d Direction { get; set; }
            /// <summary>
            /// 延伸距离
            /// </summary>
            public double Distance { get; set; }
        }
        /// <summary>
        /// U肋
        /// </summary>
        public class URib:ExtrudedPlate
        {
            /// <summary>
            /// U肋基本几何参数
            /// </summary>
            public double TopWidth { get; set; }  //顶宽
            public double BottomWidth { get; set; }  //底宽
            public double Height { get; set; }  //高度
            public double FilletRadius { get; set; }  //倒角半径
            /// <summary>
            /// 重写截面线形属性，由U肋基本几何参数get，且不能set
            /// </summary>
            public override Polyline2d BaseLine
            {
                get
                {
                    return base.BaseLine;
                }
            }
        }
        /// <summary>
        /// 球扁钢
        /// </summary>
        public class BulbFlat: ExtrudedPlate
        {
               
        }
        #endregion
    }

}
