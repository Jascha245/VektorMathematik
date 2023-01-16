using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMathematik
{
    internal class Program
    {
            Vector vector3 = new Vector(3, 0, 0);
            Vector2D v = new Vector2D();
            Vector origin = new Vector();
            Vector vector4 = new Vector(3, 3, 3);
            public Vector2D Add(Vector2D vector1, Vector2D vector2)
            {
                return vector1 + vector2;
            }

        static void Main(string[] args)
        {
            Vector2D vector2d1 = new Vector2D(1,1);
            Vector2D vector2d2 = new Vector2D(2,2);
            Vector2D vector2d3 = new Vector2D();
            Vector2D v = vector2d1 + vector2d2;
            Console.WriteLine(v.X);
            Console.ReadLine();
        }
    }

    internal class Vector
    {
        public float X;
        public float Y;
        public float Z;

        public Vector()
        {
            X = 0f;
            Y = 0f;
            Z = 0f;
        }
        public Vector(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        /// <summary>
        /// Overloaded operator for the addition of two Vectors. 
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns>Vector</returns>
        public static Vector operator +(Vector vector1, Vector vector2) => new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);

        /// <summary>
        /// Overloaded operator for the subtraction of two Vectors.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns>Vector</returns>
        public static Vector operator -(Vector vector1, Vector vector2) => new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);
        /// <summary>
        /// Overloaded operator for the multiplication of one Vector and an float.
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="x"></param>
        /// <returns>Vector</returns>
        public static Vector operator *(Vector vector1, float x) => new Vector(vector1.X * x, vector1.Y * x, vector1.Z * x);

        public static float Dis(Vector vector1, Vector vector2) => Length(vector2 - vector1);
        public static float VecDis(Vector vector1, Vector vector2, out Vector vector) => Length(vector = vector2 - vector1);
        public static float Length(Vector vector) => (float)Math.Sqrt(SquareLength(vector));
        /// <summary>
        /// Method to 
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static float SquareLength(Vector vector) => vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;
        public float NonStacicDistance(Vector otherVector) => Dis(this, otherVector);
    }

    internal class Vector2D
    {
        public float X;
        public float Y;

        public Vector2D()
        {
            X = 0f;
            Y = 0f; 
        }

        public Vector2D(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Vector2D operator +(Vector2D vector1, Vector2D vector2) => new Vector2D(vector1.X + vector2.X, vector1.Y + vector2.Y);


    }
}


