using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMathematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector3 = new Vector(3, 0, 0);
            Vector v = new Vector();
            Vector vector4 = new Vector(3, 3, 3);
            Vector.Dis(vector3, vector4);

            Console.WriteLine(Vector.Dis(vector3, vector4));

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

        public static Vector operator +(Vector vector1, Vector vector2) => new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);
        public static Vector operator -(Vector vector1, Vector vector2) => new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);
        public static Vector operator *(Vector vector1, float x) => new Vector(vector1.X * x, vector1.Y * x, vector1.Z * x);
        public static float Dis(Vector vector1, Vector vector2) => Length(vector2 - vector1);
        public static float Dis(Vector vector1, Vector vector2, out Vector vector) => Length(vector = vector2 - vector1);
        public static float Length(Vector vector) => (float)Math.Sqrt(SquareLength(vector));
        /// <summary>
        /// Fickt deine Mutter
        /// </summary>
        /// <param name="vector">Die Mutter die gefickt wird</param>
        /// <returns>Deinen neuen Bruder</returns>
        public static float SquareLength(Vector vector) => vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z;
        public float Dis(Vector otherVector) => Dis(this, otherVector);
    }
}
