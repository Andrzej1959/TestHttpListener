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
        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (listener == null)
                {
                    listener = new HttpListener();
                    //listener.Prefixes.Add("http://*:80/");
                    //listener.Prefixes.Add("http://*:1777/");
                    listener.Prefixes.Add("http://*:" + textBox1.Text + "/");
                    textBox1.Enabled = false;
                }

                if (((CheckBox)sender).Checked)
                {
                    if (!listener.IsListening)
                        listener.Start();

                    while (((CheckBox)sender).Checked)   // Jak nie działa sprawdzić ip klienta
                    {
                        HttpListenerContext context = await listener.GetContextAsync();
                        HttpListenerRequest request = context.Request;

                        
                        labelReqParam.Text = "Parametry\nUserHostName: " + request.UserHostName;
                        labelReqParam.Text += "\nRaw Url: " + request.RawUrl;
                        labelReqParam.Text += "\nHTTP Method: " + request.HttpMethod;
                        labelReqParam.Text += "\nProtocol Version: " + request.ProtocolVersion.ToString();
                        labelReqParam.Text += "\nServiceName: " + request.ServiceName;
                        labelReqParam.Text += "\nLocalEndPoint: " + request.LocalEndPoint;
                        labelReqParam.Text += "\nRemoteEndPoint: " + request.RemoteEndPoint;
                        labelReqParam.Text += "\nContentType: " + request.ContentType;
                        labelReqParam.Text += "\nUserAgent: " + request.UserAgent;

                        var heders = request.Headers;

                        labelHeders.Text = "-------->Request Heders:\n";
                        for (int k = 0; k < heders.Count; k++)
                        {
                            labelHeders.Text += heders.GetKey(k) + ": ";
                            foreach (var value in heders.GetValues(k))
                                labelHeders.Text += value;
                            labelHeders.Text += "\n";
                        }

                        if (request.QueryString.HasKeys()) labelHeders.Text += "\n------->Query String: \n";
                        else
                            labelHeders.Text = "QueryString has no keys";

                        for (int k = 0; k < request.QueryString.Count; k++)
                            labelHeders.Text += request.QueryString.GetKey(k) + "  " + (request.QueryString.GetValues(k))[0] + "\n";




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

                        response.Headers.Add("ServerHeader1", "Header value");
                   
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(textBoxResponse.Text);
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


