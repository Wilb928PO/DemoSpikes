using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambdas
{
    public partial class Form1 : Form
    {
        delegate int Transformer(int x);
        delegate int Add(int x, int y);
        public Form1()
        {
            InitializeComponent();
        }

        //This uses a traditional delegate to call a method to square a number
        private void btntraditionaldelegate_Click(object sender, EventArgs e)
        {
            Transformer method = Square; //Defines a delegate and points it to a method named Square
            int result = method(5);  //Calles the method Square by using the delegate name and stores the result in a variable named "result"
            MessageBox.Show(result.ToString());  //Displays the result in a message box
        }

        //This produces the same result as the above method, but uses an anonymous method
        private void btnanonymousmethod_Click(object sender, EventArgs e)
        {
            Transformer sqr = delegate (int x) //This declares a delegate as the above method except that it uses an anonymous method instead of
              {                                //pointing to a regular method, which makes the logic easier to follow
                  return x * x;
              };
            int result = sqr(5);
            MessageBox.Show(result.ToString());  //This calls the anonymous method via the delegate name and displays the result in a message box
        }

        //This produces the same output as the above methods except lambda expressions instead of traditional dellegates or anonyous methods
        private void btnsimplelamdaexpression_Click(object sender, EventArgs e)
        {
            Transformer sqr = x => x * x; //Declares a delegate, but uses a lambda expression instead of an anonymous method.  This makes the code more concise
            MessageBox.Show(sqr(5).ToString());  //Executes the lambda expression via the delegate name and displays the output in a messagebox
        }

        //Exactly the ame as the previous method.  The only difference is the parameter of the lambda explictly declares the data type.
        private void btnlamdawithoutinference_Click(object sender, EventArgs e)
        {
            Transformer sqr = (int x) => x * x; //When explicitly declaring the data type. parenthesis are required
            MessageBox.Show(sqr(5).ToString());  //Executes the lambda expression via the delegate name and displays  the output in a message box
        }

        //This creates a lambda that adds 2 numbers together.  It demonstrates a lambda with more than 1 parameter
        private void btnlamdawithmultipleparameters_Click(object sender, EventArgs e)
        {
            Add sum = (x, y) => x + y;  //When creating a lambda with more than 1 parameter, parenthesis are required regardless of whether or not the data types are inferred
            MessageBox.Show(sum(2, 2).ToString());  //Executes the lambda via the delegate name and displays the output in a message box
        }

        //Same as previous method but demonstates a lambda using a code block when more than 1 line of code is needed.
        private void btnlambdawithcodeblock_Click(object sender, EventArgs e)
        {
            Add sum = (x, y) =>  //Code block is required when more than one line of code is needed.  Notice the ; after the closing curly brace
              {
                  return x + y;
              };
            MessageBox.Show(sum(2, 2).ToString());  //Executes the lambda via the delegate name and displays the output in a message box
        }

        //This is the method that's being pointed to using the traditional delegate technique
        private int Square(int x)
        {
            return x * x;
        }
        
        //C# 7 method with only one line can be written like this
        //private int Square(int x) => x * x;
    }
}
