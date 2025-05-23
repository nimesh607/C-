using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorException
{
    internal class DivideByOddNoException : ApplicationException//suggestion inhertit fromApplication Exception because it doesnt have any child classes
    {
        public override string Message
        {
            get
            {
                return "Attempted to divide by Odd Number";
            }
        }
    }
}
