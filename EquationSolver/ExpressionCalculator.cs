using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;

namespace EquationSolver
{
    class ExpressionCalculator
    {
        public readonly static double epsilon_default = 1E-9;
        public readonly static double dx_default = 1E-6;
        public readonly static int TimesStep_default = 100;
        public readonly static double MaxRange_default = 1000000;
        public readonly static int NumberOfIntervals_default = 100;
        public readonly static int DecimalDigits_default = 6;

        public static double epsilon = 1E-9;
        public static double dx = 1E-6;
        public static int TimesStep = 100;
        public static double MaxRange = 1000000;
        public static int NumberOfIntervals = 100;
        public static int DecimalDigits = 6;
        static private Random random = new Random();
        static private List<string> ErrorResult = new List<string>();
        static private List<string> EmptyResult = new List<string>();

        static ExpressionCalculator()
        {
            ErrorResult.Clear();
            ErrorResult.Add("[ INVALID EXPRESSION ]");

            EmptyResult.Clear();
            EmptyResult.Add("[ EMPTY EXPRESSION ]");
        }

        private static int ExpressionCharPriority(char c)
        {
            switch (c)
            {
                case '^':
                {
                    return 103;
                }
                case '*': case '/':
                {
                    return 102;
                }
                case '+': case '-':
                {
                    return 101;
                }
                case '(':
                {
                    return 100;
                }
                default:
                {
                    return 0;
                }
            }
        }
        
        private static bool IsNumberCharacter(char c)
        {
            if( c>='0' && c<='9' )
                return true;
            return false;
        }

        private static bool IsLetterCharacter(char c)
        {
            if( c>='a' && c<='z' )
                return true;
            if( c>='A' && c<='Z' )
                return true;
            return false;
        }

        private static bool IsNormalCharacter(char c)
        {
            if( IsLetterCharacter(c) )
                return true;
            if( IsNumberCharacter(c) )
                return true;

            if( c=='.' )
                return true;

            // special character for negative number
            if( c=='~' )
                return true;

            return false;
        }

        private static string HandleNegative(string s)
        {
            string result = "";

            for(int i=0; i<s.Length; i++)
            {
                if( s[i] == '-' )
                {
                    if( i==0 || s[i-1]=='+' || s[i-1]=='-' || s[i-1]=='*' || s[i-1]=='/' || s[i-1]=='(' )
                    {
                        result+='~';
                        continue;
                    }                  
                }
                
                // DO NOT use ELSE you idiot :)
                result+=s[i];
            }

            result = result.Replace("~~","");
            for(int i=result.Length-2; i>=0; i--)
            {
                if(result[i] == '~' && ( IsLetterCharacter(result[i+1]) || result[i+1] == '(') )
                    result = result.Insert(i+1, "1");       
            }

            return result;
        }

        /// automatically add * when 2 element is stuck together, I'm cool af
        private static string HandleMultiply(string inputExpression)
        {
            string result = inputExpression;
            for(int i=inputExpression.Length-2; i>=0; i--)
            {
                char c1 = result[i];
                char c2 = result[i+1];

                if( c1 == ')' && c2 == '(' )
                    result = result.Insert(i+1, "*");
                else
                if( c1 == ')' && IsNormalCharacter(c2) )
                    result = result.Insert(i+1, "*");
                else
                if( IsNormalCharacter(c1) && c2 == '(' )
                    result = result.Insert(i+1, "*");
                else

                if( IsLetterCharacter(c1) && IsNormalCharacter(c2) )
                    result = result.Insert(i+1, "*");
                else
                if( IsNormalCharacter(c1) && IsLetterCharacter(c2) )
                    result = result.Insert(i+1, "*");
            }

            return result;
        }

        public static string RefineInfix(string inputExpression)
        {
            string temp = inputExpression;
            temp = temp.Replace(" ", "");
            temp = temp.ToLower();
            temp = HandleNegative(temp);
            temp = HandleMultiply(temp);

            return temp;
        }

