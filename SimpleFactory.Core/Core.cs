using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Core
{
    public abstract class Calculate
    {
        public double NumA { get; set; } = 0d;
        public double NumB { get; set; } = 0d;
        public abstract double GetResult();
    }

    /// <summary>
    /// 加法
    /// </summary>
    public class CalculateAdd : Calculate
    {
        public override double GetResult()
        {
            return NumA + NumB;
        }
    }

    /// <summary>
    /// 减法
    /// </summary>
    public class CalculateSub : Calculate
    {
        public override double GetResult()
        {
            return NumA - NumB;
        }
    }

    /// <summary>
    /// 乘法
    /// </summary>
    public class CalculateMul : Calculate
    {
        public override double GetResult()
        {
            return NumA * NumB;
        }
    }

    /// <summary>
    /// 除法
    /// </summary>
    public class CalculateDiv : Calculate
    {
        public override double GetResult()
        {
            if (NumB == 0)
            {
                throw new Exception("不能除以零。");
            }
            return NumA / NumB;
        }
    }

    /// <summary>
    /// 幂
    /// </summary>
    public class CalculatePow : Calculate
    {
        public override double GetResult()
        {
            return Math.Pow(NumA, NumB);
        }
    }

    public class CalculateFactory
    {
        public static Calculate CreateCalculate(string operate)
        {
            Calculate target = null;
            switch (operate)
            {
                case "+": target = new CalculateAdd(); break;
                case "-": target = new CalculateSub(); break;
                case "*": target = new CalculateMul(); break;
                case "/": target = new CalculateDiv(); break;
                case "^": target = new CalculatePow(); break;
            }
            return target;
        }
    }
}
