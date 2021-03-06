﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using WCFServices;

namespace WCFClient
{
    class Client
    {
        
        static void Main(string[] args)
        {
            try
            {
                MessageInterceptorDemoClient.ServiceClient serviceProxy = new MessageInterceptorDemoClient.ServiceClient();
                Trace.Flush();
                try
                {
                    string result = serviceProxy.HelloWorld("hello");
                    Trace.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                    
                }


                try
                {
                    string result = serviceProxy.WebFaultMethod();
                    Trace.WriteLine(result);
                }
                catch (Exception exception)
                {
                    Trace.WriteLine(exception.ToString());
                    
                }
                
                try
                {
                    string result = serviceProxy.TestMessage();
                    Trace.WriteLine(result);
                }
                catch(Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            
            Console.ReadKey();
        }

        private static Binding GetBinding()
        {
            BasicHttpBinding result = new BasicHttpBinding();
            return result;
        }
    }
}
