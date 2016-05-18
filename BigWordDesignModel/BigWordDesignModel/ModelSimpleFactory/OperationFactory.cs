using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigWordDesignModel.ModelSimpleFactory
{
    public class OperationFactory
    {
        /// <summary>
        /// 依照輸入的運算符號 產生對應物件
        /// </summary>
        /// <param name="Opration"></param>
        /// <returns></returns>
        public static Operation CreateOpration(string Opration)
        {
            Operation opra = null;
            switch (Opration)
            {
                case "+":
                    opra = new OperationAdd();
                    break;
                case "-":
                    opra = new OperationSub();
                    break;
                case "*":
                    opra = new OperationMul();
                    break;
            }
            return opra;

        }
    }
}