using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Drawing;




namespace Проект_1
{
    public partial class Form1 : Form
    {
        public string urlY;
        public string urlG;
        
        

        public Form1()
        {
            InitializeComponent();
            
            var defUrlY = $"https://yandex.ru/pogoda/yaroslavl";
            urlY = defUrlY;
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            doc1.LoadHtml(web1.Load(defUrlY).Text);
            var span1 = doc1.DocumentNode.SelectNodes("//span[contains(@class, 'temp__value')]");
            var temp1 = span1[1].InnerHtml;


            var defUrlG = $"https://www.gismeteo.ru/weather-yaroslavl-4313/";
            urlG = defUrlG;
            var doc2 = new HtmlAgilityPack.HtmlDocument();
            var web2 = new HtmlWeb();

            doc2.LoadHtml(web2.Load(defUrlG).Text);
            var span2 = doc2.DocumentNode.SelectNodes("//span[contains(@class, 'js_value tab-weather__value_l')]");
            var temp2 = span2[0].InnerText.Split(new char[] { ';', ' ','\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (temp2[0] == "&minus")
                TEMPERATURE2.Text = "−" + temp2[1] + (char)176;
            else
                TEMPERATURE2.Text = temp2[1] + (char)176;

            TEMPERATURE1.Text = temp1 + (char)176;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            searchCityY(CITY.Text);
            searchCityGis(CITY.Text);            

        }
        public void YandexTemp(string url)
        {
            var urll = url;           
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            doc1.LoadHtml(web1.Load(urll).Text);         
            var span1 = doc1.DocumentNode.SelectNodes("//span[contains(@class, 'temp__value')]");
            TEMPERATURE1.Text = span1[1].InnerHtml + (char)176;
            
            
        }
        public void searchCityY (string value)
        {      
            var city = value;            
            urlY = $"https://yandex.ru/pogoda/search?request={city}";            
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            try
            {
                doc1.LoadHtml(web1.Load(urlY).Text);
                var tegA = doc1.DocumentNode.SelectNodes("//a[contains(@class, 'link place-list__item-name i-bem')]");
                var temp1 = tegA[0].OuterHtml;

                Regex regex = new Regex(@"/\d+\?via=srp");
                MatchCollection match = regex.Matches(temp1);
                foreach (var ch in match)
                {
                    urlY = $"https://yandex.ru/pogoda" + ch.ToString();
                }
                labelCity.Text = tegA[0].InnerText.Split(',')[0];

                YandexTemp(urlY);
            }
            catch(Exception e)
            {
                MessageBox.Show("\n Yandex: Не могу найти город :( \n или \n Такого города не существует\n", e.Message);
                searchCityY("Ярославль");
            }
        }
        public void searchCityGis(string value)
        {
            var city = value;            
            var url1 = $"https://www.gismeteo.ru/search/{city}/";
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            try
            {
                doc1.LoadHtml(web1.Load(url1).Text);
                var span2 = doc1.DocumentNode.SelectNodes("//section[contains(@class, 'catalog_block')]");

                if (span2.Count > 1)
                    span2[0].RemoveAll();

                span2 = span2[0].SelectNodes("//a[contains(@class, 'catalog_link link blue fontM')]");

                Regex regex = new Regex(@"/weather-\w+[-\w+]*-\d+/");
                MatchCollection match = regex.Matches(span2[0].OuterHtml);
                foreach (var ch in match)
                {
                    url1 = $"https://www.gismeteo.ru" + ch.ToString();
                }
                GismeteoTemp(url1);
            }
            catch (Exception e)
            {
                MessageBox.Show("\n GISMETEO: Не могу найти город :( \n или \n Такого города не существует\n", e.Message);
                searchCityGis("Ярославль");
            }
            

        }
        public void GismeteoTemp(string urlGs )
        {

            var url1 = urlGs;
            urlG = url1;
            var doc1 = new HtmlAgilityPack.HtmlDocument();
            var web1 = new HtmlWeb();
            doc1.LoadHtml(web1.Load(url1).Text);
            var span2 = doc1.DocumentNode.SelectNodes("//span[contains(@class, 'js_value tab-weather__value_l')]");
            

            var temp2 = span2[0].InnerText.Split(new char[] { ';', ' ','\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (temp2.Length>1 && temp2[0] == "&minus")
                TEMPERATURE2.Text = "-" + temp2[1]+(char)176;
            else
                TEMPERATURE2.Text = temp2[0] + (char)176;
        }

        private void WeakWeather_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            form2.Visible = true;
        }

        private void CITY_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13 && CITY.Text!="")
            {
                button1_Click(new object(), new EventArgs());
                return;
            }
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }

        }

        private void CITY_Click(object sender, EventArgs e)
        {
            CITY.Clear();
        }
               
    }
}
