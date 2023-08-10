using AspNetCorePDFGenerateSample.Models;
using System.Collections.Generic;

namespace AspNetCorePDFGenerateSample.Utility
{
    public class SampleDataList
    {
        public static List<SampleModel> GetAllSampleData() =>
            new()
            {
                new SampleModel { Column1="a", Column2="b", Column3="c", Column4="d"},
                new SampleModel { Column1="e", Column2="f", Column3="g", Column4="h"},
                new SampleModel { Column1="i", Column2="j", Column3="k", Column4="l"},
                new SampleModel { Column1="m", Column2="n", Column3 = "o", Column4 = "p"},
                new SampleModel { Column1="q", Column2="r", Column3="s", Column4="t"}
            };
    }
}
