using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BigWordDesignModel
{
    public partial class interview_example : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int LevelNumber = 7;

            string RhombusStr = MarkRhombus(LevelNumber);

            Label1.Text = RhombusStr;

        }
        private string MarkRhombus(int LevelNumber)
        {
            string Result = "";
            int UpdateLevel = LevelNumber / 2;
            int downLevel = LevelNumber - UpdateLevel;
            string mark = "*";
            string tab = "_";
            for (int UpCount = 1; UpCount <= UpdateLevel; UpCount++)
            {

                for (int tabCount = 1; tabCount <=  (LevelNumber - 1); tabCount++)
                {
                    Result += tab;
                }
                for (int markCount = 1; markCount <= 2*UpCount-1; markCount++)
                {
                    Result += mark;
                }
                for (int tabCount = (LevelNumber - 1); tabCount >= 1; tabCount--)
                {
                    Result += tab;
                }

                Result += "<br />";

            }
            return Result;

        }
    }
}