using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;


namespace CsharpFinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            finalExam();

        }

        public static void finalExam()
        {
            WebClient client = new WebClient();

          string result = client.DownloadString("http://www.json-generator.com/api/json/get/bPCtVMPmNu?indent=0");
          Student[] letMEgoHome = JsonConvert.DeserializeObject<Student[]>(result);
            for (int i = 0; i < letMEgoHome.Length; i++)
            {
                letMEgoHome[i].Greeting();
            }

           

        



        }
    }
}
