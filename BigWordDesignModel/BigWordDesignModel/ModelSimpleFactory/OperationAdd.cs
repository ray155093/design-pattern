using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigWordDesignModel.ModelSimpleFactory
{
    /// <summary>
    /// 加法
    /// </summary>
    public class OperationAdd:Operation
    {
        public override int GetResult()
        {

            return Number1 + Number2;
        }
    }
}