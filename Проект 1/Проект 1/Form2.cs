using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Text;
namespace Проект_1
{
    public partial class Form2 : Form
    {
        Form1 form1;



        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            WEAK_WEATHERY();
            WEAK_WEATHERG();


        }

        //public void YandexTemp(string url)
        //{
        //    var urll = url;
        //    var doc1 = new HtmlAgilityPack.HtmlDocument();
        //    var web1 = new HtmlWeb();
        //    doc1.LoadHtml(web1.Load(urll).Text);
        //    var span1 = doc1.DocumentNode.SelectNodes("//span[contains(@class, 'temp__value')]");

        //}
        //public void searchCityY(string value)
        //{
        //    var doc1 = new HtmlAgilityPack.HtmlDocument();
        //    var web1 = new HtmlWeb();
        //    doc1.LoadHtml(web1.Load(form1.urlY).Text);


        //    var tegA = doc1.DocumentNode.SelectNodes("//a[contains(@class, 'link place-list__item-name i-bem')]");
        //    var temp1 = tegA[0].OuterHtml;


        //}

        private void WEAK_WEATHERY()
        {

            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            doc1.LoadHtml(web1.Load(form1.urlY).Text);
            try
            {
                var span1 = doc1.DocumentNode.SelectNodes("//div[contains(@class, 'content__row content__row_with-right-margin')]");
                var temp1 = span1[0].InnerText;
                var chchc = temp1.ToCharArray();
                Regex regex = new Regex(@"([А-Я][а-я])*(Сегодня)*[0-9]+ [а-я]{3}днём[" + (char)8722 + @"+]?\d+" + (char)176 + @"ночью[" + (char)8722 + @"+]?\d+" + (char)176);
                MatchCollection match = regex.Matches(temp1);
                int i = 0;
                DateTime date = DateTime.Now;
                foreach (Match item in match)
                {
                    i++;
                    if (i <= 4)
                        continue;
                    if (i >= 13)
                        break;
                    var sts = item.Value.Split();
                    StringBuilder builder = new StringBuilder();
                    builder.Append(date.Day.ToString() + "." + date.Month.ToString() + " ");
                    builder.Append(sts[1], 3, sts[1].Length - 3);
                    builder.Append("\n");
                    YANDEXWEATHER.Text += builder.ToString();
                    date = date.AddDays(1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("\n Вы не ввели город \n", e.Message);
            }           
        }
        private void WEAK_WEATHERG()
        {
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            doc1.LoadHtml(web1.Load(form1.urlG + "10-days/").Text);
            var span1 = doc1.DocumentNode.SelectNodes("//span[contains(@class, 'unit unit_temperature_c')]");
            DateTime date = DateTime.Now;
            for (int j = 0; j < 15; j += 2)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(date.Day.ToString() + "." + date.Month.ToString() + " ");
                var str = span1[j].InnerText.Split(';');
                if (str[0] == "&minus")
                {
                    builder.Append(" днём-" + str[1] + (char)176);
                }
                else
                {
                    builder.Append(" днём" + str[0] + (char)176);
                }
                str = span1[j + 1].InnerText.Split(';');
                if (str[0] == "&minus")
                {
                    builder.Append("ночью-" + str[1] + (char)176);
                }
                else
                {
                    builder.Append("ночью" + str[0] + (char)176);
                }
                builder.Append("\n");
                GISMETEOWEATHER.Text += builder.ToString();
                date = date.AddDays(1);
            }

        }
    }
}

