using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using GMBProj.CalcService;

namespace GMBProj
{
    public partial class GetWSData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // DropDownList tsOperacao = (DropDownList)ViewState["sOperacao"];
            if (sOperacao.Items.Count == 0)
            {
                // sOperacao.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(calcOptions)))
                {
                    var name = Enum.GetName(typeof(calcOptions), value);
                    sOperacao.Items.Add(name);
                }
            }
            calcularBtn.Click += new EventHandler(this.calcularBtn_Click);
        }

        public void calcularBtn_Click(Object sender, EventArgs e)
        {
            CalculatorClient client = new CalculatorClient();

            int n1 = int.Parse(num1.Text, CultureInfo.InvariantCulture);
            int n2 = int.Parse(num2.Text, CultureInfo.InvariantCulture);
            double total = 0;

            string query = sOperacao.Text;

            //Response.Write(num1 + num2);
            switch (sOperacao.SelectedValue)
            {
                case "AddNumbers":
                    {
                        total = double.Parse(client.AddNumbers(n1, n2).ToString("F2"), CultureInfo.InvariantCulture);
                        break;
                    }
                case "SubstractNumbers":
                    {
                        total = double.Parse(client.SubstractNumbers(n1, n2).ToString("F2"), CultureInfo.InvariantCulture);
                        break;
                    }
                case "MultiplyNumbers":
                    {
                        total = double.Parse(client.MultiplyNumbers(n1, n2).ToString("F2"), CultureInfo.InvariantCulture);
                        break;
                    }
                case "DivisionNumbers":
                    {
                        total = double.Parse(client.DivisionNumbers(n1, n2).ToString("F2"), CultureInfo.InvariantCulture);
                        break;
                    }
            }
            totalizador.Text = total.ToString("F2");
        }
    }


    public enum calcOptions
    {
        AddNumbers,
        SubstractNumbers,
        MultiplyNumbers,
        DivisionNumbers
    }
}