        /// Function to convert expression from infix to RPN
        public static List<string> ConvertInfixToRPN(string inputExpression)
        {
            Stack<char> st = new Stack<char>();
            List<string> result = new List<string>();
            result.Clear();

            inputExpression = RefineInfix(inputExpression);
            
            int cntOperator = 0;

            if( inputExpression.Length == 0 )
            {
                return EmptyResult;
            }

            for(int i=0; i<inputExpression.Length; i++)
            {
                char c = inputExpression[i];
                switch (c)
                {
                    case '(':
                    {
                        st.Push(c);
                        break;
                    }
                    case ')':
                    {
                        while( st.Count != 0 && st.Peek() != '(' )
                        {
                            result.Add(st.Pop().ToString());
                        }

                        if( st.Count == 0 )
                        {
                            return ErrorResult;
                        }

                        st.Pop();
                        break;
                    }
                    
                    case '+': case '-': case '*': case '/': case '^':
                    {
                        while( st.Count != 0 && ExpressionCharPriority(c) <= ExpressionCharPriority(st.Peek()) )
                        {
                            result.Add(st.Pop().ToString());
                        }
                        st.Push(c);
                        cntOperator++;

                        break;
                    }

                    default:
                    {
                        // user may type weird characters
                        if( !IsNormalCharacter(inputExpression[i]) )
                        {
                            return ErrorResult;
                        }

                        string temp = "";
                        while( i<inputExpression.Length && IsNormalCharacter(inputExpression[i]) )
                        {
                            if( inputExpression[i] == '~' )
                                temp+="-";
                            else
                                temp+=inputExpression[i];

                            i++;
                        }

                        // There was only negative sign in a number
                        if(temp == "-")
                            return ErrorResult;

                        result.Add(temp);
                        i--;
                        break;
                    }
                }
            }   
            while( st.Count != 0 )
            {
                string x = st.Pop().ToString();

                if( x == "(" )
                    return ErrorResult;

                result.Add(x);
            }

            if( 2*cntOperator+1 != result.Count )
                return ErrorResult;
            
            return result;
        }

        public static double LoadVarValue(char c, double[] UserVariables)
        {
            if(c>='a' && c<='z')
            {
                return UserVariables[c - 'a'];
            }
            else
            {
                return double.NaN;
            }
        }

        public static string CalculateRPN(List<string> inputExpression, double[] UserVariables)
        {
            if( inputExpression[0] == ErrorResult[0] || inputExpression[0] == EmptyResult[0] )
            {
                return inputExpression[0];
            }

            Stack<double> st = new Stack<double>();

            for(int i = 0; i<inputExpression.Count; i++)
            {
                switch (inputExpression[i])
                {
                    case "+":
                    {
                        double y = st.Pop();
                        double x = st.Pop();
                        st.Push(x+y);
                        break;
                    }
                    case "-":
                    {
                        double y = st.Pop();
                        double x = st.Pop();
                        st.Push(x-y);
                        break;
                    }
                    case "*":
                    {
                        double y = st.Pop();
                        double x = st.Pop();
                        st.Push(x*y);
                        break;
                    }
                    case "/":
                    {
                        double y = st.Pop();
                        double x = st.Pop();
                        
                        // cannot divides by zero
                        double z;
                        try
                        {
                            z = x / y;
                        }
                        catch
                        {
                            return "[ MATH ERROR ]";
                        }                       

                        st.Push(z);
                        break;
                    }
                    case "^":
                    {
                        double y = st.Pop();
                        double x = st.Pop();
                        
                        double z;
                        try
                        {
                            z = Math.Pow(x,y);
                        }
                        catch
                        {
                            return "[ MATH ERROR ]";
                        }

                        if( double.IsNaN(z) )
                            return "[ MATH ERROR ]";

                        st.Push(z);
                        break;
                    }
                    default:
                    {
                        string temp = inputExpression[i];
                        
                        if( IsLetterCharacter(temp[0]) )
                            st.Push( LoadVarValue(temp[0], UserVariables) );
                        else
                        {
                            try
                            {
                                st.Push(double.Parse(inputExpression[i]));
                            }
                            catch
                            {
                                return "[ MATH ERROR ]";
                            }
                        }
                        
                        break;
                    }
                }
            }

            double dRes = st.Pop();
            string result;
            if ( !IsNumber(dRes) )
                result = "[ MATH ERROR ]";
            else
            {
                dRes = Math.Round(dRes,DecimalDigits);
                result = dRes.ToString("0." + new string('#', 339));
            }
            return result;
        }

