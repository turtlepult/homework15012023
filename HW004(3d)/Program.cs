using System;
//Найти расстояние между точками в пространстве 3D
double x1 = new Random().Next(1, 20);
double y1 = new Random().Next(1, 20);
double x2 = new Random().Next(1, 20);
double y2 = new Random().Next(1, 20);
double z1 = new Random().Next(1, 20);
double z2 = new Random().Next(1, 20);
double stepen = 2;

double diffx = x1-x2;
double diffy = y1-y2;
double diffz = z1-z2;
double dist = Math.Sqrt((Math.Pow(diffx, stepen) + Math.Pow(diffy, stepen) + Math.Pow(diffz, stepen)));

Console.Write("Расстояние между точками: " + dist);