using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace DA_BridgeFactory
{
    namespace Geometry
    {
        #region Point Vector
        /// <summary>
        /// 三维几何点
        /// </summary>
        public struct Point3d
        {
            /// <summary>
            /// X、Y、Z坐标
            /// </summary>
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="x">X坐标</param>
            /// <param name="y">Y坐标</param>
            /// <param name="z">Z坐标</param>
            public Point3d(double x = 0, double y = 0, double z = 0)
            {
                X = x;
                Y = y;
                Z = z;
            }
            /// <summary>
            /// 获取原点
            /// </summary>
            public static Point3d Origin
            {
                get
                {
                    return new Point3d();
                }
            }
            /// <summary>
            /// 转换为二维点的函数
            /// </summary>
            /// <returns></returns>
            public Point2d ToPoint2d()
            {
                return new Point2d(this.X, this.Y);
            }
        }
        /// <summary>
        /// 二维几何点
        /// </summary>
        public struct Point2d
        {
            /// <summary>
            /// X、Y、Z坐标
            /// </summary>
            public double X { get; set; }
            public double Y { get; set; }
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="x">X坐标</param>
            /// <param name="y">Y坐标</param>
            public Point2d(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }
            public Point3d ToPoint3d(double z = 0)
            {
                return new Point3d(this.X, this.Y, z);
            }
        }
        public class Vector3d
        {
            /// <summary>
            /// X、Y、Z坐标
            /// </summary>
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="x">X坐标</param>
            /// <param name="y">Y坐标</param>
            /// <param name="z">Z坐标</param>
            public Vector3d(double x = 0, double y = 0, double z = 0)
            {
                X = x;
                Y = y;
                Z = z;
            }
            /// <summary>
            /// 获得向量的长度
            /// </summary>
            /// <returns></returns>
            public double GetLength()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            }
            /// <summary>
            /// 获得该向量的单位长度向量
            /// </summary>
            /// <returns>获得单位长度向量</returns>
            public Vector3d GetUnitVector()
            {
                Vector3d unitVector = new Vector3d();
                unitVector.X = X / this.GetLength();
                unitVector.Y = Y / this.GetLength();
                unitVector.Z = Z / this.GetLength();
                return unitVector;
            }
        }
        #endregion
        /// <summary>
        /// 几何基类
        /// </summary>
        public abstract class GeometryBase
        {

        }
        #region Line
        /// <summary>
        /// 一维线抽象类
        /// </summary>
        public abstract class Line:GeometryBase
        {

        }
        /// <summary>
        /// 三维线段
        /// </summary>
        public class Line3d:Line
        {
            /// <summary>
            /// 起点、终点
            /// </summary>
            public Point3d StartPt { get; set; }
            public Point3d EndPt { get; set; }
        }
        /// <summary>
        /// 三维直线
        /// </summary>
        public class XLine3d:Line
        {
            /// <summary>
            /// 起点
            /// </summary>
            public Point3d StartPt { get; set; }
            /// <summary>
            /// 方向点，只能设置不能获取，因为获取没有意义
            /// </summary>
            public Point3d DirectionPt { private get; set; }
        }
        /// <summary>
        /// 三维射线
        /// </summary>
        public class RLine3d:Line
        {
            /// <summary>
            /// 起点
            /// </summary>
            public Point3d StartPt { get; set; }
            /// <summary>
            /// 方向点，只能设置不能获取，因为获取没有意义
            /// </summary>
            public Point3d DirectionPt { private get; set; }
        }
        /// <summary>
        /// 二维多段线
        /// </summary>
        public class Polyline2d:Line
        {
            /// <summary>
            /// 多段线顶点
            /// </summary>
            public List<Point2d> Vertices { get; set; }
            /// <summary>
            /// 顶点半径（0时为折线）
            /// </summary>
            public List<double> Radius { get; set; }
        }
        #endregion
        #region CoordinateSystem
        public class CoordinateSystem
        {

        }
        /// <summary>
        /// 笛卡尔坐标系
        /// </summary>
        public class CartesianCS:CoordinateSystem
        {
            /// <summary>
            /// 坐标原点
            /// </summary>
            public Point3d Origin { get; set; } 
            /// <summary>
            /// 三个坐标轴的方向
            /// </summary>
            public Vector3d XDirection { get; set; }
            public Vector3d YDirection { get; set; }
            public Vector3d ZDirection { get; set; }
            /// <summary>
            /// 默认构造函数
            /// </summary>
            public CartesianCS()
            {
                Origin = Point3d.Origin;
                XDirection = new Vector3d(1, 0, 0);
                YDirection = new Vector3d(0, 1, 0);
                ZDirection = new Vector3d(0, 0, 1);
            }
            /// <summary>
            /// 获得世界坐标系
            /// </summary>
            public static CartesianCS WCS
            {
                get
                {
                    return new CartesianCS();
                }
            }
        }
        #endregion
    }
}
