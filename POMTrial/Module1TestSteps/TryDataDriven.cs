using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using POMTrial.BaseClass.BaseT;
using POMTrial.ReadParserData;
using OpenQA.Selenium;
using Microsoft.Office.Interop.Excel;

namespace POMTrial
{
    public class TryDataDriven: BaseTest
    { 


      
    
        [Test, Category("Module1"),Category("Regression"), TestCaseSource(typeof(ExcelDataParser), nameof(ExcelDataParser.BudgetData))]
        public void Test1(string urladdress)

        {

            //var inputText = "tiktok 2023";
          
               
             applications.datadriven.OpenUrl(urladdress);



              
           
        }
    }


}
