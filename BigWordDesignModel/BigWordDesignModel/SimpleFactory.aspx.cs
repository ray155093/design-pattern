using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BigWordDesignModel.ModelSimpleFactory;

namespace BigWordDesignModel
{
    public partial class SimpleFactory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///偷懶 給預設
            if (!IsPostBack)
            {
                txtNumber1.Text = "10";
                txtNumber2.Text = "100";
                txtOpration.Text = "+";
            }
        }
        /// <summary>
        /// 勇者計算方式
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            string Opration = txtOpration.Text;
            #region 檢查

            if (!int.TryParse(txtNumber1.Text, out N1))
            {
                txtNumber1.Focus();
                Response.Write("<Script language='JavaScript'>alert('N1要數入數字阿!');</Script>");
                return;
            }
            if (!int.TryParse(txtNumber2.Text, out N2))
            {
                txtNumber2.Focus();
                Response.Write("<Script language='JavaScript'>alert('N2要數入數字阿!');</Script>");
                return;
            }
            if (string.IsNullOrEmpty(Opration))
            {
                txtOpration.Focus();
                Response.Write("<Script language='JavaScript'>alert('運算符號要數入阿!');</Script>");
                return;
            }
            #endregion

            OperationItem Item = new OperationItem(N1, N2, Opration);

            JustBeBraveAction(ref Item);
            Label1.Text = Item.Result.ToString();
        }

        
        public void JustBeBraveAction(ref OperationItem Item)
        {
            /*
             f switch 1比較
             http://www.liangshunet.com/ca/201303/886427761.htm
            If_Elseif: 162ms Switch_Case: 71ms
          从运行结果可以看出，if elseif 用的时间比 Switch 多出91ms，程序循环了10000000次。如果循环次数继续增加，Switch 的效率更为明显，可见 Switch 的效率比 if elseif 要高。
          switch 之所以快，是因为编译后 switch 增加了一个索引跳转，而 if ... elseif 没有增加索引跳转。看反编译后的 ildasm 代码，可以发现 Switch_Case 方法中增加了下面这一句：
          switch (IL_003f, IL_0047, IL_004f, IL_0057, IL_005f, IL_0067)
          正是它实现了一个 jump table。 　
             */

            switch (Item.OprationSign)
            {
                case "+":
                    Item.Result = Item.Number1 + Item.Number2;
                    break;
                case "-":
                    Item.Result = Item.Number1 - Item.Number2;
                    break;
            }
            return;
        }

        /// <summary>
        /// 工程師計算方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDone_Click(object sender, EventArgs e)
        {
            int N1;
            int N2;
            string Opration = txtOpration.Text;
            #region 檢查

            if (!int.TryParse(txtNumber1.Text, out N1))
            {
                txtNumber1.Focus();
                Response.Write("<Script language='JavaScript'>alert('N1要數入數字阿!');</Script>");
                return;
            }
            if (!int.TryParse(txtNumber2.Text, out N2))
            {
                txtNumber2.Focus();
                Response.Write("<Script language='JavaScript'>alert('N2要數入數字阿!');</Script>");
                return;
            }
            if (string.IsNullOrEmpty(Opration))
            {
                txtOpration.Focus();
                Response.Write("<Script language='JavaScript'>alert('運算符號要數入阿!');</Script>");
                return;
            }
            #endregion

            Operation oper;

            oper = OperationFactory.CreateOpration(txtOpration.Text.Trim());
            oper.Number1 = N1;
            oper.Number2 = N2;
            oper.Result = oper.GetResult();
            Label1.Text = oper.Result.ToString();


        }
        #region 不重要
        protected void btnBrave_Click(object sender, EventArgs e)
        {
            pl_Brave.Visible = true;
        }

        protected void btnCreateClass_Click(object sender, EventArgs e)
        {
            pl_Factory.Visible = true;
        }

        #endregion
    }
}