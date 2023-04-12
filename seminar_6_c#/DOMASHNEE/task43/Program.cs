// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y1 = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int k = 0;
const int b = 1;
const int x = 0;
const int y = 1;
const int line1 = 1;
const int line2 = 2;

double[] LineCoords(int numberLine)
{
  double[] lineCoords = new double[2];
  lineCoords[b] = Write($"write b for {numberLine} ");
  lineCoords[k] = Write($"write k for {numberLine} ");
  return lineCoords;
}

double[] FindCoords(double[] lineCoords1, double[] lineCoords2)
{
  double[] coord = new double[2];
  coord[x] = (lineCoords1[b] - lineCoords2[b]) / (lineCoords2[k] - lineCoords1[k]);
  coord[y] = lineCoords1[k] * coord[x] + lineCoords1[b];
  return coord;
}

bool LineValidate(double[] lineCoords1, double[] lineCoords2)
{
  if (lineCoords1[k] == lineCoords2[k])
  {
    if (lineCoords1[b] == lineCoords2[b])
    {
      Console.WriteLine("Прямые совпадают");
      return false;
    }
    else
    {
      Console.WriteLine("Прямые параллельны");
      return false;
    }
  }
  return true;
}
double Write(string message)
{
  System.Console.Write(message);
  string value = Console.ReadLine();
  double result = Convert.ToDouble(value);
  return result;
}


double[] lineCoords1 = LineCoords(line1);
double[] lineCoords2 = LineCoords(line2);
if (LineValidate(lineCoords1, lineCoords2))
{
  double[] coord = FindCoords(lineCoords1, lineCoords2);
  Console.Write($"b1 = {lineCoords1[b]}, k1 = {lineCoords1[k]}, b2 = {lineCoords2[b]}, k2 = {lineCoords2[k]}");
  Console.WriteLine($"-> ({coord[x]}, {coord[y]})");
}