using System;
using System.Collections.Generic;
using System.Linq;


public class CalculatorProgram
{
    private static Stack<Char> signalStack;
    private static Stack<Double> numberStack;
    private static List<String> biaodashiList;
    private static Queue<String> biaodashiQueue;
    public static readonly String yunsuanfu = "+-*/()=";

    /// <summary>
    /// 检测算符优先级。使用二维数组，1为大于，0为等于，-1为小于，-2为操作异常
    /// </summary>
    private static int Precede(char stackTop, char now)
    {

        int[,] youxianguanxi = {
        /*    θ2  + - *  /  (  ) =       */
       /*θ1 + */{ 1,1,-1,-1,-1,1,1 },
         /* - */{ 1,1,-1,-1,-1,1,1 },
         /* * */{ 1,1,1,1,-1,1,1},
         /* / */{ 1,1,1,1,-1,1,1},
         /* ( */{ -1,-1,-1,-1,-1,0,-2},
         /* ) */{ 1,1,1,1,-2,1,1},
         /* = */{ -1,-1,-1,-1,-1,-2,0}
            };

        return youxianguanxi[yunsuanfu.IndexOf(stackTop), yunsuanfu.IndexOf(now)];
    }

    /// <summary>
    /// 将一整个字符串分割成由顺序，操作符和数字组成的String表
    /// </summary>
    private static List<String> DivideString(String original)
    {
        List<String> list = new List<string>();
        int index = -1, indexBefore = -1; //防止第一个字符为操作符
        while ((index = original.IndexOfAny(yunsuanfu.ToCharArray(), index + 1)) != -1)
        {
            String temp;
            if (index != 0 && (temp = original.Substring(indexBefore + 1, index - indexBefore - 1)) != "") //第一个是操作符，操作符连续
                list.Add(temp);
            list.Add(original.ElementAt(index).ToString());
            indexBefore = index;
        }
        if (indexBefore < original.Length - 1) //如果还有元素就塞入
        {
            list.Add(original.Substring(indexBefore + 1));
        }
        return list;
    }

    /// <summary>
    /// 纯粹计算
    /// </summary>
    private static double Operate(double a, char theta, double b)
    {
        switch (theta)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;
            default:
                new Exception("Operate Failed!");
                break;
        }
        return 0;
    }

    /// <summary>
    /// 主计算函数，负责将表达式表中的元素，计算并返回
    /// </summary>
    private static double EvaluateExpression(string biaodashi)
    {
        //Init
        signalStack = new Stack<Char>();
        numberStack = new Stack<Double>();
        signalStack.Push('=');
        //Input
        biaodashiList = DivideString(biaodashi);
        biaodashiList.Add("=");

        biaodashiQueue = new Queue<string>();
        foreach (String temp in biaodashiList)
        {
            biaodashiQueue.Enqueue(temp);
        }

        String suipian = biaodashiQueue.Dequeue();

        while (suipian != "=" || signalStack.Peek() != '=')
        {
            if (yunsuanfu.Contains(suipian) == false)//不是运算符则进栈
            {
                numberStack.Push(Double.Parse(suipian));
                suipian = biaodashiQueue.Dequeue();
            }
            else //是运算符
            {
                switch (Precede(signalStack.Peek(), suipian[0]))
                {
                    case -1://栈顶元素优先级低:
                        signalStack.Push(suipian[0]);
                        suipian = biaodashiQueue.Dequeue();
                        break;
                    case 0://脱括号
                        signalStack.Pop();
                        suipian = biaodashiQueue.Dequeue();
                        break;
                    case 1://退栈并将运算结果入栈
                        char theta = signalStack.Pop();
                        double b = numberStack.Pop();
                        double a = numberStack.Pop();
                        numberStack.Push(Operate(a, theta, b));
                        break;
                    default:
                        //Console.WriteLine("操作异常！");
                        throw new Exception("表达式有错误。操作异常！");
                        
                }
            }
        }
        return numberStack.Pop();
    }

    /// <summary>
    /// 输入无等号的计算式suffix
    /// </summary>
    public static double getResult(String suffix)
    {
        return EvaluateExpression(suffix);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(EvaluateExpression(Console.ReadLine()));
        ;
    }
}
