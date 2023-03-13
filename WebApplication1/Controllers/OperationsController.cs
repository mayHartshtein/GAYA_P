using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace WebApplication1.Controllers
{
    public class OperationsController : ApiController
    {
        
        [HttpGet]
        public IHttpActionResult OperationDouble(double input1, double input2 ,string operation)
        {
            double result = 0;

                double num1 = (double)input1;
                double num2 = (double)input2;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        throw new ArgumentException($"Unknown operation: {operation}");
                }


            return Ok(result.ToString());
        }

        [HttpGet]
        public IHttpActionResult OperationString(string inputstr1, string inputstr2, string operation)
        {
            string result = string.Empty;
              
                switch (operation)
                {
                    case "CONCAT":
                        result = inputstr1 + inputstr2;
                        break;
                    default:
                        throw new ArgumentException($"Unknown operation: {operation}");
                }

            return Ok(result.ToString());
        }
    }
}