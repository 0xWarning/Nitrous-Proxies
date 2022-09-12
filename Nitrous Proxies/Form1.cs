using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;

namespace Nitrous_Proxies
{
    public partial class Form1 : Form
    {
        Defaults _Def = new Defaults();
        WebClient _WC = new WebClient();

        // Variables
        int ProxyAmount, AmountOfPages, ThreadCount;
        string CurrentlyScrapingPage;
        bool Status_Gathering; // Is used !

        List<string> stringArray = new List<string>()
                    {
                      "http://rootjazz.com/proxies/proxies.txt",
"https://api.proxyscrape.com/v2/?request=displayproxies&protocol=http&timeout=10000&country=all&ssl=all&anonymity=all",
"https://api.proxyscrape.com/v2/?request=displayproxies&protocol=socks4&timeout=10000&country=all",
"https://api.proxyscrape.com/v2/?request=displayproxies&protocol=socks5&timeout=10000&country=all",
"http://free-proxy-list.net/anonymous-proxy.html",
"https://free-proxy-list.net/",
"http://proxyape.com/",
"http://socks5proxies.com/index.php?page=3&action=freeproxy",
"http://proxylistchecker.org/proxylists.php?t=anonymous&p=5",
"http://proxylistchecker.org/proxylists.php?t=anonymous&p=9",
"http://proxytime.ru/http",
"http://socks5proxies.com/index.php?page=4&action=freescrapeboxproxies",
"http://proxylistchecker.org/proxylists.php?t=anonymous&p=8",
"http://notan.h1.ru/hack/xwww/proxy5.html",
"http://notan.h1.ru/hack/xwww/proxy4.html",
"http://notan.h1.ru/hack/xwww/proxy2.html",
"https://www.us-proxy.org/",
"http://www.proxylists.net/http_highanon.txt",
"http://socks5proxies.com/index.php?action=freescrapeboxproxies",
"http://socks5proxies.com/index.php?page=2&action=freescrapeboxproxies",
"http://proxygaz.com/country/united-states-of-america-proxy/",
"http://multiproxy.org/anon_proxy.htm",
"http://socks5proxies.com/index.php?page=2&action=freeproxy",
"http://proxylistchecker.org/proxylists.php?t=anonymous",
"http://txt.proxyspy.net/proxy.txt",
"http://files.c75.in/pub/proxy-list.txt",
"https://www.my-proxy.com/free-proxy-list-7.html",
"http://proxyserverlist-24.blogspot.com/feeds/posts/default",
"http://www.proxyserverlist24.top/feeds/posts/default",
"https://www.my-proxy.com/free-proxy-list-9.html",
"http://getfreeproxylists.blogspot.com/",
"https://premproxy.com/list/02.htm",
"https://www.sslproxies.org/",
"https://openproxy.space/list/http",
"https://openproxy.space/list/socks4",
"https://openproxy.space/list/socks5",
"https://premproxy.com/socks-list/ip-port/5.htm",
"https://premproxy.com/socks-list/ip-port/6.htm",
"https://www.my-proxy.com/free-transparent-proxy.html",
"https://premproxy.com/socks-list/05.htm",
"http://proxy-heaven.blogspot.com/",
"https://premproxy.com/socks-list/18.htm",
"https://www.my-proxy.com/free-proxy-list-5.html",
"https://premproxy.com/list/09.htm",
"https://premproxy.com/list/12.htm",
"https://premproxy.com/list/05.htm",
"http://spys.ru/free-proxy-list/RU/",
"https://premproxy.com/socks-list/02.htm",
"http://nntime.com/proxy-updated-01.htm",
"https://premproxy.com/socks-list/15.htm",
"https://premproxy.com/socks-list/ip-port/2.htm",
"http://nntime.com/proxy-updated-08.htm",
"https://premproxy.com/list/06.htm",
"http://nntime.com/proxy-updated-05.htm",
"http://vipaccounts24.blogspot.com/",
"https://premproxy.com/list/08.htm",
"http://feeds.feedburner.com/proxypandora",
"https://premproxy.com/socks-list/17.htm",
"http://best-proxy.ru/feed",
"https://www.my-proxy.com/free-proxy-list-10.html",
"https://premproxy.com/list/11.htm",
"http://proxy.ipcn.org/proxylist2.html",
"https://premproxy.com/socks-list/06.htm",
"http://nntime.com/proxy-updated-03.htm",
"https://www.my-proxy.com/free-proxy-list-6.html",
"https://premproxy.com/socks-list/08.htm",
"https://premproxy.com/socks-list/16.htm",
"http://www.haozs.net/Class.asp?ID=17|/Html/?|0",
"http://nntime.com/proxy-updated-06.htm",
"https://premproxy.com/socks-list/07.htm",
"http://nntime.com/proxy-updated-07.htm",
"https://www.my-proxy.com/free-elite-proxy.html",
"http://globalproxies.blogspot.com/",
"https://www.my-proxy.com/free-proxy-list-3.html",
"https://premproxy.com/list/15.htm",
"https://premproxy.com/socks-list/14.htm",
"https://premproxy.com/socks-list/04.htm",
"http://www.thebigproxylist.com/",
"http://www.megaproxylist.net/",
"https://proxy11.com/free-proxy",
"https://www.proxy-list.download/api/v1/get?type=http",
"https://www.proxy-list.download/api/v1/get?type=socks4",
"https://www.proxy-list.download/api/v1/get?type=socks5",
"https://api.proxyscrape.com/?request=displayproxies&proxytype=http&timeout=20000",
"https://premproxy.com/socks-list/03.htm",
"https://www.socks-proxy.net/",
"https://premproxy.com/socks-list/20.htm",
"http://proxylists.net/http_highanon.txt",
"https://www.proxynova.com/proxy-server-list/",
"http://www.socks24.org/2017/10/10-10-17-vip-socks-5_85.html",
"http://proxydb.net/?protocol=socks5&ip_filter=&port_filter=&host_filter=&via_filter=&country_filter=&city_filter=&region_filter=&isp_filter=",
"http://proxydb.net/?protocol=socks5&ip_filter=&port_filter=&host_filter=&via_filter=&country_filter=&city_filter=&region_filter=&isp_filter=&offset=20",
"http://proxydb.net/?protocol=socks5&ip_filter=&port_filter=&host_filter=&via_filter=&country_filter=&city_filter=&region_filter=&isp_filter=&offset=40",
"http://socksproxylist24.blogspot.com/feeds/posts/default",
"http://www.live-socks.net/feeds/posts/default",
"http://www.socks24.org/feeds/posts/default",
"http://www.vipsocks24.net/feeds/posts/default",
"https://premproxy.com/socks-list/{01-20}.htm",
"https://premproxy.com/socks-list/10.htm",
"http://nntime.com/proxy-updated-10.htm",
"https://premproxy.com/socks-list/13.htm",
"https://openproxy.space/list/Mvy53mGu62",
"https://openproxy.space/list/ELvSfWD-x5",
"https://openproxy.space/list/hi96pheKyj",
"https://openproxy.space/list/Bo3U-avEBm",
"https://openproxy.space/list/Phii6ig6Jz",
"https://followo178.followpromo.co/download-free-netherland-vpn.dochtml?fid=25",
"https://vpntraffic.com/index.php?action=content&cont_id=95",
"https://www.gatherproxy.com/embed/?c=Netherlands",
"https://www.youtube.com/watch?v=uAKGCShSUMc",
"https://freeproxylists.net/?c=nl&f=1&s=u",
"https://chrome.google.com/webstore/detail/hide-my-ip/albbiglcfndaaphglmeaejkhepckkfgf?hl=de",
"https://www.bakermckenzie.com/-/media/files/insight/publications/2016/07/doing-business-in-the-netherlands-2016/dbiemeadoingbusinessnetherlandsjul16.pdf?la=en",
"https://www.ip-tracker.org/locator/ip-lookup.php?ip=nl.hide.me",
"https://volumeo126.cushionpromo.co/download-free-netherland-vpn.html?i=bestreviewbush4&category=nordvpn-0&fid=25",
"https://carseto126.compactpromo.co/free-unlimited-netherland-vpn-for-chrome.xhtml?i=bestreviews5&category=nordvpn-2&fid=25",
"https://telegram.me/s/wbnet?before=46212",
"https://premiumproxy.net/top-country-proxy-list?country=NL-Netherlands",
"https://www.igg-games.uk/abmc/ayq.php?z=proxy-indonesia-full-speed",
"https://www.vpstwo6.me/free-vpn-proxy-netherlands.xhtml?i=portableaudiolivesoundstageshopping&category=nordvpn-0&fid=25",
"https://serieso126.drivepromo.co/free-vpn-for-netherland-testing.xhtml?i=putlocker4kreview&category=nordvpn-0&fid=25",
"https://hummero126.bagpromo.co/download-free-netherland-vpn.jsp?i=shopsnowy1&category=nordvpn-0&fid=25",
"https://cushiono126.thaigadpromo.co/free-unlimited-netherland-vpn-for-chrome.xfile?i=immunityreview&category=nordvpn-14&fid=25",
"https://gunslow.overtime.blogsyte.com/openproxy-nordvpn.xhtml?i=www&category=nordvpn-5&fid=25",
"https://sourceforge.net/directory/?q=proxy%20list%20premium",
"https://www.sslprivateproxy.com/billing/cart.php?gid=1",
"https://api.proxyscrape.com/?request=getproxies&proxytype=socks5&timeout=50000&country=all",
"https://crackingate.io/index.php?/topic/312-proxyscrape-free-hq-proxy/",
"https://ctrader.com/forum/ctrader-support?page=12",
"https://hidester.com/proxylist/",
        };


