using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigWordDesignModel.ModelSimpleFactory
{
    /// <summary>
    /// 計算方式類別
    /// </summary>
    public class Operation
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

        /*
         * virtual 關鍵字的用途是修改方法、屬性、索引子 (Indexer) 或事件宣告，以及允許在衍生類別 (Derived Class) 中予以覆寫。例如，這個方法可由任一繼承它的類別來覆寫：
         * by MSDN
         */
        public virtual int GetResult()
        {
            return 0;
        }
    }
}