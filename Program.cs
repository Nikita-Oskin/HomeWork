using System;

namespace Geometry2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            BuildTetrahedron test1 = new BuildTetrahedron();
            BuildPyramid test2 = new BuildPyramid();
            BuildCube test3 = new BuildCube();

            test1.Tetrahedron();
            test2.Pyramid();
            test3.Cube();
        }
    }

    public class Check
    {
        public double x1, y1, z1;
        public double x2, y2, z2;
        public double x3, y3, z3;
        public double VecAB_1;
        public double VecAB_2;
        public double VecAB_3;
        public double VecAC_1;
        public double VecAC_2;
        public double VecAC_3;
        public double VectorLenghtAB;
        public double VectorLenghtAC;
        public double DotProduct;
        public double Cosine;
        public double Vec_prodA;
        public double Vec_prodB;
        public double Vec_prodC;
        public double Plane_eqA;
        public double Plane_eqB;
        public double Plane_eqC;
        public double Plane_eqD;
        public double Lenght_Vec_prod;
        public double Normalized_vecA;
        public double Normalized_vecB;
        public double Normalized_vecC;
        public double Normalized_PlaneA;
        public double Normalized_PlaneB;
        public double Normalized_PlaneC;
        public double Lenght_Plane_eq;
        public double[] Normalized_vecProd = new double[3];
        public double[] Normal = new double[3];
        public double angle_sign;

        public void Coordinate()
        {

        }
        public void CheckPoint()
        {
            Console.WriteLine("Enter point A coordinates");
            Console.WriteLine("Enter x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z1:");
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter point B coordinates");
            Console.WriteLine("Enter x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z2:");
            z2 = Convert.ToDouble(Console.ReadLine()); ;
            Console.WriteLine("Enter point C coordinates");
            Console.WriteLine("Enter x3:");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z3:");
            z3 = Convert.ToDouble(Console.ReadLine());


            VecAB_1 = x2 - x1; // Координаты AB по х
            VecAB_2 = y2 - y1; // Координаты AB по y
            VecAB_3 = z2 - z1; // Координаты AB по z
            VecAC_1 = x3 - x1; // Координаты AC по х
            VecAC_2 = y3 - y1; // Координаты AC по y
            VecAC_3 = z3 - z1; // Координаты AC по z
            VectorLenghtAB = Math.Sqrt(Math.Pow(VecAB_1, 2) + Math.Pow(VecAB_2, 2) + Math.Pow(VecAB_3, 2)); // Длина вектора AB
            VectorLenghtAC = Math.Sqrt(Math.Pow(VecAC_1, 2) + Math.Pow(VecAC_2, 2) + Math.Pow(VecAC_3, 2)); // Длина вектора AC
            DotProduct = VecAB_1 * VecAC_1 + VecAB_2 * VecAC_2 + VecAB_3 * VecAC_3; // Скалярное произведение вектора AB и AC
            Cosine = DotProduct / (VectorLenghtAB * VectorLenghtAC); // косинус угла между вектором AB и АС

            // Проверка на коллинеарность
            if (Cosine == 1 || Cosine == -1)
            {
                Console.WriteLine("Точки лежат на одной прямой");
            }
            else if (Cosine != 1 || Cosine != -1)
            {
                Console.WriteLine("Точки не лежат на одной прямой");
            }

            //Векторное произведение
            Vec_prodA = (VecAB_2 * VecAC_3 - VecAB_3 * VecAC_2);
            Vec_prodB = (VecAB_3 * VecAC_1 - VecAB_1 * VecAC_3);
            Vec_prodC = (VecAB_1 * VecAC_2 - VecAB_2 * VecAC_1);

            // Отнормированный вектор
            Lenght_Vec_prod = Math.Sqrt(Math.Pow(Vec_prodA, 2) + Math.Pow(Vec_prodB, 2) + Math.Pow(Vec_prodC, 2));
            Normalized_vecA = Vec_prodA / Lenght_Vec_prod;
            Normalized_vecB = Vec_prodB / Lenght_Vec_prod;
            Normalized_vecC = Vec_prodC / Lenght_Vec_prod;

            Normalized_vecProd[0] = Normalized_vecA;
            Normalized_vecProd[1] = Normalized_vecB;
            Normalized_vecProd[2] = Normalized_vecC;

            // Уравенние плоскости
            Plane_eqA = y1 * z2 - y2 * z1 - y1 * z3 + y3 * z1 + y2 * z3 - y3 * z2;
            Plane_eqB = -x1 * z2 + x2 * z1 + x1 * z3 - x3 * z1 - x2 * z3 + x3 * z2;
            Plane_eqC = x1 * y2 - x2 * y1 - x1 * y3 + x3 * y1 + x2 * y3 - x3 * y2;
    
            //Отнормированная нормаль
            Lenght_Plane_eq = Math.Sqrt(Math.Pow(Plane_eqA, 2) + Math.Pow(Plane_eqB, 2) + Math.Pow(Plane_eqC, 2));
            Normalized_PlaneA = Plane_eqA / Lenght_Plane_eq;
            Normalized_PlaneB = Plane_eqB / Lenght_Plane_eq;
            Normalized_PlaneC = Plane_eqC / Lenght_Plane_eq;

            Normal[0] = Normalized_PlaneA;
            Normal[1] = Normalized_PlaneB;
            Normal[2] = Normalized_PlaneC;

            if (Normalized_vecProd[0] == Normal[0] && Normalized_vecProd[1] == Normal[1] && Normalized_vecProd[2] == Normal[2])
            {
                Console.WriteLine("Точка С лежит слева ");
                angle_sign = 1;
            }
            else
            {
                Console.WriteLine("Точка С лежит справа");
                angle_sign = -1;
            }
        }
    }

    public class BuildTetrahedron : Check
    {
        public void Tetrahedron()
        {
            this.CheckPoint();
            //Матрица поворота * на вектор АВ + координаты т. А
            double Angle_tetr = (Math.PI * 60.0) / 180.0;
            double elem_tetr1 = Math.Cos(angle_sign * Angle_tetr) + (1 - Math.Cos(angle_sign * Angle_tetr)) * Math.Pow(Normalized_PlaneA, 2);
            double elem_tetr2 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneA * Normalized_PlaneB - Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneC;
            double elem_tetr3 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneA * Normalized_PlaneC + Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneB;
            double elem_tetr4 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneB * Normalized_PlaneA + Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneC;
            double elem_tetr5 = Math.Cos(angle_sign * Angle_tetr) + (1 - Math.Cos(angle_sign * Angle_tetr)) * Math.Pow(Normalized_PlaneB, 2);
            double elem_tetr6 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneB * Normalized_PlaneC - Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneA;
            double elem_tetr7 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneC * Normalized_PlaneA - Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneB;
            double elem_tetr8 = (1 - Math.Cos(angle_sign * Angle_tetr)) * Normalized_PlaneC * Normalized_PlaneB + Math.Sin(angle_sign * Angle_tetr) * Normalized_PlaneA;
            double elem_tetr9 = Math.Cos(angle_sign * Angle_tetr) + (1 - Math.Cos(angle_sign * Angle_tetr)) * Math.Pow(Normalized_PlaneC, 2);
            double[,] Rotation_matrix_tetr = new double[3, 3] { { elem_tetr1, elem_tetr2, elem_tetr3 }, { elem_tetr4, elem_tetr5, elem_tetr6 }, 
                                                                { elem_tetr7, elem_tetr8, elem_tetr9 } };

            double[,] Matrix_vec_tetr = new double[1, 3] { { VecAB_1, VecAB_2, VecAB_3 } };
            double[,] r = new double[Rotation_matrix_tetr.GetLength(0), Matrix_vec_tetr.GetLength(1)];
            double[,] A = new double[1, 3] { { x1, y1, z1 } };

            for (int i = 0; i < Rotation_matrix_tetr.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_vec_tetr.GetLength(0); j++)
                {
                    for (int k = 0; k < Matrix_vec_tetr.GetLength(1); k++)
                    {
                        r[i, j] += Rotation_matrix_tetr[i, k] * Matrix_vec_tetr[j, k]; // Произведение матрицы поворота и отнормированного вектора AB
                    }
                }
            }
            
            //Вычисление точки C'
            double Chatch_tetr1 = r[0, 0] + A[0, 0];
            double Chatch_tetr2 = r[1, 0] + A[0, 1];
            double Chatch_tetr3 = r[2, 0] + A[0, 2];

            //Расчет центра основания
            double Avarage_tetrX = (x1 + x2 + Chatch_tetr1) / 3;
            double Avarage_tetrY = (y1 + y2 + Chatch_tetr2) / 3;
            double Avarage_tetrZ = (z1 + z2 + Chatch_tetr3) / 3;

            //Высота тетраэдра
            double Tetrahedron_height = VectorLenghtAB * (Math.Sqrt(6)) / 3;

            //Получение 4ой точки тетраэдра
            double FourDot_tetrX = Avarage_tetrX + angle_sign * Normalized_PlaneA * Tetrahedron_height;
            double FourDot_tetrY = Avarage_tetrY + angle_sign * Normalized_PlaneB * Tetrahedron_height;
            double FourDot_tetrZ = Avarage_tetrZ + angle_sign * Normalized_PlaneC * Tetrahedron_height;

            Console.WriteLine($"Точки правильного тетраэдра: A({x1} , {y1} , {z1})" +
                              $"\nB({x2} , {y2} , {z2})" +
                              $"\nC'({Chatch_tetr1} , {Chatch_tetr2} , {Chatch_tetr3})" +
                              $"\nS({FourDot_tetrX} , {FourDot_tetrY} , {FourDot_tetrZ})");
            Console.WriteLine();
        }
    }

    public class BuildPyramid : Check
    {
        public void Pyramid()
        {
            this.CheckPoint();
            // Матрица поворота
            double Angle_pyramid = (Math.PI * 90.0) / 180.0;
            double elem_pyramid1 = Math.Cos(angle_sign * Angle_pyramid) + (1 - Math.Cos(angle_sign * Angle_pyramid)) * Math.Pow(Normalized_PlaneA, 2);
            double elem_pyramid2 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneA * Normalized_PlaneB - Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneC;
            double elem_pyramid3 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneA * Normalized_PlaneC + Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneB;
            double elem_pyramid4 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneB * Normalized_PlaneA + Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneC;
            double elem_pyramid5 = Math.Cos(angle_sign * Angle_pyramid) + (1 - Math.Cos(angle_sign * Angle_pyramid)) * Math.Pow(Normalized_PlaneB, 2);
            double elem_pyramid6 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneB * Normalized_PlaneC - Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneA;
            double elem_pyramid7 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneC * Normalized_PlaneA - Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneB;
            double elem_pyramid8 = (1 - Math.Cos(angle_sign * Angle_pyramid)) * Normalized_PlaneC * Normalized_PlaneB + Math.Sin(angle_sign * Angle_pyramid) * Normalized_PlaneA;
            double elem_pyramid9 = Math.Cos(Angle_pyramid) + (1 - Math.Cos(Angle_pyramid)) * Math.Pow(Normalized_PlaneC, 2);
            double[,] Rotation_matrix_pyramid = new double[3, 3] { { elem_pyramid1, elem_pyramid2, elem_pyramid3 }, { elem_pyramid4, elem_pyramid5, elem_pyramid6 }, 
                                                                   { elem_pyramid7, elem_pyramid8, elem_pyramid9 } };

            double[,] Matrix_vec_pyramid = new double[1, 3] { { VecAB_1, VecAB_2, VecAB_3 } };
            double[,] r = new double[Rotation_matrix_pyramid.GetLength(0), Matrix_vec_pyramid.GetLength(1)];
            double[,] B = new double[1, 3] { { x2, y2, z2 } };
            double[,] A = new double[1, 3] { { x1, y1, z1 } };

            for (int i = 0; i < Rotation_matrix_pyramid.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_vec_pyramid.GetLength(0); j++)
                {
                    for (int k = 0; k < Matrix_vec_pyramid.GetLength(1); k++)
                    {
                        r[i, j] += Rotation_matrix_pyramid[i, k] * Matrix_vec_pyramid[j, k]; // Произведение матрицы поворота и отнормированного вектора AB
                    }
                }
            }

            // Расчет точки C' и D
            double Chatch_pyramid1 = r[0, 0] + B[0, 0];
            double Chatch_pyramid2 = r[1, 0] + B[0, 1];
            double Chatch_pyramid3 = r[2, 0] + B[0, 2];

            double DotD_pyramid1 = r[0, 0] + A[0, 0];
            double DotD_pyramid2 = r[1, 0] + A[0, 1];
            double DotD_pyramid3 = r[2, 0] + A[0, 2];

            //Расчет центра основания
            double Avarage_pyramidX = (x1 + x2 + Chatch_pyramid1 + DotD_pyramid1) / 4;
            double Avarage_pyramidY = (y1 + y2 + Chatch_pyramid2 + DotD_pyramid2) / 4;
            double Avarage_pyramidZ = (z1 + z2 + Chatch_pyramid3 + DotD_pyramid3) / 4;

            //Высота пирамиды
            double Pyramid_height = VectorLenghtAB / (Math.Sqrt(2));

            //Получение 4ой точки пирамиды
            double FourDot_pyramidX = Avarage_pyramidX + angle_sign * Normalized_PlaneA * Pyramid_height;
            double FourDot_pyramidY = Avarage_pyramidY + angle_sign * Normalized_PlaneB * Pyramid_height;
            double FourDot_pyramidZ = Avarage_pyramidZ + angle_sign * Normalized_PlaneC * Pyramid_height;

            Console.WriteLine($"Точки правильной четырехугольной пирамиды: \nA({x1} , {y1} , {z1})" +
                              $"\nB({x2} , {y2} , {z2})" +
                              $"\nC'({Chatch_pyramid1} , {Chatch_pyramid2} , {Chatch_pyramid3})" +
                              $"\nD({DotD_pyramid1} , {DotD_pyramid2} , {DotD_pyramid3})" +
                              $"\nS({FourDot_pyramidX} , {FourDot_pyramidY} , {FourDot_pyramidZ})");
            Console.WriteLine();
        }
    }

    public class BuildCube : Check
    {
        public void Cube()
        {
            this.CheckPoint();
            // Матрица поворота
            double Angle_cube = (Math.PI * 90.0) / 180.0;
            double elem_cube1 = Math.Cos(angle_sign * Angle_cube) + (1 - Math.Cos(angle_sign * Angle_cube)) * Math.Pow(Normalized_PlaneA, 2);
            double elem_cube2 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneA * Normalized_PlaneB - Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneC;
            double elem_cube3 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneA * Normalized_PlaneC + Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneB;
            double elem_cube4 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneB * Normalized_PlaneA + Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneC;
            double elem_cube5 = Math.Cos(angle_sign * Angle_cube) + (1 - Math.Cos(angle_sign * Angle_cube)) * Math.Pow(Normalized_PlaneB, 2);
            double elem_cube6 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneB * Normalized_PlaneC - Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneA;
            double elem_cube7 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneC * Normalized_PlaneA - Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneB;
            double elem_cube8 = (1 - Math.Cos(angle_sign * Angle_cube)) * Normalized_PlaneC * Normalized_PlaneB + Math.Sin(angle_sign * Angle_cube) * Normalized_PlaneA;
            double elem_cube9 = Math.Cos(angle_sign * Angle_cube) + (1 - Math.Cos(angle_sign * Angle_cube)) * Math.Pow(Normalized_PlaneC, 2);
            double[,] Rotation_matrix_cube = new double[3, 3] { { elem_cube1, elem_cube2, elem_cube3 }, { elem_cube4, elem_cube5, elem_cube6 },
                                                                   { elem_cube7, elem_cube8, elem_cube9 } };

            double[,] Matrix_vec_cube = new double[1, 3] { { VecAB_1, VecAB_2, VecAB_3 } };
            double[,] r = new double[Rotation_matrix_cube.GetLength(0), Matrix_vec_cube.GetLength(1)];
            double[,] B = new double[1, 3] { { x2, y2, z2 } };
            double[,] A = new double[1, 3] { { x1, y1, z1 } };

            for (int i = 0; i < Rotation_matrix_cube.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix_vec_cube.GetLength(0); j++)
                {
                    for (int k = 0; k < Matrix_vec_cube.GetLength(1); k++)
                    {
                        r[i, j] += Rotation_matrix_cube[i, k] * Matrix_vec_cube[j, k]; // Произведение матрицы поворота и отнормированного вектора AB
                    }
                }
            }

            // Расчет точки C' и D
            double Chatch_cube1 = r[0, 0] + B[0, 0];
            double Chatch_cube2 = r[1, 0] + B[0, 1];
            double Chatch_cube3 = r[2, 0] + B[0, 2];

            double DotD_cube1 = r[0, 0] + A[0, 0];
            double DotD_cube2 = r[1, 0] + A[0, 1];
            double DotD_cube3 = r[2, 0] + A[0, 2];

            //Расчет центра основания
            double Avarage_cubeX = (x1 + x2 + Chatch_cube1 + DotD_cube1) / 4;
            double Avarage_cubeY = (y1 + y2 + Chatch_cube2 + DotD_cube2) / 4;
            double Avarage_cubeZ = (z1 + z2 + Chatch_cube3 + DotD_cube3) / 4;

            //Высота куба
            double Cube_height = VectorLenghtAB;

            //Получение остальных точек
            double A_hatch1 = x1 + angle_sign * Cube_height * Normalized_PlaneA;
            double A_hatch2 = y1 + angle_sign * Cube_height * Normalized_PlaneB;
            double A_hatch3 = z1 + angle_sign * Cube_height * Normalized_PlaneC;

            double B_hatch1 = x2 + angle_sign * Cube_height * Normalized_PlaneA;
            double B_hatch2 = y2 + angle_sign * Cube_height * Normalized_PlaneB;
            double B_hatch3 = z2 + angle_sign * Cube_height * Normalized_PlaneC;

            double C_doublehatch1 = Chatch_cube1 + angle_sign * Cube_height * Normalized_PlaneA;
            double C_doublehatch2 = Chatch_cube2 + angle_sign * Cube_height * Normalized_PlaneB;
            double C_doublehatch3 = Chatch_cube3 + angle_sign * Cube_height * Normalized_PlaneC;

            double D_hatch1 = DotD_cube1 + angle_sign * Cube_height * Normalized_PlaneA;
            double D_hatch2 = DotD_cube2 + angle_sign * Cube_height * Normalized_PlaneB;
            double D_hatch3 = DotD_cube3 + angle_sign * Cube_height * Normalized_PlaneC;

            Console.WriteLine($"Точки куба \nA({x1} , {y1} , {z1})" +
                              $"\nB({x2} , {y2} , {z2})" +
                              $"\nC'({Chatch_cube1} , {Chatch_cube2} , {Chatch_cube3})" +
                              $"\nD({DotD_cube1} , {DotD_cube2} , {DotD_cube3})" +
                              $"\nA'({ A_hatch1} , { A_hatch2} , { A_hatch3})" +
                              $"\nB'({ B_hatch1} , { B_hatch2} , { B_hatch3})" +
                              $"\nC''({ C_doublehatch1} , { C_doublehatch2} , { C_doublehatch3})" +
                              $"\nD'({ D_hatch1} , { D_hatch2} , { D_hatch3})");
        }
    }
}

