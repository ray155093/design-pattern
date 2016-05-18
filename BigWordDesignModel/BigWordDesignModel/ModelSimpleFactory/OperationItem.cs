using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigWordDesignModel.ModelSimpleFactory
{
    public class OperationItem
    {
        /// <summary>
        /// 第一個數字
        /// </summary>
        public int Number1 { set; get; }
        /// <summary>
        /// 第二個數字
        /// </summary>
        public int Number2 { set; get; }
        /// <summary>
        /// 運算符號
        /// </summary>
        public string OprationSign { set; get; }

        /// <summary>
        /// 計算結果
        /// </summary>
        public int Result { set; get; }

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        /// <param name="OprationSign"></param>
        public OperationItem(int Number1, int Number2, string OprationSign )
        {
            
            this.Number1 = Number1; 
            this.Number2= Number2;

             this.OprationSign=OprationSign ;
        }
    }
}