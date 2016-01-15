using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SimpleNetkeeper_ChinaNetValidationCode
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private const string SERVER_ADDR = "202.100.170.77";

        private const int SERVER_PORT = 8099;

        private const string SMS_SALT = "x%i^n&l*i)yixunsms";

        private const string CODE_PHONE = "%phone%",
            CODE_CHECK = "%check%",
            CODE_VALIDATE = "%validate%",
            CODE_ID = "%id%";

        private static string REQUEST_CODE = "<op><accountInfo login='" + CODE_PHONE + "' checkCode='" + CODE_CHECK + "' id='" + CODE_ID + "' /></op>",
            RESPONSE_CODE = "<op><validateAccount login='" + CODE_PHONE + "' checkCode='" + CODE_CHECK + "' validateCode='" + CODE_VALIDATE + "' id='" + CODE_ID + "' /></op>";

        private void getCode_Click(object sender, EventArgs e)
        {
            string request = getCheckCodeRequest(tbNum.Text);
            if (request != null)
            {
                string response = SocketHelper.sendRequest(request, SERVER_ADDR, SERVER_PORT);
                if (response != null)
                {
                    MessageBox.Show(response.IndexOf("sendSuccess='Y'") > 0 ? "短信验证码已经发送到你的手机，你需要在90秒内输入到验证码框然后发送" : "服务器未发送短信验证码，返回内容：" + response);
                }
                else {
                    MessageBox.Show("程序出现错误，或者服务器响应错误！");
                }
            }
            else {
                MessageBox.Show("手机号码长度错误");
            }
        }

        private void validCode_Click(object sender, EventArgs e)
        {
            string response = getCheckCodeResponse(tbNum.Text, tbCode.Text);
            if (response != null)
            {
                string serverResponse = SocketHelper.sendRequest(response, SERVER_ADDR, SERVER_PORT);
                if (serverResponse != null)
                {
                    MessageBox.Show("OK".Equals(getSubStr(serverResponse , "resCode='" , "'")) ? "验证成功！" : "验证错误！服务器返回数据：" + serverResponse);
                }
                else {
                    MessageBox.Show("程序出现错误，或者服务器响应错误！");
                }
            }
            else {
                MessageBox.Show("你的手机号码或者验证码非法！");
            }
        }

        public static string getSubStr(string origin, string findStart, string findEnd) {
            if (!string.IsNullOrEmpty(origin) && !string.IsNullOrEmpty(findStart) && !string.IsNullOrEmpty(findEnd)) {
                int path = origin.IndexOf(findStart);
                if (path >= 0) {
                    int pathE = origin.IndexOf(findEnd, path + findStart.Length);
                    if (pathE > path) {
                        return origin.Substring(path + findStart.Length, pathE - path - findStart.Length);
                    }
                }
            }
            return null;
        }

        public static string getCheckCodeResponse(string number, string code) {
            string checkCode = getCheckCode(number);
            if (checkCode != null && code.Length >= 6)
            {
                return RESPONSE_CODE.Replace(CODE_PHONE, number).Replace(CODE_CHECK, checkCode).Replace(CODE_ID, getTimeSpan() + "").Replace(CODE_VALIDATE , code);
            }
            return null;
        }


        public static string getCheckCodeRequest(string number) { 
            string checkCode = getCheckCode(number);
            if (checkCode != null) {
                return REQUEST_CODE.Replace(CODE_PHONE, number).Replace(CODE_CHECK, checkCode).Replace(CODE_ID, getTimeSpan() + "");
            }
            return null;
        }

        public static string getCheckCode(string number) {
            if (number.Length == 11) {
                return GetMd5Hash(number + SMS_SALT);
            }
            return null;
        }

        public static int getTimeSpan()
        {
            TimeSpan ts = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1);
            return (int)Math.Floor(ts.TotalSeconds);

        }

        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="md5Hash"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
