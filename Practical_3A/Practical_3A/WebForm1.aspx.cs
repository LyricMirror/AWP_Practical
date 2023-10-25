using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_3A
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnResult_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "Welcome";
            Label2.Text = "Todays Date" + Calendar1.TodaysDate.ToShortDateString();
            Label3.Text = "Ganpati Vacation Start: 9-19-2023";
            TimeSpan d = new DateTime(2023, 9, 19) - DateTime.Now;
            Label4.Text = "Days Remaining For Ganpati Vacation:" + d.Days.ToString();
            TimeSpan d1 = new DateTime(2023, 12, 31) - DateTime.Now;
            Label5.Text = "Days Remaining for New Year:" + d1.Days.ToString();
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Calendar1.SelectedDates.Clear();
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "Your Selected Date:" +
            Calendar1.SelectedDate.ToShortDateString();

        }
        protected void Calendar1_DayRender(object
        sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                Label lbl = new Label();
                lbl.Text = "<br>Teachers Day!";
                e.Cell.Controls.Add(lbl);
            }
            if (e.Day.Date.Day == 19 && e.Day.Date.Month == 9)
            {
                Calendar1.SelectedDate = new DateTime(2023, 9, 19);
                Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate,
                Calendar1.SelectedDate.AddDays(9));
                Label lbl1 = new Label();
                lbl1.Text = "<br>Ganpati!";
                e.Cell.Controls.Add(lbl1);
            }
        }
    }
}