    // solving equation //////////////////////////////////////////////////////////////////////////////////////////////////// 
        /// checking if a double is actually is a number :)
        private static bool IsNumber(double d)
        {
            if(double.IsNaN(d))
                return false;
            if(double.IsInfinity(d))
                return false;
            return true;
        }

        private static double RandomInRange(double L, double R)
        {
            int x = random.Next(int.MaxValue);
            double result = L + (R-L)*x/int.MaxValue;
            return result;
        }
        
        public static double DerivativeRPN(List<string> inputExpression, double[] UserVariables_, char unknown, double value)
        {
            double[] UserVariables = (double[])UserVariables_.Clone();
            try
            {
                UserVariables[unknown - 'a'] = value - dx;
                double f1 = double.Parse( CalculateRPN(inputExpression, UserVariables) );
                UserVariables[unknown - 'a'] = value + dx;
                double f2 = double.Parse( CalculateRPN(inputExpression, UserVariables) );
                return (f2 - f1)/(2*dx);
            }
            catch
            {
                return double.NaN;
            }
        }

        // Newton-Raphson method next step
        private static double NextStep(List<string> expression, double[] UserVariables_, char unknown, double value)
        {
            double[] UserVariables = (double[])UserVariables_.Clone();
            UserVariables[unknown - 'a'] = value;
            double f;
            try
            {
                f = double.Parse( CalculateRPN(expression, UserVariables) );
            }
            catch
            {
                f = double.NaN;
            }

            double fp = DerivativeRPN( expression, UserVariables, unknown, value );

            try
            {
                return value - f/fp;
            }
            catch
            {
                return double.NaN;
            }
        }

        private static double SolveForUnknownOneSpot(List<string> expression, double[] UserVariables_, char unknown, double x0)
        {
            double[] UserVariables = (double[])UserVariables_.Clone();
            double x = x0;
            for(int i = 0; i < TimesStep; i++)
            {
                UserVariables[unknown - 'a'] = x;

                double res; 
                try
                { 
                    res = Math.Abs( double.Parse( CalculateRPN(expression, UserVariables) ) );
                }
                catch
                {
                    res = double.NaN;
                }

                if( res!=double.NaN && res <= epsilon )
                    return x;

                x = NextStep(expression, UserVariables, unknown, x);
                if(! IsNumber(x) )
                    break;
            }

            return double.NaN;
        }

        /// This Uses Newton - Raphson method to solve "any" equation
        public static string SolveForUnkown(List<string> expression, double[] UserVariables_, char unknown, double LeftRange, double RightRange)
        {
            // invalid input checking
            if( expression == ErrorResult )
            {
                return ErrorResult[0];
            }
            for(int i=0; i<26; i++)
            {
                if( i!=unknown-'a' && ! IsNumber(UserVariables_[i]) )
                    return "[ MATH ERROR ]";
            }

            if(LeftRange >= RightRange)
            {
                return "[ NO SOLUTION FOUND ]";
            }

            LeftRange = Math.Max(-MaxRange, LeftRange);
            RightRange = Math.Min(MaxRange, RightRange) + 1;
            double SearchRange = RightRange - LeftRange + 1;

            double[] UserVariables = (double[])UserVariables_.Clone();
            double dRes = double.NaN;
            for(int i = 0; i<NumberOfIntervals; i++)
            {
                double IntervalLeftRange  = ( LeftRange + ((double)SearchRange)*i    /NumberOfIntervals );
                double IntervalRightRange = ( LeftRange + ((double)SearchRange)*(i+1)/NumberOfIntervals );
                dRes = SolveForUnknownOneSpot( expression, UserVariables, unknown, RandomInRange(IntervalLeftRange, IntervalRightRange) );
                if(IsNumber(dRes))
                {
                    break;
                }
            }

            if( ! IsNumber(dRes) )
            {
                return "[ NO SOLUTION FOUND ]";
            }
            else
            {
                dRes = Math.Round(dRes,DecimalDigits);
                UserVariables_[unknown - 'a'] = dRes;
                return dRes.ToString("0." + new string('#', 339));
            }
        }

    }
}