        public Form1()
        {
        
            InitializeComponent();
        }

        void DoScrape(string url)
        {

            System.Net.WebClient _WC = new System.Net.WebClient();
            List<string> TempProxies = new List<string>();
            {
                try
                {
                
                        string cur = url;
                        string PageSource = _WC.DownloadString(cur);
                        CurrentlyScrapingPage = cur;

                        MatchCollection _MC = _Def.REGEX.Matches(PageSource);
                        foreach (Match Match in _MC)
                        {
                            listBox1.Invoke((Action)delegate
                            {
                                listBox1.Items.Add(Match.ToString());

                            });
                            ProxyAmount = Convert.ToInt32(listBox1.Items.Count);
                            flatLabel3.Invoke((Action)delegate
                            {
                                flatLabel3.Text = "Scraped : " + ProxyAmount.ToString();

                            });
    
                        }
               
                    LB_Logs.Invoke((Action)delegate
                        {
                            LB_Logs.Items.Add("[+] " + "Scraped: " + cur);

                        });
                        Console.WriteLine("Scraped: " + cur);
                   
                }
                catch (Exception)
                {

                    LB_Logs.Invoke((Action)delegate
                    {
                        LB_Logs.Items.Add("[-] " + "Dead link:" + CurrentlyScrapingPage);

                    });
                }
            }
        }

