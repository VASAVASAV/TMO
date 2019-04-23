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
            return (1d / par) * Math.Log(1d / (1 - a.NextDouble()));
        }
        double IRandom.NextRand(double[] pars)
        {
            return (1d / pars[0]) * Math.Log(1d / (1 - a.NextDouble()));
        }
    }

    class NormRand : IRandom
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
}
