using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigWordDesignModel.ModelSimpleFactory
{
    /// <summary>
    /// 減法
    /// </summary>
    public class OperationSub : Operation
    {
        public override int GetResult()
        {

            return Number1 - Number2;
        }
    }
}