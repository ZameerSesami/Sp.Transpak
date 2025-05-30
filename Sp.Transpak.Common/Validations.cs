﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sp.Transpak.Common
{
    public class Validations
    {
        public static string ValidateGeBizFile(XmlDocument InputXML)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            try
            {
                //MINISTRY_CODE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='MINISTRY_CODE']") == null)
                {
                    sb.Append("MINISTRY_CODE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='MINISTRY_CODE']").InnerText))
                    {
                        sb.Append("MINISTRY_CODE field is missing |");
                    }
                }
                //DEPARTMENT_CODE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='DEPARTMENT_CODE']") == null)
                {
                    sb.Append("DEPARTMENT_CODE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='DEPARTMENT_CODE']").InnerText))
                    {
                        sb.Append("DEPARTMENT_CODE field is missing |");
                    }
                }
                //ORDER_CODE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_CODE']") == null)
                {
                    sb.Append("ORDER_CODE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_CODE']").InnerText))
                    {
                        sb.Append("ORDER_CODE field is missing |");
                    }
                }
                //VARIATION_NUMBER
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='VARIATION_NUMBER']") == null)
                {
                    sb.Append("VARIATION_NUMBER field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='VARIATION_NUMBER']").InnerText))
                    {
                        sb.Append("VARIATION_NUMBER field is missing |");
                    }
                }
                //STATUS
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='STATUS']") == null)
                {
                    sb.Append("STATUS field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='STATUS']").InnerText))
                    {
                        sb.Append("STATUS field is missing |");
                    }
                }
                //STATUS_DATE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='STATUS_DATE']") == null)
                {
                    sb.Append("STATUS_DATE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='STATUS_DATE']").InnerText))
                    {
                        sb.Append("STATUS_DATE field is missing |");
                    }
                }
                //CREATE_TIMESTAMP
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='CREATE_TIMESTAMP']") == null)
                {
                    sb.Append("CREATE_TIMESTAMP field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='CREATE_TIMESTAMP']").InnerText))
                    {
                        sb.Append("CREATE_TIMESTAMP field is missing |");
                    }
                }
                //ORDER_TYPE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_TYPE']") == null)
                {
                    sb.Append("ORDER_TYPE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='ORDER_TYPE']").InnerText))
                    {
                        sb.Append("ORDER_TYPE field is missing |");
                    }
                }
                //SITE_ID
                //if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ID']") == null)
                //{
                //    sb.Append("SITE_ID field is missing |");
                //}
                //else
                //{
                //    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ID']").InnerText))
                //    {
                //        sb.Append("SITE_ID field is missing |");
                //    }
                //}
                //ADDRESS_LINE1
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ADDRESS_LINE1']") == null)
                {
                    sb.Append("ADDRESS_LINE1 field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='SUPPLIER']/*[local-name()='SITES']/*[local-name()='SITE']/*[local-name()='ADDRESS_LINE1']").InnerText))
                    {
                        sb.Append("ADDRESS_LINE1 field is missing |");
                    }
                }
                //CURRENCY_CODE
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_CODE']") == null)
                {
                    sb.Append("CURRENCY_CODE field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_CODE']").InnerText))
                    {
                        sb.Append("CURRENCY_CODE field is missing |");
                    }
                }
                //CURRENCY_AMOUNT
                if (InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_AMOUNT']") == null)
                {
                    sb.Append("CURRENCY_AMOUNT field is missing |");
                }
                else
                {
                    if (string.IsNullOrEmpty(InputXML.SelectSingleNode("/*[local-name()='GEBIZ_ORDER']/*[local-name()='HEADER']/*[local-name()='FUND_COMMIT_AMOUNT']/*[local-name()='CURRENCY_AMOUNT']").InnerText))
                    {
                        sb.Append("CURRENCY_AMOUNT field is missing |");
                    }
                }

                XmlNodeList NodeListPOItems = InputXML.SelectNodes("/*[local-name()='GEBIZ_ORDER']/*[local-name()='ITEMS']");

                foreach (XmlNode NodePOItemList in NodeListPOItems)
                {
                    int lineno = 0;
                    //sb.Append("ITEMS OK: |");
                    XmlNodeList NodePOItems = NodePOItemList.SelectNodes("ITEM");
                    foreach (XmlNode NodePOItem in NodePOItems)
                    {
                        lineno = lineno + 1;
                        //LINE_NUMBER
                        if (NodePOItem.SelectSingleNode("LINE_NUMBER") == null)
                        {
                            sb.Append("Item No " + lineno.ToString() + ": Missing LineNo |");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(NodePOItem.SelectSingleNode("LINE_NUMBER").InnerText))
                            {
                                sb.Append("Item No " + lineno.ToString() + ": Missing LineNo |");
                            }
                        }


                        XmlNodeList ItemServiceNodesList = NodePOItem.SelectNodes("SERVICE_ORDER");
                        foreach (XmlNode ServiceItemNode in ItemServiceNodesList)
                        {
                            //UNIT_OF_MEASURE
                            if (ServiceItemNode.SelectSingleNode("ORIG_UNIT_OF_MEASURE") == null)
                            {
                                sb.Append("Item No " + lineno.ToString() + ": Missing UOM |");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ServiceItemNode.SelectSingleNode("ORIG_UNIT_OF_MEASURE").InnerText))
                                {
                                    sb.Append("Item No " + lineno.ToString() + ": Missing UOM |");
                                }
                            }
                            //QUANTITY
                            if (ServiceItemNode.SelectSingleNode("ORIG_QUANTITY") == null)
                            {
                                sb.Append("Item No " + lineno.ToString() + ": Missing Quantity |");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(ServiceItemNode.SelectSingleNode("ORIG_QUANTITY").InnerText))
                                {
                                    sb.Append("Item No " + lineno.ToString() + ": Missing Quantity |");
                                }
                            }
                            //sb.Append("ORIG_QUANTITY OK |");
                        }
                        //TOTAL_AMOUNT
                        if (NodePOItem.SelectSingleNode("TOTAL_AMOUNT") == null)
                        {
                            sb.Append("Item No " + lineno.ToString() + ": Missing TotalAmount |");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(NodePOItem.SelectSingleNode("TOTAL_AMOUNT").InnerText))
                            {
                                sb.Append("Item No " + lineno.ToString() + ": Missing TotalAmount |");
                            }
                        }

                        XmlNodeList NodeItemLocations = NodePOItem.SelectNodes("LOCATIONS");
                        foreach (XmlNode NodeItemLocationsList in NodeItemLocations)
                        {
                            XmlNodeList NodeLocationList = NodeItemLocationsList.SelectNodes("LOCATION");
                            foreach (XmlNode NodeItemLocation in NodeLocationList)
                            {
                                //LOCATION_LINE_NUMBER
                                if (NodeItemLocation.SelectSingleNode("LINE_NUMBER") == null)
                                {
                                    sb.Append("LOCATION_LINE_NUMBER field is missing |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("LINE_NUMBER").InnerText))
                                    {
                                        sb.Append("LOCATION_LINE_NUMBER field is missing |");
                                    }
                                }
                                //LOCATION_DELIVERY_DESTINATION
                                if (NodeItemLocation.SelectSingleNode("DELIVERY_DESTINATION") == null)
                                {
                                    sb.Append("DELIVERY_DESTINATION field is missing |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("DELIVERY_DESTINATION").InnerText))
                                    {
                                        sb.Append("DELIVERY_DESTINATION field is missing |");
                                    }
                                }
                                //LOCATION_DELIVERY_DATE
                                if (NodeItemLocation.SelectSingleNode("DELIVERY_DATE") == null)
                                {
                                    sb.Append("DELIVERY_DATE field is missing |");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(NodeItemLocation.SelectSingleNode("DELIVERY_DATE").InnerText))
                                    {
                                        sb.Append("DELIVERY_DATE field is missing |");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append("Error:" + ex.Message);
            }
            return sb.ToString();
        }
    }
}