        private void flatToggle3_CheckedChanged(object sender)
        {
            if (flatToggle3.Checked == true)
            {
                flatStatusBar1.Text = "Scraping Proxies !";
                try
                {
                    foreach (string Line in stringArray)
                    {
                        AmountOfPages++;
                    }
                    CreateLog("Going to scrape " + AmountOfPages + " pages", true);
                    backgroundGatherer.RunWorkerAsync();
                }
                catch (Exception)
                {
                    CreateLog("Engine is currently gathering!", false);
                }
            }
            else
            {
                Status_Gathering = false;
                if (backgroundGatherer.IsBusy)
                {
                    backgroundGatherer.CancelAsync();
                    CreateLog("Stopped gathering successfully!", true);
                }
                else
                {
                    CreateLog("Not gathering!", false);
                }
                flatStatusBar1.Text = "Idling...";
            }
        }

        private void flatMini1_Click(object sender, EventArgs e)
        {

        }
        private void SaveProxies(ListBox LB_ItemsToSave)
        {
            if (this.listBox1.Items != null)
            {
                if (this.listBox1.Items != null)
                {
                    SaveFileDialog _SFD = new SaveFileDialog();
                    _SFD.FileName = "Nitrous Proxies.txt";
                    _SFD.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (_SFD.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter _SW = new StreamWriter(_SFD.FileName))
                            foreach (string Item in this.listBox1.Items)
                            {
                                _SW.WriteLine(Item);
                            }
                    }
                    CreateLog(this.listBox1.Items.Count + " Proxies have been saved!", true);
                }
                else
                {
                    CreateLog("Could not save proxies...", false);
                }
            }
            else
            {
                CreateLog("Cannot save zero proxies!", false);
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            SaveProxies(listBox1);
        }

        private void flatListBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateLog(string TheLog, bool? Success)
        {
            if ((bool)Success)
            {
                LB_Logs.Items.Add("[+] " + TheLog);
            }
            else if ((bool)!Success)
            {
                LB_Logs.Items.Add("[-] " + TheLog);
            }
            else
            {
                LB_Logs.Items.Add("[%] " + TheLog);
            }
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void TB_Sources_TextChanged(object sender, EventArgs e)
        {


        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            flatStatusBar1.Text = "Removing Dupes";
            var _items = this.listBox1.Items.Cast<string>().Distinct().ToArray();
            this.listBox1.Items.Clear();
            foreach (var item in _items)
            {
                this.listBox1.Items.Add(item);
            }
            flatStatusBar1.Text = "Dupes Removed.    Ready to export !";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void flatRadioButton1_CheckedChanged(object sender)
        {

        }

        private void flatGroupBox6_Click(object sender, EventArgs e)
        {

        }


        private void backgroundGatherer_DoWork(object sender, DoWorkEventArgs e)
        {
            Status_Gathering = true;
            ThreadCount = Convert.ToInt32(NUD_ThreadCount.Value);

            flatStatusBar1.Text = "Scraping Proxies !";
            Parallel.ForEach(stringArray, new ParallelOptions { MaxDegreeOfParallelism = ThreadCount }, stringArray => { //stringArray.Count 
                DoScrape(stringArray);             
            });


            ProxyAmount = Convert.ToInt32(listBox1.Items.Count);
            flatStatusBar1.Invoke((Action)delegate
            {
                flatStatusBar1.Text = "Scrape Done | Scraped " + ProxyAmount.ToString() + " of HTTP Proxies";

            });


        }
    }
}
