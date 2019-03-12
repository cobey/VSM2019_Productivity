using System;
namespace VSM2019_Productivity
{
    public class QuickActions
    {
        // This codefix will wrap/indent/align lists of parameters/arguments
        // Place cursor in a parameter and type (option + return (⌥+ ⮐))
        // There are several wrapping options provided
        // Select the option to wrap every individual parameter to the same column
        public void WrapIndentAlignParameters(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
        { }

        // Use expression/block body for lambda
        // Place cursor after "=>" and type (option + return (⌥+ ⮐))
        // Select use block body for lambda expressions
        public void UseExpressionBlockBodyForLambda()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5); //j = 25 
        }
        delegate int del(int i);

        // Invert conditional expressions and logical operations
        // Place your cursor in "true"
        // Type (option + return (⌥+ ⮐)) and select invert conditional.
        public int InvertConditionalExpressionsAndLogicalOperations()
        {
            int zeroIfTrue = true ? 0 : 1;
            return zeroIfTrue;
        }

        // Convert to compound assignment
        // Place cursor in "10" and type (option + return (⌥+ ⮐))
        // Select use compound assignment
        public void ConvertToCompoundAssignment()
        {
            int x = 1;
            x = x + 10;

            Console.WriteLine(x);
        }

        // Fix Implicitly-typed variables cannot be constant
        // Uncomment the const line to cause an error
        // Place cursor in "var" and type (option + return (⌥+ ⮐))
        // Select use explicit type instead of var
        public void ImplicitlyTypedVariablesCannotBeConstant()
        {
            //const var v = "";
        }

        // Replace `@$"` with `$@"` when typing interpolated verbatim string
        // When you type an interpolated string it's easy to type the '$@' out of order.
        // This command fixes it as you type.
        // Try typing "string myString = @$" below and watch the fix apply automatically!
        public void CorrectTypingInterpolatedVerbatimString()
        {
            int x = 7;
            string myInterpolatedString = $@"This is my favorite number: {x}";
        }

        // Fix for identified unused expression values and parameters
        // Place cursor in by "x" to read the diagnostic. (no codefix)
        // Place cursor in x1 and type (option + return (⌥+ ⮐)) to remove the unused variable.
        public string UnusedParameter(string x)
        {
            string x1 = "x";
            return "x";
        }

        // Place cursor in foreach keyword and type (option + return (⌥+ ⮐))
        // Select 'Convert to Linq' to convert to a query
        public void ForeachLoopToLinqQuery()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // Place cursor in foreach keyword and type (option + return (⌥+ ⮐))
        // Select 'Convert to Linq(call form)' to convert to a method
        public void ForeachLoopToLinqMethod()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // A codefix for adding the needed "using" will appear on copy/pasted code
        // Uncomment the text into the method below: string json = JsonConvert.SerializeObject(greetings);
        // With your cursor in "JsonConvert" type (option + return (⌥+ ⮐))
        // Select to add the Using Newtonsoft.Json
        public void UsingRefAddedCopyPaste()
        {
            //string json = JsonConvert.SerializeObject("some json");
        }

        // Place cursor before the opening parenthesis in (3, "string");
        // Type (option + return (⌥+ ⮐))
        // Select Convert to struct
        public void ConvertTupleToNamedStruct()
        {
            var tuple = (3, "string");

            Console.WriteLine(tuple.Item2);
        }

        // Dead code analysis has improved to more accurately detect and remove unused code.
        // Place your cursor in the method name below and type (option + return (⌥+ ⮐))
        // Select remove unused member and it will delete the entire method and comment
        private void DeadCodeAnalysOnPrivateMembers()
        {
            Console.WriteLine("Never run.");
        }

        // Place cursor in the GetNumberAsync() in var x declaration.
        // Type (option + return (⌥+ ⮐)) and select Add await.
        public async Task ForgotImpliedAwaitAsync()
        {
            var x = GetNumberAsync();

            await GetNumberAsync();
        }
        private Task<object> GetNumberAsync()
        {
            throw new NotImplementedException();
        }

        // Place cursor in local HelloWorld method.
        // Type (option + return (⌥+ ⮐)) and select Convert to method
        public void ConvertLocalFunctionToMethod()
        {
            string HelloWorld()
            {
                return "HelloWorld!";
            }
            Console.WriteLine(HelloWorld());
        }

