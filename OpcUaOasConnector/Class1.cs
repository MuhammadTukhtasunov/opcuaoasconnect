using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Client.ComplexTypes;
using Quickstarts.ConsoleReferenceClient;
using System.Collections;

/*
namespace OpcuaOasConnector
{
    // Methods to Update BBox Using OPCUA
    public class Class1
    {
        public Class1(string method)
        {
            //method = method.ToLower();
        }

        /// <summary>
        /// Browse Server nodes
        /// </summary>
        public void Browse(Session session, string BrowseName)
        {
            if (session == null || session.Connected == false)
            {
                output.WriteLine("Session not connected!");
                return;
            }

            try
            {
                // Create a Browser Object
                Browser browser = new Browser();
                // Parameters
                browser.BrowseDirection = BrowseDirection.Both;
                browser.IncludeSubtypes = true;
                browser.NodeClassMask = (int)NodeClass.Method | (int)NodeClass.Object;
                browser.ReferenceTypeId = ReferenceTypeIds.HierarchicalReferences;

                NodeId nodeToBrowse = new NodeId(ObjectIds.BrowseName);
            }
            catch (Exception ex)
            {
                // Log Error
                output.WriteLine($"Browse Error : {ex.Message}.");
            }
        }






        private readonly TextWriter output;
    }
}
*/