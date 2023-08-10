using System.Text;

namespace AspNetCorePDFGenerateSample.Utility
{
    public class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var sample = SampleDataList.GetAllSampleData();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header' align='center'><h2> SAMPLE INVOICE </h2></div>
                                <table align='center'>
                                    <tr>
                                        <th>Column 1</th>
                                        <th>Column 2</th>
                                        <th>Column 3</th>
                                        <th>Column 4</th>
                                    </tr>");
            foreach (var sam in sample)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", sam.Column1, sam.Column2, sam.Column3, sam.Column4);
            }
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