        // Uncomment the text in the method below to cause an error.
        // To fix the error in the method below
        // Place your cursor in MyInternalClass and Type (option + return (⌥+ ⮐)) 
        // Select Generate method MyInternalClass.Deconstruct.
        public void GenerateDeconstructMethod()
        {
            //(int x, int y) = new MyInternalClass();
        }
        private class MyInternalClass
        {
            public MyInternalClass()
            {
            }
        }

        // Place cursor in new and type (option + return (⌥+ ⮐))
        // Select Convert to tuple
        public void ConvertAnonymousTypetoTuple()
        {
            var myTuple = new { a = 1, b = 2 };
            var t2 = (3, "string");

            Console.WriteLine(t2.Item2, myTuple);
        }

        // Place cursor in 'new' keyword and type (option + return (⌥+ ⮐))
        // Select Convert to class
        public void ConvertAnonymousTypetoClass()
        {
            var myClass = new { str = "Hi" };

            Console.WriteLine(myClass.str);
        }

        // Click in the if statements and type (option + return (⌥+ ⮐)) to invert them.
        public void InvertIfElse()
        {
            var tru = true;
            //Bool expressions
            if (tru)
            {
                Console.WriteLine("Truth!");
            }
            else
            {
                Console.WriteLine("Falsehood!");
            }

            // Comparisons
            if (1 > 2)
            {
                Console.WriteLine("Change places!");
            }
            else
            {
                Console.WriteLine("Okay!");
            }

            // Multiple conditions
            if (0 == 0 && true || true)
            {
                Console.WriteLine("AlwaysTrue");
            }
            else
            {
                Console.WriteLine("Unreachable");
            }
        }

        // Multi-caret allows you to place multiple cursors in the file 
        // and edit them all at once.
        // Hold down (Ctrl + Option (^ + ⌥) and click with the left mouse 
        // at the beginning of the strings below. Add the word "Hi"
        public void MultiCaret()
        {
            Console.WriteLine("dotnet Bot!");
            Console.WriteLine("Allison!");
            Console.WriteLine("Kendra!");
        }

        // Use a conditional expression to simplify your code.
        // Click inside the if statement and type (option + return (⌥+ ⮐))
        // to refactor the if else into a conditional expression.
        public bool ConditionalExpression(int two)
        {
            if (two % 0 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // You can now add a parameter to a method from a callsite.
        // This example involves the two methods below.
        // Uncomment the parameter in callMethodA and use the codefix (option + return (⌥+ ⮐)) 
        // to add a string parameter to the MethodA signature.
        public void CallMethodA()
        {
            MethodA(0 /*, "add this parameter"*/);
        }
        public void MethodA(int zero)
        {

        }

        // Place you cursor beside the grayed out parenthesis in the if statement.
        // Type (option + return (⌥+ ⮐)) to remove the extra parenthesis.
        public void RemoveParenthesis()
        {
            if ((true) && !(2 > 1)) { }
        }

        // Place your cursor in the for loop statement.
        // Use (option + return (⌥+ ⮐)) to convert it to a foreach loop.
        // Use (option + return (⌥+ ⮐)) to convert it back into a for loop.
        public void ForLoopToForEach()
        {
            List<int> intList = new List<int>() { 1, 2, 3 };

            for (int i = 0; i < intList.Count; i++)
            {
                int num = intList[i];
                Console.WriteLine(intList[num]);
            }
        }

        public void LinqToForEach()
        {
            var greetings = new List<string>() { "hi", "yo", "hello", "howdy" };

            var shortGreeting =
                from greet in greetings
                where greet.Length < 3
                select greet;
        }
    }
}

// Pull members up refactoring with dialog options
// A dialog will appear to pull the Method up into the interface
// Place your cursor in PullUpMethod and type (option + return (⌥+ ⮐))
namespace PullUp
{
    public interface MyInterface
    {

    }
    public class MyClass : MyInterface
    {
        public void PullUpMethod()
        {
            System.Console.WriteLine("Hello World");
        }

        // You can pull up members as well.
        // Place your cursor in pullUpString and type (option + return (⌥+ ⮐))
        public string pullUpString;
    }
}