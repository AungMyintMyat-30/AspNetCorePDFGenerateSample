using System.Text;

namespace AspNetCorePDFGenerateSample.Utility
{
    public class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            StringBuilder sb = new();
            sb.Append(@"<html>
                            <head>
                            </head>
                            <body>
                            <hr id='new1'>
                            <div class='header' align='center'><h2> SAMPLE INVOICE </h2></div>
                            <h4>Invoice Number : 001 </h4>
                            <h4>Account Number : 002 </h4>
                            <table class='table1' align='center'>
                            <tr>
                                <th>Shippers Reference</th>
                                <th>Shipment Date</th>
                                <th>Origin / Consignor</th>
                                <th>Destination / Consignee</th>
                            </tr>
                            <tr>
                                <td>{0}</td>
                                <td>{1}</td>
                                <td>{2}</td>
                                <td>{3}</td>
                            </tr>
                            </table>
                            <hr id='new2'>
                            </body>
                         </html>");
            return sb.ToString();
        }
    }
}
