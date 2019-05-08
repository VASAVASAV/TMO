using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    interface IRandom
    {
        double NextRand(double par);
        double NextRand(double[] pars);
    }

    class ExpRand : IRandom
    {
        Random a = new Random();
        double IRandom.NextRand(double par)
        {
            return (1d / par) * Math.Log(1d / (1 - a.NextDouble()));
        }
        double IRandom.NextRand(double[] pars)
        {
            return (1d / pars[0]) * Math.Log(1d / (1 - a.NextDouble()));
        }
    }

    class UniformRand : IRandom
    {
        Random a = new Random();
        double IRandom.NextRand(double par)
        {
            return par * a.NextDouble();
        }
        double IRandom.NextRand(double[] pars)
        {
            return pars[0]+ (pars[1]-pars[0]) * a.NextDouble();
        }
    }

    class NormRand : IRandom
    {
        Random a = new Random();
        Random b = new Random();
        Random c = new Random();
        double IRandom.NextRand(double par)
        {
            start:
            double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
            double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
            double s = x * x + y * y;
            if ((s == 0) || (s > 1))
            {
                goto start;
            }
            double result = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
            return par * result;
        }
        double IRandom.NextRand(double[] pars)
        {
        start:
            double x = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
            double y = ((Convert.ToDouble(a.Next(0, 2000) + b.Next(0, 2000) + c.Next(0, 2000)) % 2000) / 1000) - 1;
            double s = x * x + y * y;
            if ((s == 0) || (s > 1))
            {
                goto start;
            }
            double result = y * Math.Pow(((-2 * Math.Log(s)) / s), 0.5);
            return pars[0] + pars[1]*result;
        }
    }
}
