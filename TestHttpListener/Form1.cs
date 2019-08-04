using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHttpListener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       
        
        HttpListener listener;
        //private  void checkBox1_CheckedChanged(object sender, EventArgs e)    // Synchroniczny
        private async void checkBox1_CheckedChanged(object sender, EventArgs e) // Asynchroniczny
        {
            try
            {
                if (listener == null & ((CheckBox)sender).Checked)
                {
                    listener = new HttpListener();
                    //listener.Prefixes.Add("http://*:80/");
                    //listener.Prefixes.Add("http://*:1777/");
                    listener.Prefixes.Add("http://*:" + textBoxNrPortu.Text + "/");
                    textBoxNrPortu.Enabled = false;
                }

                if (((CheckBox)sender).Checked)
                {
                    if (!listener.IsListening)
                        listener.Start();

                    while (((CheckBox)sender).Checked)   // Jak nie działa sprawdzić ip klienta
                    {
                        HttpListenerContext context = await listener.GetContextAsync(); // Asynchroniczny
                        //HttpListenerContext context = listener.GetContext();          // Synchroniczny          
                        HttpListenerRequest request = context.Request;

                        string parametryText;
                        parametryText = "-------->Request Parameters\nUserHostName: " + request.UserHostName;
                        parametryText += "\nRaw Url: " + request.RawUrl;
                        parametryText += "\nHTTP Method: " + request.HttpMethod;
                        parametryText += "\nProtocol Version: " + request.ProtocolVersion.ToString();
                        parametryText += "\nServiceName: " + request.ServiceName;
                        parametryText += "\nLocalEndPoint: " + request.LocalEndPoint;
                        parametryText += "\nRemoteEndPoint: " + request.RemoteEndPoint;
                        parametryText += "\nContentType: " + request.ContentType;
                        parametryText += "\nUserAgent: " + request.UserAgent;

                        labelReqParam.Text = parametryText;

                        var heders = request.Headers;
                        string hedersText;
                        hedersText = "-------->Request Heders:\n";
                        for (int k = 0; k < heders.Count; k++)
                        {
                            hedersText += heders.GetKey(k) + ": ";
                            foreach (var value in heders.GetValues(k))
                                hedersText += value;
                            hedersText += "\n";
                        }

                        if (request.QueryString.HasKeys()) hedersText += "\n------->Query String: \n";
                        else
                            hedersText += "QueryString has no keys";

                        for (int k = 0; k < request.QueryString.Count; k++)
                            hedersText += request.QueryString.GetKey(k) + " = " + (request.QueryString.GetValues(k))[0] + "\n";

                        labelHeders.Text = hedersText;

                        if (request.HasEntityBody)
                        {
                            if (request.ContentType != null)
                                labelContentType.Text = request.ContentType + "\n";
                            else
                                labelContentType.Text = "ContentType = ?\n";

                            System.IO.Stream body = request.InputStream;
                            System.Text.Encoding encoding = request.ContentEncoding;
                            System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
                            string s = reader.ReadToEnd();
                            label1.Text = s;
                            body.Close();
                            reader.Close();                            
                        }
                        else
                        {
                            label1.Text = "No content";
                            labelContentType.Text = "ContentType = ?\n";
                        }

                        HttpListenerResponse response = context.Response;
                        response.Headers.Add(HttpResponseHeader.ContentType, "text/plain");
                        response.Headers.Add("ServerHeader1", "Header value");
                        string responseText = textBoxResponse.Text + "\n\n" + parametryText + "\n\n" + hedersText;
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseText);
                        // Get a response stream and write the response to it.
                        response.ContentLength64 = buffer.Length;
                        System.IO.Stream output = response.OutputStream;

                        output.Write(buffer, 0, buffer.Length);
                        output.Close();
                    }
                }
            }
            catch (Exception exce)
            {
                label1.Text = "Wystapił błąd: " + exce.Message;
            }
        }
    }
}


